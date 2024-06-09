namespace CarbonTracker.Views.Views
{
    partial class RegistroGastosEletrodomesticoView
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
            this.pnlDia = new System.Windows.Forms.Panel();
            this.btnTrocar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblDia = new System.Windows.Forms.Label();
            this.dtpDia = new System.Windows.Forms.DateTimePicker();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dgvRegistros = new System.Windows.Forms.DataGridView();
            this.IdEletrodomestico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeNRT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LitroPorHoraAguaNRT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KWPorHoraEletricidadeNRT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TempoUso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlDia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).BeginInit();
            this.SuspendLayout();
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
            this.lblDia.Size = new System.Drawing.Size(26, 13);
            this.lblDia.TabIndex = 1;
            this.lblDia.Text = "Dia:";
            // 
            // dtpDia
            // 
            this.dtpDia.CustomFormat = "dd/MM/yyyy";
            this.dtpDia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDia.Location = new System.Drawing.Point(7, 26);
            this.dtpDia.Name = "dtpDia";
            this.dtpDia.Size = new System.Drawing.Size(95, 20);
            this.dtpDia.TabIndex = 0;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisar.Location = new System.Drawing.Point(7, 80);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(705, 20);
            this.txtPesquisar.TabIndex = 1;
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(4, 64);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(56, 13);
            this.lblPesquisar.TabIndex = 2;
            this.lblPesquisar.Text = "Pesquisar:";
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
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Location = new System.Drawing.Point(718, 421);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(75, 23);
            this.btnRestaurar.TabIndex = 5;
            this.btnRestaurar.Text = "Restaurar";
            this.btnRestaurar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalvar.Location = new System.Drawing.Point(7, 421);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
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
            this.IdEletrodomestico,
            this.NomeNRT,
            this.LitroPorHoraAguaNRT,
            this.KWPorHoraEletricidadeNRT,
            this.TempoUso});
            this.dgvRegistros.Location = new System.Drawing.Point(7, 106);
            this.dgvRegistros.Name = "dgvRegistros";
            this.dgvRegistros.RowHeadersVisible = false;
            this.dgvRegistros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvRegistros.Size = new System.Drawing.Size(786, 309);
            this.dgvRegistros.TabIndex = 11;
            // 
            // IdEletrodomestico
            // 
            this.IdEletrodomestico.DataPropertyName = "IdEletrodomestico";
            this.IdEletrodomestico.HeaderText = "Eletrodoméstico";
            this.IdEletrodomestico.Name = "IdEletrodomestico";
            this.IdEletrodomestico.ReadOnly = true;
            this.IdEletrodomestico.Width = 90;
            // 
            // NomeNRT
            // 
            this.NomeNRT.DataPropertyName = "NomeNRT";
            this.NomeNRT.HeaderText = "Nome";
            this.NomeNRT.Name = "NomeNRT";
            this.NomeNRT.ReadOnly = true;
            this.NomeNRT.Width = 150;
            // 
            // LitroPorHoraAguaNRT
            // 
            this.LitroPorHoraAguaNRT.DataPropertyName = "LitroPorHoraAguaNRT";
            this.LitroPorHoraAguaNRT.HeaderText = "L/h Água";
            this.LitroPorHoraAguaNRT.Name = "LitroPorHoraAguaNRT";
            this.LitroPorHoraAguaNRT.ReadOnly = true;
            this.LitroPorHoraAguaNRT.Width = 120;
            // 
            // KWPorHoraEletricidadeNRT
            // 
            this.KWPorHoraEletricidadeNRT.DataPropertyName = "KWPorHoraEletricidadeNRT";
            this.KWPorHoraEletricidadeNRT.HeaderText = "kW/h Eletricidade";
            this.KWPorHoraEletricidadeNRT.Name = "KWPorHoraEletricidadeNRT";
            this.KWPorHoraEletricidadeNRT.ReadOnly = true;
            this.KWPorHoraEletricidadeNRT.Width = 120;
            // 
            // TempoUso
            // 
            this.TempoUso.DataPropertyName = "TempoUso";
            this.TempoUso.HeaderText = "Tempo de Uso (em mins)";
            this.TempoUso.Name = "TempoUso";
            // 
            // RegistroGastosEletrodomesticoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvRegistros);
            this.Controls.Add(this.btnRestaurar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.pnlDia);
            this.Name = "RegistroGastosEletrodomesticoView";
            this.Text = "RegistroGastosEletrodomesticoView";
            this.pnlDia.ResumeLayout(false);
            this.pnlDia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDia;
        private System.Windows.Forms.DateTimePicker dtpDia;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Button btnTrocar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dgvRegistros;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEletrodomestico;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeNRT;
        private System.Windows.Forms.DataGridViewTextBoxColumn LitroPorHoraAguaNRT;
        private System.Windows.Forms.DataGridViewTextBoxColumn KWPorHoraEletricidadeNRT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TempoUso;
    }
}