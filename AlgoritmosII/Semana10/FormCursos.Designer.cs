
namespace Semana10
{
    partial class FormCursos
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
            this.btnMatematica = new System.Windows.Forms.Button();
            this.btnLenguaje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMatematica
            // 
            this.btnMatematica.Location = new System.Drawing.Point(86, 22);
            this.btnMatematica.Name = "btnMatematica";
            this.btnMatematica.Size = new System.Drawing.Size(152, 97);
            this.btnMatematica.TabIndex = 0;
            this.btnMatematica.Text = "Matematica";
            this.btnMatematica.UseVisualStyleBackColor = true;
            this.btnMatematica.Click += new System.EventHandler(this.btnMatematica_Click);
            // 
            // btnLenguaje
            // 
            this.btnLenguaje.Location = new System.Drawing.Point(86, 149);
            this.btnLenguaje.Name = "btnLenguaje";
            this.btnLenguaje.Size = new System.Drawing.Size(152, 97);
            this.btnLenguaje.TabIndex = 1;
            this.btnLenguaje.Text = "Lenguaje";
            this.btnLenguaje.UseVisualStyleBackColor = true;
            this.btnLenguaje.Click += new System.EventHandler(this.btnLenguaje_Click);
            // 
            // FormCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 296);
            this.Controls.Add(this.btnLenguaje);
            this.Controls.Add(this.btnMatematica);
            this.Name = "FormCursos";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCursos_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMatematica;
        private System.Windows.Forms.Button btnLenguaje;
    }
}

