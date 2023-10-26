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
    public partial class Produtos : Form
    {
        private bool editando = false;
        public Produtos()
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
                ProdutosBLL produto = new ProdutosBLL();
                if(String.IsNullOrEmpty(txtPesquisa.Text))
                    dataGrid.DataSource = produto.Select();                
                else
                    dataGrid.DataSource = produto.Select(txtPesquisa.Text);

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

                ProdutosBLL pessoa = new ProdutosBLL();
                DbDataReader dr = pessoa.Select(id);
                if (dr.HasRows) {
                    while (dr.Read()) {
                        txtCodigo.Text = dr["Id"].ToString();
                        txtDescricao.Text = dr["Descricao"].ToString();
                        txtTipoUn.Text = dr["TipoUn"].ToString();
                        txtCodigoEAN.Text = dr["CodigoEAN"].ToString();
                        txtPreco.Text = dr["preco"].ToString();
                        txtQuantidade.Text = dr["quantidade"].ToString();
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

                ProdutosBLL pessoa = new ProdutosBLL();
                pessoa.Delete(id);

                AtualizarGrid();

                MessageBox.Show("Registro excluido com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex) {
                MessageBox.Show("Erro ao excluir registro. Erro:" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            try {
                ProdutosBLL produto = new ProdutosBLL();
                if (editando)
                    produto.Update(int.Parse(txtCodigo.Text), txtDescricao.Text, txtTipoUn.Text, txtCodigoEAN.Text, txtPreco.Text, txtQuantidade.Text);
                else
                    produto.Insert(txtDescricao.Text,txtTipoUn.Text,txtCodigoEAN.Text,txtPreco.Text,txtQuantidade.Text);

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
            ((MDIPrincipal)this.MdiParent).FechouProdutos();
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

        private void txtPreco_KeyPress(object sender, KeyPressEventArgs e) {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',')
                e.Handled = true;
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',')
                e.Handled = true;
        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e) {

        }
    }
}
