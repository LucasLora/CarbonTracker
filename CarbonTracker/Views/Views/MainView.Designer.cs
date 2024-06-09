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
            this.panelLogoMain = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnComparacoes = new System.Windows.Forms.Button();
            this.btnRegistroGastos = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnCadastrosGastos = new System.Windows.Forms.Button();
            this.pnlProgramas.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlProgramas
            // 
            this.pnlProgramas.Controls.Add(this.panelLogoMain);
            this.pnlProgramas.Controls.Add(this.btnClose);
            this.pnlProgramas.Controls.Add(this.btnComparacoes);
            this.pnlProgramas.Controls.Add(this.btnRegistroGastos);
            this.pnlProgramas.Controls.Add(this.btnUsuarios);
            this.pnlProgramas.Controls.Add(this.btnCadastrosGastos);
            this.pnlProgramas.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlProgramas.Location = new System.Drawing.Point(0, 0);
            this.pnlProgramas.Name = "pnlProgramas";
            this.pnlProgramas.Size = new System.Drawing.Size(200, 681);
            this.pnlProgramas.TabIndex = 0;
            // 
            // panelLogoMain
            // 
            this.panelLogoMain.BackgroundImage = global::CarbonTracker.Properties.Resources.Carbon_TrackerLogo;
            this.panelLogoMain.Location = new System.Drawing.Point(23, 3);
            this.panelLogoMain.Name = "panelLogoMain";
            this.panelLogoMain.Size = new System.Drawing.Size(151, 88);
            this.panelLogoMain.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(0, 626);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(200, 55);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Sair";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnComparacoes
            // 
            this.btnComparacoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnComparacoes.Location = new System.Drawing.Point(0, 253);
            this.btnComparacoes.Name = "btnComparacoes";
            this.btnComparacoes.Size = new System.Drawing.Size(200, 55);
            this.btnComparacoes.TabIndex = 4;
            this.btnComparacoes.Text = "Comparações";
            this.btnComparacoes.UseVisualStyleBackColor = true;
            // 
            // btnRegistroGastos
            // 
            this.btnRegistroGastos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistroGastos.Location = new System.Drawing.Point(0, 200);
            this.btnRegistroGastos.Name = "btnRegistroGastos";
            this.btnRegistroGastos.Size = new System.Drawing.Size(200, 55);
            this.btnRegistroGastos.TabIndex = 3;
            this.btnRegistroGastos.Text = "Registro de Gastos";
            this.btnRegistroGastos.UseVisualStyleBackColor = true;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUsuarios.Location = new System.Drawing.Point(0, 94);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(200, 55);
            this.btnUsuarios.TabIndex = 1;
            this.btnUsuarios.Text = "Informações de Usuários";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            // 
            // btnCadastrosGastos
            // 
            this.btnCadastrosGastos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastrosGastos.Location = new System.Drawing.Point(0, 147);
            this.btnCadastrosGastos.Name = "btnCadastrosGastos";
            this.btnCadastrosGastos.Size = new System.Drawing.Size(200, 55);
            this.btnCadastrosGastos.TabIndex = 2;
            this.btnCadastrosGastos.Text = "Cadastros de Gastos";
            this.btnCadastrosGastos.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pnlProgramas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carbon Tracker";
            this.pnlProgramas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlProgramas;
        private System.Windows.Forms.Button btnCadastrosGastos;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnComparacoes;
        private System.Windows.Forms.Button btnRegistroGastos;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelLogoMain;
    }
}