using Agenda_C_Sharp.dao;
using Agenda_C_Sharp.model;
using System;
using System.Windows.Forms;

namespace Agenda_C_Sharp.GUI {
    public partial class FormContato : Form {

        private ContatoDao dao;
        private int IDRegistro = 0;
        private enum Tipo { insert, update, reload }
        private Tipo tipo;

        public FormContato() {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e) {
            gbManutencao.Enabled = true;
            tipo = Tipo.insert;
            habilitarDesabilitarBotoes();
            txtNome.Focus();
        }        

        private void btnSalvar_Click(object sender, EventArgs e) {
            if (ValidarCampos() == "ERRO") {
                return;
            }
            try {
                Contato cont = new Contato {
                    nome = txtNome.Text,
                    endereco = txtEndereco.Text,
                    bairro = txtBairro.Text,
                    numero = txtNumero.Text,
                    cep = txtCep.Text,
                    cidade = txtCidade.Text,
                    estado = cbmEstado.Text,
                    status = "A"
                };
                dao = new ContatoDao();
                if (tipo == Tipo.update) {
                    cont.id = IDRegistro;
                    dao.Alterar(cont);
                    MessageBox.Show("Atualizado com Sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                dao.Inserir(cont);
                MessageBox.Show("Contato salvo com Sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex) {
                if (tipo == Tipo.update) {
                    MessageBox.Show("Erro ao atualizar contato!" + ex.Message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Erro ao salvar Contato!" + ex.Message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e) {
            tipo = Tipo.update;
            gbRegistros.Enabled = true;
            IDRegistro = Convert.ToInt32(dgvDados.CurrentRow.Cells[0].Value);
            txtNome.Text = dgvDados.CurrentRow.Cells[1].Value.ToString();
            txtEndereco.Text = dgvDados.CurrentRow.Cells[2].Value.ToString();
            txtBairro.Text = dgvDados.CurrentRow.Cells[3].Value.ToString();
            txtNumero.Text = dgvDados.CurrentRow.Cells[4].Value.ToString();
            txtCep.Text = dgvDados.CurrentRow.Cells[5].Value.ToString();
            txtCidade.Text = dgvDados.CurrentRow.Cells[6].Value.ToString();
            cbmEstado.Text = dgvDados.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnAtualizar_Click(object sender, EventArgs e) {
            CarregarRegistros();
            tipo = Tipo.update;
            habilitarDesabilitarBotoes();
            if (dgvDados.Rows.Count > 0)
                gbManutencao.Enabled = true;
        }

        private void habilitarDesabilitarBotoes() {
            btnSalvar.Enabled = tipo == Tipo.insert || tipo == Tipo.update;
            btnAlterar.Enabled = dgvDados.Rows.Count > 0 && (tipo == Tipo.update || tipo == Tipo.insert);
            btnExcluir.Enabled = dgvDados.Rows.Count > 0 && (tipo == Tipo.update || tipo == Tipo.insert);
            btnCadastrar.Enabled = tipo == Tipo.reload;
        }

        private void CarregarRegistros() {
            if (dao == null) {
                dao = new ContatoDao();
            }
            dgvDados.DataSource = dao.Consultar();
        }

        private String ValidarCampos() {
            errorProvider1.Clear();
            if (txtNome.Text == "") {
                errorProvider1.SetError(txtNome, "Preencha o campo nome.");
                return "ERRO";
            }
            if (txtEndereco.Text == "") {
                errorProvider1.SetError(txtEndereco, "Preencha o campo Endereco.");
                return "ERRO";
            }
            if (txtNumero.Text == "") {
                errorProvider1.SetError(txtNumero, "Preencha o campo Numero.");
                return "ERRO";
            }
            if (txtBairro.Text == "") {
                errorProvider1.SetError(txtBairro, "Preencha o campo Bairro.");
                return "ERRO";
            }
            if (txtCidade.Text == "") {
                errorProvider1.SetError(txtCidade, "Preencha o campo Cidade.");
                return "ERRO";
            }
            if (txtCep.Text == "") {
                errorProvider1.SetError(txtCep, "Preencha o campo Cep.");
                return "ERRO";
            }
            if (cbmEstado.Text == "") {
                errorProvider1.SetError(cbmEstado, "Selecione o estado.");
                return "ERRO";
            }
            return "CERTO";
        }
    }
}
