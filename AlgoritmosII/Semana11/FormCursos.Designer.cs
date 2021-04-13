
namespace Semana11
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
            this.btnLenguaje = new System.Windows.Forms.Button();
            this.btnMatematica = new System.Windows.Forms.Button();
            this.btnFisica = new System.Windows.Forms.Button();
            this.btnQuimica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLenguaje
            // 
            this.btnLenguaje.Location = new System.Drawing.Point(229, 174);
            this.btnLenguaje.Name = "btnLenguaje";
            this.btnLenguaje.Size = new System.Drawing.Size(152, 97);
            this.btnLenguaje.TabIndex = 3;
            this.btnLenguaje.Text = "Lenguaje";
            this.btnLenguaje.UseVisualStyleBackColor = true;
            this.btnLenguaje.Click += new System.EventHandler(this.btnLenguaje_Click);
            // 
            // btnMatematica
            // 
            this.btnMatematica.Location = new System.Drawing.Point(46, 174);
            this.btnMatematica.Name = "btnMatematica";
            this.btnMatematica.Size = new System.Drawing.Size(152, 97);
            this.btnMatematica.TabIndex = 2;
            this.btnMatematica.Text = "Matematica";
            this.btnMatematica.UseVisualStyleBackColor = true;
            this.btnMatematica.Click += new System.EventHandler(this.btnMatematica_Click);
            // 
            // btnFisica
            // 
            this.btnFisica.Location = new System.Drawing.Point(229, 47);
            this.btnFisica.Name = "btnFisica";
            this.btnFisica.Size = new System.Drawing.Size(152, 97);
            this.btnFisica.TabIndex = 5;
            this.btnFisica.Text = "Fisica";
            this.btnFisica.UseVisualStyleBackColor = true;
            this.btnFisica.Click += new System.EventHandler(this.btnFisica_Click);
            // 
            // btnQuimica
            // 
            this.btnQuimica.Location = new System.Drawing.Point(46, 47);
            this.btnQuimica.Name = "btnQuimica";
            this.btnQuimica.Size = new System.Drawing.Size(152, 97);
            this.btnQuimica.TabIndex = 4;
            this.btnQuimica.Text = "Quimica";
            this.btnQuimica.UseVisualStyleBackColor = true;
            this.btnQuimica.Click += new System.EventHandler(this.btnQuimica_Click);
            // 
            // FormCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 339);
            this.Controls.Add(this.btnFisica);
            this.Controls.Add(this.btnQuimica);
            this.Controls.Add(this.btnLenguaje);
            this.Controls.Add(this.btnMatematica);
            this.Name = "FormCursos";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCursos_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLenguaje;
        private System.Windows.Forms.Button btnMatematica;
        private System.Windows.Forms.Button btnFisica;
        private System.Windows.Forms.Button btnQuimica;
    }
}

