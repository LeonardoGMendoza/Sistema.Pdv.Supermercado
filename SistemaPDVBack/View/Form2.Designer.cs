namespace SistemaPDVBack.View
{
    partial class Form2
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            this.listBox1 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txbTotalRecebido = new System.Windows.Forms.TextBox();
            this.txbPrecoUnit = new System.Windows.Forms.TextBox();
            this.txbQuantidade = new System.Windows.Forms.TextBox();
            this.txbCodBarras = new System.Windows.Forms.TextBox();
            this.txbDescricao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.listBox1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.listBox1.FullRowSelect = true;
            this.listBox1.GridLines = true;
            this.listBox1.HideSelection = false;
            this.listBox1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(247, 398);
            this.listBox1.TabIndex = 1;
            this.listBox1.UseCompatibleStateImageBehavior = false;
            this.listBox1.View = System.Windows.Forms.View.List;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(515, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(515, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txbTotalRecebido
            // 
            this.txbTotalRecebido.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTotalRecebido.Location = new System.Drawing.Point(308, 269);
            this.txbTotalRecebido.Multiline = true;
            this.txbTotalRecebido.Name = "txbTotalRecebido";
            this.txbTotalRecebido.Size = new System.Drawing.Size(130, 38);
            this.txbTotalRecebido.TabIndex = 59;
            // 
            // txbPrecoUnit
            // 
            this.txbPrecoUnit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPrecoUnit.Location = new System.Drawing.Point(308, 135);
            this.txbPrecoUnit.Multiline = true;
            this.txbPrecoUnit.Name = "txbPrecoUnit";
            this.txbPrecoUnit.Size = new System.Drawing.Size(130, 36);
            this.txbPrecoUnit.TabIndex = 58;
            // 
            // txbQuantidade
            // 
            this.txbQuantidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbQuantidade.Location = new System.Drawing.Point(308, 196);
            this.txbQuantidade.Multiline = true;
            this.txbQuantidade.Name = "txbQuantidade";
            this.txbQuantidade.Size = new System.Drawing.Size(130, 36);
            this.txbQuantidade.TabIndex = 57;
            // 
            // txbCodBarras
            // 
            this.txbCodBarras.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCodBarras.Location = new System.Drawing.Point(308, 24);
            this.txbCodBarras.Multiline = true;
            this.txbCodBarras.Name = "txbCodBarras";
            this.txbCodBarras.Size = new System.Drawing.Size(263, 36);
            this.txbCodBarras.TabIndex = 56;
            // 
            // txbDescricao
            // 
            this.txbDescricao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDescricao.Location = new System.Drawing.Point(308, 80);
            this.txbDescricao.Multiline = true;
            this.txbDescricao.Name = "txbDescricao";
            this.txbDescricao.Size = new System.Drawing.Size(352, 36);
            this.txbDescricao.TabIndex = 55;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbTotalRecebido);
            this.Controls.Add(this.txbPrecoUnit);
            this.Controls.Add(this.txbQuantidade);
            this.Controls.Add(this.txbCodBarras);
            this.Controls.Add(this.txbDescricao);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txbTotalRecebido;
        private System.Windows.Forms.TextBox txbPrecoUnit;
        private System.Windows.Forms.TextBox txbQuantidade;
        private System.Windows.Forms.TextBox txbCodBarras;
        private System.Windows.Forms.TextBox txbDescricao;
    }
}