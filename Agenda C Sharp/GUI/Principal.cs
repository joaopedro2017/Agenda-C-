using System;
using System.Windows.Forms;

namespace Agenda_C_Sharp.GUI {
    public partial class Principal : Form {
        public Principal() {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e) {
            lblData.Text = "Data: " + DateTime.Now.ToShortDateString();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            lblHora.Text = "Hora: " + DateTime.Now.ToLongTimeString();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e) {
            FormUsuario form = new FormUsuario();
            form.ShowDialog();
        }

        private void contatoToolStripMenuItem_Click(object sender, EventArgs e) {
            FormContato form = new FormContato();
            form.ShowDialog();
        }

        private void telefoneToolStripMenuItem_Click(object sender, EventArgs e) {
            FormTelefone form = new FormTelefone();
            form.ShowDialog();
        }
    }
}
