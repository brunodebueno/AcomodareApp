using AcomodareApp.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcomodareApp {
    public partial class Login : Form {
        public Login() {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e) {
            background.Size = this.Size;
            background.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        }

        private void Login_Resize(object sender, EventArgs e) {
            pnlLogin.Top = (this.Size.Height - pnlLogin.Height) / 2;
            pnlLoginContainer.Width = (int)(this.Size.Width * 0.3);
            pnlLogin.Left = (pnlLoginContainer.Width - pnlLogin.Width) / 2;
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            if(txtUsuario.Text == "admin" && txtSenha.Text == "admin") {
                ((MDIPrincipal)this.MdiParent).EfetuouLogin();
                this.Dispose();
            }               
        }

        private void txtUsuario_KeyUp(object sender, KeyEventArgs e) {
            FormUtils.KeyUp(this, sender, e);
        }

        private void txtSenha_KeyUp(object sender, KeyEventArgs e) {
            FormUtils.KeyUp(this, sender, e);
        }
    }
}
