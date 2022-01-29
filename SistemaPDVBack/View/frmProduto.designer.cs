namespace SistemaPDVBack.View
{
    partial class frmProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCodBarras = new System.Windows.Forms.Label();
            this.txbCodigoBarras = new System.Windows.Forms.TextBox();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.cmbFornecedor = new System.Windows.Forms.ComboBox();
            this.gpDescricaoNome = new System.Windows.Forms.GroupBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.rtbDescricao = new System.Windows.Forms.RichTextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.gpCategoria = new System.Windows.Forms.GroupBox();
            this.rbNaoPerecivel = new System.Windows.Forms.RadioButton();
            this.rbPerecivel = new System.Windows.Forms.RadioButton();
            this.gpValores = new System.Windows.Forms.GroupBox();
            this.txbMargemDeLucro = new System.Windows.Forms.TextBox();
            this.lblMargem = new System.Windows.Forms.Label();
            this.txbPrecoDeVenda = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txbQuantidadeEstoque = new System.Windows.Forms.TextBox();
            this.txbPrecoCusto = new System.Windows.Forms.TextBox();
            this.lblPrecoCusto = new System.Windows.Forms.Label();
            this.lblPrecoVenda = new System.Windows.Forms.Label();
            this.lblDataFabricacao = new System.Windows.Forms.Label();
            this.lblDataVencimento = new System.Windows.Forms.Label();
            this.btnAlterar = new FontAwesome.Sharp.IconButton();
            this.btnAdicionar = new FontAwesome.Sharp.IconButton();
            this.rbProdutoInativo = new System.Windows.Forms.RadioButton();
            this.rbProdutoAtivo = new System.Windows.Forms.RadioButton();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.gpAtivo = new System.Windows.Forms.GroupBox();
            this.ckbInativo = new System.Windows.Forms.CheckBox();
            this.btnConsulta = new FontAwesome.Sharp.IconButton();
            this.msktDataFabricacao = new System.Windows.Forms.MaskedTextBox();
            this.msktDataVencimento = new System.Windows.Forms.MaskedTextBox();
            this.txbId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.gpDescricaoNome.SuspendLayout();
            this.gpCategoria.SuspendLayout();
            this.gpValores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            this.gpAtivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodBarras
            // 
            this.lblCodBarras.AutoSize = true;
            this.lblCodBarras.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodBarras.ForeColor = System.Drawing.Color.Black;
            this.lblCodBarras.Location = new System.Drawing.Point(89, 18);
            this.lblCodBarras.Name = "lblCodBarras";
            this.lblCodBarras.Size = new System.Drawing.Size(118, 15);
            this.lblCodBarras.TabIndex = 0;
            this.lblCodBarras.Text = "Código de barras";
            // 
            // txbCodigoBarras
            // 
            this.txbCodigoBarras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbCodigoBarras.Location = new System.Drawing.Point(92, 36);
            this.txbCodigoBarras.Name = "txbCodigoBarras";
            this.txbCodigoBarras.Size = new System.Drawing.Size(264, 20);
            this.txbCodigoBarras.TabIndex = 1;
            this.txbCodigoBarras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbCodigoBarras_KeyPress);
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFornecedor.ForeColor = System.Drawing.Color.Black;
            this.lblFornecedor.Location = new System.Drawing.Point(371, 18);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(83, 15);
            this.lblFornecedor.TabIndex = 3;
            this.lblFornecedor.Text = "Fornecedor";
            // 
            // cmbFornecedor
            // 
            this.cmbFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFornecedor.FormattingEnabled = true;
            this.cmbFornecedor.Items.AddRange(new object[] {
            "Selecione"});
            this.cmbFornecedor.Location = new System.Drawing.Point(374, 36);
            this.cmbFornecedor.Name = "cmbFornecedor";
            this.cmbFornecedor.Size = new System.Drawing.Size(195, 21);
            this.cmbFornecedor.TabIndex = 2;
            // 
            // gpDescricaoNome
            // 
            this.gpDescricaoNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpDescricaoNome.Controls.Add(this.lblDescricao);
            this.gpDescricaoNome.Controls.Add(this.rtbDescricao);
            this.gpDescricaoNome.Controls.Add(this.lblNome);
            this.gpDescricaoNome.Controls.Add(this.txbNome);
            this.gpDescricaoNome.Location = new System.Drawing.Point(24, 79);
            this.gpDescricaoNome.Name = "gpDescricaoNome";
            this.gpDescricaoNome.Size = new System.Drawing.Size(542, 173);
            this.gpDescricaoNome.TabIndex = 7;
            this.gpDescricaoNome.TabStop = false;
            // 
            // lblDescricao
            // 
            this.lblDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = System.Drawing.Color.Black;
            this.lblDescricao.Location = new System.Drawing.Point(6, 57);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(74, 15);
            this.lblDescricao.TabIndex = 13;
            this.lblDescricao.Text = "Descrição";
            // 
            // rtbDescricao
            // 
            this.rtbDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbDescricao.Location = new System.Drawing.Point(6, 75);
            this.rtbDescricao.Name = "rtbDescricao";
            this.rtbDescricao.Size = new System.Drawing.Size(519, 92);
            this.rtbDescricao.TabIndex = 4;
            this.rtbDescricao.Text = "";
            // 
            // lblNome
            // 
            this.lblNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.Black;
            this.lblNome.Location = new System.Drawing.Point(6, 16);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 15);
            this.lblNome.TabIndex = 12;
            this.lblNome.Text = "Nome";
            // 
            // txbNome
            // 
            this.txbNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbNome.Location = new System.Drawing.Point(6, 34);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(519, 20);
            this.txbNome.TabIndex = 3;
            // 
            // gpCategoria
            // 
            this.gpCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gpCategoria.Controls.Add(this.rbNaoPerecivel);
            this.gpCategoria.Controls.Add(this.rbPerecivel);
            this.gpCategoria.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpCategoria.Location = new System.Drawing.Point(580, 4);
            this.gpCategoria.Name = "gpCategoria";
            this.gpCategoria.Size = new System.Drawing.Size(125, 69);
            this.gpCategoria.TabIndex = 10;
            this.gpCategoria.TabStop = false;
            // 
            // rbNaoPerecivel
            // 
            this.rbNaoPerecivel.AutoSize = true;
            this.rbNaoPerecivel.Location = new System.Drawing.Point(7, 40);
            this.rbNaoPerecivel.Name = "rbNaoPerecivel";
            this.rbNaoPerecivel.Size = new System.Drawing.Size(116, 19);
            this.rbNaoPerecivel.TabIndex = 1;
            this.rbNaoPerecivel.TabStop = true;
            this.rbNaoPerecivel.Text = "Não Perecível";
            this.rbNaoPerecivel.UseVisualStyleBackColor = true;
            this.rbNaoPerecivel.CheckedChanged += new System.EventHandler(this.rbNaoPerecivel_CheckedChanged);
            // 
            // rbPerecivel
            // 
            this.rbPerecivel.AutoSize = true;
            this.rbPerecivel.Location = new System.Drawing.Point(6, 16);
            this.rbPerecivel.Name = "rbPerecivel";
            this.rbPerecivel.Size = new System.Drawing.Size(87, 19);
            this.rbPerecivel.TabIndex = 0;
            this.rbPerecivel.TabStop = true;
            this.rbPerecivel.Text = "Perecível";
            this.rbPerecivel.UseVisualStyleBackColor = true;
            this.rbPerecivel.CheckedChanged += new System.EventHandler(this.rbPerecivel_CheckedChanged);
            // 
            // gpValores
            // 
            this.gpValores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gpValores.Controls.Add(this.txbMargemDeLucro);
            this.gpValores.Controls.Add(this.lblMargem);
            this.gpValores.Controls.Add(this.txbPrecoDeVenda);
            this.gpValores.Controls.Add(this.lblQuantidade);
            this.gpValores.Controls.Add(this.txbQuantidadeEstoque);
            this.gpValores.Controls.Add(this.txbPrecoCusto);
            this.gpValores.Controls.Add(this.lblPrecoCusto);
            this.gpValores.Controls.Add(this.lblPrecoVenda);
            this.gpValores.Location = new System.Drawing.Point(580, 79);
            this.gpValores.Name = "gpValores";
            this.gpValores.Size = new System.Drawing.Size(276, 207);
            this.gpValores.TabIndex = 11;
            this.gpValores.TabStop = false;
            // 
            // txbMargemDeLucro
            // 
            this.txbMargemDeLucro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbMargemDeLucro.Enabled = false;
            this.txbMargemDeLucro.Location = new System.Drawing.Point(12, 119);
            this.txbMargemDeLucro.Name = "txbMargemDeLucro";
            this.txbMargemDeLucro.Size = new System.Drawing.Size(242, 20);
            this.txbMargemDeLucro.TabIndex = 7;
            // 
            // lblMargem
            // 
            this.lblMargem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMargem.AutoSize = true;
            this.lblMargem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMargem.ForeColor = System.Drawing.Color.Black;
            this.lblMargem.Location = new System.Drawing.Point(9, 101);
            this.lblMargem.Name = "lblMargem";
            this.lblMargem.Size = new System.Drawing.Size(120, 15);
            this.lblMargem.TabIndex = 6;
            this.lblMargem.Text = "Margem de Lucro";
            // 
            // txbPrecoDeVenda
            // 
            this.txbPrecoDeVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbPrecoDeVenda.Location = new System.Drawing.Point(12, 170);
            this.txbPrecoDeVenda.Name = "txbPrecoDeVenda";
            this.txbPrecoDeVenda.Size = new System.Drawing.Size(242, 20);
            this.txbPrecoDeVenda.TabIndex = 8;
            this.txbPrecoDeVenda.TextChanged += new System.EventHandler(this.txbPrecoDeVenda_TextChanged);
            this.txbPrecoDeVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPrecoDeVenda_KeyPress);
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.ForeColor = System.Drawing.Color.Black;
            this.lblQuantidade.Location = new System.Drawing.Point(7, 16);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(82, 15);
            this.lblQuantidade.TabIndex = 26;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // txbQuantidadeEstoque
            // 
            this.txbQuantidadeEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbQuantidadeEstoque.Location = new System.Drawing.Point(12, 37);
            this.txbQuantidadeEstoque.Name = "txbQuantidadeEstoque";
            this.txbQuantidadeEstoque.Size = new System.Drawing.Size(242, 20);
            this.txbQuantidadeEstoque.TabIndex = 5;
            // 
            // txbPrecoCusto
            // 
            this.txbPrecoCusto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbPrecoCusto.Location = new System.Drawing.Point(12, 78);
            this.txbPrecoCusto.Name = "txbPrecoCusto";
            this.txbPrecoCusto.Size = new System.Drawing.Size(242, 20);
            this.txbPrecoCusto.TabIndex = 6;
            this.txbPrecoCusto.TextChanged += new System.EventHandler(this.txbPrecoCusto_TextChanged);
            this.txbPrecoCusto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPrecoCusto_KeyPress);
            // 
            // lblPrecoCusto
            // 
            this.lblPrecoCusto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrecoCusto.AutoSize = true;
            this.lblPrecoCusto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoCusto.ForeColor = System.Drawing.Color.Black;
            this.lblPrecoCusto.Location = new System.Drawing.Point(9, 60);
            this.lblPrecoCusto.Name = "lblPrecoCusto";
            this.lblPrecoCusto.Size = new System.Drawing.Size(106, 15);
            this.lblPrecoCusto.TabIndex = 2;
            this.lblPrecoCusto.Text = "Preço de Custo";
            // 
            // lblPrecoVenda
            // 
            this.lblPrecoVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrecoVenda.AutoSize = true;
            this.lblPrecoVenda.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoVenda.ForeColor = System.Drawing.Color.Black;
            this.lblPrecoVenda.Location = new System.Drawing.Point(9, 152);
            this.lblPrecoVenda.Name = "lblPrecoVenda";
            this.lblPrecoVenda.Size = new System.Drawing.Size(109, 15);
            this.lblPrecoVenda.TabIndex = 4;
            this.lblPrecoVenda.Text = "Preço de Venda";
            // 
            // lblDataFabricacao
            // 
            this.lblDataFabricacao.AutoSize = true;
            this.lblDataFabricacao.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataFabricacao.ForeColor = System.Drawing.Color.Black;
            this.lblDataFabricacao.Location = new System.Drawing.Point(21, 263);
            this.lblDataFabricacao.Name = "lblDataFabricacao";
            this.lblDataFabricacao.Size = new System.Drawing.Size(134, 15);
            this.lblDataFabricacao.TabIndex = 14;
            this.lblDataFabricacao.Text = "Data de Fabricação";
            // 
            // lblDataVencimento
            // 
            this.lblDataVencimento.AutoSize = true;
            this.lblDataVencimento.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataVencimento.ForeColor = System.Drawing.Color.Black;
            this.lblDataVencimento.Location = new System.Drawing.Point(185, 263);
            this.lblDataVencimento.Name = "lblDataVencimento";
            this.lblDataVencimento.Size = new System.Drawing.Size(138, 15);
            this.lblDataVencimento.TabIndex = 15;
            this.lblDataVencimento.Text = "Data de Vencimento";
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.Azure;
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAlterar.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.btnAlterar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAlterar.IconSize = 32;
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAlterar.Location = new System.Drawing.Point(167, 319);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Rotation = 0D;
            this.btnAlterar.Size = new System.Drawing.Size(127, 35);
            this.btnAlterar.TabIndex = 20;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.Azure;
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.Color.Green;
            this.btnAdicionar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnAdicionar.IconColor = System.Drawing.Color.Green;
            this.btnAdicionar.IconSize = 32;
            this.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdicionar.Location = new System.Drawing.Point(24, 319);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Rotation = 0D;
            this.btnAdicionar.Size = new System.Drawing.Size(127, 35);
            this.btnAdicionar.TabIndex = 19;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // rbProdutoInativo
            // 
            this.rbProdutoInativo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbProdutoInativo.AutoSize = true;
            this.rbProdutoInativo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbProdutoInativo.Location = new System.Drawing.Point(15, 40);
            this.rbProdutoInativo.Name = "rbProdutoInativo";
            this.rbProdutoInativo.Size = new System.Drawing.Size(124, 19);
            this.rbProdutoInativo.TabIndex = 23;
            this.rbProdutoInativo.TabStop = true;
            this.rbProdutoInativo.Text = "Produto inativo";
            this.rbProdutoInativo.UseVisualStyleBackColor = true;
            // 
            // rbProdutoAtivo
            // 
            this.rbProdutoAtivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbProdutoAtivo.AutoSize = true;
            this.rbProdutoAtivo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbProdutoAtivo.Location = new System.Drawing.Point(14, 14);
            this.rbProdutoAtivo.Name = "rbProdutoAtivo";
            this.rbProdutoAtivo.Size = new System.Drawing.Size(113, 19);
            this.rbProdutoAtivo.TabIndex = 22;
            this.rbProdutoAtivo.TabStop = true;
            this.rbProdutoAtivo.Text = "Produto Ativo";
            this.rbProdutoAtivo.UseVisualStyleBackColor = true;
            // 
            // dgvProduto
            // 
            this.dgvProduto.AllowUserToAddRows = false;
            this.dgvProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProduto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProduto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProduto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvProduto.ColumnHeadersHeight = 30;
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProduto.EnableHeadersVisualStyles = false;
            this.dgvProduto.GridColor = System.Drawing.Color.SandyBrown;
            this.dgvProduto.Location = new System.Drawing.Point(20, 360);
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.ReadOnly = true;
            this.dgvProduto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduto.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvProduto.RowHeadersVisible = false;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.dgvProduto.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduto.Size = new System.Drawing.Size(836, 153);
            this.dgvProduto.TabIndex = 24;
            this.dgvProduto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduto_CellDoubleClick);
            // 
            // gpAtivo
            // 
            this.gpAtivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gpAtivo.Controls.Add(this.rbProdutoAtivo);
            this.gpAtivo.Controls.Add(this.rbProdutoInativo);
            this.gpAtivo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpAtivo.Location = new System.Drawing.Point(711, 4);
            this.gpAtivo.Name = "gpAtivo";
            this.gpAtivo.Size = new System.Drawing.Size(145, 69);
            this.gpAtivo.TabIndex = 11;
            this.gpAtivo.TabStop = false;
            // 
            // ckbInativo
            // 
            this.ckbInativo.AutoSize = true;
            this.ckbInativo.Location = new System.Drawing.Point(457, 329);
            this.ckbInativo.Name = "ckbInativo";
            this.ckbInativo.Size = new System.Drawing.Size(58, 17);
            this.ckbInativo.TabIndex = 28;
            this.ckbInativo.Text = "Inativo";
            this.ckbInativo.UseVisualStyleBackColor = true;
            // 
            // btnConsulta
            // 
            this.btnConsulta.BackColor = System.Drawing.Color.Azure;
            this.btnConsulta.FlatAppearance.BorderSize = 0;
            this.btnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta.ForeColor = System.Drawing.Color.Green;
            this.btnConsulta.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnConsulta.IconColor = System.Drawing.Color.Green;
            this.btnConsulta.IconSize = 32;
            this.btnConsulta.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConsulta.Location = new System.Drawing.Point(312, 319);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Rotation = 0D;
            this.btnConsulta.Size = new System.Drawing.Size(127, 35);
            this.btnConsulta.TabIndex = 29;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsulta.UseVisualStyleBackColor = false;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // msktDataFabricacao
            // 
            this.msktDataFabricacao.Location = new System.Drawing.Point(24, 281);
            this.msktDataFabricacao.Mask = "00/00/0000";
            this.msktDataFabricacao.Name = "msktDataFabricacao";
            this.msktDataFabricacao.Size = new System.Drawing.Size(85, 20);
            this.msktDataFabricacao.TabIndex = 9;
            // 
            // msktDataVencimento
            // 
            this.msktDataVencimento.Location = new System.Drawing.Point(188, 281);
            this.msktDataVencimento.Mask = "00/00/0000";
            this.msktDataVencimento.Name = "msktDataVencimento";
            this.msktDataVencimento.Size = new System.Drawing.Size(100, 20);
            this.msktDataVencimento.TabIndex = 10;
            // 
            // txbId
            // 
            this.txbId.Enabled = false;
            this.txbId.Location = new System.Drawing.Point(19, 36);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(54, 20);
            this.txbId.TabIndex = 45;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.Black;
            this.lblId.Location = new System.Drawing.Point(17, 18);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 15);
            this.lblId.TabIndex = 44;
            this.lblId.Text = "ID";
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(868, 522);
            this.Controls.Add(this.txbId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.msktDataVencimento);
            this.Controls.Add(this.msktDataFabricacao);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.ckbInativo);
            this.Controls.Add(this.gpAtivo);
            this.Controls.Add(this.dgvProduto);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.lblDataVencimento);
            this.Controls.Add(this.lblDataFabricacao);
            this.Controls.Add(this.gpValores);
            this.Controls.Add(this.gpCategoria);
            this.Controls.Add(this.gpDescricaoNome);
            this.Controls.Add(this.cmbFornecedor);
            this.Controls.Add(this.lblFornecedor);
            this.Controls.Add(this.txbCodigoBarras);
            this.Controls.Add(this.lblCodBarras);
            this.Name = "frmProduto";
            this.Text = "frmProduto";
            this.Load += new System.EventHandler(this.frmProduto_Load);
            this.gpDescricaoNome.ResumeLayout(false);
            this.gpDescricaoNome.PerformLayout();
            this.gpCategoria.ResumeLayout(false);
            this.gpCategoria.PerformLayout();
            this.gpValores.ResumeLayout(false);
            this.gpValores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            this.gpAtivo.ResumeLayout(false);
            this.gpAtivo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodBarras;
        private System.Windows.Forms.TextBox txbCodigoBarras;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.ComboBox cmbFornecedor;
        private System.Windows.Forms.GroupBox gpDescricaoNome;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.RichTextBox rtbDescricao;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.GroupBox gpCategoria;
        private System.Windows.Forms.RadioButton rbNaoPerecivel;
        private System.Windows.Forms.RadioButton rbPerecivel;
        private System.Windows.Forms.GroupBox gpValores;
        private System.Windows.Forms.TextBox txbMargemDeLucro;
        private System.Windows.Forms.Label lblMargem;
        private System.Windows.Forms.TextBox txbPrecoDeVenda;
        private System.Windows.Forms.Label lblPrecoVenda;
        private System.Windows.Forms.TextBox txbPrecoCusto;
        private System.Windows.Forms.Label lblPrecoCusto;
        private System.Windows.Forms.Label lblDataFabricacao;
        private System.Windows.Forms.Label lblDataVencimento;
        private FontAwesome.Sharp.IconButton btnAlterar;
        private FontAwesome.Sharp.IconButton btnAdicionar;
        private System.Windows.Forms.RadioButton rbProdutoInativo;
        private System.Windows.Forms.RadioButton rbProdutoAtivo;
        private System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.TextBox txbQuantidadeEstoque;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.GroupBox gpAtivo;
        private System.Windows.Forms.CheckBox ckbInativo;
        private FontAwesome.Sharp.IconButton btnConsulta;
        private System.Windows.Forms.MaskedTextBox msktDataFabricacao;
        private System.Windows.Forms.MaskedTextBox msktDataVencimento;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.Label lblId;
    }
}