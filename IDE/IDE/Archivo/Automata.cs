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
        //Variables de la clase
        private string[] tokens;
        private int estado = 0;
        private Boolean enterTexto = false;
        ArrayList listaTokens = new ArrayList();

        //Metodos Get y set
        //Obtener el estado
        public int getEstado()
        {
            return this.estado;
        }
        //Asignarle el estado
        public void setEstado(int estado)
        {
            this.estado = estado;
        }

        //Metodo para generar los tokens
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
                    //Estado inicial
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
                            case ';':
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(31);
                                break;
                            case '=':
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(32);
                                break;
                            case '<':
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(33);
                                break;
                            case '>':
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(34);
                                break;
                            case '!':
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(35);
                                break;
                            case '|':
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(36);
                                break;
                            case '&':
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(37);
                                break;
                            case '(':
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(38);
                                break;
                            case ')':
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(39);
                                break;
                            default:
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(10);
                                break;
                        }
                        break;
                    //Token de enteros
                    case 1:
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
                            case '.':
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(2);
                                break;
                            default:
                                insertarTokens(tokenGenerado, getEstado());
                                tokenGenerado = "";
                                i = i - 1;
                                setEstado(0);
                                break;
                        }
                        break;
                    //Token para el punto para el decimal
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
                    //Token para decimal
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
                    //Token para signo negativo
                    case 4:
                        switch (tokenPorAnalizar)
                        {
                            case ' ':
                            case '\r':
                            case '\t':
                            case '\b':
                            case '\n':
                            case '\f':
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
                            case '-':
                                tokenGenerado += tokenPorAnalizar;
                                insertarTokens(tokenGenerado, getEstado());
                                tokenGenerado = "";
                                setEstado(0);
                                break;
                            default:
                                insertarTokens(tokenGenerado, getEstado());
                                tokenGenerado = "";
                                i = i - 1;
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(0);
                                break;
                        }
                        break;
                    //Token para texto y comillas
                    case 6:
                        switch (tokenPorAnalizar)
                        {
                            case '"':
                                tokenGenerado += tokenPorAnalizar;
                                insertarTokens(tokenGenerado, getEstado());
                                tokenGenerado = "";
                                setEstado(0);
                                break;
                            case '\n':
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(6);
                                enterTexto = true;
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
                    //Token para letra de verdadero
                    case 9:
                        switch (tokenPorAnalizar)
                        {

                            case 'e':
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(11);
                                break;
                            default:
                                setEstado(100);
                                i = i - 1;
                                break;
                        }
                        break;
                    //Token para caracter
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

                                    insertarTokens(tokenGenerado, getEstado());
                                    tokenGenerado = "";
                                    setEstado(0);
                                    break;
                                case '+':
                                case '-':
                                case '*':
                                case '/':
                                case '!':
                                case '>':
                                case '<':
                                case '=':
                                case '|':
                                case '&':
                                case '(':
                                case ')':
                                case ';':
                                case '"':
                                    insertarTokens(tokenGenerado, getEstado());
                                    tokenGenerado = "";
                                    i = i - 1;
                                    setEstado(0);
                                    break;

                                default:
                                    tokenGenerado += tokenPorAnalizar;
                                    setEstado(100);
                                    break;
                            }
                            break;
                        }
                    //Token para letra de verdadero
                    case 11:
                        switch (tokenPorAnalizar)
                        {

                            case 'r':
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(12);
                                break;
                            default:
                                setEstado(100);
                                i = i - 1;
                                break;
                        }
                        break;
                    //Token para letra de verdadero
                    case 12:
                        switch (tokenPorAnalizar)
                        {

                            case 'd':
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(13);
                                break;
                            default:
                                setEstado(100);
                                i = i - 1;
                                break;
                        }
                        break;
                    //Token para letra de verdadero
                    case 13:
                        switch (tokenPorAnalizar)
                        {

                            case 'a':
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(14);
                                break;
                            default:
                                setEstado(100);
                                i = i - 1;
                                break;
                        }
                        break;
                    //Token para letra de verdadero
                    case 14:
                        switch (tokenPorAnalizar)
                        {

                            case 'd':
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(15);
                                break;
                            default:
                                setEstado(100);
                                i = i - 1;
                                break;
                        }
                        break;
                    //Token para letra de verdadero
                    case 15:
                        switch (tokenPorAnalizar)
                        {

                            case 'e':
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(16);
                                break;
                            default:
                                setEstado(100);
                                i = i - 1;
                                break;
                        }
                        break;
                    //Token para letra de verdadero
                    case 16:
                        switch (tokenPorAnalizar)
                        {

                            case 'r':
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(17);
                                break;
                            default:
                                setEstado(100);
                                i = i - 1;
                                break;
                        }
                        break;
                    //Token para letra de verdadero
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
                                setEstado(100);
                                i = i - 1;
                                break;
                        }
                        break;
                    //Token para letra de falso
                    case 18:
                        switch (tokenPorAnalizar)
                        {

                            case 'a':
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(19);
                                break;
                            default:
                                setEstado(100);
                                i = i - 1;
                                break;
                        }
                        break;
                    //Token para letra de falso
                    case 19:
                        switch (tokenPorAnalizar)
                        {

                            case 'l':
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(20);
                                break;
                            default:
                                setEstado(100);
                                i = i - 1;
                                break;
                        }
                        break;
                    //Token para letra de falso
                    case 20:
                        switch (tokenPorAnalizar)
                        {

                            case 's':
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(21);
                                break;
                            default:
                                setEstado(100);
                                i = i - 1;
                                break;
                        }
                        break;
                    //Token para letra de falso
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
                                setEstado(100);
                                i = i - 1;
                                break;
                        }
                        break;
                    //Token para signo +
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
                            default:
                                insertarTokens(tokenGenerado, getEstado());
                                tokenGenerado = "";
                                i = i - 1;
                                setEstado(0);
                                break;
                        }
                        break;
                    //Token para el signo *
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
                            default:
                                insertarTokens(tokenGenerado, getEstado());
                                tokenGenerado = "";
                                i = i - 1;
                                setEstado(0);
                                break;
                        }
                        break;
                    //Token para el signo /
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
                            case '/':
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(28);
                                break;
                            case '*':
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(29);
                                break;
                            default:
                                insertarTokens(tokenGenerado, getEstado());
                                tokenGenerado = "";
                                i = i - 1;
                                setEstado(0);
                                break;
                        }
                        break;
                    //Token para el comentario //
                    case 28:
                        switch (tokenPorAnalizar)
                        {
                            case '\n':
                            case '\r':
                            case '\t':
                            case '\b':
                            case '\f':
                                insertarTokens(tokenGenerado, getEstado());
                                tokenGenerado = "";
                                setEstado(0);
                                break;
                            default:
                                if (i + 1 == codigo.Length)
                                {
                                    insertarTokens(tokenGenerado, getEstado());
                                    tokenGenerado = "";
                                    setEstado(0);
                                }
                                else
                                {
                                    tokenGenerado += tokenPorAnalizar;
                                    setEstado(28);
                                }
                                break;
                        }
                        break;
                    //Token para comentario cerrado
                    case 29:
                        switch (tokenPorAnalizar)
                        {
                            case '*':
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(30);
                                break;
                            case '\n':
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(29);
                                enterTexto = true;
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
                                    setEstado(29);
                                }
                                break;
                        }
                        break;
                    //Token para cerrar comentario
                    case 30:
                        switch (tokenPorAnalizar)
                        {
                            case '/':
                                tokenGenerado += tokenPorAnalizar;
                                insertarTokens(tokenGenerado, getEstado());
                                tokenGenerado = "";
                                setEstado(0);
                                break;
                            case '\n':
                                tokenGenerado += tokenPorAnalizar;
                                setEstado(30);
                                enterTexto = true;
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
                                    setEstado(30);
                                }
                                break;
                        }
                        break;
                    //Token para signo ;
                    case 31:
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
                                insertarTokens(tokenGenerado, getEstado());
                                tokenGenerado = "";
                                i = i - 1;
                                setEstado(0);
                                break;
                        }
                        break;
                    //Token para signo =
                    case 32:
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
                            case '=':
                                tokenGenerado += tokenPorAnalizar;
                                insertarTokens(tokenGenerado, 24);
                                tokenGenerado = "";
                                setEstado(0);
                                break;
                            default:
                                insertarTokens(tokenGenerado, getEstado());
                                tokenGenerado = "";
                                i = i - 1;
                                setEstado(0);
                                break;
                        }
                        break;
                    //Token para signo <
                    case 33:
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
                            case '=':
                                tokenGenerado += tokenPorAnalizar;
                                insertarTokens(tokenGenerado, getEstado());
                                tokenGenerado = "";
                                setEstado(0);
                                break;
                            default:
                                insertarTokens(tokenGenerado, getEstado());
                                tokenGenerado = "";
                                i = i - 1;
                                setEstado(0);
                                break;
                        }
                        break;
                    //Token para signo >
                    case 34:
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
                            case '=':
                                tokenGenerado += tokenPorAnalizar;
                                insertarTokens(tokenGenerado, getEstado());
                                tokenGenerado = "";
                                setEstado(0);
                                break;
                            default:
                                insertarTokens(tokenGenerado, getEstado());
                                tokenGenerado = "";
                                i = i - 1;
                                setEstado(0);
                                break;
                        }
                        break;
                    //Token para signo !
                    case 35:
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
                            case '=':
                                tokenGenerado += tokenPorAnalizar;
                                insertarTokens(tokenGenerado, getEstado());
                                tokenGenerado = "";
                                setEstado(0);
                                break;
                            default:
                                insertarTokens(tokenGenerado, getEstado());
                                tokenGenerado = "";
                                i = i - 1;
                                setEstado(0);
                                break;
                        }
                        break;
                    //Token para signo ||
                    case 36:
                        switch (tokenPorAnalizar)
                        {
                            case ' ':
                            case '\r':
                            case '\t':
                            case '\b':
                            case '\f':
                            case '\n':
                                insertarTokens(tokenGenerado, 100);
                                tokenGenerado = "";
                                setEstado(0);
                                break;
                            case '|':
                                tokenGenerado += tokenPorAnalizar;
                                insertarTokens(tokenGenerado, getEstado());
                                tokenGenerado = "";
                                setEstado(0);
                                break;
                            default:
                                insertarTokens(tokenGenerado, 100);
                                tokenGenerado = "";
                                i = i - 1;
                                setEstado(0);
                                break;
                        }
                        break;
                    //Token para signo &&
                    case 37:
                        switch (tokenPorAnalizar)
                        {
                            case ' ':
                            case '\r':
                            case '\t':
                            case '\b':
                            case '\f':
                            case '\n':
                                insertarTokens(tokenGenerado, 100);
                                tokenGenerado = "";
                                setEstado(0);
                                break;
                            case '&':
                                tokenGenerado += tokenPorAnalizar;
                                insertarTokens(tokenGenerado, getEstado());
                                tokenGenerado = "";
                                setEstado(0);
                                break;
                            default:
                                insertarTokens(tokenGenerado, 100);
                                tokenGenerado = "";
                                i = i - 1;
                                setEstado(0);
                                break;
                        }
                        break;
                    //Token para signo (
                    case 38:
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
                                insertarTokens(tokenGenerado, getEstado());
                                tokenGenerado = "";
                                i = i - 1;
                                setEstado(0);
                                break;
                        }
                        break;
                    //Token para signo )
                    case 39:
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
                                insertarTokens(tokenGenerado, getEstado());
                                tokenGenerado = "";
                                i = i - 1;
                                setEstado(0);
                                break;
                        }
                        break;
                    //Token para errores
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
                            case '+':
                            case '-':
                            case '*':
                            case '/':
                            case '!':
                            case '>':
                            case '<':
                            case '=':
                            case '|':
                            case '&':
                            case '(':
                            case ')':
                            case ';':
                            case '"':
                                insertarTokens(tokenGenerado, getEstado());
                                tokenGenerado = "";
                                i = i - 1;
                                setEstado(0);
                                break;
                            default:
                                tokenGenerado += tokenPorAnalizar;
                                break;
                        }
                        break;
                    default:
                        break;
                }
                //Detecta un salto de linea
                if ((tokenPorAnalizar.Equals('\n') && (!enterTexto)))
                    insertarTokens(tokenPorAnalizar.ToString(), 99);
                else
                    enterTexto = false;
            }
            //Reinicia el token y devuelve la lista de tokens
            tokenGenerado = "";
            return this.listaTokens;
        }
        //Inserta tokens a la lista
        public void insertarTokens(String token, int estadoActual)
        {
            //Nuevo token
            tokens tokenNuevo;
            switch (estadoActual)
            {
                //Asignacion de token y tipo
                case 1:
                    tokenNuevo = new tokens(token, "Entero");
                    listaTokens.Add(tokenNuevo);
                    break;
                case 3:
                    tokenNuevo = new tokens(token, "Decimal");
                    listaTokens.Add(tokenNuevo);
                    break;
                case 6:
                    tokenNuevo = new tokens(token, "Texto");
                    listaTokens.Add(tokenNuevo);
                    break;
                case 17:
                case 21:
                    tokenNuevo = new tokens(token, "Booleano");
                    listaTokens.Add(tokenNuevo);
                    break;
                case 100:
                    tokenNuevo = new tokens(token, "Error");
                    listaTokens.Add(tokenNuevo);
                    break;
                case 99:
                    tokenNuevo = new tokens(token, "Enter");
                    listaTokens.Add(tokenNuevo);
                    break;
                case 10:
                    tokenNuevo = new tokens(token, "Caracter");
                    listaTokens.Add(tokenNuevo);
                    break;
                case 28:
                case 30:
                    tokenNuevo = new tokens(token, "Comentario");
                    listaTokens.Add(tokenNuevo);
                    break;
                case 31:
                case 32:
                    tokenNuevo = new tokens(token, "AsignacionFin");
                    listaTokens.Add(tokenNuevo);
                    break;
                case 4:
                case 24:
                case 26:
                case 27:
                case 33:
                case 34:
                case 35:
                case 36:
                case 37:
                case 38:
                case 39:
                    tokenNuevo = new tokens(token, "Operador Aritmetico");
                    listaTokens.Add(tokenNuevo);
                    break;
            }
        }
    }
}
