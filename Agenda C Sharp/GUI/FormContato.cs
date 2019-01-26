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

        private void habilitarDesabilitarBotoes() {
            btnSalvar.Enabled = tipo == Tipo.insert || tipo == Tipo.update;
            btnAlterar.Enabled = dgvDados.Rows.Count > 0 && (tipo == Tipo.update || tipo == Tipo.insert);
            btnExcluir.Enabled = dgvDados.Rows.Count > 0 && (tipo == Tipo.update || tipo == Tipo.insert);
            btnCadastrar.Enabled = tipo == Tipo.reload;
        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            try {
                Contato cont = new Contato {
                    nome = txtNome.Text,
                    endereco = txtEndereco.Text,
                    bairro = txtBairro.Text,
                    numero = txtNumero.Text,
                    cep = txtCep.Text,
                    cidade = txtCidade.Text,
                    estado = cmEstado.Text,
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
    }
}
