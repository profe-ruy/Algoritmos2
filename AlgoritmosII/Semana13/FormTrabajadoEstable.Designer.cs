
namespace Semana13
{
    partial class FormTrabajadoEstable
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
            this.txtSueldoBruto = new System.Windows.Forms.TextBox();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAfp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRentaQuinta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSueldoNeto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtSueldoBruto
            // 
            this.txtSueldoBruto.Location = new System.Drawing.Point(203, 35);
            this.txtSueldoBruto.Name = "txtSueldoBruto";
            this.txtSueldoBruto.Size = new System.Drawing.Size(100, 20);
            this.txtSueldoBruto.TabIndex = 0;
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(63, 86);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(240, 23);
            this.btnProcesar.TabIndex = 2;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sueldo Bruto";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(63, 128);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(240, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "AFP";
            // 
            // txtAfp
            // 
            this.txtAfp.Location = new System.Drawing.Point(203, 182);
            this.txtAfp.Name = "txtAfp";
            this.txtAfp.Size = new System.Drawing.Size(100, 20);
            this.txtAfp.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Renta 5 ta";
            // 
            // txtRentaQuinta
            // 
            this.txtRentaQuinta.Location = new System.Drawing.Point(203, 228);
            this.txtRentaQuinta.Name = "txtRentaQuinta";
            this.txtRentaQuinta.Size = new System.Drawing.Size(100, 20);
            this.txtRentaQuinta.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sueldo Neto";
            // 
            // txtSueldoNeto
            // 
            this.txtSueldoNeto.Location = new System.Drawing.Point(203, 277);
            this.txtSueldoNeto.Name = "txtSueldoNeto";
            this.txtSueldoNeto.Size = new System.Drawing.Size(100, 20);
            this.txtSueldoNeto.TabIndex = 9;
            // 
            // FormTrabajadoEstable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 384);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSueldoNeto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRentaQuinta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAfp);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.txtSueldoBruto);
            this.Name = "FormTrabajadoEstable";
            this.Text = "FormTrabajadoEstable";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTrabajadoEstable_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSueldoBruto;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAfp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRentaQuinta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSueldoNeto;
    }
}