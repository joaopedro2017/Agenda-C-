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
            Usuario us = new Usuario();
            us.login = txtLogin.Text;
            us.nome = txtNome.Text;
            us.senha = txtSenha.Text;
            us.status = "A";

            dao = new UsuarioDao();
            dao.Inserir(us);
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
    }
}
