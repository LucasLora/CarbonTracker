using CarbonTracker.Models.Common;
using System;

namespace CarbonTracker.Views
{
    partial class CadastroTransporteView
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
            this.tbcTransportes = new System.Windows.Forms.TabControl();
            this.tbpListagem = new System.Windows.Forms.TabPage();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.dgvTransportes = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoVeiculoDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoCombustivelDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KmPorLitroCombustivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtProcurar = new System.Windows.Forms.TextBox();
            this.lblProcurar = new System.Windows.Forms.Label();
            this.tbpDetalhes = new System.Windows.Forms.TabPage();
            this.cmbTipoCombustivel = new System.Windows.Forms.ComboBox();
            this.cmbTipoVeiculo = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtKmPorLitroCombustivel = new System.Windows.Forms.TextBox();
            this.lblKmPorLitroCombustivel = new System.Windows.Forms.Label();
            this.lblTipoCombustivel = new System.Windows.Forms.Label();
            this.lblTipoVeiculo = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.tbcTransportes.SuspendLayout();
            this.tbpListagem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransportes)).BeginInit();
            this.tbpDetalhes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcTransportes
            // 
            this.tbcTransportes.Controls.Add(this.tbpListagem);
            this.tbcTransportes.Controls.Add(this.tbpDetalhes);
            this.tbcTransportes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcTransportes.Location = new System.Drawing.Point(0, 0);
            this.tbcTransportes.Name = "tbcTransportes";
            this.tbcTransportes.SelectedIndex = 0;
            this.tbcTransportes.Size = new System.Drawing.Size(800, 450);
            this.tbcTransportes.TabIndex = 0;
            // 
            // tbpListagem
            // 
            this.tbpListagem.Controls.Add(this.btnExcluir);
            this.tbpListagem.Controls.Add(this.btnAlterar);
            this.tbpListagem.Controls.Add(this.btnProcurar);
            this.tbpListagem.Controls.Add(this.btnAdicionar);
            this.tbpListagem.Controls.Add(this.dgvTransportes);
            this.tbpListagem.Controls.Add(this.txtProcurar);
            this.tbpListagem.Controls.Add(this.lblProcurar);
            this.tbpListagem.Location = new System.Drawing.Point(4, 22);
            this.tbpListagem.Name = "tbpListagem";
            this.tbpListagem.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tbpListagem.Size = new System.Drawing.Size(792, 424);
            this.tbpListagem.TabIndex = 0;
            this.tbpListagem.Text = "Listagem";
            this.tbpListagem.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.Location = new System.Drawing.Point(688, 108);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 23);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlterar.Location = new System.Drawing.Point(688, 80);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(100, 23);
            this.btnAlterar.TabIndex = 5;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnProcurar
            // 
            this.btnProcurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcurar.Location = new System.Drawing.Point(583, 22);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(100, 23);
            this.btnProcurar.TabIndex = 2;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionar.Location = new System.Drawing.Point(688, 51);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(100, 23);
            this.btnAdicionar.TabIndex = 4;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // dgvTransportes
            // 
            this.dgvTransportes.AllowUserToAddRows = false;
            this.dgvTransportes.AllowUserToDeleteRows = false;
            this.dgvTransportes.AllowUserToResizeRows = false;
            this.dgvTransportes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTransportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransportes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.TipoVeiculoDescription,
            this.TipoCombustivelDescription,
            this.KmPorLitroCombustivel});
            this.dgvTransportes.Location = new System.Drawing.Point(6, 51);
            this.dgvTransportes.MultiSelect = false;
            this.dgvTransportes.Name = "dgvTransportes";
            this.dgvTransportes.ReadOnly = true;
            this.dgvTransportes.RowHeadersVisible = false;
            this.dgvTransportes.RowHeadersWidth = 51;
            this.dgvTransportes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransportes.Size = new System.Drawing.Size(676, 369);
            this.dgvTransportes.TabIndex = 3;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Transporte";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 75;
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
            // TipoVeiculoDescription
            // 
            this.TipoVeiculoDescription.DataPropertyName = "TipoVeiculoDescription";
            this.TipoVeiculoDescription.HeaderText = "Tipo Veículo";
            this.TipoVeiculoDescription.MinimumWidth = 6;
            this.TipoVeiculoDescription.Name = "TipoVeiculoDescription";
            this.TipoVeiculoDescription.ReadOnly = true;
            this.TipoVeiculoDescription.Width = 95;
            // 
            // TipoCombustivelDescription
            // 
            this.TipoCombustivelDescription.DataPropertyName = "TipoCombustivelDescription";
            this.TipoCombustivelDescription.HeaderText = "Tipo Combustível";
            this.TipoCombustivelDescription.MinimumWidth = 6;
            this.TipoCombustivelDescription.Name = "TipoCombustivelDescription";
            this.TipoCombustivelDescription.ReadOnly = true;
            this.TipoCombustivelDescription.Width = 115;
            // 
            // KmPorLitroCombustivel
            // 
            this.KmPorLitroCombustivel.DataPropertyName = "KmPorLitroCombustivel";
            this.KmPorLitroCombustivel.HeaderText = "Km/L Combustível";
            this.KmPorLitroCombustivel.MinimumWidth = 6;
            this.KmPorLitroCombustivel.Name = "KmPorLitroCombustivel";
            this.KmPorLitroCombustivel.ReadOnly = true;
            this.KmPorLitroCombustivel.Width = 120;
            // 
            // txtProcurar
            // 
            this.txtProcurar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProcurar.Location = new System.Drawing.Point(6, 24);
            this.txtProcurar.Name = "txtProcurar";
            this.txtProcurar.Size = new System.Drawing.Size(572, 20);
            this.txtProcurar.TabIndex = 1;
            // 
            // lblProcurar
            // 
            this.lblProcurar.AutoSize = true;
            this.lblProcurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcurar.Location = new System.Drawing.Point(2, 2);
            this.lblProcurar.Name = "lblProcurar";
            this.lblProcurar.Size = new System.Drawing.Size(73, 20);
            this.lblProcurar.TabIndex = 0;
            this.lblProcurar.Text = "Procurar:";
            // 
            // tbpDetalhes
            // 
            this.tbpDetalhes.Controls.Add(this.cmbTipoCombustivel);
            this.tbpDetalhes.Controls.Add(this.cmbTipoVeiculo);
            this.tbpDetalhes.Controls.Add(this.btnCancelar);
            this.tbpDetalhes.Controls.Add(this.btnSalvar);
            this.tbpDetalhes.Controls.Add(this.txtKmPorLitroCombustivel);
            this.tbpDetalhes.Controls.Add(this.lblKmPorLitroCombustivel);
            this.tbpDetalhes.Controls.Add(this.lblTipoCombustivel);
            this.tbpDetalhes.Controls.Add(this.lblTipoVeiculo);
            this.tbpDetalhes.Controls.Add(this.txtNome);
            this.tbpDetalhes.Controls.Add(this.lblNome);
            this.tbpDetalhes.Controls.Add(this.txtId);
            this.tbpDetalhes.Controls.Add(this.lblId);
            this.tbpDetalhes.Location = new System.Drawing.Point(4, 22);
            this.tbpDetalhes.Name = "tbpDetalhes";
            this.tbpDetalhes.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tbpDetalhes.Size = new System.Drawing.Size(792, 424);
            this.tbpDetalhes.TabIndex = 1;
            this.tbpDetalhes.Text = "Detalhes";
            this.tbpDetalhes.UseVisualStyleBackColor = true;
            // 
            // cmbTipoCombustivel
            // 
            this.cmbTipoCombustivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoCombustivel.FormattingEnabled = true;
            this.cmbTipoCombustivel.Location = new System.Drawing.Point(6, 175);
            this.cmbTipoCombustivel.Name = "cmbTipoCombustivel";
            this.cmbTipoCombustivel.Size = new System.Drawing.Size(165, 21);
            this.cmbTipoCombustivel.TabIndex = 7;
            // 
            // cmbTipoVeiculo
            // 
            this.cmbTipoVeiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoVeiculo.FormattingEnabled = true;
            this.cmbTipoVeiculo.Location = new System.Drawing.Point(6, 124);
            this.cmbTipoVeiculo.Name = "cmbTipoVeiculo";
            this.cmbTipoVeiculo.Size = new System.Drawing.Size(165, 21);
            this.cmbTipoVeiculo.TabIndex = 5;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(688, 397);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalvar.Location = new System.Drawing.Point(6, 397);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 23);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // txtKmPorLitroCombustivel
            // 
            this.txtKmPorLitroCombustivel.Location = new System.Drawing.Point(8, 226);
            this.txtKmPorLitroCombustivel.Name = "txtKmPorLitroCombustivel";
            this.txtKmPorLitroCombustivel.Size = new System.Drawing.Size(75, 20);
            this.txtKmPorLitroCombustivel.TabIndex = 9;
            // 
            // lblKmPorLitroCombustivel
            // 
            this.lblKmPorLitroCombustivel.AutoSize = true;
            this.lblKmPorLitroCombustivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKmPorLitroCombustivel.Location = new System.Drawing.Point(2, 204);
            this.lblKmPorLitroCombustivel.Name = "lblKmPorLitroCombustivel";
            this.lblKmPorLitroCombustivel.Size = new System.Drawing.Size(49, 20);
            this.lblKmPorLitroCombustivel.TabIndex = 8;
            this.lblKmPorLitroCombustivel.Text = "Km/L:";
            // 
            // lblTipoCombustivel
            // 
            this.lblTipoCombustivel.AutoSize = true;
            this.lblTipoCombustivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoCombustivel.Location = new System.Drawing.Point(2, 153);
            this.lblTipoCombustivel.Name = "lblTipoCombustivel";
            this.lblTipoCombustivel.Size = new System.Drawing.Size(133, 20);
            this.lblTipoCombustivel.TabIndex = 6;
            this.lblTipoCombustivel.Text = "Tipo Combustível:";
            // 
            // lblTipoVeiculo
            // 
            this.lblTipoVeiculo.AutoSize = true;
            this.lblTipoVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoVeiculo.Location = new System.Drawing.Point(2, 102);
            this.lblTipoVeiculo.Name = "lblTipoVeiculo";
            this.lblTipoVeiculo.Size = new System.Drawing.Size(99, 20);
            this.lblTipoVeiculo.TabIndex = 4;
            this.lblTipoVeiculo.Text = "Tipo Veículo:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(6, 74);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(301, 20);
            this.txtNome.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(2, 52);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(55, 20);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(6, 24);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(75, 20);
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
            // CadastroTransporteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbcTransportes);
            this.Name = "CadastroTransporteView";
            this.Text = "TransporteView";
            this.tbcTransportes.ResumeLayout(false);
            this.tbpListagem.ResumeLayout(false);
            this.tbpListagem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransportes)).EndInit();
            this.tbpDetalhes.ResumeLayout(false);
            this.tbpDetalhes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tbcTransportes;
        private System.Windows.Forms.TabPage tbpListagem;
        private System.Windows.Forms.TabPage tbpDetalhes;
        private System.Windows.Forms.Label lblProcurar;
        private System.Windows.Forms.DataGridView dgvTransportes;
        private System.Windows.Forms.TextBox txtProcurar;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblTipoVeiculo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtKmPorLitroCombustivel;
        private System.Windows.Forms.Label lblKmPorLitroCombustivel;
        private System.Windows.Forms.Label lblTipoCombustivel;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox cmbTipoCombustivel;
        private System.Windows.Forms.ComboBox cmbTipoVeiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoVeiculoDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoCombustivelDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn KmPorLitroCombustivel;
    }
}