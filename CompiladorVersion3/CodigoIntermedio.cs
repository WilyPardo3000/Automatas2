using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompiladorVersion3
{
    public class CodigoIntermedio
    {
        string codigoIntermedio;
        Analisis_Semantico semantico;
        public CodigoIntermedio(Analisis_Semantico semantico)
        {
            this.semantico = semantico;
            this.codigoIntermedio = string.Empty;
        }
        public string obtenerCodigoIntermedio()
        {
            codigoIntermedio = generarVariables();
            codigoIntermedio += generarCodigo();
            return codigoIntermedio;
        }
        public string generarVariables()
        {
            string salida = ".DATA\n";
            salida += "; Variables creadas desde compilador\n";
            List<string> variables = semantico.obtenerVariables();
            List<ID> mensajes = semantico.ObtenerMensajes();
            List<string> tipos = semantico.obtenerTipos();
            for (int i = 1; i < variables.Count(); i++)
            {
                if(variables[i].Length <= 7)
                {
                    salida += variables[i] + "\t\t\t";
                }
                else if(variables[i].Length >= 8 && variables[i].Length <= 15)
                {
                    salida += variables[i] + "\t\t";
                }
                else if (variables[i].Length >= 16 && variables[i].Length <= 23)
                {
                    salida += variables[i] + "\t";
                }
                string var = "";
                switch (tipos[i])
                {
                    case "int":
                        var = "DWORD";
                        break;
                    case "float":
                        var = "DWORD";
                        break;
                    case "bool":
                        var = "BYTE";
                        break;
                    case "string":
                        var = "BYTE";
                        break;
                }
                salida += var + "\t\t?\n";
            }
            salida += "; Variables creadas para manejo de impresiones\n";
            for (int i = 0; i < mensajes.Count; i++)
            {
                if (mensajes[i].Nombre.Length <= 7)
                {
                    salida += mensajes[i].Nombre + "\t\t\t" + mensajes[i].Tipo + "\t";
                }
                else if (mensajes[i].Nombre.Length >= 8 && mensajes[i].Nombre.Length <= 15)
                {
                    salida += mensajes[i].Nombre + "\t\t" + mensajes[i].Tipo + "\t\t";
                }
                else if (mensajes[i].Nombre.Length >= 16 && mensajes[i].Nombre.Length <= 23)
                {
                    salida += mensajes[i].Nombre + "\t\t" + mensajes[i].Tipo + "\t\t";
                }
                salida += mensajes[i].DireccionMemoria + "\n";
            }
            salida +=
                    "; Variables requeridas por las llamadas al sistema operativo\n" +
                    "ManejadorE\tDWORD\t\t?\n" +
                    "ManejadorS\tDWORD\t\t?\n" +
                    "Caracteres\tDWORD\t\t?\n" +
                    "Texto\t\tBYTE\t\t13 DUP( ? )\n" +
                    "SaltoLinea\tBYTE\t\t13, 10\n" +
                    "STD_INPUT\tEQU\t\t-10\n" +
                    "STD_OUTPUT\tEQU\t\t-11\n";
            return salida;
        }
        public string generarCodigo()
        {
            List<Cuadruplo> instrucciones = semantico.obtenerInstrucciones();
            string salida = ".CODE\n" + semantico.obtenerVariables()[0] + "\t" + "PROC\n";
            salida += 
            "\t; Obtener los manejadores de la entrada y salida estandar\n" +
            "\tINVOKE\tGetStdHandle, STD_INPUT; entrada estandar aqui\n" +
            "\tMOV\tManejadorE, EAX\n" +
            "\tINVOKE\tGetStdHandle, STD_OUTPUT; salida estandar aqui\n" +
            "\tMOV\tManejadorS, EAX\n" +
            "\t; Instrucciones hechas desde el compilador\n";
            //AQUI DEBE DARSE LA GENERACION DE CODIGO INTERMEDIO
            foreach(Cuadruplo item in instrucciones)
            {
                switch (item.OpCode)
                {
                    case "Leer": //arg1 = id_mensaje, arg2 = id
                        if (item.args1.Equals("")) 
                        {
                            salida += "\tINVOKE\tReadConsoleA, ManejadorE, ADDR Texto, 13, ADDR Caracteres, 0\n";
                        }
                        else
                        {
                            salida +=
                            string.Format("\tMOV\tEAX, Long_{0}\n\t" +
                            "INVOKE	WriteConsoleA, ManejadorS, ADDR {0}, EAX, ADDR Caracteres, 0\n" +
                            "\tINVOKE\tReadConsoleA, ManejadorE, ADDR Texto, 13, ADDR Caracteres, 0\n", item.args1);
                        }
                        salida += string.Format("\tCONV Texto, {0}\n", item.args2);
                        break;
                    case "Mostrar": //arg1 = id_mensaje, arg2 = id
                        if(item.args1.Equals("") && !item.args2.Equals(""))//sin texto, con id
                        {
                            salida +=
                            "\tCONV\t" + item.args2 + ", Texto, Caracteres\n" +
                            "\tINVOKE WriteConsoleA, ManejadorS, ADDR Texto, Caracteres, ADDR Caracteres, 0\n" +
                            "\tINVOKE\tWriteConsoleA, ManejadorS, ADDR SaltoLinea, 2, ADDR Caracteres, 0\n";
                        }
                        else if (!item.args1.Equals("") && item.args2.Equals(""))//con texto, sin id
                        {
                            salida +=
                            "\tMOV\tEAX, Long_" + item.args1 + "\n" +
                            "\tINVOKE\tWriteConsoleA, ManejadorS, ADDR " + item.args1 + ", EAX, ADDR Caracteres, 0\n" +
                            "\tINVOKE\tWriteConsoleA, ManejadorS, ADDR SaltoLinea, 2, ADDR Caracteres, 0\n";
                        }
                        else if(!item.args1.Equals("") && !item.args2.Equals(""))//con texto, con id
                        {
                            salida +=
                            "\tMOV\tEAX, Long_" + item.args1 + "\n" +
                            "\tINVOKE\tWriteConsoleA, ManejadorS, ADDR " + item.args1 + ", EAX, ADDR Caracteres, 0\n" +
                            "\tCONV\t" + item.args2 + ", Texto, Caracteres\n" +
                            "\tINVOKE WriteConsoleA, ManejadorS, ADDR Texto, Caracteres, ADDR Caracteres, 0\n" +
                            "\tINVOKE\tWriteConsoleA, ManejadorS, ADDR SaltoLinea, 2, ADDR Caracteres, 0\n";
                        }
                        break;
                    default:
                        salida += "\t" + item.OpCode + "\t" + item.args1 + item.args2 + item.args3 + "\n";
                        break;
                }
            }
            //AQUI TERMINA LA GENERACION DE CODIGO INTERMEDIO
            salida +=
            "\t; Salir al sistema operativo\n" +
            "\tINVOKE ExitProcess, 0\n" + 
            semantico.obtenerVariables()[0] + "\t" + "ENDP\n" + 
            "\t\tEND\t\t" + semantico.obtenerVariables()[0];
            return salida;
        }
    }
}
