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
            this.tbcGrupoUsuarios = new System.Windows.Forms.TabControl();
            this.tbpListagemEntrarGrupo = new System.Windows.Forms.TabPage();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.dgvEntrarGrupos = new System.Windows.Forms.DataGridView();
            this.txtProcurar = new System.Windows.Forms.TextBox();
            this.lblProcurar = new System.Windows.Forms.Label();
            this.IdGrupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeGrupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescricaoGrupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntrarSairGrupo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tbcGrupoUsuarios.SuspendLayout();
            this.tbpListagemEntrarGrupo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrarGrupos)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcGrupoUsuarios
            // 
            this.tbcGrupoUsuarios.Controls.Add(this.tbpListagemEntrarGrupo);
            this.tbcGrupoUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcGrupoUsuarios.Location = new System.Drawing.Point(0, 0);
            this.tbcGrupoUsuarios.Name = "tbcGrupoUsuarios";
            this.tbcGrupoUsuarios.SelectedIndex = 0;
            this.tbcGrupoUsuarios.Size = new System.Drawing.Size(800, 450);
            this.tbcGrupoUsuarios.TabIndex = 4;
            // 
            // tbpListagemEntrarGrupo
            // 
            this.tbpListagemEntrarGrupo.Controls.Add(this.btnProcurar);
            this.tbpListagemEntrarGrupo.Controls.Add(this.dgvEntrarGrupos);
            this.tbpListagemEntrarGrupo.Controls.Add(this.txtProcurar);
            this.tbpListagemEntrarGrupo.Controls.Add(this.lblProcurar);
            this.tbpListagemEntrarGrupo.Location = new System.Drawing.Point(4, 22);
            this.tbpListagemEntrarGrupo.Name = "tbpListagemEntrarGrupo";
            this.tbpListagemEntrarGrupo.Padding = new System.Windows.Forms.Padding(3);
            this.tbpListagemEntrarGrupo.Size = new System.Drawing.Size(792, 424);
            this.tbpListagemEntrarGrupo.TabIndex = 0;
            this.tbpListagemEntrarGrupo.Text = "Listagem de Grupos";
            this.tbpListagemEntrarGrupo.UseVisualStyleBackColor = true;
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
            this.NomeGrupo,
            this.DescricaoGrupo,
            this.EntrarSairGrupo});
            this.dgvEntrarGrupos.Location = new System.Drawing.Point(7, 52);
            this.dgvEntrarGrupos.MultiSelect = false;
            this.dgvEntrarGrupos.Name = "dgvEntrarGrupos";
            this.dgvEntrarGrupos.ReadOnly = true;
            this.dgvEntrarGrupos.RowHeadersVisible = false;
            this.dgvEntrarGrupos.RowHeadersWidth = 51;
            this.dgvEntrarGrupos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEntrarGrupos.Size = new System.Drawing.Size(777, 367);
            this.dgvEntrarGrupos.TabIndex = 3;
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
            // IdGrupo
            // 
            this.IdGrupo.DataPropertyName = "IdGrupo";
            this.IdGrupo.HeaderText = "Grupo";
            this.IdGrupo.MinimumWidth = 6;
            this.IdGrupo.Name = "IdGrupo";
            this.IdGrupo.ReadOnly = true;
            this.IdGrupo.Width = 75;
            // 
            // NomeGrupo
            // 
            this.NomeGrupo.DataPropertyName = "NomeGrupo";
            this.NomeGrupo.HeaderText = "Nome";
            this.NomeGrupo.MinimumWidth = 6;
            this.NomeGrupo.Name = "NomeGrupo";
            this.NomeGrupo.ReadOnly = true;
            this.NomeGrupo.Width = 200;
            // 
            // DescricaoGrupo
            // 
            this.DescricaoGrupo.DataPropertyName = "DescricaoGrupo";
            this.DescricaoGrupo.HeaderText = "Descrição";
            this.DescricaoGrupo.MinimumWidth = 6;
            this.DescricaoGrupo.Name = "DescricaoGrupo";
            this.DescricaoGrupo.ReadOnly = true;
            this.DescricaoGrupo.Width = 350;
            // 
            // EntrarSairGrupo
            // 
            this.EntrarSairGrupo.HeaderText = "Entrar/Sair";
            this.EntrarSairGrupo.Name = "EntrarSairGrupo";
            this.EntrarSairGrupo.ReadOnly = true;
            // 
            // EntrarGrupoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbcGrupoUsuarios);
            this.Name = "EntrarGrupoView";
            this.Text = "EntrarGrupoView";
            this.tbcGrupoUsuarios.ResumeLayout(false);
            this.tbpListagemEntrarGrupo.ResumeLayout(false);
            this.tbpListagemEntrarGrupo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrarGrupos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcGrupoUsuarios;
        private System.Windows.Forms.TabPage tbpListagemEntrarGrupo;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.DataGridView dgvEntrarGrupos;
        private System.Windows.Forms.TextBox txtProcurar;
        private System.Windows.Forms.Label lblProcurar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdGrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeGrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescricaoGrupo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EntrarSairGrupo;
    }
}