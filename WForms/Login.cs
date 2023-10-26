using WForms.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace WForms {
    public partial class Login : Form {
        public Login() {
            InitializeComponent();
        }

        UsuarioBLL usuario = new UsuarioBLL();

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
            try {
                if(usuario.ProcurarPorLogin(txtUsuario.Text, txtSenha.Text)) {
                    ((MDIPrincipal)this.MdiParent).EfetuouLogin();
                    this.Dispose();
                } else {
                    MessageBox.Show("Login não localizado.\nVerifique o usuário e senha digitados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch (Exception ex) {
                MessageBox.Show("Erro ao efetuar login. Erro:" + ex.Message,"Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
