namespace WForms.Forms.ControlesCustom {
    partial class BotaoNavLateral {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.pnlNavegacao = new System.Windows.Forms.Panel();
            this.imgIcone = new System.Windows.Forms.PictureBox();
            this.lblTexto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgIcone)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNavegacao
            // 
            this.pnlNavegacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(129)))), ((int)(((byte)(226)))));
            this.pnlNavegacao.Location = new System.Drawing.Point(1, 2);
            this.pnlNavegacao.Margin = new System.Windows.Forms.Padding(0);
            this.pnlNavegacao.Name = "pnlNavegacao";
            this.pnlNavegacao.Size = new System.Drawing.Size(2, 51);
            this.pnlNavegacao.TabIndex = 6;
            // 
            // imgIcone
            // 
            this.imgIcone.Location = new System.Drawing.Point(22, 12);
            this.imgIcone.Name = "imgIcone";
            this.imgIcone.Size = new System.Drawing.Size(24, 24);
            this.imgIcone.TabIndex = 7;
            this.imgIcone.TabStop = false;
            // 
            // lblTexto
            // 
            this.lblTexto.BackColor = System.Drawing.Color.Transparent;
            this.lblTexto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTexto.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.lblTexto.Location = new System.Drawing.Point(4, 37);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(62, 16);
            this.lblTexto.TabIndex = 8;
            this.lblTexto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BotaoNavLateral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.pnlNavegacao);
            this.Controls.Add(this.imgIcone);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "BotaoNavLateral";
            this.Size = new System.Drawing.Size(65, 55);
            this.Load += new System.EventHandler(this.BotaoNavLateral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgIcone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNavegacao;
        private System.Windows.Forms.PictureBox imgIcone;
        private System.Windows.Forms.Label lblTexto;
    }
}
