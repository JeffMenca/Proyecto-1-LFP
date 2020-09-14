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

namespace IDE
{
    public partial class Form1 : Form
    {
        private string[] tokensFinales;
        private string[] tokens;
        private int contadorTokens;
        private Boolean comillas = false;
        private Boolean comentario = false;
        ManejadorArchivos manejadorArchivos = new ManejadorArchivos();
        Automata analizarAutomata = new Automata();
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
                    generarTokens(rtbCodigo.Text);
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

        private void generarTokens(String codigo)
        {
            tokensFinales = new string[codigo.Length];
            char tokenPorAnalizar;
            String tokenGenerado = "";
            for (int i = 0; i < codigo.Length; i++)
            {
                tokenPorAnalizar = codigo[i];
                switch (tokenPorAnalizar)
                {
                    case ' ':
                    case '\r':
                    case '\t':
                    case '\b':
                    case '\f':
                        if (!tokenGenerado.Equals(" "))
                        {
                            if ((comillas == true) || (comentario = true))
                            {
                                tokenGenerado += tokenPorAnalizar;
                            }
                            else
                            {
                                ingresarToken(tokenGenerado);
                                ingresarToken("ESPACIO");
                                tokenGenerado = "";
                            }
                        }
                        else
                        {
                            ingresarToken(tokenGenerado);
                            ingresarToken("ESPACIO");
                            tokenGenerado = "";
                        }

                        break;
                    case '\n':
                        if (!tokenGenerado.Equals(" "))
                        {
                            if ((comillas == true) || (comentario = true))
                            {
                                tokenGenerado += tokenPorAnalizar;
                            }
                            else
                            {
                                ingresarToken(tokenGenerado);
                                ingresarToken("ENTER");
                                tokenGenerado = "";
                            }
                        }
                        else
                        {
                            ingresarToken(tokenGenerado);
                            ingresarToken("ENTER");
                            tokenGenerado = "";
                        }

                        break;
                    case '+':
                    case '-':
                    case '*':
                    case '<':
                    case '>':
                    case '!':
                    case '=':
                    case '(':
                    case ')':
                    case ';':
                        if (!tokenGenerado.Equals(""))
                            ingresarToken(tokenGenerado);
                        ingresarToken(tokenPorAnalizar.ToString());
                        tokenGenerado = "";
                        break;
                    case '"':
                        if (comillas == false)
                        {
                            if (!tokenGenerado.Equals(""))
                            {
                                ingresarToken(tokenGenerado);
                                tokenGenerado = "";
                            }
                            tokenGenerado += tokenPorAnalizar;
                            comillas = true;
                        }
                        else
                        {
                            tokenGenerado += tokenPorAnalizar;
                            ingresarToken(tokenGenerado);
                            tokenGenerado = "";
                            comillas = false;
                        }
                        break;
                    default:
                        tokenGenerado += tokenPorAnalizar;
                        break;
                }
            }
            ingresarToken(tokenGenerado);
            vaciarArray();
            rtbCodigo.Text = "";
            for (int i = 0; i < tokens.Length; i++)
            {
                //analizarAutomata.AnalizarTokens(tokensFinales[i]);
                if (tokens[i].Equals("ESPACIO"))
                {
                    rtbCodigo.SelectionColor = Color.Red;
                    rtbCodigo.AppendText(" ");
                }
                else if (tokens[i].Equals("ENTER"))
                {
                    rtbCodigo.SelectionColor = Color.Red;
                    rtbCodigo.AppendText(Environment.NewLine + "");
                }
                else
                {
                    rtbCodigo.SelectionColor = Color.Red;
                    rtbCodigo.AppendText(tokens[i]);
                }

            }

        }

        public void ingresarToken(String token)
        {
            tokensFinales[contadorTokens] = token;
            contadorTokens++;
        }

        public void vaciarArray()
        {
            tokens = new string[contadorTokens];
            for (int i = 0; i < contadorTokens; i++)
            {
                tokens[i] = tokensFinales[i];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            compilarToolStripMenuItem1.PerformClick();
        }
    }
}
