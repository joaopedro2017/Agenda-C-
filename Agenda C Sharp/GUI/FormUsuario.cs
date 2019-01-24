using Agenda_C_Sharp.dao;
using Agenda_C_Sharp.model;
using System;
using System.Windows.Forms;

namespace Agenda_C_Sharp.GUI {
    public partial class FormUsuario : Form {

        private UsuarioDao dao;
        private int IDRegistro = 0;
        private enum Tipo { insert, update, reload}
        private Tipo tipo;

        public FormUsuario() {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            errorProvider1.Clear();
            if (txtNome.Text == "") {
                errorProvider1.SetError(txtNome, "Preencha o campo nome.");
                return;
            }
            if (txtLogin.Text == "") {
                errorProvider1.SetError(txtLogin, "Preencha o campo login.");
                return;
            }
            if (txtSenha.Text == "") {
                errorProvider1.SetError(txtSenha, "Preencha o campo Senha.");
                return;
            }
            
            try {
                dao = new UsuarioDao();
                Usuario us = new Usuario {
                    login = txtLogin.Text,
                    nome = txtNome.Text,
                    senha = txtSenha.Text,
                    status = "A"
                };

                if(tipo == Tipo.update) {
                    us.id = IDRegistro;
                    dao.Alterar(us);
                    MessageBox.Show("Atualizado com Sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                
                dao.Inserir(us);
                MessageBox.Show("Usuário salvo com Sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex) {
                if(tipo == Tipo.update) {
                    MessageBox.Show("Erro ao atualizar Usuário!" + ex.Message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Erro ao salvar Usuário!" + ex.Message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSair_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Deseja sair?", "Fechamento!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
                Close();
        }

        private void btnAtualizar_Click(object sender, EventArgs e) {
            dao = new UsuarioDao();
            dgvDados.DataSource = dao.Consultar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e) {
            tipo = Tipo.insert;
            gbManutencao.Enabled = true;
        }

        private void btnAlterar_Click(object sender, EventArgs e) {
            tipo = Tipo.update;
            gbRegistros.Enabled = true;
            IDRegistro = Convert.ToInt32(dgvDados.CurrentRow.Cells[0].Value);
            txtLogin.Text = dgvDados.CurrentRow.Cells[2].Value.ToString();
            txtNome.Text = dgvDados.CurrentRow.Cells[1].Value.ToString();
            txtSenha.Text = dgvDados.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
