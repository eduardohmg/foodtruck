﻿namespace FoodTruck.Grafico
{
    partial class TelaAdicionarBebidaPedido
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbBebidas = new System.Windows.Forms.ComboBox();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bebidas:";
            // 
            // cbBebidas
            // 
            this.cbBebidas.FormattingEnabled = true;
            this.cbBebidas.Location = new System.Drawing.Point(76, 10);
            this.cbBebidas.Name = "cbBebidas";
            this.cbBebidas.Size = new System.Drawing.Size(365, 21);
            this.cbBebidas.TabIndex = 1;
            // 
            // btAdicionar
            // 
            this.btAdicionar.Location = new System.Drawing.Point(274, 49);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btAdicionar.TabIndex = 2;
            this.btAdicionar.Text = "Adicionar";
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(366, 49);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 3;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // TelaAdicionarBebidaPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 113);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAdicionar);
            this.Controls.Add(this.cbBebidas);
            this.Controls.Add(this.label1);
            this.Name = "TelaAdicionarBebidaPedido";
            this.Text = "TelaAdicionarBebidaPedido";
            this.Load += new System.EventHandler(this.TelaAdicionarBebidaPedido_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbBebidas;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.Button btCancelar;
    }
}