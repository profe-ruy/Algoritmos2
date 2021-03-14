
namespace Semana04
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
            this.Nombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtLista = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIndice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.Button();
            this.txtActualizar = new System.Windows.Forms.Button();
            this.btnBorrarSegunPosicion = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnListarTodo = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(29, 44);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 0;
            this.Nombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(84, 41);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(32, 81);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(339, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtLista
            // 
            this.txtLista.Location = new System.Drawing.Point(32, 266);
            this.txtLista.Multiline = true;
            this.txtLista.Name = "txtLista";
            this.txtLista.Size = new System.Drawing.Size(440, 127);
            this.txtLista.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Resultado";
            // 
            // txtIndice
            // 
            this.txtIndice.Location = new System.Drawing.Point(271, 41);
            this.txtIndice.Name = "txtIndice";
            this.txtIndice.Size = new System.Drawing.Size(100, 20);
            this.txtIndice.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Indice";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(385, 41);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(87, 23);
            this.txtBuscar.TabIndex = 7;
            this.txtBuscar.Text = "Buscar";
            this.txtBuscar.UseVisualStyleBackColor = true;
            this.txtBuscar.Click += new System.EventHandler(this.txtBuscar_Click);
            // 
            // txtActualizar
            // 
            this.txtActualizar.Location = new System.Drawing.Point(32, 110);
            this.txtActualizar.Name = "txtActualizar";
            this.txtActualizar.Size = new System.Drawing.Size(339, 23);
            this.txtActualizar.TabIndex = 8;
            this.txtActualizar.Text = "Actualizar";
            this.txtActualizar.UseVisualStyleBackColor = true;
            this.txtActualizar.Click += new System.EventHandler(this.txtActualizar_Click);
            // 
            // btnBorrarSegunPosicion
            // 
            this.btnBorrarSegunPosicion.Location = new System.Drawing.Point(32, 139);
            this.btnBorrarSegunPosicion.Name = "btnBorrarSegunPosicion";
            this.btnBorrarSegunPosicion.Size = new System.Drawing.Size(339, 23);
            this.btnBorrarSegunPosicion.TabIndex = 9;
            this.btnBorrarSegunPosicion.Text = "Borrar en Posicion X";
            this.btnBorrarSegunPosicion.UseVisualStyleBackColor = true;
            this.btnBorrarSegunPosicion.Click += new System.EventHandler(this.btnBorrarSegunPosicion_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(339, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Limpiar Arreglo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnListarTodo
            // 
            this.btnListarTodo.Location = new System.Drawing.Point(32, 197);
            this.btnListarTodo.Name = "btnListarTodo";
            this.btnListarTodo.Size = new System.Drawing.Size(339, 23);
            this.btnListarTodo.TabIndex = 11;
            this.btnListarTodo.Text = "Listar Arreglo";
            this.btnListarTodo.UseVisualStyleBackColor = true;
            this.btnListarTodo.Click += new System.EventHandler(this.btnListarTodo_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(385, 81);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(87, 139);
            this.btnBorrar.TabIndex = 12;
            this.btnBorrar.Text = "Borrar Caja de Texto";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 426);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnListarTodo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBorrarSegunPosicion);
            this.Controls.Add(this.txtActualizar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.txtIndice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLista);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.Nombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtLista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIndice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button txtBuscar;
        private System.Windows.Forms.Button txtActualizar;
        private System.Windows.Forms.Button btnBorrarSegunPosicion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnListarTodo;
        private System.Windows.Forms.Button btnBorrar;
    }
}

