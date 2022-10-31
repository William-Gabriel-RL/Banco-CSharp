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
            this.botaoFiltroSaldo = new System.Windows.Forms.Button();
            this.botaoAntigas = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelMaiorSaldo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelSaldoTotal = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listaResultado
            // 
            this.listaResultado.FormattingEnabled = true;
            this.listaResultado.ItemHeight = 20;
            this.listaResultado.Location = new System.Drawing.Point(12, 12);
            this.listaResultado.Name = "listaResultado";
            this.listaResultado.Size = new System.Drawing.Size(320, 204);
            this.listaResultado.TabIndex = 0;
            // 
            // botaoFiltroSaldo
            // 
            this.botaoFiltroSaldo.Location = new System.Drawing.Point(12, 350);
            this.botaoFiltroSaldo.Name = "botaoFiltroSaldo";
            this.botaoFiltroSaldo.Size = new System.Drawing.Size(198, 34);
            this.botaoFiltroSaldo.TabIndex = 1;
            this.botaoFiltroSaldo.Text = "Saldo maior que 500";
            this.botaoFiltroSaldo.UseVisualStyleBackColor = true;
            this.botaoFiltroSaldo.Click += new System.EventHandler(this.botaoFiltroSaldo_Click);
            // 
            // botaoAntigas
            // 
            this.botaoAntigas.Location = new System.Drawing.Point(243, 350);
            this.botaoAntigas.Name = "botaoAntigas";
            this.botaoAntigas.Size = new System.Drawing.Size(143, 34);
            this.botaoAntigas.TabIndex = 2;
            this.botaoAntigas.Text = "Antigas";
            this.botaoAntigas.UseVisualStyleBackColor = true;
            this.botaoAntigas.Click += new System.EventHandler(this.botaoAntigas_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelSaldoTotal);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelMaiorSaldo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 231);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 113);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resumo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saldo Total";
            // 
            // labelMaiorSaldo
            // 
            this.labelMaiorSaldo.AutoSize = true;
            this.labelMaiorSaldo.Location = new System.Drawing.Point(147, 80);
            this.labelMaiorSaldo.Name = "labelMaiorSaldo";
            this.labelMaiorSaldo.Size = new System.Drawing.Size(183, 30);
            this.labelMaiorSaldo.TabIndex = 1;
            this.labelMaiorSaldo.Text = "labelmaiorSaldo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Maior Saldo";
            // 
            // labelSaldoTotal
            // 
            this.labelSaldoTotal.AutoSize = true;
            this.labelSaldoTotal.Location = new System.Drawing.Point(143, 38);
            this.labelSaldoTotal.Name = "labelSaldoTotal";
            this.labelSaldoTotal.Size = new System.Drawing.Size(114, 20);
            this.labelSaldoTotal.TabIndex = 3;
            this.labelSaldoTotal.Text = "labelSaltoTotal";
            // 
            // FormRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.botaoAntigas);
            this.Controls.Add(this.botaoFiltroSaldo);
            this.Controls.Add(this.listaResultado);
            this.Name = "FormRelatorios";
            this.Text = "FormRelatorios";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listaResultado;
        private System.Windows.Forms.Button botaoFiltroSaldo;
        private System.Windows.Forms.Button botaoAntigas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelSaldoTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelMaiorSaldo;
        private System.Windows.Forms.Label label1;
    }
}