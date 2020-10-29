using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDE.Archivo
{
    class Simbolos
    {
        //Atributos
        private string Tipo;
        private string ID;
        private string Valor;
        public Simbolos(string tipo,string id,string valor)
        {
            this.Tipo = tipo;
            this.ID = id;
            this.Valor = valor;
        }
        //Metodos Get 
        public String getTipo()
        {
            return this.Tipo;
        }
        public String getID()
        {
            return this.ID;
        }
        public String getValor()
        {
            return this.Valor;
        }
        //Metodos set
        public void setTipo(String tipo)
        {
            this.Tipo = tipo;
        }
        public void setID(String id)
        {
            this.ID = id;
        }
        public void setValor(String valor)
        {
            this.Valor = valor;
        }

    }
}
