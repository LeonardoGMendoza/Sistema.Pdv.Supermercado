namespace SistemaPDVBack.View
{
    partial class frmColaborador
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbDadosColaborador = new System.Windows.Forms.GroupBox();
            this.txbId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.lblEmailCorporativo = new System.Windows.Forms.Label();
            this.txbEmailCorporativo = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.mskTxtCelular = new System.Windows.Forms.MaskedTextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.gpAtivo = new System.Windows.Forms.GroupBox();
            this.rbColaboradorInativo = new System.Windows.Forms.RadioButton();
            this.rbColaboradorAtivo = new System.Windows.Forms.RadioButton();
            this.msktCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.dgvColaborador = new System.Windows.Forms.DataGridView();
            this.btnAlterar = new FontAwesome.Sharp.IconButton();
            this.btnAdicionar = new FontAwesome.Sharp.IconButton();
            this.btnConsulta = new FontAwesome.Sharp.IconButton();
            this.ckbIntativo = new System.Windows.Forms.CheckBox();
            this.gbDadosColaborador.SuspendLayout();
            this.gpAtivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColaborador)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDadosColaborador
            // 
            this.gbDadosColaborador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDadosColaborador.Controls.Add(this.txbId);
            this.gbDadosColaborador.Controls.Add(this.lblId);
            this.gbDadosColaborador.Controls.Add(this.cmbCargo);
            this.gbDadosColaborador.Controls.Add(this.txbSenha);
            this.gbDadosColaborador.Controls.Add(this.lblSenha);
            this.gbDadosColaborador.Controls.Add(this.txbUsuario);
            this.gbDadosColaborador.Controls.Add(this.lblUsuario);
            this.gbDadosColaborador.Controls.Add(this.label1);
            this.gbDadosColaborador.Controls.Add(this.cmbDepartamento);
            this.gbDadosColaborador.Controls.Add(this.lblEmailCorporativo);
            this.gbDadosColaborador.Controls.Add(this.txbEmailCorporativo);
            this.gbDadosColaborador.Controls.Add(this.lblEmail);
            this.gbDadosColaborador.Controls.Add(this.txbEmail);
            this.gbDadosColaborador.Controls.Add(this.lblCelular);
            this.gbDadosColaborador.Controls.Add(this.mskTxtCelular);
            this.gbDadosColaborador.Controls.Add(this.lblCargo);
            this.gbDadosColaborador.Controls.Add(this.gpAtivo);
            this.gbDadosColaborador.Controls.Add(this.msktCpf);
            this.gbDadosColaborador.Controls.Add(this.lblCpf);
            this.gbDadosColaborador.Controls.Add(this.txbNome);
            this.gbDadosColaborador.Controls.Add(this.lblNome);
            this.gbDadosColaborador.Location = new System.Drawing.Point(12, 2);
            this.gbDadosColaborador.Name = "gbDadosColaborador";
            this.gbDadosColaborador.Size = new System.Drawing.Size(776, 179);
            this.gbDadosColaborador.TabIndex = 4;
            this.gbDadosColaborador.TabStop = false;
            // 
            // txbId
            // 
            this.txbId.Enabled = false;
            this.txbId.Location = new System.Drawing.Point(6, 30);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(51, 20);
            this.txbId.TabIndex = 48;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.Black;
            this.lblId.Location = new System.Drawing.Point(6, 10);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 15);
            this.lblId.TabIndex = 47;
            this.lblId.Text = "ID";
            // 
            // cmbCargo
            // 
            this.cmbCargo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCargo.BackColor = System.Drawing.Color.White;
            this.cmbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Items.AddRange(new object[] {
            "Admin",
            "Caixa"});
            this.cmbCargo.Location = new System.Drawing.Point(595, 132);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(175, 21);
            this.cmbCargo.TabIndex = 9;
            // 
            // txbSenha
            // 
            this.txbSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbSenha.Location = new System.Drawing.Point(350, 132);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(239, 20);
            this.txbSenha.TabIndex = 8;
            this.txbSenha.UseSystemPasswordChar = true;
            // 
            // lblSenha
            // 
            this.lblSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.Black;
            this.lblSenha.Location = new System.Drawing.Point(347, 116);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(48, 15);
            this.lblSenha.TabIndex = 44;
            this.lblSenha.Text = "Senha";
            // 
            // txbUsuario
            // 
            this.txbUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbUsuario.Location = new System.Drawing.Point(350, 83);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(236, 20);
            this.txbUsuario.TabIndex = 5;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblUsuario.Location = new System.Drawing.Point(347, 67);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(58, 15);
            this.lblUsuario.TabIndex = 42;
            this.lblUsuario.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(592, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 39;
            this.label1.Text = "Departamento";
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDepartamento.BackColor = System.Drawing.Color.White;
            this.cmbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(595, 82);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(175, 21);
            this.cmbDepartamento.TabIndex = 6;
            // 
            // lblEmailCorporativo
            // 
            this.lblEmailCorporativo.AutoSize = true;
            this.lblEmailCorporativo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailCorporativo.ForeColor = System.Drawing.Color.Black;
            this.lblEmailCorporativo.Location = new System.Drawing.Point(6, 116);
            this.lblEmailCorporativo.Name = "lblEmailCorporativo";
            this.lblEmailCorporativo.Size = new System.Drawing.Size(129, 15);
            this.lblEmailCorporativo.TabIndex = 37;
            this.lblEmailCorporativo.Text = "E-mail Corporativo";
            // 
            // txbEmailCorporativo
            // 
            this.txbEmailCorporativo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbEmailCorporativo.Location = new System.Drawing.Point(9, 132);
            this.txbEmailCorporativo.Name = "txbEmailCorporativo";
            this.txbEmailCorporativo.Size = new System.Drawing.Size(321, 20);
            this.txbEmailCorporativo.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(6, 67);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 15);
            this.lblEmail.TabIndex = 35;
            this.lblEmail.Text = "E-mail ";
            // 
            // txbEmail
            // 
            this.txbEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbEmail.Location = new System.Drawing.Point(6, 83);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(324, 20);
            this.txbEmail.TabIndex = 4;
            // 
            // lblCelular
            // 
            this.lblCelular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.ForeColor = System.Drawing.Color.Black;
            this.lblCelular.Location = new System.Drawing.Point(369, 14);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(55, 15);
            this.lblCelular.TabIndex = 31;
            this.lblCelular.Text = "Celular";
            // 
            // mskTxtCelular
            // 
            this.mskTxtCelular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mskTxtCelular.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTxtCelular.Location = new System.Drawing.Point(372, 29);
            this.mskTxtCelular.Mask = "(99) 00000-0000";
            this.mskTxtCelular.Name = "mskTxtCelular";
            this.mskTxtCelular.Size = new System.Drawing.Size(107, 22);
            this.mskTxtCelular.TabIndex = 2;
            // 
            // lblCargo
            // 
            this.lblCargo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.ForeColor = System.Drawing.Color.Black;
            this.lblCargo.Location = new System.Drawing.Point(592, 116);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(47, 15);
            this.lblCargo.TabIndex = 28;
            this.lblCargo.Text = "Cargo";
            // 
            // gpAtivo
            // 
            this.gpAtivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gpAtivo.Controls.Add(this.rbColaboradorInativo);
            this.gpAtivo.Controls.Add(this.rbColaboradorAtivo);
            this.gpAtivo.Location = new System.Drawing.Point(595, 10);
            this.gpAtivo.Name = "gpAtivo";
            this.gpAtivo.Size = new System.Drawing.Size(175, 55);
            this.gpAtivo.TabIndex = 26;
            this.gpAtivo.TabStop = false;
            // 
            // rbColaboradorInativo
            // 
            this.rbColaboradorInativo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbColaboradorInativo.AutoSize = true;
            this.rbColaboradorInativo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbColaboradorInativo.Location = new System.Drawing.Point(10, 33);
            this.rbColaboradorInativo.Name = "rbColaboradorInativo";
            this.rbColaboradorInativo.Size = new System.Drawing.Size(154, 19);
            this.rbColaboradorInativo.TabIndex = 29;
            this.rbColaboradorInativo.TabStop = true;
            this.rbColaboradorInativo.Text = "Colaborador inativo";
            this.rbColaboradorInativo.UseVisualStyleBackColor = true;
            // 
            // rbColaboradorAtivo
            // 
            this.rbColaboradorAtivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbColaboradorAtivo.AutoSize = true;
            this.rbColaboradorAtivo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbColaboradorAtivo.Location = new System.Drawing.Point(10, 11);
            this.rbColaboradorAtivo.Name = "rbColaboradorAtivo";
            this.rbColaboradorAtivo.Size = new System.Drawing.Size(143, 19);
            this.rbColaboradorAtivo.TabIndex = 28;
            this.rbColaboradorAtivo.TabStop = true;
            this.rbColaboradorAtivo.Text = "Colaborador Ativo";
            this.rbColaboradorAtivo.UseVisualStyleBackColor = true;
            // 
            // msktCpf
            // 
            this.msktCpf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.msktCpf.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msktCpf.Location = new System.Drawing.Point(492, 29);
            this.msktCpf.Mask = "999,999,999-99";
            this.msktCpf.Name = "msktCpf";
            this.msktCpf.Size = new System.Drawing.Size(97, 22);
            this.msktCpf.TabIndex = 3;
            // 
            // lblCpf
            // 
            this.lblCpf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.ForeColor = System.Drawing.Color.Black;
            this.lblCpf.Location = new System.Drawing.Point(489, 14);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(34, 15);
            this.lblCpf.TabIndex = 7;
            this.lblCpf.Text = "CPF";
            // 
            // txbNome
            // 
            this.txbNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbNome.Location = new System.Drawing.Point(68, 30);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(279, 20);
            this.txbNome.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.Black;
            this.lblNome.Location = new System.Drawing.Point(65, 10);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 15);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome";
            // 
            // dgvColaborador
            // 
            this.dgvColaborador.AllowUserToAddRows = false;
            this.dgvColaborador.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvColaborador.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvColaborador.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvColaborador.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvColaborador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvColaborador.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvColaborador.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvColaborador.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvColaborador.ColumnHeadersHeight = 30;
            this.dgvColaborador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvColaborador.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvColaborador.EnableHeadersVisualStyles = false;
            this.dgvColaborador.GridColor = System.Drawing.Color.Yellow;
            this.dgvColaborador.Location = new System.Drawing.Point(12, 239);
            this.dgvColaborador.Name = "dgvColaborador";
            this.dgvColaborador.ReadOnly = true;
            this.dgvColaborador.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvColaborador.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvColaborador.RowHeadersVisible = false;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.dgvColaborador.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvColaborador.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvColaborador.Size = new System.Drawing.Size(776, 205);
            this.dgvColaborador.TabIndex = 25;
            this.dgvColaborador.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvColaborador_CellDoubleClick);
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
            this.btnAlterar.Location = new System.Drawing.Point(145, 198);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Rotation = 0D;
            this.btnAlterar.Size = new System.Drawing.Size(127, 35);
            this.btnAlterar.TabIndex = 27;
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
            this.btnAdicionar.Location = new System.Drawing.Point(12, 198);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Rotation = 0D;
            this.btnAdicionar.Size = new System.Drawing.Size(127, 35);
            this.btnAdicionar.TabIndex = 26;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
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
            this.btnConsulta.Location = new System.Drawing.Point(278, 198);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Rotation = 0D;
            this.btnConsulta.Size = new System.Drawing.Size(127, 35);
            this.btnConsulta.TabIndex = 28;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsulta.UseVisualStyleBackColor = false;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // ckbIntativo
            // 
            this.ckbIntativo.AutoSize = true;
            this.ckbIntativo.Location = new System.Drawing.Point(435, 208);
            this.ckbIntativo.Name = "ckbIntativo";
            this.ckbIntativo.Size = new System.Drawing.Size(58, 17);
            this.ckbIntativo.TabIndex = 29;
            this.ckbIntativo.Text = "Inativo";
            this.ckbIntativo.UseVisualStyleBackColor = true;
            // 
            // frmColaborador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ckbIntativo);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.dgvColaborador);
            this.Controls.Add(this.gbDadosColaborador);
            this.Name = "frmColaborador";
            this.Text = "frmColaborador";
            this.Load += new System.EventHandler(this.frmColaborador_Load);
            this.gbDadosColaborador.ResumeLayout(false);
            this.gbDadosColaborador.PerformLayout();
            this.gpAtivo.ResumeLayout(false);
            this.gpAtivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColaborador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDadosColaborador;
        private System.Windows.Forms.MaskedTextBox msktCpf;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.MaskedTextBox mskTxtCelular;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.GroupBox gpAtivo;
        private System.Windows.Forms.RadioButton rbColaboradorInativo;
        private System.Windows.Forms.RadioButton rbColaboradorAtivo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.Label lblEmailCorporativo;
        private System.Windows.Forms.TextBox txbEmailCorporativo;
        private System.Windows.Forms.DataGridView dgvColaborador;
        private FontAwesome.Sharp.IconButton btnAlterar;
        private FontAwesome.Sharp.IconButton btnAdicionar;
        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.ComboBox cmbCargo;
        private FontAwesome.Sharp.IconButton btnConsulta;
        private System.Windows.Forms.CheckBox ckbIntativo;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.Label lblId;
    }
}