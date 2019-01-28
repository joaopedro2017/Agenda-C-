using Agenda_C_Sharp.dao;
using Agenda_C_Sharp.model;
using Agenda_C_Sharp.Helper;
using System;
using System.Windows.Forms;

namespace Agenda_C_Sharp.GUI {
    public partial class FormTelefone : Form {
        public FormTelefone() {
            InitializeComponent();
        }

        private void FormTelefone_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void FormTelefone_Load(object sender, System.EventArgs e) {
            ContatoDao dao = new ContatoDao();
            cbxContato.DataSource = dao.Consultar();
            cbxPesquisa.DataSource = dao.Consultar();
            cbxTipo.SelectedIndex = 0;
        }

        private void btnSalvar_Click(object sender, System.EventArgs e) {
            errorProvider1.SetError(txtTelefone, "");
            if (txtTelefone.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace("_", "").Trim().Length < 10) {
                errorProvider1.SetError(txtTelefone, "Telefone inválido!");
                return;
            }

            if (!string.IsNullOrEmpty(txtEmail.Text) && !Funcoes.validarEmail(txtEmail, errorProvider1))
                return;
            if (!string.IsNullOrEmpty(txtSite.Text) && !Funcoes.validarURL(txtSite, errorProvider1))
                return;
            try {
                TelefoneDao dao = new TelefoneDao();
                Telefone telefone = new Telefone() {
                    email = txtEmail.Text.Trim(),
                    id_contato = Convert.ToInt32(cbxContato.SelectedValue),
                    site = txtSite.Text.Trim(),
                    telefone = txtTelefone.Text,
                    tipo = cbxTipo.Text
                };
                dao.Inserir(telefone);
                limpar();
                MessageBox.Show("Telefone cadastrado com Sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex) {
                MessageBox.Show("Erro ao cadastrar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void limpar() {
            foreach (var item in gbCadastrar.Controls) {
                if (item is TextBox)
                    (item as TextBox).Text = string.Empty;
                if (item is MaskedTextBox)
                    (item as MaskedTextBox).Text = string.Empty;
            }
            cbxContato.SelectedIndex = 0;
            cbxTipo.SelectedIndex = 0;
            cbxContato.Focus();
        }
    }
}
