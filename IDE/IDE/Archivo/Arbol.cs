using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections;
using IDE.Archivo;
using System.Diagnostics;

namespace IDE.Archivo
{
    class Arbol
    {
        //Arrays de los nodos
        ArrayList nodos = new ArrayList();
        ArrayList nodosOrdenados = new ArrayList();
        //Constructor
        public Arbol(ArrayList nodos)
        {
            this.nodos = (ArrayList)nodos.Clone();
        }
        //Filtrar arboles correctos
        public void filtrarArbol()
        {
            Nodos nodoAux;
            for (int i = 0; i < nodos.Count; i++)
            {
                Nodos padre = (Nodos)nodos[i];
                for (int j = 0; j < padre.getHijos().Count; j++)
                {
                    padre.setNivel(i);
                    nodoAux = new Nodos(padre.getHijos()[j].ToString(), padre, (i + 1));
                    nodosOrdenados.Add(nodoAux);
                }
            }
            filtrarNiveles();
        }
        //Filtrar niveles
        public void filtrarNiveles()
        {
            for (int i = 0; i < nodosOrdenados.Count; i++)
            {
                Nodos nodoNuevo = (Nodos)nodosOrdenados[i];
                int nivelNuevo = getNivel(nodoNuevo.getPadre());
                if (nivelNuevo != 0)
                    nodoNuevo.getPadre().setNivel(nivelNuevo);
            }
        }
        //Obtener nivel de los nodos
        public int getNivel(Nodos nodo)
        {
            for (int i = 0; i < nodosOrdenados.Count; i++)
            {
                Nodos nodoAux = (Nodos)nodosOrdenados[i];
                if (nodo.getNivel() != nodoAux.getNivel() && nodo.getNombre().Equals(nodoAux.getNombre()) && !validarHijos(nodoAux)
                    && !noRaiz(nodo))
                    return nodoAux.getNivel();
            }
            return 0;
        }
        //Validar que el nodo tenga hijos
        public Boolean validarHijos(Nodos nodo)
        {
            for (int i = 0; i < nodosOrdenados.Count; i++)
            {
                Nodos nodoAux = (Nodos)nodosOrdenados[i];
                if (nodo.getNombre().Equals(nodoAux.getPadre().getNombre()) && nodo.getNivel().Equals(nodoAux.getPadre().getNivel()))
                    return true;
            }
            return false;
        }
        //Validar si es raiz 
        public Boolean noRaiz(Nodos nodo)
        {
            for (int i = 0; i < nodosOrdenados.Count; i++)
            {
                Nodos nodoAux = (Nodos)nodosOrdenados[i];
                if (nodo.getNombre().Equals(nodoAux.getNombre()) && nodo.getNivel().Equals(nodoAux.getNivel()))
                    return true;
            }
            return false;
        }
        //Generar arbol 
        public void generarArbol()
        {
            //Crear carpeta
            string path = @"..\Arboles Sintacticos";
            string contenido2 = "";
            if (!Directory.Exists(path))
            {
                DirectoryInfo di = Directory.CreateDirectory(path);
            }
            filtrarArbol();
            for (int i = 0; i < nodosOrdenados.Count; i++)
            {
                Nodos nodo = (Nodos)nodosOrdenados[i];
                contenido2 += "\"" + nodo.getPadre().getNombre() + " " + nodo.getPadre().getNivel() + "\"" + "->" + "\""
                    + nodo.getNombre() + " " + nodo.getNivel() + "\"" + ";\n";
            }
            String inicio = "digraph G {";
            string contenido1 = "{" +
                "node [margin=0 fontsize=12 shape=circle]\n";
            String final = " }";

            string graphVizString = inicio + contenido1 + contenido2 + final + final;
            Console.WriteLine(contenido2);
            Bitmap bm = new Bitmap(Graphviz.RenderImage(graphVizString, "jpg"));
            var imagen = new Bitmap(bm);
            bm.Dispose();
            Image image = (Image)imagen;
            imagen.Save(path + @"\prueba.jpg", ImageFormat.Jpeg);
            imagen.Dispose();
            IDE.ImagenArbol foto = new IDE.ImagenArbol();
            foto.Show();
        }
    }
}
