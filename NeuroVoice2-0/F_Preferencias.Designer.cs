namespace NeuroVoice2_0
{
    partial class F_Preferencias
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
            this.B_Guardar = new System.Windows.Forms.Button();
            this.B_Cancelar = new System.Windows.Forms.Button();
            this.L_Capas = new System.Windows.Forms.Label();
            this.TB_Capas = new System.Windows.Forms.TextBox();
            this.L_Neuronas = new System.Windows.Forms.Label();
            this.TB_Neuronas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // B_Guardar
            // 
            this.B_Guardar.Location = new System.Drawing.Point(12, 92);
            this.B_Guardar.Name = "B_Guardar";
            this.B_Guardar.Size = new System.Drawing.Size(75, 23);
            this.B_Guardar.TabIndex = 0;
            this.B_Guardar.Text = "Guardar";
            this.B_Guardar.UseVisualStyleBackColor = true;
            this.B_Guardar.Click += new System.EventHandler(this.B_Guardar_Click);
            // 
            // B_Cancelar
            // 
            this.B_Cancelar.Location = new System.Drawing.Point(197, 92);
            this.B_Cancelar.Name = "B_Cancelar";
            this.B_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.B_Cancelar.TabIndex = 1;
            this.B_Cancelar.Text = "Cancelar";
            this.B_Cancelar.UseVisualStyleBackColor = true;
            this.B_Cancelar.Click += new System.EventHandler(this.B_Cancelar_Click);
            // 
            // L_Capas
            // 
            this.L_Capas.AutoSize = true;
            this.L_Capas.Location = new System.Drawing.Point(13, 13);
            this.L_Capas.Name = "L_Capas";
            this.L_Capas.Size = new System.Drawing.Size(37, 13);
            this.L_Capas.TabIndex = 2;
            this.L_Capas.Text = "Capas";
            // 
            // TB_Capas
            // 
            this.TB_Capas.Location = new System.Drawing.Point(86, 13);
            this.TB_Capas.Name = "TB_Capas";
            this.TB_Capas.Size = new System.Drawing.Size(100, 20);
            this.TB_Capas.TabIndex = 3;
            this.TB_Capas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_Capas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Capas_KeyPress);
            // 
            // L_Neuronas
            // 
            this.L_Neuronas.AutoSize = true;
            this.L_Neuronas.Location = new System.Drawing.Point(12, 40);
            this.L_Neuronas.Name = "L_Neuronas";
            this.L_Neuronas.Size = new System.Drawing.Size(53, 13);
            this.L_Neuronas.TabIndex = 4;
            this.L_Neuronas.Text = "Neuronas";
            // 
            // TB_Neuronas
            // 
            this.TB_Neuronas.Location = new System.Drawing.Point(86, 40);
            this.TB_Neuronas.Name = "TB_Neuronas";
            this.TB_Neuronas.Size = new System.Drawing.Size(100, 20);
            this.TB_Neuronas.TabIndex = 5;
            this.TB_Neuronas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_Neuronas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Neuronas_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "*Separados por (;)";
            // 
            // F_Preferencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 127);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_Neuronas);
            this.Controls.Add(this.L_Neuronas);
            this.Controls.Add(this.TB_Capas);
            this.Controls.Add(this.L_Capas);
            this.Controls.Add(this.B_Cancelar);
            this.Controls.Add(this.B_Guardar);
            this.Name = "F_Preferencias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preferencias";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.F_Preferencias_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_Guardar;
        private System.Windows.Forms.Button B_Cancelar;
        private System.Windows.Forms.Label L_Capas;
        private System.Windows.Forms.TextBox TB_Capas;
        private System.Windows.Forms.Label L_Neuronas;
        private System.Windows.Forms.TextBox TB_Neuronas;
        private System.Windows.Forms.Label label1;
    }
}