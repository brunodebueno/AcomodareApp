namespace WForms {
    partial class MDIPrincipal {
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIPrincipal));
            this.pnlNav = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlLateral = new System.Windows.Forms.Panel();
            this.btnDefinicoes = new WForms.Forms.ControlesCustom.BotaoNavLateral();
            this.btnCaixa = new WForms.Forms.ControlesCustom.BotaoNavLateral();
            this.btnAgenda = new WForms.Forms.ControlesCustom.BotaoNavLateral();
            this.btnProdutos = new WForms.Forms.ControlesCustom.BotaoNavLateral();
            this.btnPessoas = new WForms.Forms.ControlesCustom.BotaoNavLateral();
            this.btnHome = new WForms.Forms.ControlesCustom.BotaoNavLateral();
            this.btnAnimais = new WForms.Forms.ControlesCustom.BotaoNavLateral();
            this.timerPrincipal = new System.Windows.Forms.Timer(this.components);
            this.pnlNav.SuspendLayout();
            this.pnlLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNav
            // 
            this.pnlNav.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(66)))), ((int)(((byte)(117)))));
            this.pnlNav.Controls.Add(this.label1);
            this.pnlNav.Controls.Add(this.btnMinimize);
            this.pnlNav.Controls.Add(this.btnClose);
            this.pnlNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNav.Location = new System.Drawing.Point(0, 0);
            this.pnlNav.Margin = new System.Windows.Forms.Padding(0);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(720, 40);
            this.pnlNav.TabIndex = 4;
            this.pnlNav.DoubleClick += new System.EventHandler(this.pnlNav_DoubleClick);
            this.pnlNav.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlNav_MouseDown);
            this.pnlNav.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlNav_MouseMove);
            this.pnlNav.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlNav_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Acomodare";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(73)))), ((int)(((byte)(126)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(624, 3);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(45, 34);
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(669, 3);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(51, 34);
            this.btnClose.TabIndex = 4;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlLateral
            // 
            this.pnlLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.pnlLateral.Controls.Add(this.btnDefinicoes);
            this.pnlLateral.Controls.Add(this.btnCaixa);
            this.pnlLateral.Controls.Add(this.btnAgenda);
            this.pnlLateral.Controls.Add(this.btnProdutos);
            this.pnlLateral.Controls.Add(this.btnPessoas);
            this.pnlLateral.Controls.Add(this.btnHome);
            this.pnlLateral.Controls.Add(this.btnAnimais);
            this.pnlLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLateral.Location = new System.Drawing.Point(0, 40);
            this.pnlLateral.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLateral.Name = "pnlLateral";
            this.pnlLateral.Size = new System.Drawing.Size(66, 460);
            this.pnlLateral.TabIndex = 5;
            // 
            // btnDefinicoes
            // 
            this.btnDefinicoes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDefinicoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnDefinicoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDefinicoes.Icone = global::WForms.Properties.Resources.definicoes_normal;
            this.btnDefinicoes.IconeSelecionado = global::WForms.Properties.Resources.definicoes_selecionado;
            this.btnDefinicoes.Location = new System.Drawing.Point(0, 405);
            this.btnDefinicoes.Margin = new System.Windows.Forms.Padding(0);
            this.btnDefinicoes.Name = "btnDefinicoes";
            this.btnDefinicoes.Selecionado = false;
            this.btnDefinicoes.Size = new System.Drawing.Size(65, 55);
            this.btnDefinicoes.TabIndex = 13;
            this.btnDefinicoes.Texto = "Definições";
            // 
            // btnCaixa
            // 
            this.btnCaixa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnCaixa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCaixa.Icone = global::WForms.Properties.Resources.caixa_normal;
            this.btnCaixa.IconeSelecionado = global::WForms.Properties.Resources.caixa_selecionado;
            this.btnCaixa.Location = new System.Drawing.Point(0, 165);
            this.btnCaixa.Margin = new System.Windows.Forms.Padding(0);
            this.btnCaixa.Name = "btnCaixa";
            this.btnCaixa.Selecionado = false;
            this.btnCaixa.Size = new System.Drawing.Size(65, 55);
            this.btnCaixa.TabIndex = 12;
            this.btnCaixa.Texto = "Caixa";
            // 
            // btnAgenda
            // 
            this.btnAgenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnAgenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgenda.Icone = global::WForms.Properties.Resources.agenda_normal;
            this.btnAgenda.IconeSelecionado = global::WForms.Properties.Resources.agenda_selecionado;
            this.btnAgenda.Location = new System.Drawing.Point(0, 110);
            this.btnAgenda.Margin = new System.Windows.Forms.Padding(0);
            this.btnAgenda.Name = "btnAgenda";
            this.btnAgenda.Selecionado = false;
            this.btnAgenda.Size = new System.Drawing.Size(65, 55);
            this.btnAgenda.TabIndex = 11;
            this.btnAgenda.Texto = "Agenda";
            // 
            // btnProdutos
            // 
            this.btnProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnProdutos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProdutos.Icone = global::WForms.Properties.Resources.produtos_normal;
            this.btnProdutos.IconeSelecionado = global::WForms.Properties.Resources.produtos_selecionado;
            this.btnProdutos.Location = new System.Drawing.Point(0, 275);
            this.btnProdutos.Margin = new System.Windows.Forms.Padding(0);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Selecionado = false;
            this.btnProdutos.Size = new System.Drawing.Size(65, 55);
            this.btnProdutos.TabIndex = 10;
            this.btnProdutos.Texto = "Produtos";
            // 
            // btnPessoas
            // 
            this.btnPessoas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnPessoas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPessoas.Icone = global::WForms.Properties.Resources.pessoas_normal;
            this.btnPessoas.IconeSelecionado = global::WForms.Properties.Resources.pessoas_selecionado;
            this.btnPessoas.Location = new System.Drawing.Point(0, 220);
            this.btnPessoas.Margin = new System.Windows.Forms.Padding(0);
            this.btnPessoas.Name = "btnPessoas";
            this.btnPessoas.Selecionado = false;
            this.btnPessoas.Size = new System.Drawing.Size(65, 55);
            this.btnPessoas.TabIndex = 9;
            this.btnPessoas.Texto = "Pessoas";
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Icone = global::WForms.Properties.Resources.home_normal;
            this.btnHome.IconeSelecionado = global::WForms.Properties.Resources.home_selecionado;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Margin = new System.Windows.Forms.Padding(0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Selecionado = false;
            this.btnHome.Size = new System.Drawing.Size(65, 55);
            this.btnHome.TabIndex = 8;
            this.btnHome.Texto = "Home";
            // 
            // btnAnimais
            // 
            this.btnAnimais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnAnimais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnimais.Icone = global::WForms.Properties.Resources.pets_normal;
            this.btnAnimais.IconeSelecionado = global::WForms.Properties.Resources.pets_selecionado;
            this.btnAnimais.Location = new System.Drawing.Point(0, 55);
            this.btnAnimais.Margin = new System.Windows.Forms.Padding(0);
            this.btnAnimais.Name = "btnAnimais";
            this.btnAnimais.Selecionado = false;
            this.btnAnimais.Size = new System.Drawing.Size(65, 55);
            this.btnAnimais.TabIndex = 7;
            this.btnAnimais.Texto = "Animais";
            this.btnAnimais.Click += new System.EventHandler(this.btnAnimais_Click);
            // 
            // timerPrincipal
            // 
            this.timerPrincipal.Enabled = true;
            this.timerPrincipal.Interval = 500;
            this.timerPrincipal.Tick += new System.EventHandler(this.timerPrincipal_Tick);
            // 
            // MDIPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(720, 500);
            this.ControlBox = false;
            this.Controls.Add(this.pnlLateral);
            this.Controls.Add(this.pnlNav);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(720, 500);
            this.Name = "MDIPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FMDIPrincipal_Load);
            this.SizeChanged += new System.EventHandler(this.MDIPrincipal_SizeChanged);
            this.Resize += new System.EventHandler(this.MDIPrincipal_Resize);
            this.pnlNav.ResumeLayout(false);
            this.pnlNav.PerformLayout();
            this.pnlLateral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlLateral;
        private System.Windows.Forms.Label label1;
        private Forms.ControlesCustom.BotaoNavLateral btnAnimais;
        private Forms.ControlesCustom.BotaoNavLateral btnHome;
        private Forms.ControlesCustom.BotaoNavLateral btnPessoas;
        private Forms.ControlesCustom.BotaoNavLateral btnAgenda;
        private Forms.ControlesCustom.BotaoNavLateral btnProdutos;
        private Forms.ControlesCustom.BotaoNavLateral btnCaixa;
        private System.Windows.Forms.Timer timerPrincipal;
        private Forms.ControlesCustom.BotaoNavLateral btnDefinicoes;
    }
}

