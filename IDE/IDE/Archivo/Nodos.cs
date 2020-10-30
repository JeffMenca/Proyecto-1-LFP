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
        private string padre;
        public ArrayList hijos = new ArrayList();
        public Nodos(string padre)
        {
            this.padre = padre;
        }

        public string getPadre()
        {
            return this.padre;
        }
        public void agregarHijo(String hijo)
        {
            hijos.Add(hijo);
        }

    }
}
