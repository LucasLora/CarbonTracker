namespace CarbonTracker.Views.Views
{
    partial class RegistroGastosTransporteView
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
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.dgvRegistros = new System.Windows.Forms.DataGridView();
            this.IdTransporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeNRT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoVeiculoDescriptionNRT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoCombustivelDescriptionNRT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KmPorLitroCombustivelNRT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KmRodados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtdePassageiros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.pnlDia = new System.Windows.Forms.Panel();
            this.btnTrocar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblDia = new System.Windows.Forms.Label();
            this.dtpDia = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).BeginInit();
            this.pnlDia.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Location = new System.Drawing.Point(718, 421);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(75, 23);
            this.btnRestaurar.TabIndex = 6;
            this.btnRestaurar.Text = "Restaurar";
            this.btnRestaurar.UseVisualStyleBackColor = true;
            // 
            // dgvRegistros
            // 
            this.dgvRegistros.AllowUserToAddRows = false;
            this.dgvRegistros.AllowUserToDeleteRows = false;
            this.dgvRegistros.AllowUserToOrderColumns = true;
            this.dgvRegistros.AllowUserToResizeRows = false;
            this.dgvRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdTransporte,
            this.NomeNRT,
            this.TipoVeiculoDescriptionNRT,
            this.TipoCombustivelDescriptionNRT,
            this.KmPorLitroCombustivelNRT,
            this.KmRodados,
            this.QtdePassageiros});
            this.dgvRegistros.Location = new System.Drawing.Point(7, 106);
            this.dgvRegistros.Name = "dgvRegistros";
            this.dgvRegistros.RowHeadersVisible = false;
            this.dgvRegistros.RowHeadersWidth = 51;
            this.dgvRegistros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvRegistros.Size = new System.Drawing.Size(786, 309);
            this.dgvRegistros.TabIndex = 4;
            this.dgvRegistros.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvRegistros_CellValidating);
            // 
            // IdTransporte
            // 
            this.IdTransporte.DataPropertyName = "IdTransporte";
            this.IdTransporte.HeaderText = "Transporte";
            this.IdTransporte.MinimumWidth = 6;
            this.IdTransporte.Name = "IdTransporte";
            this.IdTransporte.ReadOnly = true;
            this.IdTransporte.Width = 75;
            // 
            // NomeNRT
            // 
            this.NomeNRT.DataPropertyName = "NomeNRT";
            this.NomeNRT.HeaderText = "Nome";
            this.NomeNRT.MinimumWidth = 6;
            this.NomeNRT.Name = "NomeNRT";
            this.NomeNRT.ReadOnly = true;
            this.NomeNRT.Width = 200;
            // 
            // TipoVeiculoDescriptionNRT
            // 
            this.TipoVeiculoDescriptionNRT.DataPropertyName = "TipoVeiculoDescriptionNRT";
            this.TipoVeiculoDescriptionNRT.HeaderText = "Tipo Veículo";
            this.TipoVeiculoDescriptionNRT.MinimumWidth = 6;
            this.TipoVeiculoDescriptionNRT.Name = "TipoVeiculoDescriptionNRT";
            this.TipoVeiculoDescriptionNRT.ReadOnly = true;
            this.TipoVeiculoDescriptionNRT.Width = 95;
            // 
            // TipoCombustivelDescriptionNRT
            // 
            this.TipoCombustivelDescriptionNRT.DataPropertyName = "TipoCombustivelDescriptionNRT";
            this.TipoCombustivelDescriptionNRT.HeaderText = "Tipo Combustível";
            this.TipoCombustivelDescriptionNRT.MinimumWidth = 6;
            this.TipoCombustivelDescriptionNRT.Name = "TipoCombustivelDescriptionNRT";
            this.TipoCombustivelDescriptionNRT.ReadOnly = true;
            this.TipoCombustivelDescriptionNRT.Width = 115;
            // 
            // KmPorLitroCombustivelNRT
            // 
            this.KmPorLitroCombustivelNRT.DataPropertyName = "KmPorLitroCombustivelNRT";
            this.KmPorLitroCombustivelNRT.HeaderText = "Km/L Combustível";
            this.KmPorLitroCombustivelNRT.MinimumWidth = 6;
            this.KmPorLitroCombustivelNRT.Name = "KmPorLitroCombustivelNRT";
            this.KmPorLitroCombustivelNRT.ReadOnly = true;
            this.KmPorLitroCombustivelNRT.Width = 120;
            // 
            // KmRodados
            // 
            this.KmRodados.DataPropertyName = "KmRodados";
            this.KmRodados.HeaderText = "Km Rodados";
            this.KmRodados.MinimumWidth = 6;
            this.KmRodados.Name = "KmRodados";
            this.KmRodados.Width = 125;
            // 
            // QtdePassageiros
            // 
            this.QtdePassageiros.DataPropertyName = "QtdePassageiros";
            this.QtdePassageiros.HeaderText = "Quantidade Passageiros";
            this.QtdePassageiros.MinimumWidth = 6;
            this.QtdePassageiros.Name = "QtdePassageiros";
            this.QtdePassageiros.Width = 125;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalvar.Location = new System.Drawing.Point(7, 421);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisar.Location = new System.Drawing.Point(718, 78);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(4, 64);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(65, 15);
            this.lblPesquisar.TabIndex = 1;
            this.lblPesquisar.Text = "Pesquisar:";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisar.Location = new System.Drawing.Point(7, 80);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(705, 20);
            this.txtPesquisar.TabIndex = 2;
            // 
            // pnlDia
            // 
            this.pnlDia.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pnlDia.Controls.Add(this.btnTrocar);
            this.pnlDia.Controls.Add(this.btnRegistrar);
            this.pnlDia.Controls.Add(this.lblDia);
            this.pnlDia.Controls.Add(this.dtpDia);
            this.pnlDia.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDia.Location = new System.Drawing.Point(0, 0);
            this.pnlDia.Name = "pnlDia";
            this.pnlDia.Size = new System.Drawing.Size(800, 60);
            this.pnlDia.TabIndex = 0;
            // 
            // btnTrocar
            // 
            this.btnTrocar.Location = new System.Drawing.Point(189, 24);
            this.btnTrocar.Name = "btnTrocar";
            this.btnTrocar.Size = new System.Drawing.Size(75, 23);
            this.btnTrocar.TabIndex = 3;
            this.btnTrocar.Text = "Trocar Dia";
            this.btnTrocar.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(108, 24);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Location = new System.Drawing.Point(4, 10);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(29, 15);
            this.lblDia.TabIndex = 0;
            this.lblDia.Text = "Dia:";
            // 
            // dtpDia
            // 
            this.dtpDia.CustomFormat = "dd/MM/yyyy";
            this.dtpDia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDia.Location = new System.Drawing.Point(7, 26);
            this.dtpDia.Name = "dtpDia";
            this.dtpDia.Size = new System.Drawing.Size(95, 20);
            this.dtpDia.TabIndex = 1;
            // 
            // RegistroGastosTransporteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRestaurar);
            this.Controls.Add(this.dgvRegistros);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.pnlDia);
            this.Name = "RegistroGastosTransporteView";
            this.Text = "RegistroGastosTransporteView";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).EndInit();
            this.pnlDia.ResumeLayout(false);
            this.pnlDia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.DataGridView dgvRegistros;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Panel pnlDia;
        private System.Windows.Forms.Button btnTrocar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.DateTimePicker dtpDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTransporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeNRT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoVeiculoDescriptionNRT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoCombustivelDescriptionNRT;
        private System.Windows.Forms.DataGridViewTextBoxColumn KmPorLitroCombustivelNRT;
        private System.Windows.Forms.DataGridViewTextBoxColumn KmRodados;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtdePassageiros;
    }
}