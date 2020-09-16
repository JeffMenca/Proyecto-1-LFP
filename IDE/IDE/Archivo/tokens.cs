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
        public string Token;
        public string Tipo;
        public tokens(string token,string tipo)
        {
            this.Token = token;
            this.Tipo = tipo;
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
    }
}
