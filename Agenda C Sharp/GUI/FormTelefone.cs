using Agenda_C_Sharp.dao;
using Agenda_C_Sharp.model;
using System.Collections.Generic;
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
        }
    }
}
