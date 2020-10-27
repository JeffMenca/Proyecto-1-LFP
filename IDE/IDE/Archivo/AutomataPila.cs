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
                            if (token.getToken().Equals("principal"))
                            {
                                pilas.Pop();
                                pilas.Push("B");
                                pilas.Push("{");
                                pilas.Push("principal");
                            }
                            else
                            {
                                return false;
                            }
                            break;
                        }
                    case "B":
                        {
                            if ((token.getToken().Equals("entero")) || (token.getToken().Equals("decimal")) || (token.getToken().Equals("cadena"))
                                || (token.getToken().Equals("booleano")) || (token.getToken().Equals("caracter")) || (token.getToken().Equals("SI"))
                                || (token.getToken().Equals("imprimir")) || (token.getToken().Equals("leer")) || (token.getToken().Equals("MIENTRAS"))
                                || (token.getToken().Equals("HACER")) || (token.getToken().Equals("DESDE")) || (token.getTipo().Equals("ID")))
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
                            if ((token.getToken().Equals("entero")) || (token.getToken().Equals("decimal")) || (token.getToken().Equals("cadena"))
                                || (token.getToken().Equals("booleano")) || (token.getToken().Equals("caracter")) || (token.getToken().Equals("SI"))
                                || (token.getToken().Equals("imprimir")) || (token.getToken().Equals("leer")) || (token.getToken().Equals("MIENTRAS"))
                                || (token.getToken().Equals("HACER")) || (token.getToken().Equals("DESDE")) || (token.getToken().Equals("imprimir")))
                            {
                                pilas.Pop();
                                pilas.Push("L");
                                pilas.Push("D");
                            }
                            else if ((token.getTipo().Equals("ID")))
                            {
                                pilas.Pop();
                                pilas.Push("L");
                                pilas.Push("Z");
                            }
                            else if (token.getToken().Equals("}"))
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
                            else if ((token.getTipo().Equals("ID")) || (token.getTipo().Equals("Entero")) || (token.getTipo().Equals("Decimal"))
                                || (token.getToken().Equals("(")))
                            {
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
                                pilas.Push(";");
                                pilas.Push("D'");
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
                                pilas.Push("Q");
                                pilas.Push("ID");
                                pilas.Push("Decimal");
                            }
                            else if ((token.getTipo().Equals("Entero")))
                            {
                                pilas.Pop();
                                pilas.Push("P");
                                pilas.Push("ID");
                                pilas.Push("Entero");
                            }
                            else if ((token.getTipo().Equals("Booleano")))
                            {
                                pilas.Pop();
                                pilas.Push("R");
                                pilas.Push("ID");
                                pilas.Push("Booleano");
                            }
                            else if ((token.getTipo().Equals("Texto")))
                            {
                                pilas.Pop();
                                pilas.Push("S");
                                pilas.Push("ID");
                                pilas.Push("Texto");
                            }
                            else if ((token.getTipo().Equals("Caracter")))
                            {
                                pilas.Pop();
                                pilas.Push("T");
                                pilas.Push("ID");
                                pilas.Push("Caracter");
                            }
                            else
                            {
                                return false;
                            }
                            break;
                        }
                    case "P":
                        {
                            if ((token.getToken().Equals("=")))
                            {
                                pilas.Pop();
                                pilas.Push("O");
                                pilas.Push("=");
                            }
                            else if ((token.getToken().Equals(",")))
                            {
                                pilas.Pop();
                                pilas.Push("I");
                                pilas.Push(",");
                            }
                            else if ((token.getToken().Equals(";")))
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
                            if ((token.getToken().Equals("=")))
                            {
                                pilas.Pop();
                                pilas.Push("O");
                                pilas.Push("=");
                            }
                            else if ((token.getToken().Equals(",")))
                            {
                                pilas.Pop();
                                pilas.Push("I");
                                pilas.Push(",");
                            }
                            else if ((token.getToken().Equals(";")))
                            {
                                pilas.Pop();
                            }
                            else
                            {
                                return false;
                            }
                            break;
                        }
                    case "Q'":
                        {
                            if ((token.getToken().Equals("+")) || (token.getToken().Equals("-")) || (token.getToken().Equals("*"))
                                || (token.getToken().Equals("/")))
                            {
                                pilas.Pop();
                                pilas.Push("Q''");
                                pilas.Push(token.getToken());
                            }
                            else if ((token.getToken().Equals(";")))
                            {
                                pilas.Pop();
                            }
                            else
                            {
                                return false;
                            }
                            break;
                        }
                    case "Q''":
                        {
                            if ((token.getTipo().Equals("ID")) || (token.getTipo().Equals("Entero")))
                            {
                                pilas.Pop();
                                pilas.Push("Q'");
                                pilas.Push(token.getTipo());
                            }
                            else if ((token.getToken().Equals("(")))
                            {
                                pilas.Pop();
                                pilas.Push("Q'");
                                pilas.Push(")");
                                pilas.Push("Q''");
                                pilas.Push("(");
                            }
                            else
                            {
                                return false;
                            }
                            break;
                        }
                    case "R":
                        {
                            if ((token.getToken().Equals("=")))
                            {
                                pilas.Pop();
                                pilas.Push("Booleano");
                                pilas.Push("=");
                            }
                            else if ((token.getToken().Equals(",")))
                            {
                                pilas.Pop();
                                pilas.Push("I");
                                pilas.Push(",");
                            }
                            else if ((token.getToken().Equals(";")))
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
                            if ((token.getToken().Equals("=")))
                            {
                                pilas.Pop();
                                pilas.Push("O'");
                                pilas.Push("Texto");
                                pilas.Push("=");
                            }
                            else if ((token.getToken().Equals(",")))
                            {
                                pilas.Pop();
                                pilas.Push("I");
                                pilas.Push(",");
                            }
                            else if ((token.getToken().Equals(";")))
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
                            if ((token.getToken().Equals("=")))
                            {
                                pilas.Pop();
                                pilas.Push("Caracter");
                                pilas.Push("=");
                            }
                            else if ((token.getToken().Equals(",")))
                            {
                                pilas.Pop();
                                pilas.Push("I");
                                pilas.Push(",");
                            }
                            else if ((token.getToken().Equals(";")))
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
                            if ((token.getToken().Equals(",")))
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
                            if ((token.getTipo().Equals("ID")) || (token.getTipo().Equals("Entero")) || (token.getTipo().Equals("Decimal"))
                                || (token.getTipo().Equals("Texto")))
                            {
                                pilas.Pop();
                                pilas.Push(";");
                                pilas.Push(")");
                                pilas.Push("M");
                            }
                            else
                            {
                                return false;
                            }
                            break;
                        }
                    case "M":
                        {

                            if ((token.getTipo().Equals("ID")) || (token.getTipo().Equals("Entero")) || (token.getTipo().Equals("Decimal"))
                                || (token.getTipo().Equals("Texto")))
                            {
                                pilas.Pop();
                                pilas.Push("M'");
                                pilas.Push(token.getTipo());
                            }
                            else
                            {
                                return false;
                            }
                            break;
                        }
                    case "M'":
                        {
                            if ((token.getToken().Equals("+")))
                            {
                                pilas.Pop();
                                pilas.Push("M");
                                pilas.Push("+");
                            }
                            else if ((token.getToken().Equals(")")))
                            {
                                pilas.Pop();
                            }
                            else if ((token.getToken().Equals(";")))
                            {
                                pilas.Pop();
                            }
                            else
                            {
                                return false;
                            }
                            break;
                        }
                    case "F":
                        {
                            if ((token.getToken().Equals("SI")))
                            {
                                pilas.Pop();
                                pilas.Push("E'");
                                pilas.Push("E");
                                pilas.Push("S");
                                pilas.Push(")");
                                pilas.Push("V");
                                pilas.Push("(");
                                pilas.Push("SI");
                            }
                            else if ((token.getToken().Equals("MIENTRAS")))
                            {
                                pilas.Pop();
                                pilas.Push("S'");
                                pilas.Push(")");
                                pilas.Push("V");
                                pilas.Push("(");
                                pilas.Push("MIENTRAS");
                            }
                            else if ((token.getToken().Equals("HACER")))
                            {
                                pilas.Pop();
                                pilas.Push(")'");
                                pilas.Push("V");
                                pilas.Push("(");
                                pilas.Push("MIENTRAS");
                                pilas.Push("S'");
                                pilas.Push("HACER");
                            }
                            else if ((token.getToken().Equals("DESDE")))
                            {
                                pilas.Pop();
                                pilas.Push("S'");
                                pilas.Push("ENTERO");
                                pilas.Push("INCREMENTO");
                                pilas.Push("ENTERO");
                                pilas.Push("S''");
                                pilas.Push("ID");
                                pilas.Push("HASTA");
                                pilas.Push("ENTERO");
                                pilas.Push("=");
                                pilas.Push("ID");
                                pilas.Push("DESDE");
                            }
                            else if ((token.getToken().Equals(")")))
                            {
                                pilas.Pop();
                            }
                            else if ((token.getToken().Equals(";")))
                            {
                                pilas.Pop();
                            }
                            else
                            {
                                return false;
                            }
                            break;
                        }
                    case "V":
                        {

                            if ((token.getTipo().Equals("ID")) || (token.getTipo().Equals("Entero")) || (token.getTipo().Equals("Decimal"))
                                || (token.getTipo().Equals("Texto")) || (token.getTipo().Equals("Booleano")))
                            {
                                pilas.Pop();
                                pilas.Push("V'");
                                pilas.Push("X");
                                pilas.Push("V'");
                            }
                            else if ((token.getTipo().Equals("(")))
                            {
                                pilas.Pop();
                                pilas.Push("X'");
                                pilas.Push(")");
                                pilas.Push("V'");
                                pilas.Push("X");
                                pilas.Push("V'");
                                pilas.Push("(");
                            }
                            else
                            {
                                return false;
                            }
                            break;
                        }
                    case "V'":
                        {

                            if ((token.getTipo().Equals("ID")) || (token.getTipo().Equals("Entero")) || (token.getTipo().Equals("Decimal"))
                                || (token.getTipo().Equals("Texto")) || (token.getTipo().Equals("Booleano")))
                            {
                                pilas.Pop();
                                pilas.Push(token.getTipo());
                            }
                            else
                            {
                                return false;
                            }
                            break;
                        }
                    case "X":
                        {

                            if ((token.getToken().Equals(">")) || (token.getToken().Equals("<")) || (token.getToken().Equals("=="))
                                || (token.getToken().Equals("<=")) || (token.getToken().Equals(">=")) || (token.getToken().Equals("!=")))
                            {
                                pilas.Pop();
                                pilas.Push(token.getToken());
                            }
                            else
                            {
                                return false;
                            }
                            break;
                        }
                    case "X'":
                        {

                            if ((token.getToken().Equals("&&")) || (token.getToken().Equals("||")))
                            {
                                pilas.Pop();
                                pilas.Push("V");
                                pilas.Push(token.getToken());
                            }
                            else if ((token.getToken().Equals(")")))
                            {
                                pilas.Pop();
                            }
                            else
                            {
                                return false;
                            }
                            break;
                        }
                    case "S'":
                        {

                            if ((token.getToken().Equals("{")))
                            {
                                pilas.Pop();
                                pilas.Push("}");
                                pilas.Push("V");
                                pilas.Push("{");
                            }
                            else
                            {
                                return false;
                            }
                            break;
                        }
                    case "S''":
                        {

                            if ((token.getToken().Equals("=")) || (token.getToken().Equals(">")) || (token.getToken().Equals("<"))
                                || (token.getToken().Equals("<=")) || (token.getToken().Equals(">=")))
                            {
                                pilas.Pop();
                                pilas.Push(token.getToken());
                            }
                            else
                            {
                                return false;
                            }
                            break;
                        }
                    case "E":
                        {

                            if ((token.getTipo().Equals("Entero")) || (token.getTipo().Equals("Decimal")) || (token.getTipo().Equals("Texto"))
                                || (token.getTipo().Equals("Booleano")) || (token.getTipo().Equals("Caracter")) || (token.getToken().Equals("SI"))
                                || (token.getToken().Equals("imprimir")) || (token.getToken().Equals("leer")) || (token.getToken().Equals("MIENTRAS"))
                                || (token.getToken().Equals("HACER")) || (token.getToken().Equals("DESDE")) || (token.getTipo().Equals("ID"))
                                || (token.getToken().Equals("SINO")))
                            {
                                pilas.Pop();
                            }
                            else if ((token.getToken().Equals("SINO_SI")))
                            {
                                pilas.Pop();
                                pilas.Push("E");
                                pilas.Push("S'");
                                pilas.Push(")");
                                pilas.Push("V");
                                pilas.Push("(");
                                pilas.Push("SINO_SI");
                            }
                            else
                            {
                                return false;
                            }
                            break;
                        }
                    case "E'":
                        {

                            if ((token.getTipo().Equals("Entero")) || (token.getTipo().Equals("Decimal")) || (token.getTipo().Equals("Texto"))
                                || (token.getTipo().Equals("Booleano")) || (token.getTipo().Equals("Caracter")) || (token.getToken().Equals("SI"))
                                || (token.getToken().Equals("imprimir")) || (token.getToken().Equals("leer")) || (token.getToken().Equals("MIENTRAS"))
                                || (token.getToken().Equals("HACER")) || (token.getToken().Equals("DESDE")) || (token.getTipo().Equals("ID")))
                            {
                                pilas.Pop();
                            }
                            else if ((token.getToken().Equals("SINO")))
                            {
                                pilas.Pop();
                                pilas.Push("SINO");
                                pilas.Push("S'");
                            }
                            else
                            {
                                return false;
                            }
                            break;
                        }
                    case "O":
                        {

                            if ((token.getTipo().Equals("Entero")) || (token.getTipo().Equals("Decimal"))
                                || (token.getTipo().Equals("ID")))
                            {
                                pilas.Pop();
                                pilas.Push("N");
                                pilas.Push(token.getTipo());
                            }
                            else if ((token.getToken().Equals("(")))
                            {
                                pilas.Pop();
                                pilas.Push("N");
                                pilas.Push(")");
                                pilas.Push("O");
                                pilas.Push("(");
                            }
                            else
                            {
                                pilas.Pop();
                                pilas.Push("N");
                                return false;
                            }
                            break;
                        }
                    case "N":
                        {

                            if ((token.getToken().Equals("+")) || (token.getToken().Equals("-"))
                                || (token.getToken().Equals("*")) || (token.getToken().Equals("/")))
                            {
                                pilas.Pop();
                                pilas.Push("O");
                                pilas.Push(token.getTipo());
                            }
                            else if ((token.getToken().Equals(")")) || (token.getToken().Equals(";")))
                            {
                                pilas.Pop();
                            }
                            else
                            {
                                return false;
                            }
                            break;
                        }
                    case "J":
                        {

                            if ((token.getToken().Equals("=")))
                            {
                                pilas.Pop();
                                pilas.Push("Z'");
                                pilas.Push("=");
                            }
                            else if ((token.getToken().Equals("++")))
                            {
                                pilas.Pop();
                                pilas.Push("++");
                            }
                            else
                            {
                                return false;
                            }
                            break;
                        }
                    case "O'":
                        {

                            if ((token.getToken().Equals("+")))
                            {
                                pilas.Pop();
                                pilas.Push("N'");
                                pilas.Push("+");
                            }
                            else if ((token.getToken().Equals(";")))
                            {
                                pilas.Pop();
                            }
                            else
                            {
                                return false;
                            }
                            break;
                        }
                    case "N'":
                        {

                            if ((token.getTipo().Equals("ID")) || (token.getTipo().Equals("Texto")))
                            {
                                pilas.Pop();
                                pilas.Push("O'");
                                pilas.Push(token.getTipo());
                            }
                            else
                            {
                                pilas.Pop();
                                pilas.Push("O'");
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
