using Agenda_C_Sharp.dao;
using Agenda_C_Sharp.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda_C_Sharp.GUI {
    public partial class FormUsuario : Form {
        public FormUsuario() {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            Usuario us = new Usuario();
            us.login = txtLogin.Text;
            us.nome = txtNome.Text;
            us.senha = txtSenha.Text;
            us.status = "A";

            UsuarioDao dao = new UsuarioDao();
            dao.Inserir(us);
        }

        private void btnSair_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Deseja sair?", "Fechamento!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
                Close();
        }
    }
}
