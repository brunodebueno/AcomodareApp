using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WForms.Forms.ControlesCustom {
    public partial class BotaoNavLateral : UserControl {

        private readonly Color corOriginalBotao = Color.FromArgb(235, 235, 235);
        private readonly Color corFocoBotao = Color.FromArgb(245, 245, 245);
        private readonly Color corSelecaoBotao = Color.FromArgb(255, 255, 255);

        private readonly Color corTextoSelecao = Color.FromArgb(1, 111, 214);
        private readonly Color corTextoNormal = Color.FromArgb(97, 97, 97);


        private bool foco = false;


        private bool selecionado = false;
        private string texto;
        private Image icone;
        private Image iconeSelecionado;

        [
        System.ComponentModel.Browsable(true),
        Category("Propriedades Custom"),
        Description("Icone padrão")
        ]
        public Image Icone {
            get { return icone; }
            set { icone = value; imgIcone.Image = icone; }            
        }

        [
        System.ComponentModel.Browsable(true),
        Category("Propriedades Custom"),
        Description("Icone quando controle selecionado")
        ]
        public Image IconeSelecionado {
            get { return iconeSelecionado; }
            set {iconeSelecionado = value; }
        }

        [
        System.ComponentModel.Browsable(true),
        Category("Propriedades Custom"),
        Description("Texto")
        ]
        public string Texto {
            get { return texto; }
            set { texto = value; lblTexto.Text = texto; }
        }

        public bool Selecionado {
            get { return selecionado; }
            set { selecionado = value;}
        }

        public BotaoNavLateral() {
            InitializeComponent();
        }

        private void BotaoNavLateral_Load(object sender, EventArgs e) {
            pnlNavegacao.Hide();
            // Todos Controles terem o mesmo tratamento

            this.Click += new EventHandler(CustomButtonClick);
            this.MouseEnter += new EventHandler(CustomMouseEnter);
            this.MouseLeave += new EventHandler(CustomMouseLeave);

            foreach (Control c in this.Controls) {
                c.Click += new EventHandler(CustomButtonClick);
                c.MouseEnter += new EventHandler(CustomMouseEnter);
                c.MouseLeave += new EventHandler(CustomMouseLeave);
            }
        }

        private void CustomButtonClick(object sender, EventArgs e) {
            if (Selecionado) {
                Selecionado = false;
                Console.WriteLine("Selecionado: false");
            } else {
                Selecionado = true;
                Console.WriteLine("Selecionado: true");
            }
        }

        private void CustomMouseEnter(object sender, EventArgs e) {
            if (foco)
            {
                pnlNavegacao.Hide();
                this.BackColor = corOriginalBotao;
                foco = false;
            }
            else
            {
                pnlNavegacao.Show();                
                foco = true;
                // img Selecao
                imgIcone.Image = iconeSelecionado;
                lblTexto.ForeColor = corTextoSelecao;
                if (Selecionado)
                {
                    this.BackColor = corSelecaoBotao;
                }
                else
                {
                    this.BackColor = corFocoBotao;
                }
            }
            this.Invalidate();
        }

        private void CustomMouseLeave(object sender, EventArgs e)
        {
            foco = false;
            if (Selecionado) {
                pnlNavegacao.Show();
                this.BackColor = corFocoBotao;

                // img Selecao
                imgIcone.Image = iconeSelecionado;
                lblTexto.ForeColor = corTextoSelecao;
            }
            else {
                pnlNavegacao.Hide();
                this.BackColor = corOriginalBotao;
                // img normal
                imgIcone.Image = icone;
                lblTexto.ForeColor = corTextoNormal;
            }
            this.Invalidate();
        }
    }
}
