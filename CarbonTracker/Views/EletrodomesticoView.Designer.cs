﻿namespace CarbonTracker.Views
{
    partial class EletrodomesticoView
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
            this.lblLitroPorHoraAgua = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.txtProcurar = new System.Windows.Forms.TextBox();
            this.lblProcurar = new System.Windows.Forms.Label();
            this.tbpDetalhes = new System.Windows.Forms.TabPage();
            this.txtKwPorHoraEletricidade = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblKwPorHoraEletricidade = new System.Windows.Forms.Label();
            this.txtLitroPorHoraAgua = new System.Windows.Forms.TextBox();
            this.tbcEletrodomesticos = new System.Windows.Forms.TabControl();
            this.tbpListagem = new System.Windows.Forms.TabPage();
            this.dgvEletrodomesticos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LitroPorHoraAgua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kwporhoraeletricidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpDetalhes.SuspendLayout();
            this.tbcEletrodomesticos.SuspendLayout();
            this.tbpListagem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEletrodomesticos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLitroPorHoraAgua
            // 
            this.lblLitroPorHoraAgua.AutoSize = true;
            this.lblLitroPorHoraAgua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLitroPorHoraAgua.Location = new System.Drawing.Point(3, 129);
            this.lblLitroPorHoraAgua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLitroPorHoraAgua.Name = "lblLitroPorHoraAgua";
            this.lblLitroPorHoraAgua.Size = new System.Drawing.Size(98, 25);
            this.lblLitroPorHoraAgua.TabIndex = 4;
            this.lblLitroPorHoraAgua.Text = "L/h Água:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(8, 93);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(400, 22);
            this.txtNome.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(3, 66);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(70, 25);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(8, 30);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(99, 22);
            this.txtId.TabIndex = 1;
            this.txtId.Text = "0";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(3, 3);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(34, 25);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id:";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.Location = new System.Drawing.Point(918, 133);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(133, 28);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlterar.Location = new System.Drawing.Point(918, 98);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(133, 28);
            this.btnAlterar.TabIndex = 5;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnProcurar
            // 
            this.btnProcurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcurar.Location = new System.Drawing.Point(777, 27);
            this.btnProcurar.Margin = new System.Windows.Forms.Padding(4);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(133, 28);
            this.btnProcurar.TabIndex = 2;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionar.Location = new System.Drawing.Point(918, 63);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(133, 28);
            this.btnAdicionar.TabIndex = 4;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // txtProcurar
            // 
            this.txtProcurar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProcurar.Location = new System.Drawing.Point(8, 30);
            this.txtProcurar.Margin = new System.Windows.Forms.Padding(4);
            this.txtProcurar.Name = "txtProcurar";
            this.txtProcurar.Size = new System.Drawing.Size(761, 22);
            this.txtProcurar.TabIndex = 1;
            // 
            // lblProcurar
            // 
            this.lblProcurar.AutoSize = true;
            this.lblProcurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcurar.Location = new System.Drawing.Point(3, 3);
            this.lblProcurar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProcurar.Name = "lblProcurar";
            this.lblProcurar.Size = new System.Drawing.Size(92, 25);
            this.lblProcurar.TabIndex = 0;
            this.lblProcurar.Text = "Procurar:";
            // 
            // tbpDetalhes
            // 
            this.tbpDetalhes.Controls.Add(this.txtKwPorHoraEletricidade);
            this.tbpDetalhes.Controls.Add(this.btnCancelar);
            this.tbpDetalhes.Controls.Add(this.btnSalvar);
            this.tbpDetalhes.Controls.Add(this.lblKwPorHoraEletricidade);
            this.tbpDetalhes.Controls.Add(this.txtLitroPorHoraAgua);
            this.tbpDetalhes.Controls.Add(this.lblLitroPorHoraAgua);
            this.tbpDetalhes.Controls.Add(this.txtNome);
            this.tbpDetalhes.Controls.Add(this.lblNome);
            this.tbpDetalhes.Controls.Add(this.txtId);
            this.tbpDetalhes.Controls.Add(this.lblId);
            this.tbpDetalhes.Location = new System.Drawing.Point(4, 25);
            this.tbpDetalhes.Margin = new System.Windows.Forms.Padding(4);
            this.tbpDetalhes.Name = "tbpDetalhes";
            this.tbpDetalhes.Padding = new System.Windows.Forms.Padding(4);
            this.tbpDetalhes.Size = new System.Drawing.Size(1059, 525);
            this.tbpDetalhes.TabIndex = 1;
            this.tbpDetalhes.Text = "Detalhes";
            this.tbpDetalhes.UseVisualStyleBackColor = true;
            // 
            // txtKwPorHoraEletricidade
            // 
            this.txtKwPorHoraEletricidade.Location = new System.Drawing.Point(8, 219);
            this.txtKwPorHoraEletricidade.Margin = new System.Windows.Forms.Padding(4);
            this.txtKwPorHoraEletricidade.Name = "txtKwPorHoraEletricidade";
            this.txtKwPorHoraEletricidade.Size = new System.Drawing.Size(99, 22);
            this.txtKwPorHoraEletricidade.TabIndex = 7;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(918, 489);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(133, 28);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalvar.Location = new System.Drawing.Point(8, 489);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(133, 28);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // lblKwPorHoraEletricidade
            // 
            this.lblKwPorHoraEletricidade.AutoSize = true;
            this.lblKwPorHoraEletricidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKwPorHoraEletricidade.Location = new System.Drawing.Point(3, 192);
            this.lblKwPorHoraEletricidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKwPorHoraEletricidade.Name = "lblKwPorHoraEletricidade";
            this.lblKwPorHoraEletricidade.Size = new System.Drawing.Size(171, 25);
            this.lblKwPorHoraEletricidade.TabIndex = 6;
            this.lblKwPorHoraEletricidade.Text = "kW/h Eletricidade:";
            // 
            // txtLitroPorHoraAgua
            // 
            this.txtLitroPorHoraAgua.Location = new System.Drawing.Point(8, 156);
            this.txtLitroPorHoraAgua.Margin = new System.Windows.Forms.Padding(4);
            this.txtLitroPorHoraAgua.Name = "txtLitroPorHoraAgua";
            this.txtLitroPorHoraAgua.Size = new System.Drawing.Size(99, 22);
            this.txtLitroPorHoraAgua.TabIndex = 5;
            // 
            // tbcEletrodomesticos
            // 
            this.tbcEletrodomesticos.Controls.Add(this.tbpListagem);
            this.tbcEletrodomesticos.Controls.Add(this.tbpDetalhes);
            this.tbcEletrodomesticos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcEletrodomesticos.Location = new System.Drawing.Point(0, 0);
            this.tbcEletrodomesticos.Margin = new System.Windows.Forms.Padding(4);
            this.tbcEletrodomesticos.Name = "tbcEletrodomesticos";
            this.tbcEletrodomesticos.SelectedIndex = 0;
            this.tbcEletrodomesticos.Size = new System.Drawing.Size(1067, 554);
            this.tbcEletrodomesticos.TabIndex = 1;
            // 
            // tbpListagem
            // 
            this.tbpListagem.Controls.Add(this.dgvEletrodomesticos);
            this.tbpListagem.Controls.Add(this.btnExcluir);
            this.tbpListagem.Controls.Add(this.btnAlterar);
            this.tbpListagem.Controls.Add(this.btnProcurar);
            this.tbpListagem.Controls.Add(this.btnAdicionar);
            this.tbpListagem.Controls.Add(this.txtProcurar);
            this.tbpListagem.Controls.Add(this.lblProcurar);
            this.tbpListagem.Location = new System.Drawing.Point(4, 25);
            this.tbpListagem.Margin = new System.Windows.Forms.Padding(4);
            this.tbpListagem.Name = "tbpListagem";
            this.tbpListagem.Padding = new System.Windows.Forms.Padding(4);
            this.tbpListagem.Size = new System.Drawing.Size(1059, 525);
            this.tbpListagem.TabIndex = 0;
            this.tbpListagem.Text = "Listagem";
            this.tbpListagem.UseVisualStyleBackColor = true;
            // 
            // dgvEletrodomesticos
            // 
            this.dgvEletrodomesticos.AllowUserToAddRows = false;
            this.dgvEletrodomesticos.AllowUserToDeleteRows = false;
            this.dgvEletrodomesticos.AllowUserToResizeRows = false;
            this.dgvEletrodomesticos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEletrodomesticos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEletrodomesticos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.LitroPorHoraAgua,
            this.kwporhoraeletricidade});
            this.dgvEletrodomesticos.Location = new System.Drawing.Point(8, 63);
            this.dgvEletrodomesticos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEletrodomesticos.MultiSelect = false;
            this.dgvEletrodomesticos.Name = "dgvEletrodomesticos";
            this.dgvEletrodomesticos.ReadOnly = true;
            this.dgvEletrodomesticos.RowHeadersVisible = false;
            this.dgvEletrodomesticos.RowHeadersWidth = 51;
            this.dgvEletrodomesticos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEletrodomesticos.Size = new System.Drawing.Size(902, 454);
            this.dgvEletrodomesticos.TabIndex = 3;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Eletrodoméstico";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 90;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.MinimumWidth = 6;
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 150;
            // 
            // LitroPorHoraAgua
            // 
            this.LitroPorHoraAgua.DataPropertyName = "LitroPorHoraAgua";
            this.LitroPorHoraAgua.HeaderText = "L/h Água";
            this.LitroPorHoraAgua.MinimumWidth = 6;
            this.LitroPorHoraAgua.Name = "LitroPorHoraAgua";
            this.LitroPorHoraAgua.ReadOnly = true;
            this.LitroPorHoraAgua.Width = 120;
            // 
            // kwporhoraeletricidade
            // 
            this.kwporhoraeletricidade.DataPropertyName = "KWPorHoraEletricidade";
            this.kwporhoraeletricidade.HeaderText = "kW/h Eletricidade";
            this.kwporhoraeletricidade.MinimumWidth = 6;
            this.kwporhoraeletricidade.Name = "kwporhoraeletricidade";
            this.kwporhoraeletricidade.ReadOnly = true;
            this.kwporhoraeletricidade.Width = 120;
            // 
            // EletrodomesticoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tbcEletrodomesticos);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EletrodomesticoView";
            this.Text = "EletrodomesticoView";
            this.tbpDetalhes.ResumeLayout(false);
            this.tbpDetalhes.PerformLayout();
            this.tbcEletrodomesticos.ResumeLayout(false);
            this.tbpListagem.ResumeLayout(false);
            this.tbpListagem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEletrodomesticos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLitroPorHoraAgua;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox txtProcurar;
        private System.Windows.Forms.Label lblProcurar;
        private System.Windows.Forms.TabPage tbpDetalhes;
        private System.Windows.Forms.TextBox txtLitroPorHoraAgua;
        private System.Windows.Forms.TabControl tbcEletrodomesticos;
        private System.Windows.Forms.TabPage tbpListagem;
        private System.Windows.Forms.Label lblKwPorHoraEletricidade;
        private System.Windows.Forms.DataGridView dgvEletrodomesticos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtKwPorHoraEletricidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn LitroPorHoraAgua;
        private System.Windows.Forms.DataGridViewTextBoxColumn kwporhoraeletricidade;
    }
}