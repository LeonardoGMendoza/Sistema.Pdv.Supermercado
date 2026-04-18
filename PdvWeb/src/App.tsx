import { useState, useEffect } from 'react';
import { ShoppingCart, Search, CreditCard, Banknote, Trash2, Package, CheckCircle2 } from 'lucide-react';
import { motion, AnimatePresence } from 'framer-motion';

interface Product {
  id: number;
  nome: string;
  preco: number;
  codigoBarras: string;
}

interface CartItem extends Product {
  quantity: number;
}

export default function App() {
  const [cart, setCart] = useState<CartItem[]>([]);
  const [products, setProducts] = useState<Product[]>([]);
  const [searchTerm, setSearchTerm] = useState('');
  const [isFinishing, setIsFinishing] = useState(false);
  const [showSuccess, setShowSuccess] = useState(false);

  // Carregar produtos da API real
  useEffect(() => {
    const loadProducts = async () => {
      try {
        const response = await fetch('https://pdv.sandlj.com.br/api/estoque');
        if (!response.ok) throw new Error('Falha no HTTPS, tentando HTTP...');
        const data = await response.json();
        setProducts(data);
      } catch (err) {
        console.warn(err);
        // Fallback para HTTP caso o SSL do subdomínio não esteja pronto
        fetch('http://pdv.sandlj.com.br/api/estoque')
          .then(res => res.json())
          .then(data => setProducts(data))
          .catch(e => console.error("API totalmente inacessível:", e));
      }
    };
    loadProducts();
  }, []);

  const filteredProducts = products.filter(p => 
    p.nome.toLowerCase().includes(searchTerm.toLowerCase()) || 
    p.codigoBarras === searchTerm
  );

  // Se bipar um código de barras exato, adiciona direto
  useEffect(() => {
    const product = products.find(p => p.codigoBarras === searchTerm);
    if (product) {
      addToCart(product);
    }
  }, [searchTerm, products]);

  const addToCart = (product: Product) => {
    setCart(prev => {
      const existing = prev.find(item => item.id === product.id);
      if (existing) {
        return prev.map(item => item.id === product.id ? { ...item, quantity: item.quantity + 1 } : item);
      }
      return [...prev, { ...product, quantity: 1 }];
    });
    setSearchTerm('');
  };

  const removeFromCart = (id: number) => {
    setCart(prev => prev.filter(item => item.id !== id));
  };

  const total = cart.reduce((acc, item) => acc + (item.preco * item.quantity), 0);

  const handleFinishSale = async (paymentMethod: string) => {
    setIsFinishing(true);
    
    // Preparando o objeto exatamente como a API C# espera
    const pedido = {
      colaboradorId: 1,
      clienteId: 1,
      status: 1,
      formaPagamento: paymentMethod,
      total: total,
      dataPedido: new Date().toISOString(),
      itens: cart.map(item => ({
        produtoId: item.id,
        quantidade: item.quantity,
        precoUnitario: item.preco
      }))
    };

    try {
      // Chamada REAL para a sua API no Servidor Ubuntu
      const response = await fetch('https://pdv.sandlj.com.br/api/pedidos', {
        method: 'POST',
        headers: {
          'Content-Type': 'application/json',
          'Accept': '*/*'
        },
        body: JSON.stringify(pedido)
      });
      
      if (!response.ok) throw new Error('Falha ao enviar pedido');

      console.log("Pedido Salvo com Sucesso no Postgres e RabbitMQ!");

      setShowSuccess(true);
      setCart([]);
      setTimeout(() => setShowSuccess(false), 3000);
    } catch (error) {
      console.error("Erro na integração:", error);
      alert("Erro ao salvar venda na nuvem. Verifique a conexão.");
    } finally {
      setIsFinishing(false);
    }
  };

  return (
    <div className="min-h-screen bg-slate-950 text-slate-100 flex p-6 gap-6 overflow-hidden">
      
      {/* Área de Seleção de Produtos */}
      <div className="flex-1 flex flex-col gap-6">
        <header className="flex justify-between items-center bg-slate-900/50 p-6 rounded-3xl border border-white/10 backdrop-blur-xl">
          <div>
            <h1 className="text-3xl font-bold bg-gradient-to-r from-indigo-400 to-pink-400 bg-clip-text text-transparent">
              MERCADINHO GIL HUB
            </h1>
            <p className="text-slate-400 text-sm">Painel de Vendas Digital v2.0</p>
          </div>
          <div className="relative group">
            <Search className="absolute left-4 top-1/2 -translate-y-1/2 text-slate-500 group-focus-within:text-indigo-400 transition-colors" size={20} />
            <input 
              type="text" 
              placeholder="Pesquisar produto ou bipar código..."
              className="bg-slate-800 border-2 border-white/5 rounded-2xl py-3 pl-12 pr-6 w-96 focus:outline-none focus:border-indigo-500/50 transition-all text-lg"
              value={searchTerm}
              onChange={(e) => setSearchTerm(e.target.value)}
              onKeyPress={(e) => e.key === 'Enter' && filteredProducts.length > 0 && addToCart(filteredProducts[0])}
            />
          </div>
        </header>

        <main className="grid grid-cols-2 lg:grid-cols-3 gap-4 overflow-y-auto pr-2">
          {filteredProducts.map(product => (
            <motion.div 
              whileHover={{ y: -5 }}
              whileTap={{ scale: 0.95 }}
              key={product.id}
              onClick={() => addToCart(product)}
              className="bg-slate-900/40 p-5 rounded-3xl border border-white/5 hover:border-indigo-500/30 cursor-pointer transition-all group"
            >
              <div className="w-12 h-12 bg-indigo-500/10 rounded-2xl flex items-center justify-center mb-4 group-hover:bg-indigo-500/20 transition-colors">
                <Package className="text-indigo-400" />
              </div>
              <h3 className="font-semibold text-lg">{product.nome}</h3>
              <p className="text-slate-500 text-sm mb-3"># {product.codigoBarras}</p>
              <p className="text-2xl font-bold text-indigo-400">R$ {product.preco.toFixed(2)}</p>
            </motion.div>
          ))}
        </main>
      </div>

      {/* Carrinho de Compras lateral */}
      <aside className="w-96 bg-slate-900/80 rounded-3xl border border-white/10 backdrop-blur-3xl flex flex-col shadow-2xl overflow-hidden">
        <div className="p-6 border-bottom border-white/5 flex items-center gap-3">
          <ShoppingCart className="text-pink-500" />
          <h2 className="text-xl font-bold">Carrinho Atual</h2>
          <span className="ml-auto bg-slate-800 px-3 py-1 rounded-full text-xs font-mono">{cart.length} ITENS</span>
        </div>

        <div className="flex-1 overflow-y-auto p-4 flex flex-col gap-3">
          <AnimatePresence>
            {cart.map(item => (
              <motion.div 
                initial={{ opacity: 0, x: 20 }}
                animate={{ opacity: 1, x: 0 }}
                exit={{ opacity: 0, scale: 0.9 }}
                key={item.id}
                className="bg-slate-800/40 p-4 rounded-2xl border border-white/5 flex justify-between items-center group"
              >
                <div>
                  <h4 className="font-medium text-sm">{item.nome}</h4>
                  <p className="text-xs text-slate-500">{item.quantity}x R$ {item.preco.toFixed(2)}</p>
                </div>
                <div className="flex items-center gap-4">
                  <span className="font-bold text-indigo-400">R$ {(item.preco * item.quantity).toFixed(2)}</span>
                  <button 
                    onClick={() => removeFromCart(item.id)}
                    className="p-2 text-slate-600 hover:text-red-400 transition-colors"
                  >
                    <Trash2 size={16} />
                  </button>
                </div>
              </motion.div>
            ))}
          </AnimatePresence>
        </div>

        <div className="p-6 bg-slate-950/50 border-t border-white/10">
          <div className="flex justify-between mb-6">
            <span className="text-slate-400">Total da Venda</span>
            <span className="text-4xl font-black text-white">R$ {total.toFixed(2)}</span>
          </div>

          <div className="grid grid-cols-2 gap-3 mb-4">
            <button 
              onClick={() => handleFinishSale('Dinheiro')}
              disabled={cart.length === 0 || isFinishing}
              className="flex items-center justify-center gap-2 bg-slate-800 hover:bg-slate-700 disabled:opacity-50 h-14 rounded-2xl font-bold transition-all border border-white/5"
            >
              <Banknote size={20} className="text-green-400" /> DINHEIRO
            </button>
            <button 
              onClick={() => handleFinishSale('Cartão')}
              disabled={cart.length === 0 || isFinishing}
              className="flex items-center justify-center gap-2 bg-slate-800 hover:bg-slate-700 disabled:opacity-50 h-14 rounded-2xl font-bold transition-all border border-white/5"
            >
              <CreditCard size={20} className="text-blue-400" /> CARTÃO
            </button>
          </div>

          <button 
            onClick={() => handleFinishSale('PIX')}
            disabled={cart.length === 0 || isFinishing}
            className="w-full h-16 bg-gradient-to-r from-indigo-600 to-purple-600 hover:from-indigo-500 hover:to-purple-500 disabled:opacity-50 rounded-2xl font-black text-xl shadow-lg shadow-indigo-500/20 transition-all flex items-center justify-center gap-3"
          >
            {isFinishing ? (
              <div className="w-6 h-6 border-4 border-white/30 border-t-white rounded-full animate-spin" />
            ) : (
              <>FINALIZAR VENDA (PIX)</>
            )}
          </button>
        </div>
      </aside>

      {/* Notificação de Sucesso */}
      <AnimatePresence>
        {showSuccess && (
          <motion.div 
            initial={{ opacity: 0, y: 50 }}
            animate={{ opacity: 1, y: 0 }}
            exit={{ opacity: 0, y: 50 }}
            className="fixed bottom-10 left-1/2 -translate-x-1/2 bg-green-500 text-white px-8 py-4 rounded-2xl shadow-2xl flex items-center gap-4 z-50 font-bold text-lg"
          >
            <CheckCircle2 size={30} />
            <div>
              <p>VENDA FINALIZADA COM SUCESSO!</p>
              <p className="text-sm opacity-80">Evento enviado para RabbitMQ e Nota Fiscal preparada.</p>
            </div>
          </motion.div>
        )}
      </AnimatePresence>

    </div>
  );
}
