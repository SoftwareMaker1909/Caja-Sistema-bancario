namespace Caja_Sistema_bancario
{
    partial class Deposito
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
            this.BuscarBTN = new System.Windows.Forms.Button();
            this.DepositarBTN = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ApellidoTxT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.NombreTXT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.NcuentaTXT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MontoTXT = new System.Windows.Forms.TextBox();
            this.ConceptoTxT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BuscarBTN
            // 
            this.BuscarBTN.Location = new System.Drawing.Point(453, 206);
            this.BuscarBTN.Name = "BuscarBTN";
            this.BuscarBTN.Size = new System.Drawing.Size(75, 23);
            this.BuscarBTN.TabIndex = 34;
            this.BuscarBTN.Text = "Buscar";
            this.BuscarBTN.UseVisualStyleBackColor = true;
            // 
            // DepositarBTN
            // 
            this.DepositarBTN.Location = new System.Drawing.Point(429, 362);
            this.DepositarBTN.Name = "DepositarBTN";
            this.DepositarBTN.Size = new System.Drawing.Size(126, 58);
            this.DepositarBTN.TabIndex = 33;
            this.DepositarBTN.Text = "Depositar";
            this.DepositarBTN.UseVisualStyleBackColor = true;
            this.DepositarBTN.Click += new System.EventHandler(this.DepositarBTN_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(693, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 32;
            this.label6.Text = "Apellido";
            // 
            // ApellidoTxT
            // 
            this.ApellidoTxT.Location = new System.Drawing.Point(642, 161);
            this.ApellidoTxT.Name = "ApellidoTxT";
            this.ApellidoTxT.Size = new System.Drawing.Size(172, 22);
            this.ApellidoTxT.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(460, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 30;
            this.label7.Text = "Nombre";
            // 
            // NombreTXT
            // 
            this.NombreTXT.Location = new System.Drawing.Point(409, 161);
            this.NombreTXT.Name = "NombreTXT";
            this.NombreTXT.Size = new System.Drawing.Size(172, 22);
            this.NombreTXT.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(218, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 16);
            this.label8.TabIndex = 28;
            this.label8.Text = "N. de Cuenta";
            // 
            // NcuentaTXT
            // 
            this.NcuentaTXT.Location = new System.Drawing.Point(176, 161);
            this.NcuentaTXT.Name = "NcuentaTXT";
            this.NcuentaTXT.Size = new System.Drawing.Size(172, 22);
            this.NcuentaTXT.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(479, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Monto";
            // 
            // MontoTXT
            // 
            this.MontoTXT.Location = new System.Drawing.Point(442, 71);
            this.MontoTXT.Multiline = true;
            this.MontoTXT.Name = "MontoTXT";
            this.MontoTXT.Size = new System.Drawing.Size(113, 38);
            this.MontoTXT.TabIndex = 23;
            this.MontoTXT.TextChanged += new System.EventHandler(this.MontoTXT_TextChanged);
            // 
            // ConceptoTxT
            // 
            this.ConceptoTxT.Location = new System.Drawing.Point(354, 286);
            this.ConceptoTxT.Name = "ConceptoTxT";
            this.ConceptoTxT.Size = new System.Drawing.Size(290, 22);
            this.ConceptoTxT.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(460, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "Concepto";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(809, 441);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(131, 50);
            this.button9.TabIndex = 37;
            this.button9.Text = "Cerrar";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // Deposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 503);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConceptoTxT);
            this.Controls.Add(this.BuscarBTN);
            this.Controls.Add(this.DepositarBTN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ApellidoTxT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NombreTXT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.NcuentaTXT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MontoTXT);
            this.Name = "Deposito";
            this.Text = "Deposito";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BuscarBTN;
        private System.Windows.Forms.Button DepositarBTN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ApellidoTxT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NombreTXT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox NcuentaTXT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MontoTXT;
        private System.Windows.Forms.TextBox ConceptoTxT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button9;
    }
}