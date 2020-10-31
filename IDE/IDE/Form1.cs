//Librerias
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
        //Variables 
        ManejadorArchivos manejadorArchivos = new ManejadorArchivos();
        Arbol arbolSintactico;
        Automata analizarAutomata = new Automata();
        ArrayList listaTokens = new ArrayList();
        public static ArrayList listaNodos = new ArrayList();
        private Boolean compilado = false;
        private int contadorErrores = 1;
        public Form1()
        {
            InitializeComponent();
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
                rtbCodigo.Clear();
                rtbCodigo.SelectionColor = Color.White;
                rtbCodigo.AppendText(fileContent);
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
                //Crea un nuevp archivo
                guardarComoToolStripMenuItem.PerformClick();
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
        //Guardar el archivo con otro boton
        private void button2_Click(object sender, EventArgs e)
        {
            GuardarToolStripMenuItem.PerformClick();
        }
        //Compila el codigo, analiza y pinta
        private void compilarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                compilado = true;
                listaNodos.Clear();
                analizarAutomata = new Automata();
                //Analiza si el codigo esta vacio
                if (!rtbCodigo.Text.Equals(""))
                {
                    listaTokens.Clear();
                    //Carga la lista de los tokens validos
                    listaTokens = analizarAutomata.generarTokens(rtbCodigo.Text);
                    //Compila
                    compilar();
                }
                else
                {
                    MessageBox.Show("El codigo esta vacio o no es valido");
                    compilado = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("El codigo introducido no es valido");
                compilado = false;
            }
        }

        //Compilar con otro boton
        private void button1_Click(object sender, EventArgs e)
        {
            compilarToolStripMenuItem1.PerformClick();
        }
        //Compila el proyecto, general el token y analiza su tipo para asignarle un color
        private void compilar()
        {
            rtbCodigo.Clear();
            rtbErrores.Clear();
            contadorErrores = 0;
            for (int i = 0; i < listaTokens.Count; i++)
            {
                //Genera un nuevo token para analizar la lista
                tokens tokenmostrar = (tokens)listaTokens[i];
                switch (tokenmostrar.getTipo())
                {
                    //Casos para pintar el codigo
                    case "Entero":
                        rtbCodigo.SelectionColor = Color.Orchid;
                        rtbCodigo.AppendText(tokenmostrar.getToken());
                        rtbCodigo.AppendText(" ");
                        break;
                    case "Decimal":
                        rtbCodigo.SelectionColor = Color.LightBlue;
                        rtbCodigo.AppendText(tokenmostrar.getToken());
                        rtbCodigo.AppendText(" ");
                        break;
                    case "Texto":
                        rtbCodigo.SelectionColor = Color.LightGray;
                        rtbCodigo.AppendText(tokenmostrar.getToken());
                        rtbCodigo.AppendText(" ");
                        break;
                    case "Booleano":
                        rtbCodigo.SelectionColor = Color.Orange;
                        rtbCodigo.AppendText(tokenmostrar.getToken());
                        rtbCodigo.AppendText(" ");
                        break;
                    case "Reservada":
                        rtbCodigo.SelectionColor = Color.Lime;
                        rtbCodigo.AppendText(tokenmostrar.getToken());
                        rtbCodigo.AppendText(" ");
                        break;
                    case "Error":
                        //Analiza las palabras reservadas
                        //Errores encontrados
                        rtbCodigo.SelectionColor = Color.Yellow;
                        rtbCodigo.AppendText(tokenmostrar.getToken());
                        rtbErrores.AppendText(contadorErrores + ". Error en sentencia: " + tokenmostrar.getToken() + " en fila: "
                            + tokenmostrar.getFila() + " y en columna: " + tokenmostrar.getColumna());
                        contadorErrores++;
                        rtbCodigo.AppendText(" ");
                        rtbErrores.AppendText(Environment.NewLine);
                        break;
                    case "Enter":
                        rtbCodigo.SelectionColor = Color.White;
                        rtbCodigo.AppendText(Environment.NewLine);
                        break;
                    case "Caracter":
                        rtbCodigo.SelectionColor = Color.Peru;
                        rtbCodigo.AppendText(tokenmostrar.getToken());
                        rtbCodigo.AppendText(" ");
                        break;
                    case "AsignacionFin":
                        rtbCodigo.SelectionColor = Color.Pink;
                        rtbCodigo.AppendText(tokenmostrar.getToken());
                        rtbCodigo.AppendText(" ");
                        break;
                    case "Comentario":
                        rtbCodigo.SelectionColor = Color.Red;
                        rtbCodigo.AppendText(tokenmostrar.getToken());
                        rtbCodigo.AppendText(" ");
                        break;
                    case "ID":
                        rtbCodigo.SelectionColor = Color.GreenYellow;
                        rtbCodigo.AppendText(tokenmostrar.getToken());
                        rtbCodigo.AppendText(" ");
                        break;
                    case "Operador Aritmetico":
                        rtbCodigo.SelectionColor = Color.Blue;
                        rtbCodigo.AppendText(tokenmostrar.getToken());
                        rtbCodigo.AppendText(" ");
                        break;
                }
            }
            //Reinicia el color del texto para seguir escribiendo
            rtbCodigo.SelectionColor = Color.White;
        }
        //Vacia los richTextBox para volver a ingresar todo
        private void reiniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Reinicia el codigo
            rtbCodigo.Clear();
            rtbErrores.Clear();
        }
        //Metodo para poner el modo oscuro
        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbCodigo.BackColor = Color.FromArgb(29, 28, 28);
        }
        //Metodo para poner el modo claro
        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbCodigo.BackColor = Color.FromArgb(255, 255, 255);
        }
        //Metodo para obtener linea y columna cada vez que se presiona el richtextbox
        private void rtbCodigo_Click(object sender, EventArgs e)
        {
            //Obtiene la posicion
            int posicion = rtbCodigo.SelectionStart;
            //Obtiene linea y columna de la posicion
            int linea = rtbCodigo.GetLineFromCharIndex(posicion) + 1;
            int columna = posicion - rtbCodigo.GetFirstCharIndexOfCurrentLine() + 1;
            //Imprime la linea y columna
            lbnumlinea.Text = linea.ToString();
            lbnumColumna.Text = columna.ToString();
        }
        //Metodo para exportar errores
        private void exportarErroresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Filtro del savefiledialog
            saveFileDialog1.Filter = "gtE files (*.gtE)|*.gtE";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Guarda el nuevo archivo
                manejadorArchivos.crearArchivo(saveFileDialog1.OpenFile(), saveFileDialog1.FileName);
                rtbErrores.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                MessageBox.Show("Archivo de errores exportado correctamente");
            }
        }
        //Metodo para guardar todo desde otro boton
        private void button3_Click(object sender, EventArgs e)
        {
            GuardarToolStripMenuItem.PerformClick();
        }
        //Metodo para guardar como desde otro boton
        private void button4_Click(object sender, EventArgs e)
        {
            guardarComoToolStripMenuItem.PerformClick();
        }
        //Metodo que termina la app
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        //Metodo que reinicia el color del codigo cada vez se edita el richtextbox
        private void rtbCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            rtbCodigo.SelectionColor = Color.White;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Variables para el contenido y la ubicacion del archivo
            String filePath = string.Empty;
            //Filtro del filedialog
            openFileDialog1.Filter = "gt files (*.gt)|*.gt";
            //If para abrir el archivo
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Ruta del archivo
                filePath = openFileDialog1.FileName;
                //Elimina el archivo
                File.Delete(filePath);
                MessageBox.Show("Proyecto eliminado correctamente");
                this.Text = "IDE - Mencode " + openFileDialog1.FileName;
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //Comprueba si ya se compilo y genera el arbol
            if (compilado == true)
            {
                //Genera el arbol
                arbolSintactico = new Arbol(listaNodos);
                arbolSintactico.generarArbol();
            }
            else
                MessageBox.Show("Debe compilar el codigo antes");
        }
    }
}
