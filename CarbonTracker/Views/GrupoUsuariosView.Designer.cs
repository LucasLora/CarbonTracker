namespace CarbonTracker.Views
{
    partial class GrupoUsuariosView
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.tbpDetalhes = new System.Windows.Forms.TabPage();
            this.txtDescricao = new System.Windows.Forms.RichTextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtProcurar = new System.Windows.Forms.TextBox();
            this.lblProcurar = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.dgvGrupoUsuarios = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpListagem = new System.Windows.Forms.TabPage();
            this.tbcGrupoUsuarios = new System.Windows.Forms.TabControl();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlTopGrupoUsuarios = new System.Windows.Forms.Panel();
            this.lblGrupoUsuarios = new System.Windows.Forms.Label();
            this.tbpDetalhes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupoUsuarios)).BeginInit();
            this.tbpListagem.SuspendLayout();
            this.tbcGrupoUsuarios.SuspendLayout();
            this.pnlTopGrupoUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(689, 325);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalvar.Location = new System.Drawing.Point(3, 325);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 23);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(7, 76);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(450, 20);
            this.txtNome.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(3, 53);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(55, 20);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(3, 3);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(27, 20);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id:";
            // 
            // tbpDetalhes
            // 
            this.tbpDetalhes.Controls.Add(this.txtDescricao);
            this.tbpDetalhes.Controls.Add(this.lblDescricao);
            this.tbpDetalhes.Controls.Add(this.btnCancelar);
            this.tbpDetalhes.Controls.Add(this.btnSalvar);
            this.tbpDetalhes.Controls.Add(this.txtNome);
            this.tbpDetalhes.Controls.Add(this.lblNome);
            this.tbpDetalhes.Controls.Add(this.txtId);
            this.tbpDetalhes.Controls.Add(this.lblId);
            this.tbpDetalhes.Location = new System.Drawing.Point(4, 22);
            this.tbpDetalhes.Name = "tbpDetalhes";
            this.tbpDetalhes.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDetalhes.Size = new System.Drawing.Size(792, 351);
            this.tbpDetalhes.TabIndex = 1;
            this.tbpDetalhes.Text = "Detalhes";
            this.tbpDetalhes.UseVisualStyleBackColor = true;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(7, 128);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(779, 191);
            this.txtDescricao.TabIndex = 14;
            this.txtDescricao.Text = "";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(3, 105);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(84, 20);
            this.lblDescricao.TabIndex = 12;
            this.lblDescricao.Text = "Descrição:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(7, 26);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(75, 20);
            this.txtId.TabIndex = 1;
            this.txtId.Text = "0";
            // 
            // txtProcurar
            // 
            this.txtProcurar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProcurar.Location = new System.Drawing.Point(7, 26);
            this.txtProcurar.Name = "txtProcurar";
            this.txtProcurar.Size = new System.Drawing.Size(567, 20);
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
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.Location = new System.Drawing.Point(686, 110);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 23);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlterar.Location = new System.Drawing.Point(686, 81);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(100, 23);
            this.btnAlterar.TabIndex = 5;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnProcurar
            // 
            this.btnProcurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcurar.Location = new System.Drawing.Point(580, 24);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(100, 23);
            this.btnProcurar.TabIndex = 2;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionar.Location = new System.Drawing.Point(686, 52);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(100, 23);
            this.btnAdicionar.TabIndex = 4;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // dgvGrupoUsuarios
            // 
            this.dgvGrupoUsuarios.AllowUserToAddRows = false;
            this.dgvGrupoUsuarios.AllowUserToDeleteRows = false;
            this.dgvGrupoUsuarios.AllowUserToResizeRows = false;
            this.dgvGrupoUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGrupoUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupoUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.Descricao});
            this.dgvGrupoUsuarios.Location = new System.Drawing.Point(7, 52);
            this.dgvGrupoUsuarios.MultiSelect = false;
            this.dgvGrupoUsuarios.Name = "dgvGrupoUsuarios";
            this.dgvGrupoUsuarios.ReadOnly = true;
            this.dgvGrupoUsuarios.RowHeadersVisible = false;
            this.dgvGrupoUsuarios.RowHeadersWidth = 51;
            this.dgvGrupoUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrupoUsuarios.Size = new System.Drawing.Size(673, 291);
            this.dgvGrupoUsuarios.TabIndex = 3;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Grupo";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 75;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 200;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 350;
            // 
            // tbpListagem
            // 
            this.tbpListagem.Controls.Add(this.btnExcluir);
            this.tbpListagem.Controls.Add(this.btnAlterar);
            this.tbpListagem.Controls.Add(this.btnProcurar);
            this.tbpListagem.Controls.Add(this.btnAdicionar);
            this.tbpListagem.Controls.Add(this.dgvGrupoUsuarios);
            this.tbpListagem.Controls.Add(this.txtProcurar);
            this.tbpListagem.Controls.Add(this.lblProcurar);
            this.tbpListagem.Location = new System.Drawing.Point(4, 22);
            this.tbpListagem.Name = "tbpListagem";
            this.tbpListagem.Padding = new System.Windows.Forms.Padding(3);
            this.tbpListagem.Size = new System.Drawing.Size(792, 351);
            this.tbpListagem.TabIndex = 0;
            this.tbpListagem.Text = "Listagem";
            this.tbpListagem.UseVisualStyleBackColor = true;
            // 
            // tbcGrupoUsuarios
            // 
            this.tbcGrupoUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcGrupoUsuarios.Controls.Add(this.tbpListagem);
            this.tbcGrupoUsuarios.Controls.Add(this.tbpDetalhes);
            this.tbcGrupoUsuarios.Location = new System.Drawing.Point(0, 73);
            this.tbcGrupoUsuarios.Name = "tbcGrupoUsuarios";
            this.tbcGrupoUsuarios.SelectedIndex = 0;
            this.tbcGrupoUsuarios.Size = new System.Drawing.Size(800, 377);
            this.tbcGrupoUsuarios.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(772, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // pnlTopGrupoUsuarios
            // 
            this.pnlTopGrupoUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTopGrupoUsuarios.BackColor = System.Drawing.Color.White;
            this.pnlTopGrupoUsuarios.Controls.Add(this.btnClose);
            this.pnlTopGrupoUsuarios.Controls.Add(this.lblGrupoUsuarios);
            this.pnlTopGrupoUsuarios.Location = new System.Drawing.Point(0, 0);
            this.pnlTopGrupoUsuarios.Name = "pnlTopGrupoUsuarios";
            this.pnlTopGrupoUsuarios.Size = new System.Drawing.Size(800, 73);
            this.pnlTopGrupoUsuarios.TabIndex = 2;
            // 
            // lblGrupoUsuarios
            // 
            this.lblGrupoUsuarios.AutoSize = true;
            this.lblGrupoUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrupoUsuarios.Location = new System.Drawing.Point(12, 19);
            this.lblGrupoUsuarios.Name = "lblGrupoUsuarios";
            this.lblGrupoUsuarios.Size = new System.Drawing.Size(218, 31);
            this.lblGrupoUsuarios.TabIndex = 0;
            this.lblGrupoUsuarios.Text = "Grupo Usuários";
            // 
            // GrupoUsuariosView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbcGrupoUsuarios);
            this.Controls.Add(this.pnlTopGrupoUsuarios);
            this.Name = "GrupoUsuariosView";
            this.Text = "GrupoUsuariosView";
            this.tbpDetalhes.ResumeLayout(false);
            this.tbpDetalhes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupoUsuarios)).EndInit();
            this.tbpListagem.ResumeLayout(false);
            this.tbpListagem.PerformLayout();
            this.tbcGrupoUsuarios.ResumeLayout(false);
            this.pnlTopGrupoUsuarios.ResumeLayout(false);
            this.pnlTopGrupoUsuarios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TabPage tbpDetalhes;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtProcurar;
        private System.Windows.Forms.Label lblProcurar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.DataGridView dgvGrupoUsuarios;
        private System.Windows.Forms.TabPage tbpListagem;
        private System.Windows.Forms.TabControl tbcGrupoUsuarios;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlTopGrupoUsuarios;
        private System.Windows.Forms.Label lblGrupoUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.RichTextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
    }
}