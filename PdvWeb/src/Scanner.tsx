import { useEffect } from 'react';
import { Html5QrcodeScanner } from 'html5-qrcode';

interface ScannerProps {
  onScan: (decodedText: string) => void;
  onClose: () => void;
}

export default function Scanner({ onScan, onClose }: ScannerProps) {
  useEffect(() => {
    const scanner = new Html5QrcodeScanner(
      'reader',
      { 
        fps: 10, 
        qrbox: { width: 250, height: 250 },
        aspectRatio: 1.0
      },
      /* verbose= */ false
    );

    scanner.render(
      (decodedText) => {
        onScan(decodedText);
        scanner.clear();
        onClose();
      },
      (error) => {
        // Ignorar erros de scan falho (normal enquanto procura)
      }
    );

    return () => {
      scanner.clear().catch(error => console.error("Falha ao fechar scanner:", error));
    };
  }, []);

  return (
    <div className="fixed inset-0 z-[60] flex items-center justify-center bg-slate-950/90 backdrop-blur-xl p-4">
      <div className="bg-slate-900 border border-white/10 rounded-3xl p-6 w-full max-w-lg shadow-2xl relative">
        <button 
          onClick={onClose}
          className="absolute right-4 top-4 text-slate-400 hover:text-white transition-colors text-2xl"
        >
          &times;
        </button>
        <h2 className="text-xl font-bold mb-4 text-center">Aponte a Câmera para o Código</h2>
        <div id="reader" className="overflow-hidden rounded-2xl border border-indigo-500/30"></div>
        <p className="text-slate-500 text-center text-sm mt-4">
          O sistema detectará automaticamente QR Codes ou Códigos de Barras.
        </p>
      </div>
    </div>
  );
}
