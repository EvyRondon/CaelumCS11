namespace POO
{
    partial class FormCadastroConta
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
            this.lblTitular = new System.Windows.Forms.Label();
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblConta = new System.Windows.Forms.Label();
            this.comboTipoConta = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTitular
            // 
            this.lblTitular.AutoSize = true;
            this.lblTitular.Location = new System.Drawing.Point(12, 34);
            this.lblTitular.Name = "lblTitular";
            this.lblTitular.Size = new System.Drawing.Size(36, 13);
            this.lblTitular.TabIndex = 8;
            this.lblTitular.Text = "Titular";
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(62, 31);
            this.txtTitular.MaxLength = 8;
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(210, 20);
            this.txtTitular.TabIndex = 9;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(62, 57);
            this.txtNumero.MaxLength = 8;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(210, 20);
            this.txtNumero.TabIndex = 10;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(12, 60);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 11;
            this.lblNumero.Text = "Numero";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(197, 226);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 12;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblConta
            // 
            this.lblConta.AutoSize = true;
            this.lblConta.Location = new System.Drawing.Point(12, 9);
            this.lblConta.Name = "lblConta";
            this.lblConta.Size = new System.Drawing.Size(35, 13);
            this.lblConta.TabIndex = 13;
            this.lblConta.Text = "Conta";
            // 
            // comboTipoConta
            // 
            this.comboTipoConta.FormattingEnabled = true;
            this.comboTipoConta.Location = new System.Drawing.Point(62, 6);
            this.comboTipoConta.Name = "comboTipoConta";
            this.comboTipoConta.Size = new System.Drawing.Size(210, 21);
            this.comboTipoConta.TabIndex = 14;
            // 
            // FormCadastroConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.comboTipoConta);
            this.Controls.Add(this.lblConta);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblTitular);
            this.Controls.Add(this.txtTitular);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblNumero);
            this.Name = "FormCadastroConta";
            this.Text = "Cadastro de Conta";
            this.Load += new System.EventHandler(this.FormCadastroConta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitular;
        private System.Windows.Forms.TextBox txtTitular;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblConta;
        private System.Windows.Forms.ComboBox comboTipoConta;
    }
}