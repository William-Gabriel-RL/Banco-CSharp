﻿namespace Banco
{
    partial class FormCalculaImposto
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
            this.botaoImpostos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botaoImpostos
            // 
            this.botaoImpostos.Location = new System.Drawing.Point(266, 343);
            this.botaoImpostos.Name = "botaoImpostos";
            this.botaoImpostos.Size = new System.Drawing.Size(107, 43);
            this.botaoImpostos.TabIndex = 0;
            this.botaoImpostos.Text = "Impostos";
            this.botaoImpostos.UseVisualStyleBackColor = true;
            this.botaoImpostos.Click += new System.EventHandler(this.botaoImpostos_Click);
            // 
            // FormCalculaImposto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botaoImpostos);
            this.Name = "FormCalculaImposto";
            this.Text = "FormCalculaImposto";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botaoImpostos;
    }
}