using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace IDE.Archivo
{
    class Automata
    {
        private string[] tokens;
        public int estado = 0;
        ArrayList listaTokens = new ArrayList(); 

        //Metodos Get y set
        public int getEstado()
        {
            return this.estado;
        }
        public void setEstado(int estado)
        {
            this.estado = estado; 
        }


        public ArrayList generarTokens(String codigo)
        {
            codigo += " ";
            char tokenPorAnalizar;
            String tokenGenerado = "";
            for (int i = 0; i < codigo.Length; i++)
            {
                tokenPorAnalizar = codigo[i];
                switch (estado)
                {
                    case 0:
                        switch (tokenPorAnalizar)
                        {
                            case ' ':
                            case '\r':
                            case '\t':
                            case '\b':
                            case '\f':
                            case '\n':
                                break;
                            case '0':
                            case '1':
                            case '2':
                            case '3':
                            case '4':
                            case '5':
                            case '6':
                            case '7':
                            case '8':
                            case '9':
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(1);
                                break;
                            case '-':
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(4);
                                break;
                            case '+':
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(24);
                                break;
                            case '*':
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(26);
                                break;
                            case '/':
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(27);
                                break;
                            case '"':
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(6);
                                break;
                            case 'v':
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(9);
                                break;
                            case 'f':
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(18);
                                break;
                            default:
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(10);
                                break;
                        }
                        break;
                    case 1:
                        switch (tokenPorAnalizar)
                        {
                            case ' ':
                            case '\r':
                            case '\t':
                            case '\b':
                            case '\f':
                            case '\n':
                                insertarTokens(tokenGenerado,getEstado());
                                tokenGenerado = "";
                                setEstado(0);
                                break;
                            case '0':
                            case '1':
                            case '2':
                            case '3':
                            case '4':
                            case '5':
                            case '6':
                            case '7':
                            case '8':
                            case '9':
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(1);
                                break;
                            case '+':
                                insertarTokens(tokenGenerado,getEstado());
                                tokenGenerado = "";
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(24);
                                break;
                            case '-':
                                insertarTokens(tokenGenerado, getEstado());
                                tokenGenerado = "";
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(4);
                                break;
                            case '*':
                                insertarTokens(tokenGenerado, getEstado());
                                tokenGenerado = "";
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(26);
                                break;
                            case '/':
                                insertarTokens(tokenGenerado, getEstado());
                                tokenGenerado = "";
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(27);
                                break;
                            case '.':
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(2);
                                break;
                            default:
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(100);
                                break;
                        }
                        break;
                    case 2:
                        switch (tokenPorAnalizar)
                        {
                            case '0':
                            case '1':
                            case '2':
                            case '3':
                            case '4':
                            case '5':
                            case '6':
                            case '7':
                            case '8':
                            case '9':
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(3);
                                break;
                            default:
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(100);
                                break;
                        }
                        break;
                    case 3:
                        switch (tokenPorAnalizar)
                        {
                            case ' ':
                            case '\r':
                            case '\t':
                            case '\b':
                            case '\f':
                            case '\n':
                                insertarTokens(tokenGenerado, getEstado());
                                tokenGenerado = "";
                                setEstado(0);
                                break;
                            case '0':
                            case '1':
                            case '2':
                            case '3':
                            case '4':
                            case '5':
                            case '6':
                            case '7':
                            case '8':
                            case '9':
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(3);
                                break;
                            default:
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(100);
                                break;
                        }
                        break;
                    case 4:
                        switch (tokenPorAnalizar)
                        {
                            case ' ':
                            case '\r':
                            case '\t':
                            case '\b':
                            case '\f':
                            case '\n':
                                insertarTokens(tokenGenerado, getEstado());
                                tokenGenerado = "";
                                setEstado(0);
                                break;
                            case '0':
                            case '1':
                            case '2':
                            case '3':
                            case '4':
                            case '5':
                            case '6':
                            case '7':
                            case '8':
                            case '9':
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(1);
                                break;
                            case 'v':
                                insertarTokens(tokenGenerado, getEstado());
                                tokenGenerado = "";
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(9);
                                break;
                            case 'f':
                                insertarTokens(tokenGenerado, getEstado());
                                tokenGenerado = "";
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(18);
                                break;
                            case '-':
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(5);
                                break;
                            case '*':
                                insertarTokens(tokenGenerado, getEstado());
                                tokenGenerado = "";
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(26);
                                break;
                            case '/':
                                insertarTokens(tokenGenerado, getEstado());
                                tokenGenerado = "";
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(27);
                                break;
                            case '"':
                                insertarTokens(tokenGenerado, getEstado());
                                tokenGenerado = "";
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(6);
                                break;
                            default:
                                insertarTokens(tokenGenerado, getEstado());
                                tokenGenerado = "";
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(10);
                                break;
                        }
                        break;
                    case 5:
                        switch (tokenPorAnalizar)
                        {
                            case ' ':
                            case '\r':
                            case '\t':
                            case '\b':
                            case '\f':
                            case '\n':
                                insertarTokens(tokenGenerado, getEstado());
                                tokenGenerado = "";
                                setEstado(0);
                                break;
                            default:
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(100);
                                break;
                        }
                        break;
                    case 6:
                        switch (tokenPorAnalizar)
                        {
                            case '"':
                                tokenGenerado += tokenPorAnalizar;
                                insertarTokens(tokenGenerado, getEstado());
                                tokenGenerado = "";
                                setEstado(0);
                                break;
                            default:
                                if (i + 1 == codigo.Length)
                                {
                                    insertarTokens(tokenGenerado, 100);
                                    tokenGenerado = "";
                                    setEstado(0);
                                }
                                else
                                {
                                    tokenGenerado += tokenPorAnalizar;
                                    setEstado(6);   
                                }
                                break;
                        }
                        break;
                    case 9:
                        switch (tokenPorAnalizar)
                        {
                          
                            case 'e':
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(11);
                                break;
                            default:
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(100);
                                break;
                        }
                        break;
                    case 10:
                        {
                            switch (tokenPorAnalizar)
                            {
                                case ' ':
                                case '\r':
                                case '\t':
                                case '\n':
                                case '\b':
                                case '\f':

                                    insertarTokens(tokenGenerado,getEstado());
                                    tokenGenerado = "";
                                    setEstado(0);
                                    break;
                                case '+':
                                    insertarTokens(tokenGenerado, getEstado());
                                    tokenGenerado = "";
                                    tokenGenerado += tokenPorAnalizar;
                                    setEstado(24);
                                    break;
                                case '-':
                                    insertarTokens(tokenGenerado, 100);
                                    tokenGenerado = "";
                                    tokenGenerado += tokenPorAnalizar;
                                    setEstado(4);
                                    break;
                                case '*':
                                    insertarTokens(tokenGenerado, getEstado());
                                    tokenGenerado = "";
                                    tokenGenerado += tokenPorAnalizar;
                                    setEstado(26);
                                    break;
                                case '/':
                                    insertarTokens(tokenGenerado, getEstado());
                                    tokenGenerado = "";
                                    tokenGenerado += tokenPorAnalizar;
                                    setEstado(27);
                                    break;
                                default:
                                    tokenGenerado += tokenPorAnalizar;
                                    setEstado(100);
                                    break;
                            }
                            break;
                        }
                    case 11:
                        switch (tokenPorAnalizar)
                        {

                            case 'r':
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(12);
                                break;
                            default:
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(100);
                                break;
                        }
                        break;
                    case 12:
                        switch (tokenPorAnalizar)
                        {

                            case 'd':
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(13);
                                break;
                            default:
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(100);
                                break;
                        }
                        break;
                    case 13:
                        switch (tokenPorAnalizar)
                        {

                            case 'a':
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(14);
                                break;
                            default:
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(100);
                                break;
                        }
                        break;
                    case 14:
                        switch (tokenPorAnalizar)
                        {

                            case 'd':
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(15);
                                break;
                            default:
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(100);
                                break;
                        }
                        break;
                    case 15:
                        switch (tokenPorAnalizar)
                        {

                            case 'e':
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(16);
                                break;
                            default:
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(100);
                                break;
                        }
                        break;
                    case 16:
                        switch (tokenPorAnalizar)
                        {

                            case 'r':
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(17);
                                break;
                            default:
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(100);
                                break;
                        }
                        break;
                    case 17:
                        switch (tokenPorAnalizar)
                        {

                            case 'o':
                                tokenGenerado += tokenPorAnalizar;
                                insertarTokens(tokenGenerado, getEstado());
                                tokenGenerado = "";
                                setEstado(0);
                                break;
                            default:
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(100);
                                break;
                        }
                        break;
                    case 18:
                        switch (tokenPorAnalizar)
                        {

                            case 'a':
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(19);
                                break;
                            default:
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(100);
                                break;
                        }
                        break;
                    case 19:
                        switch (tokenPorAnalizar)
                        {

                            case 'l':
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(20);
                                break;
                            default:
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(100);
                                break;
                        }
                        break;
                    case 20:
                        switch (tokenPorAnalizar)
                        {

                            case 's':
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(21);
                                break;
                            default:
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(100);
                                break;
                        }
                        break;
                    case 21:
                        switch (tokenPorAnalizar)
                        {

                            case 'o':
                                tokenGenerado += tokenPorAnalizar;
                                insertarTokens(tokenGenerado, getEstado());
                                tokenGenerado = "";
                                setEstado(0);
                                break;
                            default:
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(100);
                                break;
                        }
                        break;
                    case 24:
                        switch (tokenPorAnalizar)
                        {
                            case ' ':
                            case '\r':
                            case '\t':
                            case '\b':
                            case '\f':
                            case '\n':
                                insertarTokens(tokenGenerado, getEstado());
                                tokenGenerado = "";
                                setEstado(0);
                                break;
                            case '+':
                                tokenGenerado += tokenPorAnalizar;
                                insertarTokens(tokenGenerado, getEstado());
                                tokenGenerado = "";
                                setEstado(0);
                                break;
                            case 'v':
                                insertarTokens(tokenGenerado, getEstado());
                                tokenGenerado = "";
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(9);
                                break;
                            case 'f':
                                insertarTokens(tokenGenerado, getEstado());
                                tokenGenerado = "";
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(18);
                                break;
                            case '"':
                                insertarTokens(tokenGenerado, getEstado());
                                tokenGenerado = "";
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(6);
                                break;
                            case '0':
                            case '1':
                            case '2':
                            case '3':
                            case '4':
                            case '5':
                            case '6':
                            case '7':
                            case '8':
                            case '9':
                                insertarTokens(tokenGenerado, getEstado());
                                tokenGenerado = "";
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(1);
                                break;
                            default:
                                insertarTokens(tokenGenerado, getEstado());
                                tokenGenerado = "";
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(10);
                                break;
                        }
                        break;
                    case 26:
                        switch (tokenPorAnalizar)
                        {
                            case ' ':
                            case '\r':
                            case '\t':
                            case '\b':
                            case '\f':
                            case '\n':
                                insertarTokens(tokenGenerado, getEstado());
                                tokenGenerado = "";
                                setEstado(0);
                                break;
                            case 'v':
                                insertarTokens(tokenGenerado, getEstado());
                                tokenGenerado = "";
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(9);
                                break;
                            case 'f':
                                insertarTokens(tokenGenerado, getEstado());
                                tokenGenerado = "";
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(18);
                                break;
                            case '"':
                                insertarTokens(tokenGenerado, getEstado());
                                tokenGenerado = "";
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(6);
                                break;
                            case '0':
                            case '1':
                            case '2':
                            case '3':
                            case '4':
                            case '5':
                            case '6':
                            case '7':
                            case '8':
                            case '9':
                                insertarTokens(tokenGenerado, getEstado());
                                tokenGenerado = "";
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(1);
                                break;
                            default:
                                insertarTokens(tokenGenerado, getEstado());
                                tokenGenerado = "";
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(10);
                                break;
                        }
                        break;
                    case 27:
                        switch (tokenPorAnalizar)
                        {
                            case ' ':
                            case '\r':
                            case '\t':
                            case '\b':
                            case '\f':
                            case '\n':
                                insertarTokens(tokenGenerado, getEstado());
                                tokenGenerado = "";
                                setEstado(0);
                                break;
                            case 'v':
                                insertarTokens(tokenGenerado, getEstado());
                                tokenGenerado = "";
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(9);
                                break;
                            case 'f':
                                insertarTokens(tokenGenerado, getEstado());
                                tokenGenerado = "";
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(18);
                                break;
                            case '"':
                                insertarTokens(tokenGenerado, getEstado());
                                tokenGenerado = "";
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(6);
                                break;
                            case '0':
                            case '1':
                            case '2':
                            case '3':
                            case '4':
                            case '5':
                            case '6':
                            case '7':
                            case '8':
                            case '9':
                                insertarTokens(tokenGenerado, getEstado());
                                tokenGenerado = "";
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(1);
                                break;
                            default:
                                insertarTokens(tokenGenerado, getEstado());
                                tokenGenerado = "";
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(10);
                                break;
                        }
                        break;
                    case 100:
                        switch (tokenPorAnalizar)
                        {
                            case '\n':
                            case ' ':
                            case '\r':
                            case '\t':
                            case '\b':
                            case '\f':
                                insertarTokens(tokenGenerado, getEstado());
                                tokenGenerado = "";
                                setEstado(0);
                                break;
                            case '"':
                                insertarTokens(tokenGenerado, getEstado());
                                tokenGenerado = "";
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(6);
                                break;
                            case '+':
                                insertarTokens(tokenGenerado, getEstado());
                                tokenGenerado = "";
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(24);
                                break;
                            case '*':
                                insertarTokens(tokenGenerado, getEstado());
                                tokenGenerado = "";
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(26);
                                break;
                            case '/':
                                insertarTokens(tokenGenerado, getEstado());
                                tokenGenerado = "";
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(27);
                                break;
                            case '-':
                                insertarTokens(tokenGenerado, getEstado());
                                tokenGenerado = "";
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(4);
                                break;
                            default:
                                tokenGenerado += tokenPorAnalizar;
                                break;
                        }
                        break;
                    default:
                        break;
                }
                
               
            }
            tokenGenerado = "";
            return this.listaTokens;
        }

        public void insertarTokens(String token, int estadoActual)
        {
            tokens tokenNuevo;
            switch (estadoActual)
            {
                case 1:
                    tokenNuevo = new tokens(token,"Morado","Entero");
                    listaTokens.Add(tokenNuevo);
                    break;
                case 3:
                    tokenNuevo = new tokens(token, "Celeste", "Decimal");
                    listaTokens.Add(tokenNuevo);
                    break;
                case 6:
                    tokenNuevo = new tokens(token, "Gris", "Texto");
                    listaTokens.Add(tokenNuevo);
                    break;
                case 17:
                case 21:
                    tokenNuevo = new tokens(token, "Naranja", "Booleano");
                    listaTokens.Add(tokenNuevo);
                    break;
                case 100:
                    tokenNuevo = new tokens(token, "Gris", "Error");
                    listaTokens.Add(tokenNuevo);
                    break;
                case 67:
                    tokenNuevo = new tokens(token, "Nulo", "Enter");
                    listaTokens.Add(tokenNuevo);
                    break;
                case 10:
                    tokenNuevo = new tokens(token, "Cafe", "Caracter");
                    listaTokens.Add(tokenNuevo);
                    break;
                case 4:
                case 5:
                case 24:
                case 26:
                case 27:
                    tokenNuevo = new tokens(token, "Azul", "Operador Aritmetico");
                    listaTokens.Add(tokenNuevo);
                    break;
            }

        }
    }
}
