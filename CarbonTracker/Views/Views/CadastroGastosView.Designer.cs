namespace CarbonTracker.Views
{
    partial class CadastroGastosView
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lblCadastroGastos = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEletrodomestico = new System.Windows.Forms.Button();
            this.btnTransporte = new System.Windows.Forms.Button();
            this.tbcRegistroGastos = new System.Windows.Forms.TabControl();
            this.tbpEletrodomestico = new System.Windows.Forms.TabPage();
            this.tbpTransporte = new System.Windows.Forms.TabPage();
            this.pnlTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tbcRegistroGastos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1029, 4);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(33, 31);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lblCadastroGastos
            // 
            this.lblCadastroGastos.AutoSize = true;
            this.lblCadastroGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroGastos.Location = new System.Drawing.Point(16, 26);
            this.lblCadastroGastos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCadastroGastos.Name = "lblCadastroGastos";
            this.lblCadastroGastos.Size = new System.Drawing.Size(336, 39);
            this.lblCadastroGastos.TabIndex = 0;
            this.lblCadastroGastos.Text = "Cadastro de Gastos";
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Controls.Add(this.lblCadastroGastos);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1067, 90);
            this.pnlTop.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEletrodomestico);
            this.panel1.Controls.Add(this.btnTransporte);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 90);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 464);
            this.panel1.TabIndex = 13;
            // 
            // btnEletrodomestico
            // 
            this.btnEletrodomestico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEletrodomestico.Location = new System.Drawing.Point(0, 3);
            this.btnEletrodomestico.Margin = new System.Windows.Forms.Padding(4);
            this.btnEletrodomestico.Name = "btnEletrodomestico";
            this.btnEletrodomestico.Size = new System.Drawing.Size(160, 68);
            this.btnEletrodomestico.TabIndex = 5;
            this.btnEletrodomestico.Text = "Eletrodomésticos";
            this.btnEletrodomestico.UseVisualStyleBackColor = true;
            // 
            // btnTransporte
            // 
            this.btnTransporte.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTransporte.Location = new System.Drawing.Point(0, 68);
            this.btnTransporte.Margin = new System.Windows.Forms.Padding(4);
            this.btnTransporte.Name = "btnTransporte";
            this.btnTransporte.Size = new System.Drawing.Size(160, 68);
            this.btnTransporte.TabIndex = 6;
            this.btnTransporte.Text = "Transportes";
            this.btnTransporte.UseVisualStyleBackColor = true;
            // 
            // tbcRegistroGastos
            // 
            this.tbcRegistroGastos.Controls.Add(this.tbpEletrodomestico);
            this.tbcRegistroGastos.Controls.Add(this.tbpTransporte);
            this.tbcRegistroGastos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcRegistroGastos.Location = new System.Drawing.Point(160, 90);
            this.tbcRegistroGastos.Margin = new System.Windows.Forms.Padding(4);
            this.tbcRegistroGastos.Name = "tbcRegistroGastos";
            this.tbcRegistroGastos.SelectedIndex = 0;
            this.tbcRegistroGastos.Size = new System.Drawing.Size(907, 464);
            this.tbcRegistroGastos.TabIndex = 14;
            // 
            // tbpEletrodomestico
            // 
            this.tbpEletrodomestico.Location = new System.Drawing.Point(4, 25);
            this.tbpEletrodomestico.Margin = new System.Windows.Forms.Padding(4);
            this.tbpEletrodomestico.Name = "tbpEletrodomestico";
            this.tbpEletrodomestico.Padding = new System.Windows.Forms.Padding(4);
            this.tbpEletrodomestico.Size = new System.Drawing.Size(899, 435);
            this.tbpEletrodomestico.TabIndex = 0;
            this.tbpEletrodomestico.Text = "Eletrodoméstico";
            this.tbpEletrodomestico.UseVisualStyleBackColor = true;
            // 
            // tbpTransporte
            // 
            this.tbpTransporte.Location = new System.Drawing.Point(4, 25);
            this.tbpTransporte.Margin = new System.Windows.Forms.Padding(4);
            this.tbpTransporte.Name = "tbpTransporte";
            this.tbpTransporte.Padding = new System.Windows.Forms.Padding(4);
            this.tbpTransporte.Size = new System.Drawing.Size(899, 435);
            this.tbpTransporte.TabIndex = 1;
            this.tbpTransporte.Text = "Transporte";
            this.tbpTransporte.UseVisualStyleBackColor = true;
            // 
            // CadastroGastosView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tbcRegistroGastos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CadastroGastosView";
            this.Text = "PreCadastro";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tbcRegistroGastos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblCadastroGastos;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEletrodomestico;
        private System.Windows.Forms.Button btnTransporte;
        private System.Windows.Forms.TabControl tbcRegistroGastos;
        private System.Windows.Forms.TabPage tbpEletrodomestico;
        private System.Windows.Forms.TabPage tbpTransporte;
    }
}