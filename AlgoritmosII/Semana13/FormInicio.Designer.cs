
namespace Semana13
{
    partial class FormInicio
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
            this.btnPorPlanilla = new System.Windows.Forms.Button();
            this.btnPorHoras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPorPlanilla
            // 
            this.btnPorPlanilla.Location = new System.Drawing.Point(45, 30);
            this.btnPorPlanilla.Name = "btnPorPlanilla";
            this.btnPorPlanilla.Size = new System.Drawing.Size(287, 97);
            this.btnPorPlanilla.TabIndex = 0;
            this.btnPorPlanilla.Text = "Trabajadores en Planilla";
            this.btnPorPlanilla.UseVisualStyleBackColor = true;
            this.btnPorPlanilla.Click += new System.EventHandler(this.btnPorPlanilla_Click);
            // 
            // btnPorHoras
            // 
            this.btnPorHoras.Location = new System.Drawing.Point(45, 165);
            this.btnPorHoras.Name = "btnPorHoras";
            this.btnPorHoras.Size = new System.Drawing.Size(287, 97);
            this.btnPorHoras.TabIndex = 1;
            this.btnPorHoras.Text = "Trabajadores por Horas";
            this.btnPorHoras.UseVisualStyleBackColor = true;
            this.btnPorHoras.Click += new System.EventHandler(this.btnPorHoras_Click);
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 322);
            this.Controls.Add(this.btnPorHoras);
            this.Controls.Add(this.btnPorPlanilla);
            this.Name = "FormInicio";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormInicio_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPorPlanilla;
        private System.Windows.Forms.Button btnPorHoras;
    }
}

