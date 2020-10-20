using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDE.Archivo
{
    class AutomataPila
    {
        //Atributos
        private Stack pilas = new Stack();
        public AutomataPila()
        {
            pilas.Push("A");
        }

        public Boolean analizarSintaxis(tokens token)
        {

            string peek = (string)pilas.Peek();
            switch (peek)
            {

                case "A":
                    {
                        if (token.getToken() == "PRINCIPAL")
                        {
                            pilas.Pop();
                            pilas.Push("B");
                            pilas.Push("{");
                            pilas.Push("PRINCIPAL");
                        }
                        break;
                    }
                case "B":
                    {
                        if ((token.getTipo() == "Entero") || (token.getTipo() == "Decimal") || (token.getTipo() == "Texto")
                            || (token.getTipo() == "Booleano") || (token.getTipo() == "Caracter") || (token.getToken() == "SI")
                            || (token.getToken() == "imprimir") || (token.getToken() == "leer") || (token.getToken() == "MIENTRAS")
                            || (token.getToken() == "HACER") || (token.getToken() == "DESDE") || (token.getToken() == "imprimir"))
                        {
                            pilas.Pop();
                            pilas.Push("}");
                            pilas.Push("L");
                        }
                        break;
                    }

            }
            return true;
        }


    }
}
