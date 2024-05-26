namespace CarbonTracker.Views
{
    partial class RegistroGastosView
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
            this.lblRegistroGastos = new System.Windows.Forms.Label();
            this.pnlTopRegistroGastos = new System.Windows.Forms.Panel();
            this.btnTransporte = new System.Windows.Forms.Button();
            this.btnEletrodomesticos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbcRegistroGastos = new System.Windows.Forms.TabControl();
            this.tbpEletrodomestico = new System.Windows.Forms.TabPage();
            this.tbpTransporte = new System.Windows.Forms.TabPage();
            this.pnlTopRegistroGastos.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tbcRegistroGastos.SuspendLayout();
            this.SuspendLayout();
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
            // lblRegistroGastos
            // 
            this.lblRegistroGastos.AutoSize = true;
            this.lblRegistroGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroGastos.Location = new System.Drawing.Point(12, 19);
            this.lblRegistroGastos.Name = "lblRegistroGastos";
            this.lblRegistroGastos.Size = new System.Drawing.Size(265, 31);
            this.lblRegistroGastos.TabIndex = 0;
            this.lblRegistroGastos.Text = "Registro de Gastos";
            // 
            // pnlTopRegistroGastos
            // 
            this.pnlTopRegistroGastos.BackColor = System.Drawing.Color.White;
            this.pnlTopRegistroGastos.Controls.Add(this.btnClose);
            this.pnlTopRegistroGastos.Controls.Add(this.lblRegistroGastos);
            this.pnlTopRegistroGastos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopRegistroGastos.Location = new System.Drawing.Point(0, 0);
            this.pnlTopRegistroGastos.Name = "pnlTopRegistroGastos";
            this.pnlTopRegistroGastos.Size = new System.Drawing.Size(800, 73);
            this.pnlTopRegistroGastos.TabIndex = 2;
            // 
            // btnTransporte
            // 
            this.btnTransporte.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTransporte.Location = new System.Drawing.Point(0, 56);
            this.btnTransporte.Name = "btnTransporte";
            this.btnTransporte.Size = new System.Drawing.Size(120, 55);
            this.btnTransporte.TabIndex = 6;
            this.btnTransporte.Text = "Transportes";
            this.btnTransporte.UseVisualStyleBackColor = true;
            // 
            // btnEletrodomesticos
            // 
            this.btnEletrodomesticos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEletrodomesticos.Location = new System.Drawing.Point(0, 3);
            this.btnEletrodomesticos.Name = "btnEletrodomesticos";
            this.btnEletrodomesticos.Size = new System.Drawing.Size(120, 55);
            this.btnEletrodomesticos.TabIndex = 5;
            this.btnEletrodomesticos.Text = "Eletrodomésticos";
            this.btnEletrodomesticos.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEletrodomesticos);
            this.panel1.Controls.Add(this.btnTransporte);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 377);
            this.panel1.TabIndex = 8;
            // 
            // tbcRegistroGastos
            // 
            this.tbcRegistroGastos.Controls.Add(this.tbpEletrodomestico);
            this.tbcRegistroGastos.Controls.Add(this.tbpTransporte);
            this.tbcRegistroGastos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcRegistroGastos.Location = new System.Drawing.Point(120, 73);
            this.tbcRegistroGastos.Name = "tbcRegistroGastos";
            this.tbcRegistroGastos.SelectedIndex = 0;
            this.tbcRegistroGastos.Size = new System.Drawing.Size(680, 377);
            this.tbcRegistroGastos.TabIndex = 9;
            // 
            // tbpEletrodomestico
            // 
            this.tbpEletrodomestico.Location = new System.Drawing.Point(4, 22);
            this.tbpEletrodomestico.Name = "tbpEletrodomestico";
            this.tbpEletrodomestico.Padding = new System.Windows.Forms.Padding(3);
            this.tbpEletrodomestico.Size = new System.Drawing.Size(672, 351);
            this.tbpEletrodomestico.TabIndex = 0;
            this.tbpEletrodomestico.Text = "Eletrodoméstico";
            this.tbpEletrodomestico.UseVisualStyleBackColor = true;
            // 
            // tbpTransporte
            // 
            this.tbpTransporte.Location = new System.Drawing.Point(4, 22);
            this.tbpTransporte.Name = "tbpTransporte";
            this.tbpTransporte.Padding = new System.Windows.Forms.Padding(3);
            this.tbpTransporte.Size = new System.Drawing.Size(672, 351);
            this.tbpTransporte.TabIndex = 1;
            this.tbpTransporte.Text = "Transporte";
            this.tbpTransporte.UseVisualStyleBackColor = true;
            // 
            // RegistroGastosView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbcRegistroGastos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTopRegistroGastos);
            this.Name = "RegistroGastosView";
            this.Text = "RegistroGastos";
            this.pnlTopRegistroGastos.ResumeLayout(false);
            this.pnlTopRegistroGastos.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tbcRegistroGastos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRegistroGastos;
        private System.Windows.Forms.Panel pnlTopRegistroGastos;
        private System.Windows.Forms.Button btnTransporte;
        private System.Windows.Forms.Button btnEletrodomesticos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tbcRegistroGastos;
        private System.Windows.Forms.TabPage tbpEletrodomestico;
        private System.Windows.Forms.TabPage tbpTransporte;
    }
}