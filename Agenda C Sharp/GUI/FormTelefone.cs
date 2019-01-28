using Agenda_C_Sharp.dao;
using Agenda_C_Sharp.model;
using System;
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

        private void btnSalvar_Click(object sender, System.EventArgs e) {
            TelefoneDao dao = new TelefoneDao();
            try {                
                Telefone telefone = new Telefone() {                    
                    email = txtEmail.Text.Trim(),
                    id_contato = Convert.ToInt32(cbxContato.SelectedValue),
                    site = txtSite.Text.Trim(),
                    telefone = txtTelefone.Text,
                    tipo = cbxTipo.Text
                };
                dao.Inserir(telefone);
                MessageBox.Show("Telefone cadastrado com Sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex) {
                MessageBox.Show("Erro ao cadastrar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
