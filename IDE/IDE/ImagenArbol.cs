using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDE
{
    public partial class ImagenArbol : Form
    {
        public ImagenArbol()
        {
            InitializeComponent();
        }

        private void ImagenArbol_Load(object sender, EventArgs e)
        {
            try
            {
                byte[] bytes = System.IO.File.ReadAllBytes(@"..\Arboles Sintacticos\prueba.jpg");
                System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes);
                pictureBox1.Image = Image.FromStream(ms);
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog Guardar = new SaveFileDialog();
            Guardar.Filter = "JPEG(*.JPG)|*.JPG|BMP(*.BMP)|*.BMP|PNG(*.PNG)|*.PNG";
            Image Imagen = pictureBox1.Image;
            if (Guardar.ShowDialog() == DialogResult.OK)
            {
                Imagen.Save(Guardar.FileName);
                MessageBox.Show("Se guardo exitosamente");
            }
        }
    }
}
