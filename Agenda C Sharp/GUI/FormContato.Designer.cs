namespace Agenda_C_Sharp.GUI {
    partial class FormContato {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContato));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbRegistros = new System.Windows.Forms.GroupBox();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbManutencao = new System.Windows.Forms.GroupBox();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbRegistros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.gbManutencao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbRegistros
            // 
            resources.ApplyResources(this.gbRegistros, "gbRegistros");
            this.gbRegistros.Controls.Add(this.dgvDados);
            this.errorProvider1.SetError(this.gbRegistros, resources.GetString("gbRegistros.Error"));
            this.errorProvider1.SetIconAlignment(this.gbRegistros, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("gbRegistros.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.gbRegistros, ((int)(resources.GetObject("gbRegistros.IconPadding"))));
            this.gbRegistros.Name = "gbRegistros";
            this.gbRegistros.TabStop = false;
            // 
            // dgvDados
            // 
            resources.ApplyResources(this.dgvDados, "dgvDados");
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.AllowUserToResizeColumns = false;
            this.dgvDados.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            this.dgvDados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDados.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome,
            this.Endereco,
            this.Bairro,
            this.Numero,
            this.Cep,
            this.Cidade,
            this.Estado,
            this.Status});
            this.errorProvider1.SetError(this.dgvDados, resources.GetString("dgvDados.Error"));
            this.errorProvider1.SetIconAlignment(this.dgvDados, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("dgvDados.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.dgvDados, ((int)(resources.GetObject("dgvDados.IconPadding"))));
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.RowHeadersVisible = false;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "id";
            resources.ApplyResources(this.Codigo, "Codigo");
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "nome";
            resources.ApplyResources(this.Nome, "Nome");
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Endereco
            // 
            this.Endereco.DataPropertyName = "endereco";
            resources.ApplyResources(this.Endereco, "Endereco");
            this.Endereco.Name = "Endereco";
            this.Endereco.ReadOnly = true;
            // 
            // Bairro
            // 
            this.Bairro.DataPropertyName = "bairro";
            resources.ApplyResources(this.Bairro, "Bairro");
            this.Bairro.Name = "Bairro";
            this.Bairro.ReadOnly = true;
            // 
            // Numero
            // 
            this.Numero.DataPropertyName = "numero";
            resources.ApplyResources(this.Numero, "Numero");
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            // 
            // Cep
            // 
            this.Cep.DataPropertyName = "cep";
            resources.ApplyResources(this.Cep, "Cep");
            this.Cep.Name = "Cep";
            this.Cep.ReadOnly = true;
            // 
            // Cidade
            // 
            this.Cidade.DataPropertyName = "cidade";
            resources.ApplyResources(this.Cidade, "Cidade");
            this.Cidade.Name = "Cidade";
            this.Cidade.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "estado";
            resources.ApplyResources(this.Estado, "Estado");
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "status";
            resources.ApplyResources(this.Status, "Status");
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // gbManutencao
            // 
            resources.ApplyResources(this.gbManutencao, "gbManutencao");
            this.gbManutencao.Controls.Add(this.txtCep);
            this.gbManutencao.Controls.Add(this.cbxEstado);
            this.gbManutencao.Controls.Add(this.txtBairro);
            this.gbManutencao.Controls.Add(this.txtEndereco);
            this.gbManutencao.Controls.Add(this.txtCidade);
            this.gbManutencao.Controls.Add(this.txtNumero);
            this.gbManutencao.Controls.Add(this.txtNome);
            this.gbManutencao.Controls.Add(this.label7);
            this.gbManutencao.Controls.Add(this.label6);
            this.gbManutencao.Controls.Add(this.label5);
            this.gbManutencao.Controls.Add(this.label4);
            this.gbManutencao.Controls.Add(this.label3);
            this.gbManutencao.Controls.Add(this.label2);
            this.gbManutencao.Controls.Add(this.label1);
            this.errorProvider1.SetError(this.gbManutencao, resources.GetString("gbManutencao.Error"));
            this.errorProvider1.SetIconAlignment(this.gbManutencao, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("gbManutencao.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.gbManutencao, ((int)(resources.GetObject("gbManutencao.IconPadding"))));
            this.gbManutencao.Name = "gbManutencao";
            this.gbManutencao.TabStop = false;
            // 
            // txtCep
            // 
            resources.ApplyResources(this.txtCep, "txtCep");
            this.errorProvider1.SetError(this.txtCep, resources.GetString("txtCep.Error"));
            this.errorProvider1.SetIconAlignment(this.txtCep, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtCep.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtCep, ((int)(resources.GetObject("txtCep.IconPadding"))));
            this.txtCep.Name = "txtCep";
            this.txtCep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // cbxEstado
            // 
            resources.ApplyResources(this.cbxEstado, "cbxEstado");
            this.cbxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.errorProvider1.SetError(this.cbxEstado, resources.GetString("cbxEstado.Error"));
            this.cbxEstado.FormattingEnabled = true;
            this.errorProvider1.SetIconAlignment(this.cbxEstado, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cbxEstado.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.cbxEstado, ((int)(resources.GetObject("cbxEstado.IconPadding"))));
            this.cbxEstado.Items.AddRange(new object[] {
            resources.GetString("cbxEstado.Items"),
            resources.GetString("cbxEstado.Items1"),
            resources.GetString("cbxEstado.Items2"),
            resources.GetString("cbxEstado.Items3"),
            resources.GetString("cbxEstado.Items4"),
            resources.GetString("cbxEstado.Items5"),
            resources.GetString("cbxEstado.Items6"),
            resources.GetString("cbxEstado.Items7"),
            resources.GetString("cbxEstado.Items8"),
            resources.GetString("cbxEstado.Items9"),
            resources.GetString("cbxEstado.Items10"),
            resources.GetString("cbxEstado.Items11"),
            resources.GetString("cbxEstado.Items12"),
            resources.GetString("cbxEstado.Items13"),
            resources.GetString("cbxEstado.Items14"),
            resources.GetString("cbxEstado.Items15"),
            resources.GetString("cbxEstado.Items16"),
            resources.GetString("cbxEstado.Items17"),
            resources.GetString("cbxEstado.Items18"),
            resources.GetString("cbxEstado.Items19"),
            resources.GetString("cbxEstado.Items20"),
            resources.GetString("cbxEstado.Items21"),
            resources.GetString("cbxEstado.Items22"),
            resources.GetString("cbxEstado.Items23"),
            resources.GetString("cbxEstado.Items24")});
            this.cbxEstado.Name = "cbxEstado";
            // 
            // txtBairro
            // 
            resources.ApplyResources(this.txtBairro, "txtBairro");
            this.errorProvider1.SetError(this.txtBairro, resources.GetString("txtBairro.Error"));
            this.errorProvider1.SetIconAlignment(this.txtBairro, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtBairro.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtBairro, ((int)(resources.GetObject("txtBairro.IconPadding"))));
            this.txtBairro.Name = "txtBairro";
            // 
            // txtEndereco
            // 
            resources.ApplyResources(this.txtEndereco, "txtEndereco");
            this.errorProvider1.SetError(this.txtEndereco, resources.GetString("txtEndereco.Error"));
            this.errorProvider1.SetIconAlignment(this.txtEndereco, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtEndereco.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtEndereco, ((int)(resources.GetObject("txtEndereco.IconPadding"))));
            this.txtEndereco.Name = "txtEndereco";
            // 
            // txtCidade
            // 
            resources.ApplyResources(this.txtCidade, "txtCidade");
            this.errorProvider1.SetError(this.txtCidade, resources.GetString("txtCidade.Error"));
            this.errorProvider1.SetIconAlignment(this.txtCidade, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtCidade.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtCidade, ((int)(resources.GetObject("txtCidade.IconPadding"))));
            this.txtCidade.Name = "txtCidade";
            // 
            // txtNumero
            // 
            resources.ApplyResources(this.txtNumero, "txtNumero");
            this.errorProvider1.SetError(this.txtNumero, resources.GetString("txtNumero.Error"));
            this.errorProvider1.SetIconAlignment(this.txtNumero, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtNumero.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtNumero, ((int)(resources.GetObject("txtNumero.IconPadding"))));
            this.txtNumero.Name = "txtNumero";
            // 
            // txtNome
            // 
            resources.ApplyResources(this.txtNome, "txtNome");
            this.errorProvider1.SetError(this.txtNome, resources.GetString("txtNome.Error"));
            this.errorProvider1.SetIconAlignment(this.txtNome, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtNome.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtNome, ((int)(resources.GetObject("txtNome.IconPadding"))));
            this.txtNome.Name = "txtNome";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.errorProvider1.SetError(this.label7, resources.GetString("label7.Error"));
            this.errorProvider1.SetIconAlignment(this.label7, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label7.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label7, ((int)(resources.GetObject("label7.IconPadding"))));
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.errorProvider1.SetError(this.label6, resources.GetString("label6.Error"));
            this.errorProvider1.SetIconAlignment(this.label6, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label6.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label6, ((int)(resources.GetObject("label6.IconPadding"))));
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.errorProvider1.SetError(this.label5, resources.GetString("label5.Error"));
            this.errorProvider1.SetIconAlignment(this.label5, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label5.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label5, ((int)(resources.GetObject("label5.IconPadding"))));
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.errorProvider1.SetError(this.label4, resources.GetString("label4.Error"));
            this.errorProvider1.SetIconAlignment(this.label4, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label4.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label4, ((int)(resources.GetObject("label4.IconPadding"))));
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.errorProvider1.SetError(this.label3, resources.GetString("label3.Error"));
            this.errorProvider1.SetIconAlignment(this.label3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label3.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label3, ((int)(resources.GetObject("label3.IconPadding"))));
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.errorProvider1.SetError(this.label2, resources.GetString("label2.Error"));
            this.errorProvider1.SetIconAlignment(this.label2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label2.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label2, ((int)(resources.GetObject("label2.IconPadding"))));
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.errorProvider1.SetError(this.label1, resources.GetString("label1.Error"));
            this.errorProvider1.SetIconAlignment(this.label1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label1, ((int)(resources.GetObject("label1.IconPadding"))));
            this.label1.Name = "label1";
            // 
            // btnCadastrar
            // 
            resources.ApplyResources(this.btnCadastrar, "btnCadastrar");
            this.errorProvider1.SetError(this.btnCadastrar, resources.GetString("btnCadastrar.Error"));
            this.errorProvider1.SetIconAlignment(this.btnCadastrar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnCadastrar.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.btnCadastrar, ((int)(resources.GetObject("btnCadastrar.IconPadding"))));
            this.btnCadastrar.Image = global::Agenda_C_Sharp.Properties.Resources.Accept_icon;
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnSalvar
            // 
            resources.ApplyResources(this.btnSalvar, "btnSalvar");
            this.errorProvider1.SetError(this.btnSalvar, resources.GetString("btnSalvar.Error"));
            this.errorProvider1.SetIconAlignment(this.btnSalvar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnSalvar.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.btnSalvar, ((int)(resources.GetObject("btnSalvar.IconPadding"))));
            this.btnSalvar.Image = global::Agenda_C_Sharp.Properties.Resources.Save_icon;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAlterar
            // 
            resources.ApplyResources(this.btnAlterar, "btnAlterar");
            this.errorProvider1.SetError(this.btnAlterar, resources.GetString("btnAlterar.Error"));
            this.errorProvider1.SetIconAlignment(this.btnAlterar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnAlterar.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.btnAlterar, ((int)(resources.GetObject("btnAlterar.IconPadding"))));
            this.btnAlterar.Image = global::Agenda_C_Sharp.Properties.Resources.Actions_document_edit_icon;
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            resources.ApplyResources(this.btnExcluir, "btnExcluir");
            this.errorProvider1.SetError(this.btnExcluir, resources.GetString("btnExcluir.Error"));
            this.errorProvider1.SetIconAlignment(this.btnExcluir, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnExcluir.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.btnExcluir, ((int)(resources.GetObject("btnExcluir.IconPadding"))));
            this.btnExcluir.Image = global::Agenda_C_Sharp.Properties.Resources.delete_file_icon;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            resources.ApplyResources(this.btnCancelar, "btnCancelar");
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.errorProvider1.SetError(this.btnCancelar, resources.GetString("btnCancelar.Error"));
            this.errorProvider1.SetIconAlignment(this.btnCancelar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnCancelar.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.btnCancelar, ((int)(resources.GetObject("btnCancelar.IconPadding"))));
            this.btnCancelar.Image = global::Agenda_C_Sharp.Properties.Resources.cancel_icon;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAtualizar
            // 
            resources.ApplyResources(this.btnAtualizar, "btnAtualizar");
            this.errorProvider1.SetError(this.btnAtualizar, resources.GetString("btnAtualizar.Error"));
            this.errorProvider1.SetIconAlignment(this.btnAtualizar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnAtualizar.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.btnAtualizar, ((int)(resources.GetObject("btnAtualizar.IconPadding"))));
            this.btnAtualizar.Image = global::Agenda_C_Sharp.Properties.Resources.Refresh_icon;
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnSair
            // 
            resources.ApplyResources(this.btnSair, "btnSair");
            this.errorProvider1.SetError(this.btnSair, resources.GetString("btnSair.Error"));
            this.errorProvider1.SetIconAlignment(this.btnSair, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnSair.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.btnSair, ((int)(resources.GetObject("btnSair.IconPadding"))));
            this.btnSair.Image = global::Agenda_C_Sharp.Properties.Resources.Close_2_icon1;
            this.btnSair.Name = "btnSair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            resources.ApplyResources(this.errorProvider1, "errorProvider1");
            // 
            // FormContato
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.gbManutencao);
            this.Controls.Add(this.gbRegistros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormContato";
            this.gbRegistros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.gbManutencao.ResumeLayout(false);
            this.gbManutencao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRegistros;
        private System.Windows.Forms.GroupBox gbManutencao;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cep;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}