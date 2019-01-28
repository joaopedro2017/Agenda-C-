namespace Agenda_C_Sharp.GUI {
    partial class FormTelefone {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTelefone));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbCadastrar = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSite = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxContato = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.gbPesquisar = new System.Windows.Forms.GroupBox();
            this.dgvContato = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxPesquisa = new System.Windows.Forms.ComboBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Tefefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Site = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idContato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbCadastrar.SuspendLayout();
            this.gbPesquisar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContato)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastro de Contato";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Preencha as informações corretamente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(503, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Selecione o contato desejado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(501, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "Pesquisar Contato";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::Agenda_C_Sharp.Properties.Resources.Male_user_search_icon;
            this.pictureBox2.Location = new System.Drawing.Point(415, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Agenda_C_Sharp.Properties.Resources.Male_user_edit_icon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gbCadastrar
            // 
            this.gbCadastrar.Controls.Add(this.label9);
            this.gbCadastrar.Controls.Add(this.cbxTipo);
            this.gbCadastrar.Controls.Add(this.label8);
            this.gbCadastrar.Controls.Add(this.txtSite);
            this.gbCadastrar.Controls.Add(this.label7);
            this.gbCadastrar.Controls.Add(this.txtTelefone);
            this.gbCadastrar.Controls.Add(this.label6);
            this.gbCadastrar.Controls.Add(this.txtEmail);
            this.gbCadastrar.Controls.Add(this.label5);
            this.gbCadastrar.Controls.Add(this.cbxContato);
            this.gbCadastrar.Controls.Add(this.btnSalvar);
            this.gbCadastrar.Location = new System.Drawing.Point(12, 98);
            this.gbCadastrar.Name = "gbCadastrar";
            this.gbCadastrar.Size = new System.Drawing.Size(391, 208);
            this.gbCadastrar.TabIndex = 6;
            this.gbCadastrar.TabStop = false;
            this.gbCadastrar.Text = "Cadastro:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Tipo:";
            // 
            // cbxTipo
            // 
            this.cbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Items.AddRange(new object[] {
            "Comercial",
            "Particular",
            "Residencial"});
            this.cbxTipo.Location = new System.Drawing.Point(73, 54);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(297, 21);
            this.cbxTipo.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "E-mail:";
            // 
            // txtSite
            // 
            this.txtSite.Location = new System.Drawing.Point(73, 133);
            this.txtSite.Name = "txtSite";
            this.txtSite.Size = new System.Drawing.Size(297, 20);
            this.txtSite.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Site:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(73, 81);
            this.txtTelefone.Mask = "(99)0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(297, 20);
            this.txtTelefone.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Telefone:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(73, 107);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(297, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Contato:";
            // 
            // cbxContato
            // 
            this.cbxContato.DisplayMember = "nome";
            this.cbxContato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxContato.FormattingEnabled = true;
            this.cbxContato.Location = new System.Drawing.Point(73, 27);
            this.cbxContato.Name = "cbxContato";
            this.cbxContato.Size = new System.Drawing.Size(297, 21);
            this.cbxContato.TabIndex = 0;
            this.cbxContato.ValueMember = "id";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(280, 170);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(90, 28);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Cadastrar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // gbPesquisar
            // 
            this.gbPesquisar.Controls.Add(this.dgvContato);
            this.gbPesquisar.Controls.Add(this.panel1);
            this.gbPesquisar.Location = new System.Drawing.Point(415, 98);
            this.gbPesquisar.Name = "gbPesquisar";
            this.gbPesquisar.Size = new System.Drawing.Size(436, 208);
            this.gbPesquisar.TabIndex = 7;
            this.gbPesquisar.TabStop = false;
            this.gbPesquisar.Text = "Pesquisar:";
            // 
            // dgvContato
            // 
            this.dgvContato.AllowUserToAddRows = false;
            this.dgvContato.AllowUserToDeleteRows = false;
            this.dgvContato.AllowUserToResizeColumns = false;
            this.dgvContato.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MintCream;
            this.dgvContato.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvContato.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvContato.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvContato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContato.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tefefone,
            this.Tipo,
            this.Email,
            this.Site,
            this.id,
            this.idContato});
            this.dgvContato.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContato.Location = new System.Drawing.Point(3, 56);
            this.dgvContato.Name = "dgvContato";
            this.dgvContato.ReadOnly = true;
            this.dgvContato.RowHeadersVisible = false;
            this.dgvContato.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContato.Size = new System.Drawing.Size(430, 149);
            this.dgvContato.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbxPesquisa);
            this.panel1.Controls.Add(this.btnPesquisar);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 40);
            this.panel1.TabIndex = 0;
            // 
            // cbxPesquisa
            // 
            this.cbxPesquisa.DisplayMember = "nome";
            this.cbxPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPesquisa.FormattingEnabled = true;
            this.cbxPesquisa.Location = new System.Drawing.Point(61, 11);
            this.cbxPesquisa.Name = "cbxPesquisa";
            this.cbxPesquisa.Size = new System.Drawing.Size(264, 21);
            this.cbxPesquisa.TabIndex = 6;
            this.cbxPesquisa.ValueMember = "id";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPesquisar.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Location = new System.Drawing.Point(331, 6);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(90, 28);
            this.btnPesquisar.TabIndex = 7;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Contato:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // Tefefone
            // 
            this.Tefefone.DataPropertyName = "telefone";
            this.Tefefone.HeaderText = "Telefone";
            this.Tefefone.Name = "Tefefone";
            this.Tefefone.ReadOnly = true;
            this.Tefefone.Width = 95;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Width = 85;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "email";
            this.Email.HeaderText = "E-mail";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 115;
            // 
            // Site
            // 
            this.Site.DataPropertyName = "site";
            this.Site.HeaderText = "Site";
            this.Site.Name = "Site";
            this.Site.ReadOnly = true;
            this.Site.Width = 115;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // idContato
            // 
            this.idContato.DataPropertyName = "id_contato";
            this.idContato.HeaderText = "idContato";
            this.idContato.Name = "idContato";
            this.idContato.ReadOnly = true;
            this.idContato.Visible = false;
            // 
            // FormTelefone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(862, 321);
            this.Controls.Add(this.gbPesquisar);
            this.Controls.Add(this.gbCadastrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormTelefone";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contatos";
            this.Load += new System.EventHandler(this.FormTelefone_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormTelefone_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbCadastrar.ResumeLayout(false);
            this.gbCadastrar.PerformLayout();
            this.gbPesquisar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContato)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox gbCadastrar;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxContato;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSite;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.GroupBox gbPesquisar;
        private System.Windows.Forms.DataGridView dgvContato;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxPesquisa;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tefefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Site;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn idContato;
    }
}