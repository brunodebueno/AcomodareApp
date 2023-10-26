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
    public partial class Pets : Form
    {
        private bool editando = false;
        public Pets()
        {
            InitializeComponent();
        }

        private void Pets_Load(object sender, EventArgs e) {
            AtualizarGrid();
        }

        private void AtualizarGrid() {
            try {
                PetsBLL pets = new PetsBLL();
                if(String.IsNullOrEmpty(txtPesquisa.Text))
                    dataGridPet.DataSource = pets.Select();                
                else
                    dataGridPet.DataSource = pets.Select(txtPesquisa.Text);

            } catch (Exception ex) {
                MessageBox.Show("Erro ao carregar listagem. Erro:" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparFormulario() {
            foreach (Control c in tabFormulario.Controls) {
                if(c is TextBox) {
                    c.Text = "";
                }
            }
        }

        private void EditarGrid() {
            try {
                editando = true;
                tabControl.SelectTab(1); //Tab de Formulario

                int id = int.Parse(dataGridPet.CurrentRow.Cells[0].Value.ToString());
                if (id == 0)
                    return;

                PetsBLL pets = new PetsBLL();
                DbDataReader dr = pets.Select(id);
                if (dr.HasRows) {
                    while (dr.Read()) {
                        txtCodigo.Text = dr["Id"].ToString();
                        txtNome.Text = dr["Nome"].ToString();
                        txtProprietario.Text = dr["Proprietario"].ToString();
                        txtRaca.Text = dr["Raca"].ToString();
                        txtCor.Text = dr["Cor"].ToString();
                        txtPelagem.Text = dr["Pelagem"].ToString();
                        txtTamanho.Text = dr["Tamanho"].ToString();
                        txtObservacoes.Text = dr["Observacoes"].ToString();
                    }
                }              
            } catch (Exception ex) {
                MessageBox.Show("Erro ao carregar registro. Erro:" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            try {
                PetsBLL pets = new PetsBLL();
                if (editando)
                    pets.Update(int.Parse(txtCodigo.Text), txtNome.Text, txtRaca.Text, txtProprietario.Text, txtCor.Text,
                    txtPelagem.Text, txtTamanho.Text, txtObservacoes.Text);
                else
                    pets.Insert(txtNome.Text, txtRaca.Text, txtProprietario.Text, txtCor.Text,
                    txtPelagem.Text, txtTamanho.Text, txtObservacoes.Text);

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
            EditarGrid();
        }

        private void btnAdicionar_Click(object sender, EventArgs e) {
            tabControl.SelectTab(1); //Tab de Formulario
            LimparFormulario();
        }

        private void btnVoltar_Click(object sender, EventArgs e) {
            tabControl.SelectTab(0); //Volta pra listagem
        }

        private void btnFechar_Click(object sender, EventArgs e) {
            this.Dispose();
        }
        private void dataGridPet_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            EditarGrid();
        }
        private void btnPesquisar_Click(object sender, EventArgs e) {
            AtualizarGrid();
        }
    }
}
