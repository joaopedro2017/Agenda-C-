using Agenda_C_Sharp.dao;
using Agenda_C_Sharp.model;
using System;
using System.Windows.Forms;

namespace Agenda_C_Sharp.GUI {
    public partial class FormUsuario : Form {

        private UsuarioDao dao;

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
                Usuario us = new Usuario {
                    login = txtLogin.Text,
                    nome = txtNome.Text,
                    senha = txtSenha.Text,
                    status = "A"
                };

                dao = new UsuarioDao();
                dao.Inserir(us);
                MessageBox.Show("Usuário salvo com Sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex) {
                MessageBox.Show("Erro ao salvar ao salvar Usuário!" + ex.Message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            gbManutencao.Enabled = true;
        }
    }
}
