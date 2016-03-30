using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visualizador_imagenes
{
    public partial class Visor : Form
    {
        private List<String> ruta_archivo; //path de la imagen
        private int ident = 0;                  //contador de posicion
        private OpenFileDialog dlg_archivo;     //abre archivo imagen
        public Visor()
        {
            InitializeComponent();
            this.ruta_archivo = null;
            this.dlg_archivo = new OpenFileDialog(); //se instancea el open dialog
            this.dlg_archivo.Multiselect = true;    //activa la multiselección
           
        }

        private void btn_cargar_Click(object sender, EventArgs e)
        {
            //se le aplica un filtro para que solo pueda abrir imagenes con formato jpg, png o bmp
            this.dlg_archivo.Filter = "Imagenes JPG (*.jpg)|*.jpg|Imagenes PNG (*.png)|*.png|Imagenes bmp (*.bmp)|*.bmp";
            //cuando se abre y se selecciona una imagen
            if (this.dlg_archivo.ShowDialog() == DialogResult.OK) {
                this.ruta_archivo = this.dlg_archivo.FileNames.OfType<String>().ToList();//convertir array en list
                this.contenedor_imagen.Load(ruta_archivo[0]);      //se agrega imagen a picturebox
            }
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            this.contenedor_imagen.Image = null;//se elimina el contenido del picturebox
            this.ruta_archivo.RemoveAt(ident);  //elimina la imagen seleccionada
        }

        private void btn_copiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(this.contenedor_imagen.Image);//se copia al portapapeles
        }

        private void btn_color_Click(object sender, EventArgs e)
        {
            //cuando se habre el selector de color y se aprete ok o abrir
            if (this.colorDialog1.ShowDialog() == DialogResult.OK)
                this.contenedor_imagen.BackColor = this.colorDialog1.Color;//carga un color de fondo para el picturebox
        }

        private void btn_fondo_Click(object sender, EventArgs e)
        {
            //si existe un ruta de imagen
            if (this.ruta_archivo != null)
                Fondo_Class.SetDesktopWallpaper(this.ruta_archivo[ident]);//se setea la imagen como fondo de pantalla
            else //de lo contrario
                MessageBox.Show("Carge una imagen antes.");//muestra mensaje de advertencia
        }

        private void chk_ajuste_CheckedChanged(object sender, EventArgs e)
        {
            //cambia la imagen ajustando los parametros
            this.contenedor_imagen.SizeMode = this.chk_ajuste.Checked ? PictureBoxSizeMode.StretchImage : PictureBoxSizeMode.Normal;
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            if (this.ruta_archivo != null)
            {
                //si el identificador es igual a 0 se seteara la ultima imagen de lo contrario disminuira en 1
                this.ident = this.ident == 0 ? this.ruta_archivo.Count - 1 : this.ident - 1;
                this.contenedor_imagen.Load(ruta_archivo[ident]);//muestra imagen
            }

        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            if (this.ruta_archivo != null)
            {
                //si el identificador es igual al tamaño de la lista seteara la primera imagen de lo contrario aumentara en 1
                this.ident = this.ident == this.ruta_archivo.Count - 1 ? 0 : this.ident + 1;
                this.contenedor_imagen.Load(this.ruta_archivo[ident]);//muestra imagen
            }
        }
    }
}
