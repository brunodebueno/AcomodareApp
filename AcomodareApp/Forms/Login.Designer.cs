namespace AcomodareApp {
    partial class Login {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.pnlLoginContainer = new System.Windows.Forms.Panel();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblSenha = new System.Windows.Forms.Label();
            this.background = new System.Windows.Forms.PictureBox();
            this.pnlLoginContainer.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLoginContainer
            // 
            this.pnlLoginContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlLoginContainer.BackColor = System.Drawing.Color.White;
            this.pnlLoginContainer.Controls.Add(this.pnlLogin);
            this.pnlLoginContainer.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlLoginContainer.Location = new System.Drawing.Point(340, 0);
            this.pnlLoginContainer.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLoginContainer.MinimumSize = new System.Drawing.Size(340, 430);
            this.pnlLoginContainer.Name = "pnlLoginContainer";
            this.pnlLoginContainer.Size = new System.Drawing.Size(375, 430);
            this.pnlLoginContainer.TabIndex = 6;
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.label4);
            this.pnlLogin.Controls.Add(this.label3);
            this.pnlLogin.Controls.Add(this.label2);
            this.pnlLogin.Controls.Add(this.label1);
            this.pnlLogin.Controls.Add(this.txtSenha);
            this.pnlLogin.Controls.Add(this.txtUsuario);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.lblSenha);
            this.pnlLogin.Location = new System.Drawing.Point(17, 33);
            this.pnlLogin.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(340, 360);
            this.pnlLogin.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(129)))), ((int)(((byte)(226)))));
            this.label4.Location = new System.Drawing.Point(39, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "esqueci a senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Faça seu login para entar no sistema";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(111)))), ((int)(((byte)(214)))));
            this.label2.Location = new System.Drawing.Point(94, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 30);
            this.label2.TabIndex = 16;
            this.label2.Text = "seja bem vindo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label1.Location = new System.Drawing.Point(39, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Usuario";
            // 
            // txtSenha
            // 
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenha.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(39, 234);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(266, 33);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSenha_KeyUp);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(39, 172);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(266, 33);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtUsuario_KeyUp);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(129)))), ((int)(((byte)(226)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(175)))), ((int)(((byte)(255)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(149)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(42, 313);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(263, 35);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Acessar";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.lblSenha.Location = new System.Drawing.Point(39, 218);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(39, 13);
            this.lblSenha.TabIndex = 11;
            this.lblSenha.Text = "Senha";
            // 
            // background
            // 
            this.background.Image = global::AcomodareApp.Properties.Resources.login_background;
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Margin = new System.Windows.Forms.Padding(0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(295, 181);
            this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.background.TabIndex = 5;
            this.background.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(715, 430);
            this.ControlBox = false;
            this.Controls.Add(this.pnlLoginContainer);
            this.Controls.Add(this.background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(715, 430);
            this.Name = "Login";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Login";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Login_Load);
            this.Resize += new System.EventHandler(this.Login_Resize);
            this.pnlLoginContainer.ResumeLayout(false);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.Panel pnlLoginContainer;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblSenha;
    }
}