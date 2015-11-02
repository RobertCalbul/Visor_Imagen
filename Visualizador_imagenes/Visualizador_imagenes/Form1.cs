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
        private String ruta_archivo = String.Empty; //path de la imagen
        private OpenFileDialog dlg_archivo;     //abre archivo imagen
        public Visor()
        {
            InitializeComponent();
            this.dlg_archivo = new OpenFileDialog(); //se instancea el open dialog
        }

        private void btn_cargar_Click(object sender, EventArgs e)
        {
            //se le aplica un filtro para que solo pueda abrir imagenes con formato jpg, png o bmp
            this.dlg_archivo.Filter = "Imagenes JPG (*.jpg)|*.jpg|Imagenes PNG (*.png)|*.png|Imagenes bmp (*.bmp)|*.bmp";
            //cuando se abre y se selecciona una imagen
            if (this.dlg_archivo.ShowDialog() == DialogResult.OK) {
                this.ruta_archivo = this.dlg_archivo.FileName;  // se guarda la ruta de la imagen
                this.contenedor_imagen.Load(ruta_archivo);      //se agrega imagen a picturebox
            }
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            this.contenedor_imagen.Image = null;//se elimina el contenido del picturebox
            this.ruta_archivo = String.Empty;   //se resetea el path de la imagen
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
            if (this.ruta_archivo != String.Empty)
                Fondo_Class.SetDesktopWallpaper(this.ruta_archivo);//se setea la imagen como fondo de pantalla
            else //de lo contrario
                MessageBox.Show("Carge una imagen antes.");//muestra mensaje de advertencia
        }

        private void chk_ajuste_CheckedChanged(object sender, EventArgs e)
        {
            this.contenedor_imagen.SizeMode = this.chk_ajuste.Checked ? PictureBoxSizeMode.StretchImage : PictureBoxSizeMode.Normal;
        }
    }
}
