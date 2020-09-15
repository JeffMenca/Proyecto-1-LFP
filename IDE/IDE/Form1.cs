using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using IDE.Archivo;
using System.Collections;

namespace IDE
{
    public partial class Form1 : Form
    {
        ManejadorArchivos manejadorArchivos = new ManejadorArchivos();
        Automata analizarAutomata = new Automata();
        ArrayList listaTokens = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guardarProeyctoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //Metodo para abrir un archivo
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Variables para el contenido y la ubicacion del archivo
            String fileContent = string.Empty;
            String filePath = string.Empty;
            //Filtro del filedialog
            openFileDialog1.Filter = "gt files (*.gt)|*.gt";
            //If para abrir el archivo
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Ruta del archivo
                filePath = openFileDialog1.FileName;
                fileContent = manejadorArchivos.cargarArchivo(filePath);
                rtbCodigo.Text = fileContent;
                MessageBox.Show("Proyecto cargado correctamente");
                this.Text = "IDE - Mencode " + openFileDialog1.FileName;
            }
        }

        //Metodo para guardar el archivo
        private void eliminarProyectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Guarda el nuevo archivo
                rtbCodigo.SaveFile(manejadorArchivos.getpathActual(), RichTextBoxStreamType.PlainText);
                MessageBox.Show("Proyecto guardado correctamente");
            }
            catch (Exception)
            {
                MessageBox.Show("No ha cargado o creado un archivo");
            }
        }

        //Metodo para crear nuevo archivo
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Filtro del savefiledialog
            saveFileDialog1.Filter = "gt files (*.gt)|*.gt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //crea el nuevo archivo
                manejadorArchivos.crearArchivo(saveFileDialog1.OpenFile(), saveFileDialog1.FileName);
                MessageBox.Show("Proyecto creado correctamente");
                this.Text = "IDE - Mencode " + openFileDialog1.FileName;
            }
        }

        //Metodo para guardar como archivos
        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Filtro del savefiledialog
            saveFileDialog1.Filter = "gt files (*.gt)|*.gt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Guarda el nuevo archivo
                manejadorArchivos.crearArchivo(saveFileDialog1.OpenFile(), saveFileDialog1.FileName);
                rtbCodigo.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                MessageBox.Show("Proyecto guardado correctamente");
                this.Text = "IDE - Mencode " + openFileDialog1.FileName;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GuardarToolStripMenuItem.PerformClick();
        }

        private void compilarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!rtbCodigo.Text.Equals(""))
                {
                    listaTokens.Clear();
                    listaTokens = analizarAutomata.generarTokens(rtbCodigo.Text);
                    rtbCodigo.Text = "";
                    rtbErrores.Text = "";
                    for (int i = 0; i < listaTokens.Count; i++)
                    {
                        tokens tokenmostrar =(tokens) listaTokens[i];
                        switch (tokenmostrar.getTipo())
                        {
                            case "Entero":
                                rtbCodigo.SelectionColor = Color.Orchid;
                                rtbCodigo.AppendText(" ");
                                rtbCodigo.AppendText(tokenmostrar.getToken());
                                break;
                            case "Decimal":
                                rtbCodigo.SelectionColor = Color.LightBlue;
                                rtbCodigo.AppendText(" ");
                                rtbCodigo.AppendText(tokenmostrar.getToken());
                                break;
                            case "Texto":
                                 rtbCodigo.SelectionColor = Color.LightGray;
                                 rtbCodigo.AppendText(" ");
                                 rtbCodigo.AppendText(tokenmostrar.getToken());
                                break;
                            case "Booleano":
                                rtbCodigo.SelectionColor = Color.Orange;
                                rtbCodigo.AppendText(" ");
                                rtbCodigo.AppendText(tokenmostrar.getToken());
                                break;
                            case "Error":
                                rtbCodigo.SelectionColor = Color.Yellow;
                                rtbCodigo.AppendText(" ");
                                rtbErrores.AppendText(Environment.NewLine);
                                rtbCodigo.AppendText(tokenmostrar.getToken());
                                rtbErrores.AppendText("Error en caracter: "+tokenmostrar.getToken());
                                break;
                            case "Enter":
                                rtbCodigo.SelectionColor = Color.White;
                                rtbCodigo.AppendText(Environment.NewLine);
                                break;
                            case "Caracter":
                                rtbCodigo.SelectionColor = Color.Peru;
                                rtbCodigo.AppendText(" ");
                                rtbCodigo.AppendText(tokenmostrar.getToken());
                                break;
                            case "Operador Aritmetico":
                                rtbCodigo.SelectionColor = Color.Blue;
                                rtbCodigo.AppendText(" ");
                                rtbCodigo.AppendText(tokenmostrar.getToken());
                                break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El codigo esta vacio o no es valido");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("El codigo introducido no es valido");
            }
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            compilarToolStripMenuItem1.PerformClick();
        }
    }
}
