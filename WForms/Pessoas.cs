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
    public partial class Pessoas : Form
    {
        private bool editando = false;
        public Pessoas()
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
                PessoasBLL pessoa = new PessoasBLL();
                if(String.IsNullOrEmpty(txtPesquisa.Text))
                    dataGridPet.DataSource = pessoa.Select();                
                else
                    dataGridPet.DataSource = pessoa.Select(txtPesquisa.Text);

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

                int id = int.Parse(dataGridPet.CurrentRow.Cells[0].Value.ToString());
                if (id == 0)
                    return;

                PessoasBLL pessoa = new PessoasBLL();
                DbDataReader dr = pessoa.Select(id);
                if (dr.HasRows) {
                    while (dr.Read()) {
                        txtCodigo.Text = dr["Id"].ToString();
                        txtNome.Text = dr["Nome"].ToString();
                        txtCPF.Text = dr["cpf"].ToString();
                        txtGenero.Text = dr["genero"].ToString();
                        dtpNascimento.Text = dr["dataNascimento"].ToString();
                        txtEndereco.Text = dr["endereco"].ToString();
                        mskTelefone.Text = dr["telefone"].ToString();
                        txtBairro.Text = dr["bairro"].ToString();
                        txtCidade.Text = dr["cidade"].ToString();
                        mskCEP.Text = dr["cep"].ToString();
                        txtUF.Text = dr["uf"].ToString();
                    }
                }             
            } catch (Exception ex) {
                MessageBox.Show("Erro ao carregar registro. Erro:" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Excluir() {
            try {
                int id = int.Parse(dataGridPet.CurrentRow.Cells[0].Value.ToString());
                if (id == 0) {                    
                    MessageBox.Show("Selecione um registro para efetuar a exclusão", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                PessoasBLL pessoa = new PessoasBLL();
                pessoa.Delete(id);

                AtualizarGrid();

                MessageBox.Show("Registro excluido com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex) {
                MessageBox.Show("Erro ao excluir registro. Erro:" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            try {
                PessoasBLL pessoa = new PessoasBLL();
                if (editando)
                    pessoa.Update(int.Parse(txtCodigo.Text), txtNome.Text, txtCPF.Text, txtGenero.Text, dtpNascimento.Value.Date,
                        txtEndereco.Text, mskTelefone.Text, txtBairro.Text, txtCidade.Text, mskCEP.Text, txtUF.Text);
                else
                    pessoa.Insert(txtNome.Text, txtCPF.Text, txtGenero.Text, dtpNascimento.Value.Date,
                    txtEndereco.Text, mskTelefone.Text, txtBairro.Text, txtCidade.Text, mskCEP.Text, txtUF.Text);

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
            ((MDIPrincipal)this.MdiParent).FechouPessoas();
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

        private void label6_Click(object sender, EventArgs e) {

        }
    }
}
