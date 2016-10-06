namespace Banco
{
    partial class FormRelatorios
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
            this.listaResultado = new System.Windows.Forms.ListBox();
            this.btnFiltroSaldo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMaiorSaldo = new System.Windows.Forms.Label();
            this.lblSaldoTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listaResultado
            // 
            this.listaResultado.FormattingEnabled = true;
            this.listaResultado.Location = new System.Drawing.Point(12, 12);
            this.listaResultado.Name = "listaResultado";
            this.listaResultado.Size = new System.Drawing.Size(260, 121);
            this.listaResultado.TabIndex = 0;
            // 
            // btnFiltroSaldo
            // 
            this.btnFiltroSaldo.Location = new System.Drawing.Point(12, 235);
            this.btnFiltroSaldo.Name = "btnFiltroSaldo";
            this.btnFiltroSaldo.Size = new System.Drawing.Size(162, 23);
            this.btnFiltroSaldo.TabIndex = 1;
            this.btnFiltroSaldo.Text = "Saldo Maior do que 5000";
            this.btnFiltroSaldo.UseVisualStyleBackColor = true;
            this.btnFiltroSaldo.Click += new System.EventHandler(this.btnFiltroSaldo_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(198, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Antigas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMaiorSaldo);
            this.groupBox1.Controls.Add(this.lblSaldoTotal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 74);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resumo";
            // 
            // lblMaiorSaldo
            // 
            this.lblMaiorSaldo.AutoSize = true;
            this.lblMaiorSaldo.Location = new System.Drawing.Point(184, 50);
            this.lblMaiorSaldo.Name = "lblMaiorSaldo";
            this.lblMaiorSaldo.Size = new System.Drawing.Size(70, 13);
            this.lblMaiorSaldo.TabIndex = 3;
            this.lblMaiorSaldo.Text = "lblMaiorSaldo";
            // 
            // lblSaldoTotal
            // 
            this.lblSaldoTotal.AutoSize = true;
            this.lblSaldoTotal.Location = new System.Drawing.Point(183, 27);
            this.lblSaldoTotal.Name = "lblSaldoTotal";
            this.lblSaldoTotal.Size = new System.Drawing.Size(68, 13);
            this.lblSaldoTotal.TabIndex = 2;
            this.lblSaldoTotal.Text = "lblSaldoTotal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Maior Saldo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saldo Total";
            // 
            // FormRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 270);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFiltroSaldo);
            this.Controls.Add(this.listaResultado);
            this.Name = "FormRelatorios";
            this.Text = "FormRelatorios";
            this.Load += new System.EventHandler(this.FormRelatorios_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listaResultado;
        private System.Windows.Forms.Button btnFiltroSaldo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMaiorSaldo;
        private System.Windows.Forms.Label lblSaldoTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}