namespace CarbonTracker.Views
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.pnlProgramas = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnComparacoes = new System.Windows.Forms.Button();
            this.btnRegistroGastos = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.lblTracker = new System.Windows.Forms.Label();
            this.lblCarbon = new System.Windows.Forms.Label();
            this.btnCadastrosGastos = new System.Windows.Forms.Button();
            this.pnlProgramas.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlProgramas
            // 
            this.pnlProgramas.Controls.Add(this.btnClose);
            this.pnlProgramas.Controls.Add(this.btnComparacoes);
            this.pnlProgramas.Controls.Add(this.btnRegistroGastos);
            this.pnlProgramas.Controls.Add(this.btnUsuarios);
            this.pnlProgramas.Controls.Add(this.lblTracker);
            this.pnlProgramas.Controls.Add(this.lblCarbon);
            this.pnlProgramas.Controls.Add(this.btnCadastrosGastos);
            this.pnlProgramas.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlProgramas.Location = new System.Drawing.Point(0, 0);
            this.pnlProgramas.Name = "pnlProgramas";
            this.pnlProgramas.Size = new System.Drawing.Size(200, 450);
            this.pnlProgramas.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(0, 395);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(200, 55);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Sair";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnComparacoes
            // 
            this.btnComparacoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnComparacoes.Location = new System.Drawing.Point(0, 237);
            this.btnComparacoes.Name = "btnComparacoes";
            this.btnComparacoes.Size = new System.Drawing.Size(200, 55);
            this.btnComparacoes.TabIndex = 6;
            this.btnComparacoes.Text = "Comparações";
            this.btnComparacoes.UseVisualStyleBackColor = true;
            // 
            // btnRegistroGastos
            // 
            this.btnRegistroGastos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistroGastos.Location = new System.Drawing.Point(0, 184);
            this.btnRegistroGastos.Name = "btnRegistroGastos";
            this.btnRegistroGastos.Size = new System.Drawing.Size(200, 55);
            this.btnRegistroGastos.TabIndex = 5;
            this.btnRegistroGastos.Text = "Registro de Gastos";
            this.btnRegistroGastos.UseVisualStyleBackColor = true;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUsuarios.Location = new System.Drawing.Point(0, 77);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(200, 55);
            this.btnUsuarios.TabIndex = 2;
            this.btnUsuarios.Text = "Informações de Usuários";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            // 
            // lblTracker
            // 
            this.lblTracker.AutoSize = true;
            this.lblTracker.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTracker.Location = new System.Drawing.Point(39, 37);
            this.lblTracker.Name = "lblTracker";
            this.lblTracker.Size = new System.Drawing.Size(133, 37);
            this.lblTracker.TabIndex = 1;
            this.lblTracker.Text = "Tracker";
            // 
            // lblCarbon
            // 
            this.lblCarbon.AutoSize = true;
            this.lblCarbon.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarbon.Location = new System.Drawing.Point(41, 6);
            this.lblCarbon.Name = "lblCarbon";
            this.lblCarbon.Size = new System.Drawing.Size(129, 37);
            this.lblCarbon.TabIndex = 0;
            this.lblCarbon.Text = "Carbon";
            // 
            // btnCadastrosGastos
            // 
            this.btnCadastrosGastos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastrosGastos.Location = new System.Drawing.Point(0, 131);
            this.btnCadastrosGastos.Name = "btnCadastrosGastos";
            this.btnCadastrosGastos.Size = new System.Drawing.Size(200, 55);
            this.btnCadastrosGastos.TabIndex = 4;
            this.btnCadastrosGastos.Text = "Cadastros de Gastos";
            this.btnCadastrosGastos.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.pnlProgramas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(1016, 487);
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carbon Tracker";
            this.pnlProgramas.ResumeLayout(false);
            this.pnlProgramas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlProgramas;
        private System.Windows.Forms.Label lblTracker;
        private System.Windows.Forms.Label lblCarbon;
        private System.Windows.Forms.Button btnCadastrosGastos;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnComparacoes;
        private System.Windows.Forms.Button btnRegistroGastos;
        private System.Windows.Forms.Button btnClose;
    }
}