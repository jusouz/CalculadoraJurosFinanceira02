namespace CalculadoraJurosFinanceira02
{
    partial class CalculadoraJuros
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CalcularJurosButton = new System.Windows.Forms.Button();
            this.txtPrincipal = new System.Windows.Forms.TextBox();
            this.lblPrincipal = new System.Windows.Forms.Label();
            this.lblTaxaJuros = new System.Windows.Forms.Label();
            this.txtTaxaJuros = new System.Windows.Forms.TextBox();
            this.lblNumeroParcelas = new System.Windows.Forms.Label();
            this.txtNumeroParcelas = new System.Windows.Forms.TextBox();
            this.lblValorParcela = new System.Windows.Forms.Label();
            this.lblTotalJuros = new System.Windows.Forms.Label();
            this.lblTotalPago = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // CalcularJurosButton
            // 
            this.CalcularJurosButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CalcularJurosButton.Location = new System.Drawing.Point(292, 298);
            this.CalcularJurosButton.Name = "CalcularJurosButton";
            this.CalcularJurosButton.Size = new System.Drawing.Size(121, 23);
            this.CalcularJurosButton.TabIndex = 0;
            this.CalcularJurosButton.Text = "Calcular Juros";
            this.CalcularJurosButton.UseVisualStyleBackColor = true;
            this.CalcularJurosButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPrincipal
            // 
            this.txtPrincipal.Location = new System.Drawing.Point(292, 101);
            this.txtPrincipal.Name = "txtPrincipal";
            this.txtPrincipal.Size = new System.Drawing.Size(100, 23);
            this.txtPrincipal.TabIndex = 1;
            // 
            // lblPrincipal
            // 
            this.lblPrincipal.AutoSize = true;
            this.lblPrincipal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrincipal.Location = new System.Drawing.Point(292, 77);
            this.lblPrincipal.Name = "lblPrincipal";
            this.lblPrincipal.Size = new System.Drawing.Size(78, 21);
            this.lblPrincipal.TabIndex = 2;
            this.lblPrincipal.Text = "Principal";
            // 
            // lblTaxaJuros
            // 
            this.lblTaxaJuros.AutoSize = true;
            this.lblTaxaJuros.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTaxaJuros.Location = new System.Drawing.Point(292, 142);
            this.lblTaxaJuros.Name = "lblTaxaJuros";
            this.lblTaxaJuros.Size = new System.Drawing.Size(112, 21);
            this.lblTaxaJuros.TabIndex = 4;
            this.lblTaxaJuros.Text = "Taxa de Juros";
            // 
            // txtTaxaJuros
            // 
            this.txtTaxaJuros.Location = new System.Drawing.Point(292, 171);
            this.txtTaxaJuros.Name = "txtTaxaJuros";
            this.txtTaxaJuros.Size = new System.Drawing.Size(100, 23);
            this.txtTaxaJuros.TabIndex = 3;
            // 
            // lblNumeroParcelas
            // 
            this.lblNumeroParcelas.AutoSize = true;
            this.lblNumeroParcelas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumeroParcelas.Location = new System.Drawing.Point(292, 217);
            this.lblNumeroParcelas.Name = "lblNumeroParcelas";
            this.lblNumeroParcelas.Size = new System.Drawing.Size(163, 21);
            this.lblNumeroParcelas.TabIndex = 6;
            this.lblNumeroParcelas.Text = "Numero de Parcelas";
            // 
            // txtNumeroParcelas
            // 
            this.txtNumeroParcelas.Location = new System.Drawing.Point(292, 244);
            this.txtNumeroParcelas.Name = "txtNumeroParcelas";
            this.txtNumeroParcelas.Size = new System.Drawing.Size(100, 23);
            this.txtNumeroParcelas.TabIndex = 5;
            // 
            // lblValorParcela
            // 
            this.lblValorParcela.AutoSize = true;
            this.lblValorParcela.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValorParcela.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblValorParcela.Location = new System.Drawing.Point(292, 332);
            this.lblValorParcela.Name = "lblValorParcela";
            this.lblValorParcela.Size = new System.Drawing.Size(0, 17);
            this.lblValorParcela.TabIndex = 7;
            // 
            // lblTotalJuros
            // 
            this.lblTotalJuros.AutoSize = true;
            this.lblTotalJuros.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalJuros.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTotalJuros.Location = new System.Drawing.Point(292, 349);
            this.lblTotalJuros.Name = "lblTotalJuros";
            this.lblTotalJuros.Size = new System.Drawing.Size(0, 17);
            this.lblTotalJuros.TabIndex = 8;
            // 
            // lblTotalPago
            // 
            this.lblTotalPago.AutoSize = true;
            this.lblTotalPago.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalPago.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTotalPago.Location = new System.Drawing.Point(246, 361);
            this.lblTotalPago.Name = "lblTotalPago";
            this.lblTotalPago.Size = new System.Drawing.Size(0, 17);
            this.lblTotalPago.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(484, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 456);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(221, 449);
            this.panel2.TabIndex = 11;
            // 
            // CalculadoraJuros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTotalPago);
            this.Controls.Add(this.lblTotalJuros);
            this.Controls.Add(this.lblValorParcela);
            this.Controls.Add(this.lblNumeroParcelas);
            this.Controls.Add(this.txtNumeroParcelas);
            this.Controls.Add(this.lblTaxaJuros);
            this.Controls.Add(this.txtTaxaJuros);
            this.Controls.Add(this.lblPrincipal);
            this.Controls.Add(this.txtPrincipal);
            this.Controls.Add(this.CalcularJurosButton);
            this.Name = "CalculadoraJuros";
            this.Text = "CalculadoraJurosFinanceiro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button CalcularJurosButton;
        private TextBox txtPrincipal;
        private Label lblPrincipal;
        private Label lblTaxaJuros;
        private TextBox txtTaxaJuros;
        private Label lblNumeroParcelas;
        private TextBox txtNumeroParcelas;
        private Label lblValorParcela;
        private Label lblTotalJuros;
        private Label lblTotalPago;
        private Panel panel1;
        private Panel panel2;
    }
}