namespace CarbonTracker.Views.Views
{
    partial class EntrarGrupoView
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
            this.btnProcurar = new System.Windows.Forms.Button();
            this.dgvEntrarGrupos = new System.Windows.Forms.DataGridView();
            this.txtProcurar = new System.Windows.Forms.TextBox();
            this.lblProcurar = new System.Windows.Forms.Label();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.IdGrupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeGrupoNRT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescricaoGrupoNRT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PresenteNRT = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrarGrupos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProcurar
            // 
            this.btnProcurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcurar.Location = new System.Drawing.Point(693, 24);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(100, 23);
            this.btnProcurar.TabIndex = 6;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            // 
            // dgvEntrarGrupos
            // 
            this.dgvEntrarGrupos.AllowUserToAddRows = false;
            this.dgvEntrarGrupos.AllowUserToDeleteRows = false;
            this.dgvEntrarGrupos.AllowUserToResizeRows = false;
            this.dgvEntrarGrupos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEntrarGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntrarGrupos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdGrupo,
            this.NomeGrupoNRT,
            this.DescricaoGrupoNRT,
            this.PresenteNRT});
            this.dgvEntrarGrupos.Location = new System.Drawing.Point(7, 52);
            this.dgvEntrarGrupos.MultiSelect = false;
            this.dgvEntrarGrupos.Name = "dgvEntrarGrupos";
            this.dgvEntrarGrupos.RowHeadersVisible = false;
            this.dgvEntrarGrupos.RowHeadersWidth = 51;
            this.dgvEntrarGrupos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEntrarGrupos.Size = new System.Drawing.Size(786, 363);
            this.dgvEntrarGrupos.TabIndex = 7;
            // 
            // txtProcurar
            // 
            this.txtProcurar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProcurar.Location = new System.Drawing.Point(7, 26);
            this.txtProcurar.Name = "txtProcurar";
            this.txtProcurar.Size = new System.Drawing.Size(680, 20);
            this.txtProcurar.TabIndex = 5;
            // 
            // lblProcurar
            // 
            this.lblProcurar.AutoSize = true;
            this.lblProcurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcurar.Location = new System.Drawing.Point(3, 3);
            this.lblProcurar.Name = "lblProcurar";
            this.lblProcurar.Size = new System.Drawing.Size(73, 20);
            this.lblProcurar.TabIndex = 4;
            this.lblProcurar.Text = "Procurar:";
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Location = new System.Drawing.Point(693, 421);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(100, 23);
            this.btnRestaurar.TabIndex = 21;
            this.btnRestaurar.Text = "Restaurar";
            this.btnRestaurar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalvar.Location = new System.Drawing.Point(7, 421);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 23);
            this.btnSalvar.TabIndex = 20;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // IdGrupo
            // 
            this.IdGrupo.DataPropertyName = "IdGrupo";
            this.IdGrupo.HeaderText = "Grupo";
            this.IdGrupo.MinimumWidth = 6;
            this.IdGrupo.Name = "IdGrupo";
            this.IdGrupo.ReadOnly = true;
            this.IdGrupo.Width = 60;
            // 
            // NomeGrupoNRT
            // 
            this.NomeGrupoNRT.DataPropertyName = "NomeGrupoNRT";
            this.NomeGrupoNRT.HeaderText = "Nome";
            this.NomeGrupoNRT.MinimumWidth = 6;
            this.NomeGrupoNRT.Name = "NomeGrupoNRT";
            this.NomeGrupoNRT.ReadOnly = true;
            this.NomeGrupoNRT.Width = 150;
            // 
            // DescricaoGrupoNRT
            // 
            this.DescricaoGrupoNRT.DataPropertyName = "DescricaoGrupoNRT";
            this.DescricaoGrupoNRT.HeaderText = "Descrição";
            this.DescricaoGrupoNRT.MinimumWidth = 6;
            this.DescricaoGrupoNRT.Name = "DescricaoGrupoNRT";
            this.DescricaoGrupoNRT.ReadOnly = true;
            this.DescricaoGrupoNRT.Width = 350;
            // 
            // PresenteNRT
            // 
            this.PresenteNRT.DataPropertyName = "PresenteNRT";
            this.PresenteNRT.HeaderText = "Presente?";
            this.PresenteNRT.Name = "PresenteNRT";
            this.PresenteNRT.Width = 75;
            // 
            // EntrarGrupoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRestaurar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.dgvEntrarGrupos);
            this.Controls.Add(this.txtProcurar);
            this.Controls.Add(this.lblProcurar);
            this.Name = "EntrarGrupoView";
            this.Text = "EntrarGrupoView";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrarGrupos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.DataGridView dgvEntrarGrupos;
        private System.Windows.Forms.TextBox txtProcurar;
        private System.Windows.Forms.Label lblProcurar;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdGrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeGrupoNRT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescricaoGrupoNRT;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PresenteNRT;
    }
}