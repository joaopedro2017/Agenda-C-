using Agenda_C_Sharp.dao;
using Agenda_C_Sharp.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Agenda_C_Sharp.GUI {
    public partial class FormUsuario : Form {

        private UsuarioDao dao;
        private int IDRegistro = 0;
        private enum Tipo { insert, update, reload }
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

            dao = new UsuarioDao();
            if (tipo == Tipo.insert) {
                if (dao.validarLogin(txtLogin.Text.Trim())) {
                    MessageBox.Show("Login encontra-se cadastrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            try {
                Usuario us = new Usuario {
                    login = txtLogin.Text,
                    nome = txtNome.Text,
                    senha = txtSenha.Text,
                    status = "A"
                };

                if (tipo == Tipo.update) {
                    us.id = IDRegistro;
                    dao.Alterar(us);
                    MessageBox.Show("Atualizado com Sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                dao.Inserir(us);
                MessageBox.Show("Usuário salvo com Sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex) {
                if (tipo == Tipo.update) {
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
            CarregarRegistros();
            tipo = Tipo.update;
            habilitarDesabilitarBotoes();
            if (dgvDados.Rows.Count > 0)
                gbManutencao.Enabled = true;
        }

        private void btnCadastrar_Click(object sender, EventArgs e) {
            gbManutencao.Enabled = true;
            tipo = Tipo.insert;
            habilitarDesabilitarBotoes();
            txtNome.Focus();
        }

        private void btnAlterar_Click(object sender, EventArgs e) {
            tipo = Tipo.update;
            gbRegistros.Enabled = true;
            IDRegistro = Convert.ToInt32(dgvDados.CurrentRow.Cells[0].Value);
            txtLogin.Text = dgvDados.CurrentRow.Cells[2].Value.ToString();
            txtNome.Text = dgvDados.CurrentRow.Cells[1].Value.ToString();
            txtSenha.Text = dgvDados.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnExcluir_Click(object sender, EventArgs e) {
            int qntLinhas = dgvDados.RowCount;
            if (qntLinhas > 0) {
                try {
                    dao = new UsuarioDao();
                    Usuario us = dao.retornaPorId(Convert.ToInt32(dgvDados.CurrentRow.Cells[0].Value));
                    dao.Excluir(us);
                    MessageBox.Show("Registro excluido com Sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnAtualizar_Click(sender, e);
                    if (qntLinhas == 1)
                        btnCancelar_Click(sender, e);
                } catch (Exception ex) {
                    MessageBox.Show("Erro ao excluir" + ex.Message, "Excluir",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            tipo = Tipo.reload;
            limpar();
            dgvDados.DataSource = String.Empty;
            gbManutencao.Enabled = false;
            habilitarDesabilitarBotoes();
        }

        private void habilitarDesabilitarBotoes() {
            btnSalvar.Enabled = tipo == Tipo.insert || tipo == Tipo.update;
            btnAlterar.Enabled = dgvDados.Rows.Count > 0 && (tipo == Tipo.update || tipo == Tipo.insert);
            btnExcluir.Enabled = dgvDados.Rows.Count > 0 && (tipo == Tipo.update || tipo == Tipo.insert);
            btnCadastrar.Enabled = tipo == Tipo.reload;
        }

        private void CarregarRegistros() {
            if (dao == null) {
                dao = new UsuarioDao();
            }

            if (rbSemOrdem.Checked) {
                dgvDados.DataSource = dao.Consultar();
                return;
            }
            if (rbNome.Checked) {
                dgvDados.DataSource = dao.ordernarPorNome();
                return;
            }
            if (rbLogin.Checked) {
                dgvDados.DataSource = dao.ordernarPorLogin();
                return;
            }
        }

        public void limpar() {
            txtLogin.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtSenha.Text = string.Empty;
            IDRegistro = 0;
            txtNome.Focus();
        }
    }
}
