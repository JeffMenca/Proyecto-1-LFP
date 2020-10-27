using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDE.Archivo;

namespace IDE.Archivo
{
    class tokens
    { 
        //Atributos
        private string Token;
        private string Tipo;
        private int fila;
        private int columna;
        public tokens(string token,string tipo)
        {
            this.Token = token;
            this.Tipo = tipo;
        }
        public tokens(string token, string tipo,int fila,int columna)
        {
            this.Token = token;
            this.Tipo = tipo;
            this.fila = fila;
            this.columna = columna;
        }

        //Metodos Get 
        //Devuelve el contenido del token
        public String getToken()
        {
            return this.Token;
        }
        //Devuelve el tipo del token
        public String getTipo()
        {
            return this.Tipo;
        }
        //Devuelve la fila del token
        public int getFila()
        {
            return this.fila;
        }
        //Devuelve la columna del token
        public int getColumna()
        {
            return this.columna;
        }
        //setear tipo
        public void setTipo(String tipo)
        {
            this.Tipo = tipo;
        }

    }
}
