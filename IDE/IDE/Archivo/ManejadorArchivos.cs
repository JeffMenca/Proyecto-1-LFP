using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IDE.Archivo
{
    class ManejadorArchivos
    {
        //Atributos
        private string pathActual;

        //Metodos Get y set
        public String getpathActual()
        {
            return this.pathActual;
        }
        public void setpathActual(String path)
        {
            this.pathActual = path;
        }

        //Metodo para cargar archivos
        public String cargarArchivo(String path)
        {
            String codigofuente = "";
            try
            {
                //lector del texto
                TextReader reader = new StreamReader(path);
                codigofuente = reader.ReadToEnd();
                setpathActual(path);
                reader.Close();
                //retorna el texto encontrado
                return codigofuente;
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("El codigo esta vacio");
                return "";
            }
        }
        //Metodo para crear archivos
        public void crearArchivo(Stream file, String path)
        {
            Stream myStream;
            try
            {
                //lector del texto
                if ((myStream = file) != null)
                {
                    // Se cierra el stream
                    myStream.Close();
                }
                //retorna el texto encontrado
                setpathActual(path);
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("El codigo esta vacio");
            }

        }
    }
}
