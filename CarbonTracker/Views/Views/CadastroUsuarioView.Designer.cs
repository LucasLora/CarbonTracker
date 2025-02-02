﻿namespace CarbonTracker.Views
{
    partial class CadastroUsuarioView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbcUsuarios = new System.Windows.Forms.TabControl();
            this.tbpListagem = new System.Windows.Forms.TabPage();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoUsuarioDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataCriacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtProcurar = new System.Windows.Forms.TextBox();
            this.lblProcurar = new System.Windows.Forms.Label();
            this.tbpDetalhes = new System.Windows.Forms.TabPage();
            this.lblDataCriacao = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.cmbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtDataCriacao = new System.Windows.Forms.TextBox();
            this.tbcUsuarios.SuspendLayout();
            this.tbpListagem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.tbpDetalhes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcUsuarios
            // 
            this.tbcUsuarios.Controls.Add(this.tbpListagem);
            this.tbcUsuarios.Controls.Add(this.tbpDetalhes);
            this.tbcUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcUsuarios.Location = new System.Drawing.Point(0, 0);
            this.tbcUsuarios.Name = "tbcUsuarios";
            this.tbcUsuarios.SelectedIndex = 0;
            this.tbcUsuarios.Size = new System.Drawing.Size(800, 450);
            this.tbcUsuarios.TabIndex = 0;
            // 
            // tbpListagem
            // 
            this.tbpListagem.Controls.Add(this.btnExcluir);
            this.tbpListagem.Controls.Add(this.btnAlterar);
            this.tbpListagem.Controls.Add(this.btnProcurar);
            this.tbpListagem.Controls.Add(this.btnAdicionar);
            this.tbpListagem.Controls.Add(this.dgvUsuarios);
            this.tbpListagem.Controls.Add(this.txtProcurar);
            this.tbpListagem.Controls.Add(this.lblProcurar);
            this.tbpListagem.Location = new System.Drawing.Point(4, 22);
            this.tbpListagem.Name = "tbpListagem";
            this.tbpListagem.Padding = new System.Windows.Forms.Padding(3);
            this.tbpListagem.Size = new System.Drawing.Size(792, 424);
            this.tbpListagem.TabIndex = 0;
            this.tbpListagem.Text = "Listagem";
            this.tbpListagem.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.Location = new System.Drawing.Point(688, 110);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 23);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlterar.Location = new System.Drawing.Point(688, 81);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(100, 23);
            this.btnAlterar.TabIndex = 5;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnProcurar
            // 
            this.btnProcurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcurar.Location = new System.Drawing.Point(583, 24);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(100, 23);
            this.btnProcurar.TabIndex = 2;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionar.Location = new System.Drawing.Point(688, 52);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(100, 23);
            this.btnAdicionar.TabIndex = 4;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToResizeRows = false;
            this.dgvUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.Email,
            this.TipoUsuarioDescription,
            this.DataCriacao});
            this.dgvUsuarios.Location = new System.Drawing.Point(7, 52);
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(676, 367);
            this.dgvUsuarios.TabIndex = 3;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Usuário";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 80;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.MinimumWidth = 6;
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 170;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "E-mail";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 200;
            // 
            // TipoUsuarioDescription
            // 
            this.TipoUsuarioDescription.DataPropertyName = "TipoUsuarioDescription";
            this.TipoUsuarioDescription.HeaderText = "Tipo Usuário";
            this.TipoUsuarioDescription.MinimumWidth = 6;
            this.TipoUsuarioDescription.Name = "TipoUsuarioDescription";
            this.TipoUsuarioDescription.ReadOnly = true;
            this.TipoUsuarioDescription.Width = 125;
            // 
            // DataCriacao
            // 
            this.DataCriacao.DataPropertyName = "DataCriacao";
            this.DataCriacao.HeaderText = "Data Criação";
            this.DataCriacao.MinimumWidth = 6;
            this.DataCriacao.Name = "DataCriacao";
            this.DataCriacao.ReadOnly = true;
            this.DataCriacao.Width = 125;
            // 
            // txtProcurar
            // 
            this.txtProcurar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProcurar.Location = new System.Drawing.Point(7, 26);
            this.txtProcurar.Name = "txtProcurar";
            this.txtProcurar.Size = new System.Drawing.Size(571, 20);
            this.txtProcurar.TabIndex = 1;
            // 
            // lblProcurar
            // 
            this.lblProcurar.AutoSize = true;
            this.lblProcurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcurar.Location = new System.Drawing.Point(3, 3);
            this.lblProcurar.Name = "lblProcurar";
            this.lblProcurar.Size = new System.Drawing.Size(73, 20);
            this.lblProcurar.TabIndex = 0;
            this.lblProcurar.Text = "Procurar:";
            // 
            // tbpDetalhes
            // 
            this.tbpDetalhes.Controls.Add(this.lblDataCriacao);
            this.tbpDetalhes.Controls.Add(this.btnCancelar);
            this.tbpDetalhes.Controls.Add(this.btnSalvar);
            this.tbpDetalhes.Controls.Add(this.txtSenha);
            this.tbpDetalhes.Controls.Add(this.lblSenha);
            this.tbpDetalhes.Controls.Add(this.cmbTipoUsuario);
            this.tbpDetalhes.Controls.Add(this.lblTipoUsuario);
            this.tbpDetalhes.Controls.Add(this.txtEmail);
            this.tbpDetalhes.Controls.Add(this.lblEmail);
            this.tbpDetalhes.Controls.Add(this.txtNome);
            this.tbpDetalhes.Controls.Add(this.lblNome);
            this.tbpDetalhes.Controls.Add(this.txtId);
            this.tbpDetalhes.Controls.Add(this.lblId);
            this.tbpDetalhes.Controls.Add(this.txtDataCriacao);
            this.tbpDetalhes.Location = new System.Drawing.Point(4, 22);
            this.tbpDetalhes.Name = "tbpDetalhes";
            this.tbpDetalhes.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDetalhes.Size = new System.Drawing.Size(792, 424);
            this.tbpDetalhes.TabIndex = 1;
            this.tbpDetalhes.Text = "Detalhes";
            this.tbpDetalhes.UseVisualStyleBackColor = true;
            // 
            // lblDataCriacao
            // 
            this.lblDataCriacao.AutoSize = true;
            this.lblDataCriacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataCriacao.Location = new System.Drawing.Point(104, 2);
            this.lblDataCriacao.Name = "lblDataCriacao";
            this.lblDataCriacao.Size = new System.Drawing.Size(131, 20);
            this.lblDataCriacao.TabIndex = 2;
            this.lblDataCriacao.Text = "Data Da Criação:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(686, 395);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 23);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalvar.Location = new System.Drawing.Point(6, 395);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 23);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(6, 180);
            this.txtSenha.MaxLength = 20;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(237, 20);
            this.txtSenha.TabIndex = 9;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(2, 158);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(60, 20);
            this.lblSenha.TabIndex = 8;
            this.lblSenha.Text = "Senha:";
            // 
            // cmbTipoUsuario
            // 
            this.cmbTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoUsuario.FormattingEnabled = true;
            this.cmbTipoUsuario.Location = new System.Drawing.Point(6, 236);
            this.cmbTipoUsuario.Name = "cmbTipoUsuario";
            this.cmbTipoUsuario.Size = new System.Drawing.Size(175, 21);
            this.cmbTipoUsuario.TabIndex = 11;
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.AutoSize = true;
            this.lblTipoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoUsuario.Location = new System.Drawing.Point(2, 214);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(124, 20);
            this.lblTipoUsuario.TabIndex = 10;
            this.lblTipoUsuario.Text = "Tipo de Usuário:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(6, 124);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(237, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(2, 102);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 20);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "E-mail:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(6, 75);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(237, 20);
            this.txtNome.TabIndex = 5;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(2, 53);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(55, 20);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(6, 24);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(96, 20);
            this.txtId.TabIndex = 1;
            this.txtId.Text = "0";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(2, 2);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(27, 20);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id:";
            // 
            // txtDataCriacao
            // 
            this.txtDataCriacao.Location = new System.Drawing.Point(107, 24);
            this.txtDataCriacao.Name = "txtDataCriacao";
            this.txtDataCriacao.ReadOnly = true;
            this.txtDataCriacao.Size = new System.Drawing.Size(136, 20);
            this.txtDataCriacao.TabIndex = 3;
            // 
            // CadastroUsuarioView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbcUsuarios);
            this.Name = "CadastroUsuarioView";
            this.Text = "UsuariosView";
            this.tbcUsuarios.ResumeLayout(false);
            this.tbpListagem.ResumeLayout(false);
            this.tbpListagem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.tbpDetalhes.ResumeLayout(false);
            this.tbpDetalhes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcUsuarios;
        private System.Windows.Forms.TabPage tbpListagem;
        private System.Windows.Forms.TabPage tbpDetalhes;
        private System.Windows.Forms.Label lblProcurar;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.TextBox txtProcurar;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.ComboBox cmbTipoUsuario;
        private System.Windows.Forms.Label lblTipoUsuario;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtDataCriacao;
        private System.Windows.Forms.Label lblDataCriacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoUsuarioDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCriacao;
    }
}