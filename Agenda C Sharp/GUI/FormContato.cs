using Agenda_C_Sharp.dao;
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
    }
}
