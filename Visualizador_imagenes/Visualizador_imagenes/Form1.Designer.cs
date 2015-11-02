namespace Visualizador_imagenes
{
    partial class Visor
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.contenedor_imagen = new System.Windows.Forms.PictureBox();
            this.chk_ajuste = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_cargar = new System.Windows.Forms.Button();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.btn_copiar = new System.Windows.Forms.Button();
            this.btn_fondo = new System.Windows.Forms.Button();
            this.btn_color = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contenedor_imagen)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.contenedor_imagen, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(782, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel2.Controls.Add(this.chk_ajuste, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 457);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(782, 100);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // contenedor_imagen
            // 
            this.contenedor_imagen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor_imagen.Location = new System.Drawing.Point(3, 3);
            this.contenedor_imagen.Name = "contenedor_imagen";
            this.contenedor_imagen.Size = new System.Drawing.Size(776, 444);
            this.contenedor_imagen.TabIndex = 0;
            this.contenedor_imagen.TabStop = false;
            // 
            // chk_ajuste
            // 
            this.chk_ajuste.AutoSize = true;
            this.chk_ajuste.Location = new System.Drawing.Point(3, 3);
            this.chk_ajuste.Name = "chk_ajuste";
            this.chk_ajuste.Size = new System.Drawing.Size(95, 17);
            this.chk_ajuste.TabIndex = 0;
            this.chk_ajuste.Text = "Ajustar imagen";
            this.chk_ajuste.UseVisualStyleBackColor = true;
            this.chk_ajuste.CheckedChanged += new System.EventHandler(this.chk_ajuste_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_cargar);
            this.flowLayoutPanel1.Controls.Add(this.btn_borrar);
            this.flowLayoutPanel1.Controls.Add(this.btn_copiar);
            this.flowLayoutPanel1.Controls.Add(this.btn_fondo);
            this.flowLayoutPanel1.Controls.Add(this.btn_color);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(120, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(659, 94);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btn_cargar
            // 
            this.btn_cargar.Location = new System.Drawing.Point(3, 3);
            this.btn_cargar.Name = "btn_cargar";
            this.btn_cargar.Size = new System.Drawing.Size(75, 23);
            this.btn_cargar.TabIndex = 0;
            this.btn_cargar.Text = "Cargar";
            this.btn_cargar.UseVisualStyleBackColor = true;
            this.btn_cargar.Click += new System.EventHandler(this.btn_cargar_Click);
            // 
            // btn_borrar
            // 
            this.btn_borrar.Location = new System.Drawing.Point(84, 3);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(75, 23);
            this.btn_borrar.TabIndex = 1;
            this.btn_borrar.Text = "Borrar";
            this.btn_borrar.UseVisualStyleBackColor = true;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // btn_copiar
            // 
            this.btn_copiar.Location = new System.Drawing.Point(165, 3);
            this.btn_copiar.Name = "btn_copiar";
            this.btn_copiar.Size = new System.Drawing.Size(75, 23);
            this.btn_copiar.TabIndex = 2;
            this.btn_copiar.Text = "Copiar ";
            this.btn_copiar.UseVisualStyleBackColor = true;
            this.btn_copiar.Click += new System.EventHandler(this.btn_copiar_Click);
            // 
            // btn_fondo
            // 
            this.btn_fondo.Location = new System.Drawing.Point(246, 3);
            this.btn_fondo.Name = "btn_fondo";
            this.btn_fondo.Size = new System.Drawing.Size(127, 23);
            this.btn_fondo.TabIndex = 3;
            this.btn_fondo.Text = "Fondo pantalla";
            this.btn_fondo.UseVisualStyleBackColor = true;
            this.btn_fondo.Click += new System.EventHandler(this.btn_fondo_Click);
            // 
            // btn_color
            // 
            this.btn_color.Location = new System.Drawing.Point(379, 3);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(102, 23);
            this.btn_color.TabIndex = 4;
            this.btn_color.Text = "Cambiar color";
            this.btn_color.UseVisualStyleBackColor = true;
            this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // Visor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.Name = "Visor";
            this.Text = "Visor de imagenes";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contenedor_imagen)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox contenedor_imagen;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.CheckBox chk_ajuste;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_cargar;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.Button btn_copiar;
        private System.Windows.Forms.Button btn_fondo;
        private System.Windows.Forms.Button btn_color;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

