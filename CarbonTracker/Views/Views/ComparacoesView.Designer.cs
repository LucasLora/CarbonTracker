namespace CarbonTracker.Views.Views
{
    partial class ComparacoesView
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
            this.dgvPosicaoGruposUsuarios = new System.Windows.Forms.DataGridView();
            this.IdGrupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeGrupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PosicaoGrupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPontuacao = new System.Windows.Forms.Label();
            this.txtPontuacao = new System.Windows.Forms.TextBox();
            this.lblPosicaoGruposUsuarios = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.panelComparacoes = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.gpbPredefinicoesData = new System.Windows.Forms.GroupBox();
            this.btnMensal = new System.Windows.Forms.Button();
            this.btnAnual = new System.Windows.Forms.Button();
            this.btnTrimestral = new System.Windows.Forms.Button();
            this.btnSemestral = new System.Windows.Forms.Button();
            this.btnComparar = new System.Windows.Forms.Button();
            this.lblDiaFinal = new System.Windows.Forms.Label();
            this.lblDiaInicial = new System.Windows.Forms.Label();
            this.dtpDiaFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpDiaInicial = new System.Windows.Forms.DateTimePicker();
            this.chkCompararGrupos = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosicaoGruposUsuarios)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.gpbPredefinicoesData.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPosicaoGruposUsuarios
            // 
            this.dgvPosicaoGruposUsuarios.AllowUserToAddRows = false;
            this.dgvPosicaoGruposUsuarios.AllowUserToDeleteRows = false;
            this.dgvPosicaoGruposUsuarios.AllowUserToOrderColumns = true;
            this.dgvPosicaoGruposUsuarios.AllowUserToResizeRows = false;
            this.dgvPosicaoGruposUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPosicaoGruposUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosicaoGruposUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdGrupo,
            this.NomeGrupo,
            this.PosicaoGrupo});
            this.dgvPosicaoGruposUsuarios.Location = new System.Drawing.Point(7, 199);
            this.dgvPosicaoGruposUsuarios.Name = "dgvPosicaoGruposUsuarios";
            this.dgvPosicaoGruposUsuarios.ReadOnly = true;
            this.dgvPosicaoGruposUsuarios.RowHeadersVisible = false;
            this.dgvPosicaoGruposUsuarios.RowHeadersWidth = 51;
            this.dgvPosicaoGruposUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvPosicaoGruposUsuarios.Size = new System.Drawing.Size(786, 244);
            this.dgvPosicaoGruposUsuarios.TabIndex = 11;
            this.dgvPosicaoGruposUsuarios.TabStop = false;
            // 
            // IdGrupo
            // 
            this.IdGrupo.DataPropertyName = "IdGrupo";
            this.IdGrupo.HeaderText = "Grupo";
            this.IdGrupo.MinimumWidth = 6;
            this.IdGrupo.Name = "IdGrupo";
            this.IdGrupo.ReadOnly = true;
            this.IdGrupo.Width = 125;
            // 
            // NomeGrupo
            // 
            this.NomeGrupo.DataPropertyName = "NomeGrupo";
            this.NomeGrupo.HeaderText = "Nome";
            this.NomeGrupo.MinimumWidth = 6;
            this.NomeGrupo.Name = "NomeGrupo";
            this.NomeGrupo.ReadOnly = true;
            this.NomeGrupo.Width = 125;
            // 
            // PosicaoGrupo
            // 
            this.PosicaoGrupo.DataPropertyName = "PosicaoGrupo";
            this.PosicaoGrupo.HeaderText = "Posição";
            this.PosicaoGrupo.MinimumWidth = 6;
            this.PosicaoGrupo.Name = "PosicaoGrupo";
            this.PosicaoGrupo.ReadOnly = true;
            this.PosicaoGrupo.Width = 125;
            // 
            // lblPontuacao
            // 
            this.lblPontuacao.AutoSize = true;
            this.lblPontuacao.Location = new System.Drawing.Point(4, 136);
            this.lblPontuacao.Name = "lblPontuacao";
            this.lblPontuacao.Size = new System.Drawing.Size(158, 15);
            this.lblPontuacao.TabIndex = 8;
            this.lblPontuacao.Text = "Pontuação (menor melhor):";
            // 
            // txtPontuacao
            // 
            this.txtPontuacao.Location = new System.Drawing.Point(7, 154);
            this.txtPontuacao.Name = "txtPontuacao";
            this.txtPontuacao.ReadOnly = true;
            this.txtPontuacao.Size = new System.Drawing.Size(206, 20);
            this.txtPontuacao.TabIndex = 9;
            this.txtPontuacao.TabStop = false;
            // 
            // lblPosicaoGruposUsuarios
            // 
            this.lblPosicaoGruposUsuarios.AutoSize = true;
            this.lblPosicaoGruposUsuarios.Location = new System.Drawing.Point(4, 181);
            this.lblPosicaoGruposUsuarios.Name = "lblPosicaoGruposUsuarios";
            this.lblPosicaoGruposUsuarios.Size = new System.Drawing.Size(189, 15);
            this.lblPosicaoGruposUsuarios.TabIndex = 10;
            this.lblPosicaoGruposUsuarios.Text = "Posição nos Grupos de Usuários:";
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.panelComparacoes);
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(800, 73);
            this.pnlTop.TabIndex = 0;
            // 
            // panelComparacoes
            // 
            this.panelComparacoes.BackgroundImage = global::CarbonTracker.Properties.Resources.Comparacoes;
            this.panelComparacoes.Location = new System.Drawing.Point(0, -8);
            this.panelComparacoes.Name = "panelComparacoes";
            this.panelComparacoes.Size = new System.Drawing.Size(516, 89);
            this.panelComparacoes.TabIndex = 0;
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
            // gpbPredefinicoesData
            // 
            this.gpbPredefinicoesData.Controls.Add(this.btnMensal);
            this.gpbPredefinicoesData.Controls.Add(this.btnAnual);
            this.gpbPredefinicoesData.Controls.Add(this.btnTrimestral);
            this.gpbPredefinicoesData.Controls.Add(this.btnSemestral);
            this.gpbPredefinicoesData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gpbPredefinicoesData.Location = new System.Drawing.Point(451, 81);
            this.gpbPredefinicoesData.Name = "gpbPredefinicoesData";
            this.gpbPredefinicoesData.Size = new System.Drawing.Size(328, 47);
            this.gpbPredefinicoesData.TabIndex = 7;
            this.gpbPredefinicoesData.TabStop = false;
            this.gpbPredefinicoesData.Text = "Predefinições de Intervalos de Data";
            // 
            // btnMensal
            // 
            this.btnMensal.Location = new System.Drawing.Point(6, 19);
            this.btnMensal.Name = "btnMensal";
            this.btnMensal.Size = new System.Drawing.Size(75, 23);
            this.btnMensal.TabIndex = 0;
            this.btnMensal.Text = "Mensal";
            this.btnMensal.UseVisualStyleBackColor = true;
            // 
            // btnAnual
            // 
            this.btnAnual.Location = new System.Drawing.Point(249, 19);
            this.btnAnual.Name = "btnAnual";
            this.btnAnual.Size = new System.Drawing.Size(75, 23);
            this.btnAnual.TabIndex = 3;
            this.btnAnual.Text = "Anual";
            this.btnAnual.UseVisualStyleBackColor = true;
            // 
            // btnTrimestral
            // 
            this.btnTrimestral.Location = new System.Drawing.Point(87, 19);
            this.btnTrimestral.Name = "btnTrimestral";
            this.btnTrimestral.Size = new System.Drawing.Size(75, 23);
            this.btnTrimestral.TabIndex = 1;
            this.btnTrimestral.Text = "Trimestral";
            this.btnTrimestral.UseVisualStyleBackColor = true;
            // 
            // btnSemestral
            // 
            this.btnSemestral.Location = new System.Drawing.Point(168, 19);
            this.btnSemestral.Name = "btnSemestral";
            this.btnSemestral.Size = new System.Drawing.Size(75, 23);
            this.btnSemestral.TabIndex = 2;
            this.btnSemestral.Text = "Semestral";
            this.btnSemestral.UseVisualStyleBackColor = true;
            // 
            // btnComparar
            // 
            this.btnComparar.Location = new System.Drawing.Point(229, 100);
            this.btnComparar.Name = "btnComparar";
            this.btnComparar.Size = new System.Drawing.Size(75, 23);
            this.btnComparar.TabIndex = 5;
            this.btnComparar.Text = "Comparar";
            this.btnComparar.UseVisualStyleBackColor = true;
            // 
            // lblDiaFinal
            // 
            this.lblDiaFinal.AutoSize = true;
            this.lblDiaFinal.Location = new System.Drawing.Point(115, 85);
            this.lblDiaFinal.Name = "lblDiaFinal";
            this.lblDiaFinal.Size = new System.Drawing.Size(59, 15);
            this.lblDiaFinal.TabIndex = 3;
            this.lblDiaFinal.Text = "Dia Final:";
            // 
            // lblDiaInicial
            // 
            this.lblDiaInicial.AutoSize = true;
            this.lblDiaInicial.Location = new System.Drawing.Point(4, 85);
            this.lblDiaInicial.Name = "lblDiaInicial";
            this.lblDiaInicial.Size = new System.Drawing.Size(64, 15);
            this.lblDiaInicial.TabIndex = 1;
            this.lblDiaInicial.Text = "Dia Inicial:";
            // 
            // dtpDiaFinal
            // 
            this.dtpDiaFinal.CustomFormat = "dd/MM/yyyy";
            this.dtpDiaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDiaFinal.Location = new System.Drawing.Point(118, 101);
            this.dtpDiaFinal.Name = "dtpDiaFinal";
            this.dtpDiaFinal.Size = new System.Drawing.Size(95, 20);
            this.dtpDiaFinal.TabIndex = 4;
            // 
            // dtpDiaInicial
            // 
            this.dtpDiaInicial.CustomFormat = "dd/MM/yyyy";
            this.dtpDiaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDiaInicial.Location = new System.Drawing.Point(7, 101);
            this.dtpDiaInicial.Name = "dtpDiaInicial";
            this.dtpDiaInicial.Size = new System.Drawing.Size(95, 20);
            this.dtpDiaInicial.TabIndex = 2;
            // 
            // chkCompararGrupos
            // 
            this.chkCompararGrupos.AutoSize = true;
            this.chkCompararGrupos.Location = new System.Drawing.Point(320, 103);
            this.chkCompararGrupos.Name = "chkCompararGrupos";
            this.chkCompararGrupos.Size = new System.Drawing.Size(127, 19);
            this.chkCompararGrupos.TabIndex = 6;
            this.chkCompararGrupos.Text = "Comparar Grupos";
            this.chkCompararGrupos.UseVisualStyleBackColor = true;
            // 
            // ComparacoesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkCompararGrupos);
            this.Controls.Add(this.gpbPredefinicoesData);
            this.Controls.Add(this.btnComparar);
            this.Controls.Add(this.lblDiaFinal);
            this.Controls.Add(this.lblDiaInicial);
            this.Controls.Add(this.dtpDiaFinal);
            this.Controls.Add(this.dtpDiaInicial);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.lblPosicaoGruposUsuarios);
            this.Controls.Add(this.dgvPosicaoGruposUsuarios);
            this.Controls.Add(this.lblPontuacao);
            this.Controls.Add(this.txtPontuacao);
            this.Name = "ComparacoesView";
            this.Text = "ComparacoesView";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosicaoGruposUsuarios)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.gpbPredefinicoesData.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPosicaoGruposUsuarios;
        private System.Windows.Forms.Label lblPontuacao;
        private System.Windows.Forms.TextBox txtPontuacao;
        private System.Windows.Forms.Label lblPosicaoGruposUsuarios;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox gpbPredefinicoesData;
        private System.Windows.Forms.Button btnMensal;
        private System.Windows.Forms.Button btnAnual;
        private System.Windows.Forms.Button btnTrimestral;
        private System.Windows.Forms.Button btnSemestral;
        private System.Windows.Forms.Button btnComparar;
        private System.Windows.Forms.Label lblDiaFinal;
        private System.Windows.Forms.Label lblDiaInicial;
        private System.Windows.Forms.DateTimePicker dtpDiaFinal;
        private System.Windows.Forms.DateTimePicker dtpDiaInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdGrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeGrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PosicaoGrupo;
        private System.Windows.Forms.CheckBox chkCompararGrupos;
        private System.Windows.Forms.Panel panelComparacoes;
    }
}