namespace Capitulo._4.Programa._1
{
    partial class Tela
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
            this.milhasIniciaisLabel = new System.Windows.Forms.Label();
            this.milhasFinaisLabel = new System.Windows.Forms.Label();
            this.reembolsoLabel = new System.Windows.Forms.Label();
            this.upDownInicial = new System.Windows.Forms.NumericUpDown();
            this.upDownFinal = new System.Windows.Forms.NumericUpDown();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnMilhasViajadas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.upDownInicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownFinal)).BeginInit();
            this.SuspendLayout();
            // 
            // milhasIniciaisLabel
            // 
            this.milhasIniciaisLabel.AutoSize = true;
            this.milhasIniciaisLabel.Location = new System.Drawing.Point(12, 9);
            this.milhasIniciaisLabel.Name = "milhasIniciaisLabel";
            this.milhasIniciaisLabel.Size = new System.Drawing.Size(72, 13);
            this.milhasIniciaisLabel.TabIndex = 0;
            this.milhasIniciaisLabel.Text = "Milhas Iniciais";
            // 
            // milhasFinaisLabel
            // 
            this.milhasFinaisLabel.AutoSize = true;
            this.milhasFinaisLabel.Location = new System.Drawing.Point(12, 41);
            this.milhasFinaisLabel.Name = "milhasFinaisLabel";
            this.milhasFinaisLabel.Size = new System.Drawing.Size(67, 13);
            this.milhasFinaisLabel.TabIndex = 1;
            this.milhasFinaisLabel.Text = "Milhas Finais";
            // 
            // reembolsoLabel
            // 
            this.reembolsoLabel.AutoSize = true;
            this.reembolsoLabel.Location = new System.Drawing.Point(12, 70);
            this.reembolsoLabel.Name = "reembolsoLabel";
            this.reembolsoLabel.Size = new System.Drawing.Size(60, 13);
            this.reembolsoLabel.TabIndex = 2;
            this.reembolsoLabel.Text = "Reembolso";
            // 
            // upDownInicial
            // 
            this.upDownInicial.Location = new System.Drawing.Point(101, 7);
            this.upDownInicial.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.upDownInicial.Name = "upDownInicial";
            this.upDownInicial.Size = new System.Drawing.Size(120, 20);
            this.upDownInicial.TabIndex = 3;
            this.upDownInicial.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // upDownFinal
            // 
            this.upDownFinal.Location = new System.Drawing.Point(101, 39);
            this.upDownFinal.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.upDownFinal.Name = "upDownFinal";
            this.upDownFinal.Size = new System.Drawing.Size(120, 20);
            this.upDownFinal.TabIndex = 4;
            this.upDownFinal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(15, 107);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnMilhasViajadas
            // 
            this.btnMilhasViajadas.Location = new System.Drawing.Point(125, 107);
            this.btnMilhasViajadas.Name = "btnMilhasViajadas";
            this.btnMilhasViajadas.Size = new System.Drawing.Size(96, 23);
            this.btnMilhasViajadas.TabIndex = 6;
            this.btnMilhasViajadas.Text = "Milhas Viajadas";
            this.btnMilhasViajadas.UseVisualStyleBackColor = true;
            this.btnMilhasViajadas.Click += new System.EventHandler(this.btnMilhasViajadas_Click);
            // 
            // Tela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 150);
            this.Controls.Add(this.btnMilhasViajadas);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.upDownFinal);
            this.Controls.Add(this.upDownInicial);
            this.Controls.Add(this.reembolsoLabel);
            this.Controls.Add(this.milhasFinaisLabel);
            this.Controls.Add(this.milhasIniciaisLabel);
            this.Name = "Tela";
            this.Text = "Tela Reembolso";
            ((System.ComponentModel.ISupportInitialize)(this.upDownInicial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownFinal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label milhasIniciaisLabel;
        private System.Windows.Forms.Label milhasFinaisLabel;
        private System.Windows.Forms.Label reembolsoLabel;
        private System.Windows.Forms.NumericUpDown upDownInicial;
        private System.Windows.Forms.NumericUpDown upDownFinal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnMilhasViajadas;
    }
}

