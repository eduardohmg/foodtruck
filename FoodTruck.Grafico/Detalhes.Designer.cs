namespace FoodTruck.Grafico
{
    partial class Detalhes
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
            this.dgLanches = new System.Windows.Forms.DataGridView();
            this.dbBebidas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCliente = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgLanches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBebidas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgLanches
            // 
            this.dgLanches.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgLanches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLanches.Location = new System.Drawing.Point(12, 12);
            this.dgLanches.Name = "dgLanches";
            this.dgLanches.Size = new System.Drawing.Size(367, 394);
            this.dgLanches.TabIndex = 0;
            // 
            // dbBebidas
            // 
            this.dbBebidas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dbBebidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbBebidas.Location = new System.Drawing.Point(385, 12);
            this.dbBebidas.Name = "dbBebidas";
            this.dbBebidas.Size = new System.Drawing.Size(367, 394);
            this.dbBebidas.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 455);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cliente: ";
            // 
            // lbCliente
            // 
            this.lbCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbCliente.AutoSize = true;
            this.lbCliente.Location = new System.Drawing.Point(63, 455);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(0, 13);
            this.lbCliente.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(642, 455);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total: ";
            // 
            // lbTotal
            // 
            this.lbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(685, 455);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(0, 13);
            this.lbTotal.TabIndex = 5;
            // 
            // lbId
            // 
            this.lbId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(63, 442);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(0, 13);
            this.lbId.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 442);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Id: ";
            // 
            // Detalhes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 477);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dbBebidas);
            this.Controls.Add(this.dgLanches);
            this.Name = "Detalhes";
            this.Text = "Detalhes";
            ((System.ComponentModel.ISupportInitialize)(this.dgLanches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBebidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgLanches;
        private System.Windows.Forms.DataGridView dbBebidas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label label4;
    }
}