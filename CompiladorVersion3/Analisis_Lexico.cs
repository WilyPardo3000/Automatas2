using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CompiladorVersion3
{
    public class Analisis_Lexico
    {
        private List<Token> listaTokens = new List<Token>();
        private string logSalida = string.Empty;
        public string Scanner(string[] texto)
        {
            List<string> lineas = new List<string>();
            this.listaTokens.Clear();
            lineas.Clear();
            for (int i = 0; i < texto.Count(); i++)
                lineas.Add(texto[i]);

            string salida = string.Empty;
            int index = 1;
            foreach (string linea in lineas)
            {
                salida += "Linea: " + index + " " + linea.TrimStart() + "\n";
                salida += AnalizarLinea(linea);
                index++;
            }
            return salida;
        }
        public string AnalizarLinea(string linea)
        {
            logSalida = "";
            char[] caracteres = linea.ToCharArray();
            string lexema = "";
            bool flagChar = false;
            for (int i = 0; i < caracteres.Length; i++)
            {
                string caracter = caracteres[i] + "";

                if (flagChar)
                {
                    if (caracter.Equals("\""))
                    {
                        flagChar = false;
                        Token token = new Token("string", lexema, false, -3); //definir codigo string
                        this.logSalida += string.Format("\t< TKN, {0}, {1} >\n", token.Nombre, token.Lexema);
                        this.listaTokens.Add(token);
                        AnalizarLexema(caracter);
                        lexema = "";
                        continue;
                    }
                    lexema += caracter;
                    continue;
                }
                if (Gramatica.INSTANCIA().EsLexema(caracter))
                {
                    if (caracter.Equals("\""))
                    {
                        flagChar = true;
                    }
                    if (!lexema.Equals(""))
                    {
                        AnalizarLexema(lexema);
                    }
                    AnalizarLexema(caracter);
                    lexema = "";
                }
                else if (caracter.Equals(" "))
                {
                    if (!lexema.Equals(""))
                    {
                        AnalizarLexema(lexema);
                    }
                    lexema = "";
                }
                else
                {
                    lexema += caracter;
                }
            }
            if (!lexema.Equals(""))
            {
                AnalizarLexema(lexema);
            }
            return logSalida;
        }
        private void AnalizarLexema(string lexema)
        {
            Token token = Gramatica.INSTANCIA().ObtenerSimboloPorLexema(lexema);
            if (null == token)
            {
                if (Automatas.EsIdentificador(lexema))
                    token = new Token("id", lexema, false, 0);//definir codigo id
                else if (Automatas.EsNumero(lexema))
                    token = new Token("n_int", lexema, false, -1);//definir codigo int
                else if (Automatas.EsReal(lexema))
                    token = new Token("n_float", lexema, false, -2);//definir codigo float

                if (!Gramatica.INSTANCIA().ExisteLexemaID(lexema))
                {
                    Gramatica.INSTANCIA().Tokens.Add(token);
                }
            }
            if (null != token)
            {
                logSalida += string.Format("\t< TKN, {0}, {1} >\n", token.Nombre, token.Lexema);
                //this.logSalida += "\tToken: " + simbolo.Token + " Lexema: " + simbolo.Lexema + "\n";
                this.listaTokens.Add(token);
            }
            else
            {
                logSalida = string.Format("\t<ERROR, {0}, {1} >\n", "NO_IDENTIFICADO", lexema);
                logSalida += "\tERROR: " + lexema + "\n";
            }
        }
        public List<Token> ListadoTokens
        {
            get { return listaTokens; }
            set { listaTokens = value; }
        }
        private string LogSalida
        {
            get { return logSalida; }
            set { logSalida = value; }
        }
    }
    public class Gramatica
    {
        private List<Token> tokens;
        private static Gramatica Instancia;
        public Gramatica()
        {
            /*
                Codigos para valores volatiles
                string = -3
                float = -2    
                int = -1
                id = 0
             */
            tokens = new List<Token>();
            tokens.Add(new Token("start", "InicioPrograma", true, 1));
            tokens.Add(new Token("end", "FinPrograma", true, 2));
            //Elementos para declaracion
            tokens.Add(new Token("declaration", "Declarar", true, 3));
            tokens.Add(new Token("as", "Como", true, 4));
            tokens.Add(new Token("int", "Entero", true, 5));
            tokens.Add(new Token("float", "Real", true, 6));
            tokens.Add(new Token("bool", "Logico", true, 7));
            tokens.Add(new Token("string", "Texto", true, 8));
            //elementos para asignacion
            tokens.Add(new Token("asing", "=", true, 9));
            //elementos para operaciones / operadores
            tokens.Add(new Token("minus", "-", true, 10));
            tokens.Add(new Token("plus", "+", true, 11));
            tokens.Add(new Token("by", "*", true, 12));
            tokens.Add(new Token("with", "/", true, 13));
            tokens.Add(new Token("pow", "^", true, 14));
            //elementos para condiciones
            tokens.Add(new Token("or", "|", true, 15));
            tokens.Add(new Token("and", "&", true, 16));
            tokens.Add(new Token("getter than", ">", true, 17));
            tokens.Add(new Token("less than", "<", true, 18));
            tokens.Add(new Token("opposite", "!", true, 19));
            //elementos para funciones
            tokens.Add(new Token("start_if", "Si", true, 20));
            tokens.Add(new Token("then", "Entonces", true, 21));
            tokens.Add(new Token("else", "Sino", true, 22));
            tokens.Add(new Token("end_if", "FinSi", true, 23));
            tokens.Add(new Token("start_while", "Mientras", true, 24));
            tokens.Add(new Token("end_while", "FinMientras", true, 25));
            //elementos para separacion o apoyo
            tokens.Add(new Token("separator_Open", "(", true, 26));
            tokens.Add(new Token("separator_Closed", ")", true, 27));
            tokens.Add(new Token("Comma", ",", true, 28));
            tokens.Add(new Token("Period_And_comma", ";", true, 29));
            tokens.Add(new Token("true", "Verdadero", true, 30));
            tokens.Add(new Token("false", "Falso", true, 31));
            tokens.Add(new Token("SE_string", "\"", true, 32));
            //elementos para la impresion y lectura
            tokens.Add(new Token("print", "Mostrar", true, 33));
            tokens.Add(new Token("read", "Leer", true, 34));
        }
        public static Gramatica INSTANCIA()
        {
            if (Instancia == null)
            {
                Instancia = new Gramatica();
            }
            return Instancia;
        }
        public List<Token> Tokens
        {
            get { return tokens; }
            set { tokens = value; }
        }
        public List<Token> ObtenerTokens()
        {
            return tokens;
        }
        public Token ObtenerSimboloPorLexema(string lexema)
        {
            foreach (Token item in tokens)
                if (item != null)
                    if (item.Lexema.Equals(lexema))
                        return item;
            return null;
        }
        public bool EsLexema(string lexema)
        {
            foreach (Token item in tokens)
            {
                if (item != null)
                    if (item.Lexema.Equals(lexema) && item.EsPalabraReservada)
                        return true;
            }
            return false;
        }
        public bool ExisteLexemaID(string lexema)
        {
            foreach (Token item in tokens)
                if (item != null)
                    if (lexema.Equals(item.Lexema) && !item.EsPalabraReservada)
                        return true;
            return false;
        }
    }
    class Automatas
    {
        public static bool EsIdentificador(string lexema)
        {
            string letras = @"[a-zA-Z]";
            string digitoLetra = @"[0-9A-Z_a-z]";
            int estado = 1;
            foreach (char c in lexema.ToCharArray())
            {
                Match entroLetra = Regex.Match(c + "", letras);
                Match entroDigitoLetra = Regex.Match(c + "", digitoLetra);
                switch (estado)
                {
                    case 1:
                        if (entroLetra.Success)
                            estado = 2;
                        else
                            estado = 3;

                        break;
                    case 2:
                        if (entroDigitoLetra.Success)
                            estado = 2;
                        else
                            estado = 3;

                        break;
                }
            }
            if (estado != 3 && lexema.Last() != '_')
                return true;
            else
                return false;
        }
        public static bool EsNumero(string lexema)
        {
            string digito = "[0-9]";
            string caracter = "";
            int estado = 1;
            foreach (char c in lexema.ToCharArray())
            {
                caracter = c + "";
                Match entroNumero = Regex.Match(caracter, digito);
                switch (estado)
                {
                    case 1:
                        if (entroNumero.Success)
                            estado = 1;
                        else
                            estado = 2;
                        break;
                }
            }
            if (estado != 2)
                return true;
            return false;
        }
        public static bool EsReal(string lexema)
        {
            string caracter = "";
            char[] palabra = lexema.ToCharArray();
            int estado = 1;
            for (int i = 0; i < palabra.Length; i++)
            {
                caracter = palabra[i] + "";
                switch (estado)
                {
                    case 1:
                        if (EsNumero(caracter))
                            estado = 1;
                        else
                        {
                            estado = 2;
                            i--;
                        }
                        break;
                    case 2:
                        if (caracter.Equals("."))
                        {
                            if (i + 1 != lexema.Length)
                            {
                                estado = 3;
                            }
                            else
                            {
                                estado = 10;
                            }
                        }
                        else if (caracter.Equals("E"))
                        {
                            if (i + 1 != lexema.Length)
                            {
                                estado = 4;
                            }
                            else
                            {
                                estado = 10;
                            }
                        }
                        else
                        {
                            estado = 10;
                        }
                        break;
                    case 3:
                        if (EsNumero(caracter))
                        {
                            estado = 3;
                        }
                        else if (caracter.Equals("E"))
                        {
                            if (i + 1 != lexema.Length)
                            {
                                estado = 4;
                            }
                            else
                            {
                                estado = 10;
                            }
                        }
                        else
                        {
                            estado = 10;
                        }
                        break;
                    case 4:
                        if (caracter.Equals("+") || caracter.Equals("-"))
                        {
                            if (i + 1 != lexema.Length)
                            {
                                estado = 5;
                            }
                            else
                            {
                                estado = 10;
                            }
                        }
                        else
                        {
                            estado = 10;
                        }
                        break;
                    case 5:
                        if (EsNumero(caracter))
                        {
                            estado = 5;
                        }
                        else
                        {
                            estado = 10;
                        }
                        break;
                }
            }
            if (estado != 10)
                return true;

            return false;
        }
    }

    public class Token
    {
        private string nombre;
        private string lexema;
        private bool esPalabraReservada;
        private int codigo;
        public Token(string nombre, string lexema, bool esPalabraReservada, int codigo)
        {
            this.nombre = nombre;
            this.lexema = lexema;
            this.esPalabraReservada = esPalabraReservada;
            this.codigo = codigo;
        }
        public string Nombre
        {
            get { return nombre; }
        }
        public string Lexema
        {
            get { return lexema; }
        }
        public bool EsPalabraReservada
        {
            get { return esPalabraReservada; }
        }
        public int Codigo
        {
            get { return codigo; }
        }
    }
}
