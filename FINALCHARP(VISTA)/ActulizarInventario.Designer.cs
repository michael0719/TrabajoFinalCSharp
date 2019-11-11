namespace FINALCHARP_VISTA_
{
    partial class ActulizarInventario
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
            this.gbadministrar = new System.Windows.Forms.GroupBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lblcategoria = new System.Windows.Forms.Label();
            this.cbcategoria = new System.Windows.Forms.ComboBox();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.lblprecio = new System.Windows.Forms.Label();
            this.lblnombreproducto = new System.Windows.Forms.Label();
            this.lbltituloadministrar = new System.Windows.Forms.Label();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnguardarcambios = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvproductos = new System.Windows.Forms.DataGridView();
            this.btnregresar = new System.Windows.Forms.Button();
            this.categoriaactual = new System.Windows.Forms.Label();
            this.gbadministrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbadministrar
            // 
            this.gbadministrar.Controls.Add(this.categoriaactual);
            this.gbadministrar.Controls.Add(this.btnregresar);
            this.gbadministrar.Controls.Add(this.txtcodigo);
            this.gbadministrar.Controls.Add(this.txtcantidad);
            this.gbadministrar.Controls.Add(this.txtprecio);
            this.gbadministrar.Controls.Add(this.txtnombre);
            this.gbadministrar.Controls.Add(this.lblcategoria);
            this.gbadministrar.Controls.Add(this.cbcategoria);
            this.gbadministrar.Controls.Add(this.lblcodigo);
            this.gbadministrar.Controls.Add(this.lblcantidad);
            this.gbadministrar.Controls.Add(this.lblprecio);
            this.gbadministrar.Controls.Add(this.lblnombreproducto);
            this.gbadministrar.Controls.Add(this.lbltituloadministrar);
            this.gbadministrar.Controls.Add(this.btnregistrar);
            this.gbadministrar.Controls.Add(this.btncancelar);
            this.gbadministrar.Controls.Add(this.btnguardarcambios);
            this.gbadministrar.Controls.Add(this.btneliminar);
            this.gbadministrar.Location = new System.Drawing.Point(12, 12);
            this.gbadministrar.Name = "gbadministrar";
            this.gbadministrar.Size = new System.Drawing.Size(543, 256);
            this.gbadministrar.TabIndex = 12;
            this.gbadministrar.TabStop = false;
            this.gbadministrar.Text = "Administrar inventario";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(373, 16);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(112, 20);
            this.txtcodigo.TabIndex = 17;
            this.txtcodigo.Visible = false;
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(303, 164);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(182, 20);
            this.txtcantidad.TabIndex = 16;
            this.txtcantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcantidad_KeyPress);
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(303, 127);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(182, 20);
            this.txtprecio.TabIndex = 15;
            this.txtprecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprecio_KeyPress);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(303, 54);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(182, 20);
            this.txtnombre.TabIndex = 14;
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombre_KeyPress);
            // 
            // lblcategoria
            // 
            this.lblcategoria.AutoSize = true;
            this.lblcategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcategoria.Location = new System.Drawing.Point(27, 94);
            this.lblcategoria.Name = "lblcategoria";
            this.lblcategoria.Size = new System.Drawing.Size(73, 16);
            this.lblcategoria.TabIndex = 13;
            this.lblcategoria.Text = "Categoria: ";
            // 
            // cbcategoria
            // 
            this.cbcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcategoria.FormattingEnabled = true;
            this.cbcategoria.Location = new System.Drawing.Point(303, 89);
            this.cbcategoria.Name = "cbcategoria";
            this.cbcategoria.Size = new System.Drawing.Size(182, 21);
            this.cbcategoria.TabIndex = 12;
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(275, 19);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(66, 13);
            this.lblcodigo.TabIndex = 11;
            this.lblcodigo.Text = "ID producto:";
            this.lblcodigo.Visible = false;
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcantidad.Location = new System.Drawing.Point(27, 168);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(101, 16);
            this.lblcantidad.TabIndex = 10;
            this.lblcantidad.Text = "Cantidad(total): ";
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprecio.Location = new System.Drawing.Point(27, 131);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(158, 16);
            this.lblprecio.TabIndex = 9;
            this.lblprecio.Text = "Precio producto(unidad): ";
            // 
            // lblnombreproducto
            // 
            this.lblnombreproducto.AutoSize = true;
            this.lblnombreproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombreproducto.Location = new System.Drawing.Point(27, 58);
            this.lblnombreproducto.Name = "lblnombreproducto";
            this.lblnombreproducto.Size = new System.Drawing.Size(138, 16);
            this.lblnombreproducto.TabIndex = 8;
            this.lblnombreproducto.Text = "Nombre del producto:";
            // 
            // lbltituloadministrar
            // 
            this.lbltituloadministrar.AutoSize = true;
            this.lbltituloadministrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltituloadministrar.Location = new System.Drawing.Point(26, 16);
            this.lbltituloadministrar.Name = "lbltituloadministrar";
            this.lbltituloadministrar.Size = new System.Drawing.Size(159, 20);
            this.lbltituloadministrar.TabIndex = 7;
            this.lbltituloadministrar.Text = "Registrar producto";
            // 
            // btnregistrar
            // 
            this.btnregistrar.Location = new System.Drawing.Point(6, 227);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(100, 23);
            this.btnregistrar.TabIndex = 2;
            this.btnregistrar.Text = "Registrar";
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(322, 227);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(100, 23);
            this.btncancelar.TabIndex = 5;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnguardarcambios
            // 
            this.btnguardarcambios.Location = new System.Drawing.Point(112, 227);
            this.btnguardarcambios.Name = "btnguardarcambios";
            this.btnguardarcambios.Size = new System.Drawing.Size(98, 23);
            this.btnguardarcambios.TabIndex = 3;
            this.btnguardarcambios.Text = "Guardar cambios";
            this.btnguardarcambios.UseVisualStyleBackColor = true;
            this.btnguardarcambios.Click += new System.EventHandler(this.btnguardarcambios_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(216, 227);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(100, 23);
            this.btneliminar.TabIndex = 4;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Productos Registrados";
            // 
            // dgvproductos
            // 
            this.dgvproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproductos.Location = new System.Drawing.Point(12, 308);
            this.dgvproductos.Name = "dgvproductos";
            this.dgvproductos.Size = new System.Drawing.Size(543, 132);
            this.dgvproductos.TabIndex = 10;
            this.dgvproductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvproductos_CellClick);
            // 
            // btnregresar
            // 
            this.btnregresar.Location = new System.Drawing.Point(428, 227);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(100, 23);
            this.btnregresar.TabIndex = 18;
            this.btnregresar.Text = "Regresar";
            this.btnregresar.UseVisualStyleBackColor = true;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // categoriaactual
            // 
            this.categoriaactual.AutoSize = true;
            this.categoriaactual.Location = new System.Drawing.Point(185, 96);
            this.categoriaactual.Name = "categoriaactual";
            this.categoriaactual.Size = new System.Drawing.Size(0, 13);
            this.categoriaactual.TabIndex = 19;
            // 
            // ActulizarInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(570, 455);
            this.Controls.Add(this.gbadministrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvproductos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ActulizarInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ActulizarInventario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ActulizarInventario_FormClosing);
            this.gbadministrar.ResumeLayout(false);
            this.gbadministrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbadministrar;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblcategoria;
        private System.Windows.Forms.ComboBox cbcategoria;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.Label lblnombreproducto;
        private System.Windows.Forms.Label lbltituloadministrar;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnguardarcambios;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvproductos;
        private System.Windows.Forms.Button btnregresar;
        private System.Windows.Forms.Label categoriaactual;
    }
}