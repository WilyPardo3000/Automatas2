using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompiladorVersion3
{
    public class ID
    {
        public ID(string nombre, string tipo, string direccionMemoria)
        {
            Nombre = nombre;
            Tipo = tipo;
            DireccionMemoria = direccionMemoria;
        }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string DireccionMemoria { get; set; }

    }
    public class Cuadruplo
    {
        public Cuadruplo(string opCode, string args1, string args2, string args3)
        {
            OpCode = opCode;
            this.args1 = args1;
            this.args2 = args2;
            this.args3 = args3;
        }
        public string OpCode { get; set; }
        public string args1 { get; set; }
        public string args2 { get; set; }
        public string args3 { get; set; }
    }
    public class Analisis_Semantico
    {
        int direcionMemoria;
        List<ID> variables;
        List<ID> mensajes;
        List<Cuadruplo> instrucciones;
        public Analisis_Semantico(int direcionMemoria)
        {
            this.direcionMemoria = direcionMemoria;
            variables = new List<ID>();
            mensajes = new List<ID>();
            instrucciones = new List<Cuadruplo>();
        }
        public ID ObtenerID(string Lexema)
        {
            ID id = null;
            foreach(ID item in variables)
            {
                if (item.Nombre.Equals(Lexema))
                {
                    id = item;
                    break;
                }
            }
            return id;
        }
        public bool AñadirID(string nombre, int tipo)
        {
            bool salida = false;
            ID id = ObtenerID(nombre);
            if(id == null)
            {
                string tipoReal = "NA";
                switch (tipo)
                {
                    case 5:
                        tipoReal = "int";
                        break;
                    case 6:
                        tipoReal = "float";
                        break;
                    case 7:
                        tipoReal = "bool";
                        break;
                    case 8:
                        tipoReal = "string";
                        break;
                }
                ID ap = new ID(nombre, tipoReal, direcionMemoria + "H");
                variables.Add(ap);
                direcionMemoria += 2;
                salida = true;
            }
            else
            {
                salida = false;
            }
            return salida;
        }
        public void AñadirMensaje(string nombre, string tipo)
        {
            mensajes.Add(new ID(nombre, "BYTE", "\""+tipo+"\""));
            mensajes.Add(new ID("Long_"+nombre, "EQU", "$ - "+nombre));
        }
        public List<ID> ObtenerMensajes()
        {
            return mensajes;
        } 
        public void añadirInstruccion(Cuadruplo instruccion)
        {
            instrucciones.Add(instruccion);
        }
        public List<Cuadruplo> obtenerInstrucciones()
        {
            return instrucciones;
        }
        public List<string> obtenerVariables()
        {
            List<string> salida = new List<string>();
            foreach (ID item in variables)
            {
                salida.Add(item.Nombre);
            }
            return salida;
        }
        public List<string> obtenerTipos()
        {
            List<string> salida = new List<string>();
            foreach (ID item in variables)
            {
                salida.Add(item.Tipo);
            }
            return salida;
        }
    }
}
