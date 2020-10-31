using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDE.Archivo
{
    class Nodos
    {
        //Atributos
        private Nodos padre;
        private string nombre;
        private int nivel;
        public ArrayList hijos = new ArrayList();
        public Nodos(string nombre)
        {
            this.nombre = nombre;
        }
        public Nodos(string nombre, Nodos padre, int nivel)
        {
            this.nombre = nombre;
            this.padre = padre;
            this.nivel = nivel;
        }

        //Metodos get
        public string getNombre()
        {
            return this.nombre;
        }
        public Nodos getPadre()
        {
            return this.padre;
        }
        public int getNivel()
        {
            return this.nivel;
        }
        public ArrayList getHijos()
        {
            return hijos;
        }
        //Metodos set
        public void agregarHijo(String hijo)
        {
            hijos.Add(hijo);
        }
        public void setNivel(int nivel)
        {
            this.nivel = nivel;
        }

    }
}
