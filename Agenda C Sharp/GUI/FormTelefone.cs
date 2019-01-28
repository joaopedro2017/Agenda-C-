﻿using Agenda_C_Sharp.dao;
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
            cbxTipo.SelectedIndex = 0;
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
