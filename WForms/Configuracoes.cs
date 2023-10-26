using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WForms
{
    public partial class Configuracoes : Form
    {
        private bool editando = false;
        public Configuracoes()
        {
            InitializeComponent();
        }

        private void Pets_Load(object sender, EventArgs e) {
            AtualizarGrid();

            //Oculta as tabs para o usuario
            tabControl.Appearance = TabAppearance.FlatButtons;
            tabControl.ItemSize = new Size(0, 1);
            tabControl.SizeMode = TabSizeMode.Fixed;
        }

        private void AtualizarGrid() {
            try {
                UsuarioBLL usuario = new UsuarioBLL();
                if(String.IsNullOrEmpty(txtPesquisa.Text))
                    dataGrid.DataSource = usuario.Select();                
                else
                    dataGrid.DataSource = usuario.Select(txtPesquisa.Text);

            } catch (Exception ex) {
                MessageBox.Show("Erro ao carregar listagem. Erro:" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparFormulario() {
            foreach (Control c in tabFormulario.Controls) {
                if(c is TextBox || c is MaskedTextBox || c is DateTimePicker) {
                    c.Text = "";
                }
            }
        }

        private void Editar() {
            try {
                editando = true;
                tabControl.SelectTab(1); //Tab de Formulario

                int id = int.Parse(dataGrid.CurrentRow.Cells[0].Value.ToString());
                if (id == 0)
                    return;

                UsuarioBLL pessoa = new UsuarioBLL();
                DbDataReader dr = pessoa.Select(id);
                if (dr.HasRows) {
                    while (dr.Read()) {
                        txtCodigo.Text = dr["Id"].ToString();
                        txtLogin.Text = dr["login"].ToString();
                        txtSenha.Text = dr["senha"].ToString();
                    }
                }             
            } catch (Exception ex) {
                MessageBox.Show("Erro ao carregar registro. Erro:" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Excluir() {
            try {
                int id = int.Parse(dataGrid.CurrentRow.Cells[0].Value.ToString());
                if (id == 0) {                    
                    MessageBox.Show("Selecione um registro para efetuar a exclusão", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                UsuarioBLL usuario = new UsuarioBLL();
                usuario.Delete(id);

                AtualizarGrid();

                MessageBox.Show("Registro excluido com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex) {
                MessageBox.Show("Erro ao excluir registro. Erro:" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            try {
                UsuarioBLL usuario = new UsuarioBLL();
                if (editando)
                    usuario.Update(int.Parse(txtCodigo.Text), txtLogin.Text, txtSenha.Text);
                else
                    usuario.Insert(txtLogin.Text,txtSenha.Text);

                MessageBox.Show("Salvo com sucesso", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                AtualizarGrid();
            } catch(Exception ex) {
                MessageBox.Show("Erro ao Salvar. Erro:" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            tabControl.SelectTab(0); //Volta pra listagem
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e) {
            if (tabControl.SelectedIndex == 1) {
                txtCodigo.Enabled = false;
                if(editando)
                    LimparFormulario();
            } else if (tabControl.SelectedIndex == 0) {
                editando = false;                
            }
        }

        private void btnEditar_Click(object sender, EventArgs e) {
            Editar();
        }

        private void btnAdicionar_Click(object sender, EventArgs e) {
            tabControl.SelectTab(1); //Tab de Formulario
            LimparFormulario();
        }

        private void btnVoltar_Click(object sender, EventArgs e) {
            tabControl.SelectTab(0); //Volta pra listagem
        }

        private void btnFechar_Click(object sender, EventArgs e) {
            ((MDIPrincipal)this.MdiParent).FechouConfiguracoes();
            this.Dispose();
        }
        private void dataGridPet_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            Editar();
        }
        private void btnPesquisar_Click(object sender, EventArgs e) {
            AtualizarGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e) {
            Excluir();
        }
    }
}
