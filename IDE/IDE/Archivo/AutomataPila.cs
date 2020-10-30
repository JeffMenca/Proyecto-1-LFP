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
        private int validacion = 0;
        private string[] simbolo = new string[3];
        
        public AutomataPila()
        {
            pilas.Push("A");
        }

        public Boolean analizarSintaxis(tokens token)
        {


            while (pilas.Count != 0)
            {
                string peek = (string)pilas.Peek();
                switch (peek)
                {
                    case "A":
                        {
                            Nodos nodo = new Nodos(peek);
                            if (token.getToken().Equals("principal"))
                            {
                                pilas.Pop();
                                pilas.Push("B");
                                nodo.agregarHijo("B");
                                pilas.Push("{");
                                nodo.agregarHijo("{");
                                pilas.Push("principal");
                                nodo.agregarHijo("principal");
                            }
                            else
                            {
                                pilas.Pop();
                                pilas.Push("B");
                                nodo.agregarHijo("B");
                                pilas.Push("{");
                                nodo.agregarHijo("{");
                                return false;
                            }
                            Form1.listaNodos.Add(nodo);
                            break;
                        }
                    case "B":
                        {
                            Nodos nodo = new Nodos(peek);
                            if ((token.getToken().Equals("entero")) || (token.getToken().Equals("decimal")) || (token.getToken().Equals("cadena"))
                                || (token.getToken().Equals("booleano")) || (token.getToken().Equals("caracter")) || (token.getToken().Equals("SI"))
                                || (token.getToken().Equals("imprimir")) || (token.getToken().Equals("leer")) || (token.getToken().Equals("MIENTRAS"))
                                || (token.getToken().Equals("HACER")) || (token.getToken().Equals("DESDE")) || (token.getTipo().Equals("Comentario")) ||
                                (token.getTipo().Equals("ID")))
                            {
                                pilas.Pop();
                                pilas.Push("}");
                                nodo.agregarHijo("}");
                                pilas.Push("L");
                                nodo.agregarHijo("L");
                            }
                            else
                            {
                                pilas.Pop();
                                pilas.Push("}");
                                nodo.agregarHijo("}");
                                pilas.Push("L");
                                nodo.agregarHijo("L");
                                return false;
                            }
                            Form1.listaNodos.Add(nodo);
                            break;
                        }
                    case "L":
                        {
                            Nodos nodo = new Nodos(peek);
                            if ((token.getToken().Equals("entero")) || (token.getToken().Equals("decimal")) || (token.getToken().Equals("cadena"))
                                || (token.getToken().Equals("booleano")) || (token.getToken().Equals("caracter")))
                            {
                                pilas.Pop();
                                pilas.Push("L");
                                nodo.agregarHijo("L");
                                pilas.Push("D");
                                nodo.agregarHijo("D");
                            }
                            else if ((token.getToken().Equals("SI")) || (token.getToken().Equals("MIENTRAS"))
                                || (token.getToken().Equals("HACER")) || (token.getToken().Equals("DESDE")))
                            {
                                pilas.Pop();
                                pilas.Push("L");
                                nodo.agregarHijo("L");
                                pilas.Push("F");
                                nodo.agregarHijo("F");
                            }
                            else if ((token.getTipo().Equals("Comentario")))
                            {
                                pilas.Pop();
                                pilas.Push("L");
                                nodo.agregarHijo("L");
                                pilas.Push(token.getToken());
                                nodo.agregarHijo(token.getToken());
                            }
                            else if ((token.getToken().Equals("leer")) || (token.getToken().Equals("imprimir")))
                            {
                                pilas.Pop();
                                pilas.Push("L");
                                nodo.agregarHijo("L");
                                pilas.Push("G");
                                nodo.agregarHijo("G");
                            }
                            else if ((token.getTipo().Equals("ID")))
                            {
                                pilas.Pop();
                                pilas.Push("L");
                                nodo.agregarHijo("L");
                                pilas.Push("Z");
                                nodo.agregarHijo("Z");
                            }
                            else if (token.getToken().Equals("}") && (validacion == 0))
                            {
                                pilas.Pop();
                            }
                            else if (token.getToken().Equals("}") && (validacion != 0))
                            {
                                pilas.Pop();
                                pilas.Push("L");
                                nodo.agregarHijo("L");
                                pilas.Push("}");
                                nodo.agregarHijo("}");
                                validacion--;
                            }
                            else
                            {
                                if (token.getToken().Equals("{"))
                                {
                                    pilas.Push("}");
                                    nodo.agregarHijo("}");
                                    pilas.Push("L");
                                    nodo.agregarHijo("L");
                                    pilas.Push("{");
                                    nodo.agregarHijo("{");
                                }
                                else if (token.getToken().Equals("("))
                                {
                                    pilas.Push(")");
                                    nodo.agregarHijo(")");
                                    pilas.Push("L");
                                    nodo.agregarHijo("L");
                                    pilas.Push("(");
                                    nodo.agregarHijo("(");
                                }
                                else
                                {
                                    pilas.Pop();
                                    pilas.Push("L");
                                    nodo.agregarHijo("L");
                                    return false;
                                }
                            }
                            Form1.listaNodos.Add(nodo);
                            break;
                        }
                    case "Z":
                        {
                            Nodos nodo = new Nodos(peek);
                            if ((token.getTipo().Equals("ID")))
                            {
                                pilas.Pop();
                                pilas.Push(";");
                                nodo.agregarHijo(";");
                                pilas.Push("J");
                                nodo.agregarHijo("J");
                                pilas.Push("ID");
                                nodo.agregarHijo("ID");
                            }
                            else
                            {
                                return false;
                            }
                            Form1.listaNodos.Add(nodo);
                            break;
                        }
                    case "Z'":
                        {
                            Nodos nodo = new Nodos(peek);
                            if ((token.getTipo().Equals("Booleano")) || (token.getTipo().Equals("Caracter")))
                            {
                                pilas.Pop();
                                pilas.Push(token.getTipo());
                                nodo.agregarHijo(token.getTipo());
                            }
                            else if ((token.getTipo().Equals("Texto")))
                            {
                                pilas.Pop();
                                pilas.Push("O'");
                                nodo.agregarHijo("O'");
                                pilas.Push(token.getTipo());
                                nodo.agregarHijo(token.getTipo());
                            }
                            else if ((token.getTipo().Equals("ID")) || (token.getTipo().Equals("Entero")) || (token.getTipo().Equals("Decimal"))
                                || (token.getToken().Equals("(")))
                            {
                                pilas.Pop();
                                pilas.Push("O");
                                nodo.agregarHijo("O");
                            }
                            else
                            {
                                return false;
                            }
                            Form1.listaNodos.Add(nodo);
                            break;
                        }
                    case "D":
                        {
                            Nodos nodo = new Nodos(peek);
                            if ((token.getTipo().Equals("Booleano")) || (token.getTipo().Equals("Texto")) || (token.getTipo().Equals("Caracter"))
                                || (token.getTipo().Equals("Entero")) || (token.getTipo().Equals("Decimal")))
                            {
                                pilas.Pop();
                                pilas.Push(";");
                                nodo.agregarHijo(";");
                                pilas.Push("D'");
                                nodo.agregarHijo("D'");
                            }
                            else
                            {
                                return false;
                            }
                            Form1.listaNodos.Add(nodo);
                            break;
                        }
                    case "D'":
                        {
                            Nodos nodo = new Nodos(peek);
                            if ((token.getTipo().Equals("Decimal")))
                            {
                                pilas.Pop();
                                pilas.Push("Q");
                                nodo.agregarHijo("Q");
                                pilas.Push("ID");
                                nodo.agregarHijo("ID");
                                pilas.Push("Decimal");
                                nodo.agregarHijo("Decimal");
                            }
                            else if ((token.getTipo().Equals("Entero")))
                            {
                                pilas.Pop();
                                pilas.Push("P");
                                nodo.agregarHijo("P");
                                pilas.Push("ID");
                                nodo.agregarHijo("ID");
                                pilas.Push("Entero");
                                nodo.agregarHijo("Entero");
                            }
                            else if ((token.getTipo().Equals("Booleano")))
                            {
                                pilas.Pop();
                                pilas.Push("R");
                                nodo.agregarHijo("R");
                                pilas.Push("ID");
                                nodo.agregarHijo("ID");
                                pilas.Push("Booleano");
                                nodo.agregarHijo("Booleano");
                            }
                            else if ((token.getTipo().Equals("Texto")))
                            {
                                pilas.Pop();
                                pilas.Push("S");
                                nodo.agregarHijo("S");
                                pilas.Push("ID");
                                nodo.agregarHijo("ID");
                                pilas.Push("Texto");
                                nodo.agregarHijo("Texto");
                            }
                            else if ((token.getTipo().Equals("Caracter")))
                            {
                                pilas.Pop();
                                pilas.Push("T");
                                nodo.agregarHijo("T");
                                pilas.Push("ID");
                                nodo.agregarHijo("ID");
                                pilas.Push("Caracter");
                                nodo.agregarHijo("Caracter");
                            }
                            else
                            {
                                return false;
                            }
                            Form1.listaNodos.Add(nodo);
                            break;
                        }
                    case "P":
                        {
                            Nodos nodo = new Nodos(peek);
                            if ((token.getToken().Equals("=")))
                            {
                                pilas.Pop();
                                pilas.Push("O");
                                nodo.agregarHijo("O");
                                pilas.Push("=");
                                nodo.agregarHijo("=");
                            }
                            else if ((token.getToken().Equals(",")))
                            {
                                pilas.Pop();
                                pilas.Push("I");
                                nodo.agregarHijo("I");
                                pilas.Push(",");
                                nodo.agregarHijo(",");
                            }
                            else if ((token.getToken().Equals(";")))
                            {
                                pilas.Pop();
                            }
                            else
                            {
                                return false;
                            }
                            Form1.listaNodos.Add(nodo);
                            break;
                        }
                    case "Q":
                        {
                            Nodos nodo = new Nodos(peek);
                            if ((token.getToken().Equals("=")))
                            {
                                pilas.Pop();
                                pilas.Push("O");
                                nodo.agregarHijo("O");
                                pilas.Push("=");
                                nodo.agregarHijo("=");
                            }
                            else if ((token.getToken().Equals(",")))
                            {
                                pilas.Pop();
                                pilas.Push("I");
                                nodo.agregarHijo("I");
                                pilas.Push(",");
                                nodo.agregarHijo(",");
                            }
                            else if ((token.getToken().Equals(";")))
                            {
                                pilas.Pop();
                            }
                            else
                            {
                                return false;
                            }
                            Form1.listaNodos.Add(nodo);
                            break;
                        }
                    case "Q'":
                        {
                            Nodos nodo = new Nodos(peek);
                            if ((token.getToken().Equals("+")) || (token.getToken().Equals("-")) || (token.getToken().Equals("*"))
                                || (token.getToken().Equals("/")))
                            {
                                pilas.Pop();
                                pilas.Push("Q''");
                                nodo.agregarHijo("Q''");
                                pilas.Push(token.getToken());
                                nodo.agregarHijo(token.getToken());
                            }
                            else if ((token.getToken().Equals(";")))
                            {
                                pilas.Pop();
                            }
                            else
                            {
                                return false;
                            }
                            Form1.listaNodos.Add(nodo);
                            break;
                        }
                    case "Q''":
                        {
                            Nodos nodo = new Nodos(peek);
                            if ((token.getTipo().Equals("ID")) || (token.getTipo().Equals("Entero")))
                            {
                                pilas.Pop();
                                pilas.Push("Q'");
                                nodo.agregarHijo("Q'");
                                pilas.Push(token.getTipo());
                                nodo.agregarHijo(token.getTipo());
                            }
                            else if ((token.getToken().Equals("(")))
                            {
                                pilas.Pop();
                                pilas.Push("Q'");
                                nodo.agregarHijo("Q'");
                                pilas.Push(")");
                                nodo.agregarHijo(")");
                                pilas.Push("Q''");
                                nodo.agregarHijo("Q''");
                                pilas.Push("(");
                                nodo.agregarHijo("(");
                            }
                            else
                            {
                                return false;
                            }
                            Form1.listaNodos.Add(nodo);
                            break;
                        }
                    case "R":
                        {
                            Nodos nodo = new Nodos(peek);
                            if ((token.getToken().Equals("=")))
                            {
                                pilas.Pop();
                                pilas.Push("Booleano");
                                nodo.agregarHijo("Booleano");
                                pilas.Push("=");
                                nodo.agregarHijo("=");
                            }
                            else if ((token.getToken().Equals(",")))
                            {
                                pilas.Pop();
                                pilas.Push("I");
                                nodo.agregarHijo("I");
                                pilas.Push(",");
                                nodo.agregarHijo(",");
                            }
                            else if ((token.getToken().Equals(";")))
                            {
                                pilas.Pop();
                            }
                            else
                            {
                                return false;
                            }
                            Form1.listaNodos.Add(nodo);
                            break;
                        }
                    case "S":
                        {
                            Nodos nodo = new Nodos(peek);
                            if ((token.getToken().Equals("=")))
                            {
                                pilas.Pop();
                                pilas.Push("O'");
                                nodo.agregarHijo("O'");
                                pilas.Push("Texto");
                                nodo.agregarHijo("Texto");
                                pilas.Push("=");
                                nodo.agregarHijo("=");
                            }
                            else if ((token.getToken().Equals(",")))
                            {
                                pilas.Pop();
                                pilas.Push("I");
                                nodo.agregarHijo("I");
                                pilas.Push(",");
                                nodo.agregarHijo(",");
                            }
                            else if ((token.getToken().Equals(";")))
                            {
                                pilas.Pop();
                            }
                            else
                            {
                                return false;
                            }
                            Form1.listaNodos.Add(nodo);
                            break;
                        }
                    case "T":
                        {
                            Nodos nodo = new Nodos(peek);
                            if ((token.getToken().Equals("=")))
                            {
                                pilas.Pop();
                                pilas.Push("Caracter");
                                nodo.agregarHijo("Caracter");
                                pilas.Push("=");
                                nodo.agregarHijo("=");
                            }
                            else if ((token.getToken().Equals(",")))
                            {
                                pilas.Pop();
                                pilas.Push("I");
                                nodo.agregarHijo("I");
                                pilas.Push(",");
                                nodo.agregarHijo(",");
                            }
                            else if ((token.getToken().Equals(";")))
                            {
                                pilas.Pop();
                            }
                            else
                            {
                                return false;
                            }
                            Form1.listaNodos.Add(nodo);
                            break;
                        }
                    case "I":
                        {
                            Nodos nodo = new Nodos(peek);
                            if ((token.getTipo().Equals("ID")))
                            {
                                pilas.Pop();
                                pilas.Push("I'");
                                nodo.agregarHijo("I'");
                                pilas.Push("ID");
                                nodo.agregarHijo("ID");
                            }
                            else
                            {
                                pilas.Pop();
                                pilas.Push("P");
                                nodo.agregarHijo("P");
                                return false;
                            }
                            Form1.listaNodos.Add(nodo);
                            break;
                        }
                    case "I'":
                        {
                            Nodos nodo = new Nodos(peek);
                            if ((token.getToken().Equals(",")))
                            {
                                pilas.Pop();
                                pilas.Push("I");
                                nodo.agregarHijo("I");
                                pilas.Push(",");
                                nodo.agregarHijo(",");
                            }
                            else if ((token.getToken().Equals(";")))
                            {
                                pilas.Pop();
                            }
                            else
                            {
                                return false;
                            }
                            Form1.listaNodos.Add(nodo);
                            break;
                        }
                    case "G":
                        {
                            Nodos nodo = new Nodos(peek);
                            if ((token.getToken().Equals("imprimir")))
                            {
                                pilas.Pop();
                                pilas.Push("C");
                                nodo.agregarHijo("C");
                                pilas.Push("(");
                                nodo.agregarHijo("(");
                                pilas.Push("imprimir");
                                nodo.agregarHijo("imprimir");
                            }
                            else if ((token.getToken().Equals("leer")))
                            {
                                pilas.Pop();
                                pilas.Push(";");
                                nodo.agregarHijo(";");
                                pilas.Push(")");
                                nodo.agregarHijo(")");
                                pilas.Push("ID");
                                nodo.agregarHijo("ID");
                                pilas.Push("(");
                                nodo.agregarHijo("(");
                                pilas.Push("leer");
                                nodo.agregarHijo("leer");
                            }
                            else
                            {
                                return false;
                            }
                            Form1.listaNodos.Add(nodo);
                            break;
                        }
                    case "C":
                        {
                            Nodos nodo = new Nodos(peek);
                            if ((token.getTipo().Equals("ID")) || (token.getTipo().Equals("Entero")) || (token.getTipo().Equals("Decimal"))
                                || (token.getTipo().Equals("Texto")))
                            {
                                pilas.Pop();
                                pilas.Push(";");
                                nodo.agregarHijo(";");
                                pilas.Push(")");
                                nodo.agregarHijo(")");
                                pilas.Push("M");
                                nodo.agregarHijo("M");
                            }
                            else
                            {
                                return false;
                            }
                            Form1.listaNodos.Add(nodo);
                            break;
                        }
                    case "M":
                        {
                            Nodos nodo = new Nodos(peek);
                            if ((token.getTipo().Equals("ID")) || (token.getTipo().Equals("Entero")) || (token.getTipo().Equals("Decimal"))
                                || (token.getTipo().Equals("Texto")))
                            {
                                pilas.Pop();
                                pilas.Push("M'");
                                nodo.agregarHijo("M''");
                                pilas.Push(token.getTipo());
                                nodo.agregarHijo(token.getTipo());
                            }
                            else
                            {
                                return false;
                            }
                            Form1.listaNodos.Add(nodo);
                            break;
                        }
                    case "M'":
                        {
                            Nodos nodo = new Nodos(peek);
                            if ((token.getToken().Equals("+")))
                            {
                                pilas.Pop();
                                pilas.Push("M");
                                nodo.agregarHijo("M");
                                pilas.Push("+");
                                nodo.agregarHijo("+");
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
                            Form1.listaNodos.Add(nodo);
                            break;
                        }
                    case "F":
                        {
                            Nodos nodo = new Nodos(peek);
                            if ((token.getToken().Equals("SI")))
                            {
                                pilas.Pop();
                                pilas.Push("E'");
                                nodo.agregarHijo("E'");
                                pilas.Push("E");
                                nodo.agregarHijo("E");
                                pilas.Push("S'");
                                nodo.agregarHijo("S'");
                                pilas.Push(")");
                                nodo.agregarHijo(")");
                                pilas.Push("V");
                                nodo.agregarHijo("V");
                                pilas.Push("(");
                                nodo.agregarHijo("(");
                                pilas.Push("SI");
                                nodo.agregarHijo("SI");
                            }
                            else if ((token.getToken().Equals("MIENTRAS")))
                            {
                                pilas.Pop();
                                pilas.Push("S'");
                                nodo.agregarHijo("S'");
                                pilas.Push(")");
                                nodo.agregarHijo(")");
                                pilas.Push("V");
                                nodo.agregarHijo("V");
                                pilas.Push("(");
                                nodo.agregarHijo("(");
                                pilas.Push("MIENTRAS");
                                nodo.agregarHijo("MIENTRAS");
                            }
                            else if ((token.getToken().Equals("HACER")))
                            {
                                pilas.Pop();
                                pilas.Push(")");
                                nodo.agregarHijo(")");
                                pilas.Push("V");
                                nodo.agregarHijo("V");
                                pilas.Push("(");
                                nodo.agregarHijo("(");
                                pilas.Push("MIENTRAS");
                                nodo.agregarHijo("MIENTRAS");
                                pilas.Push("S'");
                                nodo.agregarHijo("S'");
                                pilas.Push("HACER");
                                nodo.agregarHijo("HACER");
                            }
                            else if ((token.getToken().Equals("DESDE")))
                            {
                                pilas.Pop();
                                pilas.Push("S'");
                                nodo.agregarHijo("S'");
                                pilas.Push("ENTERO");
                                nodo.agregarHijo("ENTERO");
                                pilas.Push("INCREMENTO");
                                nodo.agregarHijo("INCREMENTO");
                                pilas.Push("ENTERO");
                                nodo.agregarHijo("ENTERO");
                                pilas.Push("S''");
                                nodo.agregarHijo("S''");
                                pilas.Push("ID");
                                nodo.agregarHijo("ID");
                                pilas.Push("HASTA");
                                nodo.agregarHijo("HASTA");
                                pilas.Push("ENTERO");
                                nodo.agregarHijo("ENTERO");
                                pilas.Push("=");
                                nodo.agregarHijo("=");
                                pilas.Push("ID");
                                nodo.agregarHijo("ID");
                                pilas.Push("DESDE");
                                nodo.agregarHijo("DESDE");
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
                            Form1.listaNodos.Add(nodo);
                            break;
                        }
                    case "V":
                        {
                            Nodos nodo = new Nodos(peek);
                            if ((token.getTipo().Equals("ID")) || (token.getTipo().Equals("Entero")) || (token.getTipo().Equals("Decimal"))
                                || (token.getTipo().Equals("Texto")) || (token.getTipo().Equals("Booleano")))
                            {
                                pilas.Pop();
                                pilas.Push("V'");
                                nodo.agregarHijo("V'");
                                pilas.Push("X");
                                nodo.agregarHijo("X");
                                pilas.Push("V'");
                                nodo.agregarHijo("V'");
                            }
                            else if ((token.getToken().Equals("(")))
                            {
                                pilas.Pop();
                                pilas.Push("X'");
                                nodo.agregarHijo("X'");
                                pilas.Push(")");
                                nodo.agregarHijo(")");
                                pilas.Push("V'");
                                nodo.agregarHijo("V'");
                                pilas.Push("X");
                                nodo.agregarHijo("X");
                                pilas.Push("V'");
                                nodo.agregarHijo("V'");
                                pilas.Push("(");
                                nodo.agregarHijo("(");
                            }
                            else
                            {
                                return false;
                            }
                            Form1.listaNodos.Add(nodo);
                            break;
                        }
                    case "V'":
                        {
                            Nodos nodo = new Nodos(peek);
                            if ((token.getTipo().Equals("ID")) || (token.getTipo().Equals("Entero")) || (token.getTipo().Equals("Decimal"))
                                || (token.getTipo().Equals("Texto")) || (token.getTipo().Equals("Booleano")))
                            {
                                pilas.Pop();
                                pilas.Push(token.getTipo());
                                nodo.agregarHijo(token.getTipo());
                            }
                            else
                            {
                                return false;
                            }
                            Form1.listaNodos.Add(nodo);
                            break;
                        }
                    case "X":
                        {
                            Nodos nodo = new Nodos(peek);
                            if ((token.getToken().Equals(">")) || (token.getToken().Equals("<")) || (token.getToken().Equals("=="))
                                || (token.getToken().Equals("<=")) || (token.getToken().Equals(">=")) || (token.getToken().Equals("!=")))
                            {
                                pilas.Pop();
                                pilas.Push(token.getToken());
                                nodo.agregarHijo(token.getToken());
                            }
                            else
                            {
                                return false;
                            }
                            Form1.listaNodos.Add(nodo);
                            break;
                        }
                    case "X'":
                        {
                            Nodos nodo = new Nodos(peek);
                            if ((token.getToken().Equals("&&")) || (token.getToken().Equals("||")))
                            {
                                pilas.Pop();
                                pilas.Push("V");
                                nodo.agregarHijo("V");
                                pilas.Push(token.getToken());
                                nodo.agregarHijo(token.getToken());
                            }
                            else if ((token.getToken().Equals(")")))
                            {
                                pilas.Pop();
                            }
                            else
                            {
                                return false;
                            }
                            Form1.listaNodos.Add(nodo);
                            break;
                        }
                    case "S'":
                        {
                            Nodos nodo = new Nodos(peek);
                            if ((token.getToken().Equals("{")))
                            {
                                pilas.Pop();
                                pilas.Push("}");
                                nodo.agregarHijo("}");
                                pilas.Push("L");
                                nodo.agregarHijo("L");
                                pilas.Push("{");
                                nodo.agregarHijo("{");
                            }
                            else
                            {
                                return false;
                            }
                            Form1.listaNodos.Add(nodo);
                            break;
                        }
                    case "S''":
                        {
                            Nodos nodo = new Nodos(peek);
                            if ((token.getToken().Equals("=")) || (token.getToken().Equals(">")) || (token.getToken().Equals("<"))
                                || (token.getToken().Equals("<=")) || (token.getToken().Equals(">=")))
                            {
                                pilas.Pop();
                                pilas.Push(token.getToken());
                                nodo.agregarHijo(token.getToken());
                            }
                            else
                            {
                                return false;
                            }
                            Form1.listaNodos.Add(nodo);
                            break;
                        }
                    case "E":
                        {
                            Nodos nodo = new Nodos(peek);
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
                                nodo.agregarHijo("E");
                                pilas.Push("S'");
                                nodo.agregarHijo("S'");
                                pilas.Push(")");
                                nodo.agregarHijo(")");
                                pilas.Push("V");
                                nodo.agregarHijo("V");
                                pilas.Push("(");
                                nodo.agregarHijo("(");
                                pilas.Push("SINO_SI");
                                nodo.agregarHijo("SINO_SI");
                            }
                            else if ((token.getTipo().Equals("Comentario")))
                            {
                                pilas.Pop();
                                pilas.Push("E");
                                nodo.agregarHijo("E");
                                pilas.Push(token.getToken());
                                nodo.agregarHijo(token.getToken());
                            }
                            else if ((token.getToken().Equals("}")))
                            {
                                pilas.Pop();
                                pilas.Push("}");
                                nodo.agregarHijo("}");
                            }
                            else
                            {
                                return false;
                            }
                            Form1.listaNodos.Add(nodo);
                            break;
                        }
                    case "E'":
                        {
                            Nodos nodo = new Nodos(peek);
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
                                pilas.Push("S'");
                                nodo.agregarHijo("S'");
                                pilas.Push("SINO");
                                nodo.agregarHijo("SINO");
                            }
                            else
                            {
                                return false;
                            }
                            Form1.listaNodos.Add(nodo);
                            break;
                        }
                    case "O":
                        {
                            Nodos nodo = new Nodos(peek);
                            if ((token.getTipo().Equals("Entero")) || (token.getTipo().Equals("Decimal"))
                                || (token.getTipo().Equals("ID")))
                            {
                                pilas.Pop();
                                pilas.Push("N");
                                nodo.agregarHijo("N");
                                pilas.Push(token.getTipo());
                                nodo.agregarHijo(token.getTipo());
                            }
                            else if ((token.getToken().Equals("(")))
                            {
                                pilas.Pop();
                                pilas.Push("N");
                                nodo.agregarHijo("N");
                                pilas.Push(")");
                                nodo.agregarHijo(")");
                                pilas.Push("O");
                                nodo.agregarHijo("O");
                                pilas.Push("(");
                                nodo.agregarHijo("(");
                            }
                            else
                            {
                                pilas.Pop();
                                pilas.Push("N");
                                nodo.agregarHijo("N");
                                return false;
                            }
                            Form1.listaNodos.Add(nodo);
                            break;
                        }
                    case "N":
                        {
                            Nodos nodo = new Nodos(peek);
                            if ((token.getToken().Equals("+")) || (token.getToken().Equals("-"))
                                || (token.getToken().Equals("*")) || (token.getToken().Equals("/")))
                            {
                                pilas.Pop();
                                pilas.Push("O");
                                nodo.agregarHijo("O");
                                pilas.Push(token.getTipo());
                                nodo.agregarHijo(token.getTipo());
                            }
                            else if ((token.getToken().Equals(")")) || (token.getToken().Equals(";")))
                            {
                                pilas.Pop();
                            }
                            else
                            {
                                return false;
                            }
                            Form1.listaNodos.Add(nodo);
                            break;
                        }
                    case "J":
                        {
                            Nodos nodo = new Nodos(peek);
                            if ((token.getToken().Equals("=")))
                            {
                                pilas.Pop();
                                pilas.Push("Z'");
                                nodo.agregarHijo("Z'");
                                pilas.Push("=");
                                nodo.agregarHijo("=");
                            }
                            else if ((token.getToken().Equals("++")) || (token.getToken().Equals("--")))
                            {
                                pilas.Pop();
                                pilas.Push(token.getTipo());
                                nodo.agregarHijo(token.getTipo());
                            }
                            else
                            {
                                pilas.Pop();
                                return false;
                            }
                            Form1.listaNodos.Add(nodo);
                            break;
                        }
                    case "O'":
                        {
                            Nodos nodo = new Nodos(peek);
                            if ((token.getToken().Equals("+")))
                            {
                                pilas.Pop();
                                pilas.Push("N'");
                                nodo.agregarHijo("N'");
                                pilas.Push("+");
                                nodo.agregarHijo("+");
                            }
                            else if ((token.getToken().Equals(";")))
                            {
                                pilas.Pop();
                            }
                            else
                            {
                                return false;
                            }
                            Form1.listaNodos.Add(nodo);
                            break;
                        }
                    case "N'":
                        {
                            Nodos nodo = new Nodos(peek);
                            if ((token.getTipo().Equals("ID")) || (token.getTipo().Equals("Texto")))
                            {
                                pilas.Pop();
                                pilas.Push("O'");
                                nodo.agregarHijo("O");
                                pilas.Push(token.getTipo());
                                nodo.agregarHijo(token.getTipo());
                            }
                            else
                            {
                                pilas.Pop();
                                pilas.Push("O'");
                                nodo.agregarHijo("O'");
                                return false;
                            }
                            Form1.listaNodos.Add(nodo);
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
                                if (token.getToken().Equals("{"))
                                {
                                    validacion++;
                                }
                                return false;
                            }
                            break;
                        }
                }

            }
            return true;


        }


    }
}
