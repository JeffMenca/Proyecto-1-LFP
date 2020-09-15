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
        public string Color;
        public string Tipo;
        public tokens(string token,string color,string tipo)
        {
            this.Token = token;
            this.Color = color;
            this.Tipo = tipo;
        }

        //Metodos Get y set
        public String getToken()
        {
            return this.Token;
        }
        public void setToken(String token)
        {
            this.Token = token;
        }
        public String getTipo()
        {
            return this.Tipo;
        }
        public void setTipo(String tipo)
        {
            this.Tipo = tipo;
        }
        public String getColor()
        {
            return this.Color;
        }
        public void setColor(String color)
        {
            this.Color = color;
        }


    }
}
