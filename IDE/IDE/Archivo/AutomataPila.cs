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

            
            while (true)
            {
                string peek = (string)pilas.Peek();
                switch (peek)
                {

                    case "A":
                        {
                            if (token.getToken().Equals("PRINCIPAL"))
                            {
                                pilas.Pop();
                                pilas.Push("B");
                                pilas.Push("{");
                                pilas.Push("PRINCIPAL");
                            }
                            else
                            {
                                return false;
                            }
                            break;
                        }
                    case "B":
                        {
                            if ((token.getTipo().Equals("Entero")) || (token.getTipo().Equals("Decimal")) || (token.getTipo().Equals("Texto"))
                                || (token.getTipo().Equals("Booleano")) || (token.getTipo().Equals("Caracter")) || (token.getToken().Equals("SI"))
                                || (token.getToken().Equals("imprimir")) || (token.getToken().Equals("leer")) || (token.getToken().Equals("MIENTRAS"))
                                || (token.getToken().Equals("HACER")) || (token.getToken().Equals("DESDE")) || (token.getTipo().Equals("ID")) || (token.getToken().Equals("imprimir")))
                            {
                                pilas.Pop();
                                pilas.Push("}");
                                pilas.Push("L");
                            }
                            else
                            {
                                return false;
                            }
                            break;
                        }
                    case "L":
                        {
                            if ((token.getTipo().Equals("Entero")) || (token.getTipo().Equals("Decimal")) || (token.getTipo().Equals("Texto"))
                                || (token.getTipo().Equals("Booleano")) || (token.getTipo().Equals("Caracter")) || (token.getToken().Equals("SI"))
                                || (token.getToken().Equals("imprimir")) || (token.getToken().Equals("leer")) || (token.getToken().Equals("MIENTRAS"))
                                || (token.getToken().Equals("HACER")) || (token.getTipo().Equals("ID")) || (token.getToken().Equals("DESDE")) || (token.getToken().Equals("imprimir")))
                            {
                                pilas.Pop();
                                pilas.Push("L");
                                pilas.Push("D");
                            }
                            else if (token.getTipo().Equals("}"))
                            {
                                pilas.Pop();
                            }
                            else
                            {
                                return false;
                            }
                            break;
                        }
                    case "Z":
                        {
                            if ((token.getTipo().Equals("ID")))
                            {
                                pilas.Pop();
                                pilas.Push(";");
                                pilas.Push("J");
                                pilas.Push("ID");
                            }
                            else
                            {
                                return false;
                            }
                            break;
                        }
                    case "Z'":
                        {
                            if ((token.getTipo().Equals("Booleano")) || (token.getTipo().Equals("Texto")) || (token.getTipo().Equals("Caracter")))
                            {
                                pilas.Pop();
                                pilas.Push(token.getTipo());
                            }
                            else if((token.getTipo().Equals("ID")) || (token.getTipo().Equals("Entero")) || (token.getTipo().Equals("Decimal"))
                                || (token.getToken().Equals("("))){
                                pilas.Pop();
                                pilas.Push("O");
                            }
                            else
                            {
                                return false;
                            }
                            break;
                        }
                    case "D":
                        {
                            if ((token.getTipo().Equals("Booleano")) || (token.getTipo().Equals("Texto")) || (token.getTipo().Equals("Caracter"))
                                || (token.getTipo().Equals("Entero")) || (token.getTipo().Equals("Decimal")))
                            {
                                pilas.Pop();
                                pilas.Push("D'");
                                pilas.Push(";");
                            }
                            else
                            {
                                return false;
                            }
                            break;
                        }
                    case "D'":
                        {
                            if ((token.getTipo().Equals("Decimal")))
                            {
                                pilas.Pop();
                                pilas.Push("Decimal");
                                pilas.Push("ID"); 
                                pilas.Push("P");
                            }
                            else if ((token.getTipo().Equals("Entero")))
                            {
                                pilas.Pop();
                                pilas.Push("Entero");
                                pilas.Push("ID");
                                pilas.Push("Q");
                            }
                            else if ((token.getTipo().Equals("Booleano")))
                            {
                                pilas.Pop();
                                pilas.Push("Booleano");
                                pilas.Push("ID");
                                pilas.Push("R");
                            }
                            else if ((token.getTipo().Equals("Texto")))
                            {
                                pilas.Pop();
                                pilas.Push("Texto");
                                pilas.Push("ID");
                                pilas.Push("S");
                            }
                            else if ((token.getTipo().Equals("Caracter")))
                            {
                                pilas.Pop();
                                pilas.Push("Caracter");
                                pilas.Push("ID");
                                pilas.Push("T");
                            }
                            else
                            {
                                return false;
                            }
                            break;
                        }
                    case "P":
                        {
                            if ((token.getTipo().Equals("=")))
                            {
                                pilas.Pop();
                                pilas.Push("Decimal");
                                pilas.Push("=");
                            }
                            else if ((token.getTipo().Equals(",")))
                            {
                                pilas.Pop();
                                pilas.Push("I");
                                pilas.Push(",");
                            }
                            else if ((token.getTipo().Equals(";")))
                            {
                                pilas.Pop();
                            }
                            else
                            {
                                return false;
                            }
                            break;
                        }
                    case "Q":
                        {
                            if ((token.getTipo().Equals("=")))
                            {
                                pilas.Pop();
                                pilas.Push("Entero");
                                pilas.Push("=");
                            }
                            else if ((token.getTipo().Equals(",")))
                            {
                                pilas.Pop();
                                pilas.Push("I");
                                pilas.Push(",");
                            }
                            else if ((token.getTipo().Equals(";")))
                            {
                                pilas.Pop();
                            }
                            else
                            {
                                return false;
                            }
                            break;
                        }
                    case "R":
                        {
                            if ((token.getTipo().Equals("=")))
                            {
                                pilas.Pop();
                                pilas.Push("Booleano");
                                pilas.Push("=");
                            }
                            else if ((token.getTipo().Equals(",")))
                            {
                                pilas.Pop();
                                pilas.Push("I");
                                pilas.Push(",");
                            }
                            else if ((token.getTipo().Equals(";")))
                            {
                                pilas.Pop();
                            }
                            else
                            {
                                return false;
                            }
                            break;
                        }
                    case "S":
                        {
                            if ((token.getTipo().Equals("=")))
                            {
                                pilas.Pop();
                                pilas.Push("Texto");
                                pilas.Push("=");
                            }
                            else if ((token.getTipo().Equals(",")))
                            {
                                pilas.Pop();
                                pilas.Push("I");
                                pilas.Push(",");
                            }
                            else if ((token.getTipo().Equals(";")))
                            {
                                pilas.Pop();
                            }
                            else
                            {
                                return false;
                            }
                            break;
                        }
                    case "T":
                        {
                            if ((token.getTipo().Equals("=")))
                            {
                                pilas.Pop();
                                pilas.Push("Cadena");
                                pilas.Push("=");
                            }
                            else if ((token.getTipo().Equals(",")))
                            {
                                pilas.Pop();
                                pilas.Push("I");
                                pilas.Push(",");
                            }
                            else if ((token.getTipo().Equals(";")))
                            {
                                pilas.Pop();
                            }
                            else
                            {
                                return false;
                            }
                            break;
                        }
                    case "I":
                        {
                            if ((token.getTipo().Equals("ID")))
                            {
                                pilas.Pop();
                                pilas.Push("I'");
                                pilas.Push("ID");
                            }
                            else
                            {
                                return false;
                            }
                            break;
                        }
                    case "I'":
                        {
                            if ((token.getTipo().Equals(",")))
                            {
                                pilas.Pop();
                                pilas.Push("I");
                                pilas.Push(",");
                            }
                            else if ((token.getTipo().Equals(";")))
                            {
                                pilas.Pop();
                            }
                            else
                            {
                                return false;
                            }
                            break;
                        }
                    case "G":
                        {
                            if ((token.getToken().Equals("imprimir")))
                            {
                                pilas.Pop();
                                pilas.Push("C");
                                pilas.Push("(");
                                pilas.Push("imprimir");
                            }
                            else if ((token.getToken().Equals("leer")))
                            {
                                pilas.Pop();
                                pilas.Push(";");
                                pilas.Push(")");
                                pilas.Push("ID");
                                pilas.Push("(");
                                pilas.Push("leer");
                            }
                            else
                            {
                                return false;
                            }
                            break;
                        }
                    case "C":
                        {
                            if ((token.getTipo().Equals("imprimir")))
                            {
                                pilas.Pop();
                                pilas.Push("C");
                                pilas.Push("(");
                                pilas.Push("imprimir");
                            }
                            else
                            {
                                return false;
                            }
                            break;
                        }

                    default:
                        {
                            if (peek.Equals(token.getToken()) || peek.Equals(token.getTipo()))
                            {
                                pilas.Pop();
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                            break;
                        }
                }
            }


        }


    }
}
