using WForms.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace WForms {
    public partial class MDIPrincipal : Form {

        private const int cGrip = 16;
        private const int cCaption = 32;        
        private bool enableMoving = false;
        private Point initialClickedPoint;

        Login login;
        Pets pets;
        Pessoas pessoas;
        Produtos produtos;
        Configuracoes configuracoes;

        private bool exibiuLogin = false;

        public MDIPrincipal() {
            InitializeComponent();
        }
        private void FMDIPrincipal_Load(object sender, EventArgs e) {
            login.MdiParent = this;

            pnlLateral.Hide();
            login.Show();
            login.Location = new Point(0, 0);
            this.ActivateMdiChild(login);
            this.ActiveMdiChild.Dock = DockStyle.Fill;

            this.SetBevel(false);

            btnAnimais.Clicked += new EventHandler(btnAnimais_Click);
            btnPessoas.Clicked += new EventHandler(btnPessoas_Click);
            btnProdutos.Clicked += new EventHandler(btnProdutos_Click);
            btnDefinicoes.Clicked += new EventHandler(btnDefinicoes_Click);

        }

        private void MDIPrincipal_SizeChanged(object sender, EventArgs e) {
            if (!exibiuLogin) {
                exibiuLogin = true;
                login = new Login();
            }
        }

        #region Funções Locais
        public void EfetuouLogin() {
            pnlLateral.Show();
            //MaximizarForm();
        }

        public void FechouPets() {
            btnAnimais.Selecionado = false;
            btnAnimais.LostFocus();
        }

        public void FechouPessoas() {
            btnPessoas.Selecionado = false;
            btnPessoas.LostFocus();
        }

        public void FechouProdutos() {
            btnProdutos.Selecionado = false;
            btnProdutos.LostFocus();
        }
        public void FechouConfiguracoes() {
            btnDefinicoes.Selecionado = false;
            btnDefinicoes.LostFocus();
        }

        private void DoubleClickRedimensionar() {
            if (this.WindowState == FormWindowState.Normal)
                MaximizarForm();
            else if (this.WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
        }

        private void MaximizarForm() {
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
        }

        #endregion

        #region Funções Redimensionamento Form
        protected override void OnPaint(PaintEventArgs e) {
            Rectangle rc = new Rectangle(this.ClientSize.Width - cGrip, this.ClientSize.Height - cGrip, cGrip, cGrip);
            ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);
            rc = new Rectangle(0, 0, this.ClientSize.Width, cCaption);
            e.Graphics.FillRectangle(Brushes.DarkBlue, rc);
        }
        protected override void WndProc(ref Message m) {
            if (m.Msg == 0x84) {  // Trap WM_NCHITTEST
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption) {
                    m.Result = (IntPtr)2;  // HTCAPTION
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip) {
                    m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                    return;
                }
            }
            base.WndProc(ref m);
        }
        #endregion

        #region Navegação
        private void btnClose_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e) {
            WindowState = FormWindowState.Minimized;
        }

        private void pnlNav_DoubleClick(object sender, EventArgs e) {
            DoubleClickRedimensionar();
        }

        private void pnlNav_MouseDown(object sender, MouseEventArgs e) {
            enableMoving = true;
            initialClickedPoint = e.Location;
        }

        private void pnlNav_MouseUp(object sender, MouseEventArgs e) {
            enableMoving = false;
        }
        
        private void pnlNav_MouseMove(object sender, MouseEventArgs e) {
            if (enableMoving){
                this.Location = new Point(e.X + this.Left - initialClickedPoint.X,
                        e.Y + this.Top - initialClickedPoint.Y);
            }
        }
        #endregion

        #region Botoes

        #endregion

        private void timerPrincipal_Tick(object sender, EventArgs e)
        {
            //lblHoras.Text = DateTime.Now.ToString("HH:mm");            
        }
        
        private void btnAnimais_Click(object sender, EventArgs e)
        {
            if(pets == null || pets.IsDisposed)
                pets = new Pets();
            btnAnimais.Selecionado = false; // Altera pra voltar a ser selecionado
            if (this.ActiveMdiChild != pets) {                 
                this.ActivateMdiChild(pets);
                if(this.ActiveMdiChild != null)
                    this.ActiveMdiChild.BringToFront();
            }

            pets.MdiParent = this;
            pets.Show();
            pets.Location = new Point(0, 0);
            this.SetBevel(false);

            this.ActiveMdiChild.Dock = DockStyle.Fill;
        }

        private void MDIPrincipal_Resize(object sender, EventArgs e)
        {
            if(this.ActiveMdiChild != null) this.ActiveMdiChild.Dock = DockStyle.Fill;
        }


        private void btnPessoas_Click(object sender, EventArgs e) {
            if (pessoas == null || pessoas.IsDisposed)
                pessoas = new Pessoas();
            btnPessoas.Selecionado = false; // Altera pra voltar a ser selecionado
            if (this.ActiveMdiChild != pessoas) {                 
                this.ActivateMdiChild(pessoas);
                if (this.ActiveMdiChild != null)
                    this.ActiveMdiChild.BringToFront();
            }
                

            pessoas.MdiParent = this;
            pessoas.Show();
            pessoas.Location = new Point(0, 0);
            this.SetBevel(false);

            this.ActiveMdiChild.Dock = DockStyle.Fill;
        }

        private void btnProdutos_Click(object sender, EventArgs e) {
            if (produtos == null || produtos.IsDisposed)
                produtos = new Produtos();
            btnProdutos.Selecionado = false; // Altera pra voltar a ser selecionado
            if (this.ActiveMdiChild != produtos) {
                this.ActivateMdiChild(produtos);
                if (this.ActiveMdiChild != null)
                    this.ActiveMdiChild.BringToFront();
            }


            produtos.MdiParent = this;
            produtos.Show();
            produtos.Location = new Point(0, 0);
            this.SetBevel(false);

            this.ActiveMdiChild.Dock = DockStyle.Fill;
        }

        private void btnDefinicoes_Click(object sender, EventArgs e) {
            if (configuracoes == null || configuracoes.IsDisposed)
                configuracoes = new Configuracoes();
            btnDefinicoes.Selecionado = false; // Altera pra voltar a ser selecionado
            if (this.ActiveMdiChild != configuracoes) {
                this.ActivateMdiChild(configuracoes);
                if (this.ActiveMdiChild != null)
                    this.ActiveMdiChild.BringToFront();
            }


            configuracoes.MdiParent = this;
            configuracoes.Show();
            configuracoes.Location = new Point(0, 0);
            this.SetBevel(false);

            this.ActiveMdiChild.Dock = DockStyle.Fill;
        }        
    }

    public static class MDIClientSupport {
        [DllImport("user32.dll")]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll", ExactSpelling = true)]
        private static extern int SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        private const int GWL_EXSTYLE = -20;
        private const int WS_EX_CLIENTEDGE = 0x200;
        private const uint SWP_NOSIZE = 0x0001;
        private const uint SWP_NOMOVE = 0x0002;
        private const uint SWP_NOZORDER = 0x0004;
        private const uint SWP_NOREDRAW = 0x0008;
        private const uint SWP_NOACTIVATE = 0x0010;
        private const uint SWP_FRAMECHANGED = 0x0020;
        private const uint SWP_SHOWWINDOW = 0x0040;
        private const uint SWP_HIDEWINDOW = 0x0080;
        private const uint SWP_NOCOPYBITS = 0x0100;
        private const uint SWP_NOOWNERZORDER = 0x0200;
        private const uint SWP_NOSENDCHANGING = 0x0400;

        public static bool SetBevel(this Form form, bool show) {
            foreach (Control c in form.Controls) {
                MdiClient client = c as MdiClient;
                if (client != null) {
                    int windowLong = GetWindowLong(c.Handle, GWL_EXSTYLE);

                    if (show) {
                        windowLong |= WS_EX_CLIENTEDGE;
                    } else {
                        windowLong &= ~WS_EX_CLIENTEDGE;
                    }

                    SetWindowLong(c.Handle, GWL_EXSTYLE, windowLong);

                    // Update the non-client area.
                    SetWindowPos(client.Handle, IntPtr.Zero, 0, 0, 0, 0,
                        SWP_NOACTIVATE | SWP_NOMOVE | SWP_NOSIZE | SWP_NOZORDER |
                        SWP_NOOWNERZORDER | SWP_FRAMECHANGED);

                    return true;
                }
            }
            return false;
        }

    }
}


