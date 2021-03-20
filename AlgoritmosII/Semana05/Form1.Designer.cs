
namespace Semana05
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFila = new System.Windows.Forms.TextBox();
            this.txtColumna = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnListarSuma = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnMayorMenor = new System.Windows.Forms.Button();
            this.btnSumatoriaFila = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fila";
            // 
            // txtFila
            // 
            this.txtFila.Location = new System.Drawing.Point(175, 29);
            this.txtFila.Name = "txtFila";
            this.txtFila.Size = new System.Drawing.Size(64, 20);
            this.txtFila.TabIndex = 1;
            // 
            // txtColumna
            // 
            this.txtColumna.Location = new System.Drawing.Point(175, 67);
            this.txtColumna.Name = "txtColumna";
            this.txtColumna.Size = new System.Drawing.Size(64, 20);
            this.txtColumna.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Columna";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(41, 134);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(198, 23);
            this.btnGenerar.TabIndex = 4;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnListarSuma
            // 
            this.btnListarSuma.Location = new System.Drawing.Point(41, 189);
            this.btnListarSuma.Name = "btnListarSuma";
            this.btnListarSuma.Size = new System.Drawing.Size(198, 23);
            this.btnListarSuma.TabIndex = 5;
            this.btnListarSuma.Text = "Sumatoria y Promedio";
            this.btnListarSuma.UseVisualStyleBackColor = true;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(266, 15);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(378, 408);
            this.txtResultado.TabIndex = 6;
            // 
            // btnMayorMenor
            // 
            this.btnMayorMenor.Location = new System.Drawing.Point(41, 253);
            this.btnMayorMenor.Name = "btnMayorMenor";
            this.btnMayorMenor.Size = new System.Drawing.Size(198, 23);
            this.btnMayorMenor.TabIndex = 7;
            this.btnMayorMenor.Text = "#Mayor , #Menor";
            this.btnMayorMenor.UseVisualStyleBackColor = true;
            // 
            // btnSumatoriaFila
            // 
            this.btnSumatoriaFila.Location = new System.Drawing.Point(41, 315);
            this.btnSumatoriaFila.Name = "btnSumatoriaFila";
            this.btnSumatoriaFila.Size = new System.Drawing.Size(198, 23);
            this.btnSumatoriaFila.TabIndex = 8;
            this.btnSumatoriaFila.Text = "Sumatoria Fila 2";
            this.btnSumatoriaFila.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Sumatoria Columna 3";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 443);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSumatoriaFila);
            this.Controls.Add(this.btnMayorMenor);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnListarSuma);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtColumna);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFila);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFila;
        private System.Windows.Forms.TextBox txtColumna;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnListarSuma;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnMayorMenor;
        private System.Windows.Forms.Button btnSumatoriaFila;
        private System.Windows.Forms.Button button1;
    }
}

