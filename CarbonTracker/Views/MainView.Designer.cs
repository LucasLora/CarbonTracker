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
            this.pnlProgramas = new System.Windows.Forms.Panel();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnTransportes = new System.Windows.Forms.Button();
            this.lblTracker = new System.Windows.Forms.Label();
            this.lblCarbon = new System.Windows.Forms.Label();
            this.btnEletrodomesticos = new System.Windows.Forms.Button();
            this.btnGrupoUsuarios = new System.Windows.Forms.Button();
            this.btnRegistroGastos = new System.Windows.Forms.Button();
            this.btnComparacoes = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.pnlProgramas.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlProgramas
            // 
            this.pnlProgramas.Controls.Add(this.btnLogOut);
            this.pnlProgramas.Controls.Add(this.btnComparacoes);
            this.pnlProgramas.Controls.Add(this.btnRegistroGastos);
            this.pnlProgramas.Controls.Add(this.btnGrupoUsuarios);
            this.pnlProgramas.Controls.Add(this.btnUsuarios);
            this.pnlProgramas.Controls.Add(this.btnTransportes);
            this.pnlProgramas.Controls.Add(this.lblTracker);
            this.pnlProgramas.Controls.Add(this.lblCarbon);
            this.pnlProgramas.Controls.Add(this.btnEletrodomesticos);
            this.pnlProgramas.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlProgramas.Location = new System.Drawing.Point(0, 0);
            this.pnlProgramas.Name = "pnlProgramas";
            this.pnlProgramas.Size = new System.Drawing.Size(200, 450);
            this.pnlProgramas.TabIndex = 0;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Location = new System.Drawing.Point(0, 77);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(200, 55);
            this.btnUsuarios.TabIndex = 4;
            this.btnUsuarios.Text = "Cadastro de Usuários";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            // 
            // btnTransportes
            // 
            this.btnTransportes.Location = new System.Drawing.Point(0, 236);
            this.btnTransportes.Name = "btnTransportes";
            this.btnTransportes.Size = new System.Drawing.Size(200, 55);
            this.btnTransportes.TabIndex = 3;
            this.btnTransportes.Text = "Pré Cadastro de Transportes";
            this.btnTransportes.UseVisualStyleBackColor = true;
            // 
            // lblTracker
            // 
            this.lblTracker.AutoSize = true;
            this.lblTracker.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTracker.Location = new System.Drawing.Point(54, 40);
            this.lblTracker.Name = "lblTracker";
            this.lblTracker.Size = new System.Drawing.Size(91, 26);
            this.lblTracker.TabIndex = 2;
            this.lblTracker.Text = "Tracker";
            // 
            // lblCarbon
            // 
            this.lblCarbon.AutoSize = true;
            this.lblCarbon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarbon.Location = new System.Drawing.Point(56, 12);
            this.lblCarbon.Name = "lblCarbon";
            this.lblCarbon.Size = new System.Drawing.Size(89, 26);
            this.lblCarbon.TabIndex = 1;
            this.lblCarbon.Text = "Carbon";
            // 
            // btnEletrodomesticos
            // 
            this.btnEletrodomesticos.Location = new System.Drawing.Point(0, 183);
            this.btnEletrodomesticos.Name = "btnEletrodomesticos";
            this.btnEletrodomesticos.Size = new System.Drawing.Size(200, 55);
            this.btnEletrodomesticos.TabIndex = 1;
            this.btnEletrodomesticos.Text = "Pré Cadastro de Eletrodomésticos";
            this.btnEletrodomesticos.UseVisualStyleBackColor = true;
            // 
            // btnGrupoUsuarios
            // 
            this.btnGrupoUsuarios.Location = new System.Drawing.Point(0, 130);
            this.btnGrupoUsuarios.Name = "btnGrupoUsuarios";
            this.btnGrupoUsuarios.Size = new System.Drawing.Size(200, 55);
            this.btnGrupoUsuarios.TabIndex = 5;
            this.btnGrupoUsuarios.Text = "Cadastro de Grupo de Usuários";
            this.btnGrupoUsuarios.UseVisualStyleBackColor = true;
            // 
            // btnRegistroGastos
            // 
            this.btnRegistroGastos.Location = new System.Drawing.Point(0, 289);
            this.btnRegistroGastos.Name = "btnRegistroGastos";
            this.btnRegistroGastos.Size = new System.Drawing.Size(200, 55);
            this.btnRegistroGastos.TabIndex = 6;
            this.btnRegistroGastos.Text = "Registro de Gastos";
            this.btnRegistroGastos.UseVisualStyleBackColor = true;
            // 
            // btnComparacoes
            // 
            this.btnComparacoes.Location = new System.Drawing.Point(0, 342);
            this.btnComparacoes.Name = "btnComparacoes";
            this.btnComparacoes.Size = new System.Drawing.Size(200, 55);
            this.btnComparacoes.TabIndex = 7;
            this.btnComparacoes.Text = "Visualizar Comparações";
            this.btnComparacoes.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(0, 395);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(200, 55);
            this.btnLogOut.TabIndex = 8;
            this.btnLogOut.Text = "Sair da Conta";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.pnlProgramas);
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(1016, 489);
            this.Name = "MainView";
            this.Text = "Carbon Tracker";
            this.pnlProgramas.ResumeLayout(false);
            this.pnlProgramas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlProgramas;
        private System.Windows.Forms.Label lblTracker;
        private System.Windows.Forms.Label lblCarbon;
        private System.Windows.Forms.Button btnEletrodomesticos;
        private System.Windows.Forms.Button btnTransportes;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnGrupoUsuarios;
        private System.Windows.Forms.Button btnComparacoes;
        private System.Windows.Forms.Button btnRegistroGastos;
        private System.Windows.Forms.Button btnLogOut;
    }
}