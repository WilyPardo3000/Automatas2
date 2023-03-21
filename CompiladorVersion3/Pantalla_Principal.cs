using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompiladorVersion3
{
    public partial class Pantalla_Principal : Form
    {
        //Elementos de uso general
        Analisis_Semantico semantico;
        Analisis_Lexico lexico;
        List<Token> tokens;
        //Archivo de uso casi general
        string archivoAbierto;
        //Mensajes que genera el parser y semantico
        string[] mensajes;
        //Elementos logicos para evitar errores
        bool scannerRealizado = false;
        bool parserRealizado = false;
        bool semanticoRealizado = false;
        public Pantalla_Principal()
        {
            lexico = new Analisis_Lexico();
            tokens = null;
            mensajes = new string[2];
            parserRealizado = false;
            InitializeComponent();
        }
        //Botones en el compilador
        private void btnScanner_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rtbPrograma.Text) || string.IsNullOrWhiteSpace(rtbPrograma.Text)) 
                rtbScanner.Text = "NO SE ENCONTRO CODIGO";
            else
            {
                rtbScanner.Text = lexico.Scanner(rtbPrograma.Lines);
                tokens = lexico.ListadoTokens;
                scannerRealizado = true;
            }
        }
        private void btnParser_Click(object sender, EventArgs e)
        {
            if (scannerRealizado)
            {
                if (string.IsNullOrEmpty(rtbPrograma.Text) || string.IsNullOrWhiteSpace(rtbPrograma.Text))
                {
                    lblParser.ForeColor = Color.Red;
                    lblParser.Text = "NO SE ENCONTRO CODIGO";
                }
                else
                {
                    semantico = new Analisis_Semantico(1000);
                    mensajes = new Analisis_Sintactico(tokens, semantico).Parser();
                    if (mensajes[0].Equals("PROGRAMA SINTACTICAMENTE CORRECTO"))
                    {
                        lblParser.ForeColor = Color.DarkGreen;
                        lblParser.Text = "PROGRAMA SINTACTICAMENTE CORRECTO";
                        parserRealizado = true;
                    }
                    else
                    {
                        lblParser.ForeColor = Color.Red;
                        lblParser.Text = "PROGRAMA SINTACTICAMENTE INCORRECTO";
                    }
                }
            }
            else
            {
                lblParser.ForeColor = Color.Red;
                lblParser.Text = "NECESITAS EJECUTAR EL SCANNER";
            }
        }
        private void btnSemantico_Click(object sender, EventArgs e)
        {
            if (parserRealizado)
            {
                if (mensajes[1].Equals("PROGRAMA SEMANTICAMENTE CORRECTO"))
                {
                    lblSemantico.ForeColor = Color.DarkGreen;
                    lblSemantico.Text = mensajes[1];
                    semanticoRealizado = true;
                }
                else
                {
                    lblSemantico.ForeColor = Color.Red;
                    lblSemantico.Text = mensajes[1];
                    semanticoRealizado = false;
                }
            }
            else
            {
                lblSemantico.ForeColor = Color.Red;
                lblSemantico.Text = "NECESITAS EJECUTAR EL PARSER";
            }
        }
        private void btn_CodigoIntermedio_Click(object sender, EventArgs e)
        {
            if (semanticoRealizado)
            {
                rtbCodigoIntermedio.ForeColor = Color.Black;
                rtbCodigoIntermedio.Text = new CodigoIntermedio(semantico).obtenerCodigoIntermedio();
            }
            else
            {
                rtbCodigoIntermedio.ForeColor = Color.Red;
                rtbCodigoIntermedio.Text = "NECESITAS EJECUTAR EL SEMANTICO";
            }
        }
        //Seccion archivo del compilador
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ventanaArchivos = new OpenFileDialog();
            ventanaArchivos.Filter = "Archivo txt (*.txt)|*.txt|Archivo UwU (*.uwu)|*.uwu";
            string direccionArchivo = string.Empty;
            string contenidoArchivo = string.Empty;
            bool abrioArchivo = false;
            if (ventanaArchivos.ShowDialog().Equals(DialogResult.OK))
            {
                direccionArchivo = ventanaArchivos.FileName;
                StreamReader lector = new StreamReader(direccionArchivo);
                StringBuilder builder = new StringBuilder();
                while ((contenidoArchivo = lector.ReadLine()) != null)
                {
                    builder.AppendLine(contenidoArchivo);
                }
                lector.Close();
                rtbPrograma.Text = builder.ToString();
                abrioArchivo = true;
            }
            if (abrioArchivo) archivoAbierto = direccionArchivo;
        }
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            archivoAbierto = string.Empty;
            rtbPrograma.Text = string.Empty;
        }
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(archivoAbierto))
            {
                StreamWriter guardador = File.CreateText(archivoAbierto);
                guardador.Write(rtbPrograma.Text);
                guardador.Flush();
                guardador.Close();
            }
            else
            {
                SaveFileDialog guardarComo = new SaveFileDialog();
                guardarComo.Filter = "Archivo txt (*.txt)|*.txt|Archivo UwU (*.uwu)|*.uwu";
                guardarComo.FilterIndex = 2;
                guardarComo.RestoreDirectory = true;

                if (guardarComo.ShowDialog().Equals(DialogResult.OK))
                {
                    string archivo = guardarComo.FileName;
                    StreamWriter guardador = File.CreateText(archivo);
                    guardador.Write(rtbPrograma.Text);
                    guardador.Flush();
                    guardador.Close();
                }
            }
        }
        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardarComo = new SaveFileDialog();
            guardarComo.Filter = "Archivo txt (*.txt)|*.txt|Archivo UwU (*.uwu)|*.uwu";
            guardarComo.FilterIndex = 2;
            guardarComo.RestoreDirectory = true;

            if (guardarComo.ShowDialog().Equals(DialogResult.OK))
            {
                string archivo = guardarComo.FileName;
                StreamWriter guardador = File.CreateText(archivo);
                guardador.Write(rtbPrograma.Text);
                guardador.Flush();
                guardador.Close();
            }
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Pestaña fases del compilador
        private void analisisLexicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rtbPrograma.Text) || string.IsNullOrWhiteSpace(rtbPrograma.Text))
                rtbScanner.Text = "NO SE ENCONTRO CODIGO";
            else
            {
                rtbScanner.Text = lexico.Scanner(rtbPrograma.Lines);
                tokens = lexico.ListadoTokens;
                scannerRealizado = true;
            }
        }
        private void analisisSintacticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (scannerRealizado)
            {
                if (string.IsNullOrEmpty(rtbPrograma.Text) || string.IsNullOrWhiteSpace(rtbPrograma.Text))
                {
                    lblParser.ForeColor = Color.Red;
                    lblParser.Text = "NO SE ENCONTRO CODIGO";
                }
                else
                {
                    semantico = new Analisis_Semantico(1000);
                    mensajes = new Analisis_Sintactico(tokens, semantico).Parser();
                    if (mensajes[0].Equals("PROGRAMA SINTACTICAMENTE CORRECTO"))
                    {
                        lblParser.ForeColor = Color.DarkGreen;
                        lblParser.Text = "PROGRAMA SINTACTICAMENTE CORRECTO";
                        parserRealizado = true;
                    }
                    else
                    {
                        lblParser.ForeColor = Color.Red;
                        lblParser.Text = "PROGRAMA SINTACTICAMENTE INCORRECTO";
                    }
                }
            }
            else
            {
                lblParser.ForeColor = Color.Red;
                lblParser.Text = "NECESITAS EJECUTAR EL SCANNER";
            }
        }
        private void analisisSemanticoSemanticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Semantico");
        }
        private void generacionIntermediaCodigoIntermedioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Codigo intermedio");
        }
        //Pestaña compilador -> Gramatica
        private void gramaticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Pantalla_Gramatica(new Gramatica(), "Gramatica del lenguaje").ShowDialog();
        }
        //Pestaña compilador -> Gramatica Actual
        private void gramaticaActualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Pantalla_Gramatica(Gramatica.INSTANCIA(), "Gramatica actual").ShowDialog();
        }
        //Seccion de los programas de ejemplo
        private void vacioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbPrograma.Text =
            "InicioPrograma ejemplo1\n" +
            "FinPrograma";
        }
        private void declaracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbPrograma.Text =
            "InicioPrograma ejemplo1\n    " +
            "Declarar x Como Entero\n    " +
            "Declarar y Como Real\n    " +
            "Declarar bandera Como Logico\n    " +
            "Declarar mensaje Como Texto\n    " +
            "Declarar n1, n2, n3 Como Entero;\n    " +
            "Declarar n4, n5, n7 Como Real\n" +
            "FinPrograma";
        }
        private void lecturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbPrograma.Text =
            "InicioPrograma ejemplo1\n    " +
            "Declarar nombre Como Texto\n    " +
            "Leer nombre\n    " +
            "Leer (nombre)\n    " +
            "Leer <- nombre\n    " +
            "Leer \"Mensaje aquí: \", nombre\n    " +
            "Leer (\"Mensaje aquí: \", nombre)\n    " +
            "Leer <- \"Mensaje aquí: \", nombre\n" +
            "FinPrograma";
        }
        private void impresionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbPrograma.Text =
            "InicioPrograma ejemplo1\n    " +
            "Declarar nombre Como Texto\n    " +
            "Mostrar (\"mensaje random\", nombre)\n    " +
            "Mostrar -> nombre\n    " +
            "Mostrar -> \"Mensaje aquí: \", nombre\n    " +
            "Mostrar (\"Mensaje aquí: \", nombre)\n    " +
            "Mostrar -> \"Mensaje aquí: \", nombre\n" +
            "FinPrograma";
        }
        private void aritmeticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbPrograma.Text =
            "InicioPrograma ejemplo1\n    " +
            "Declarar mcm Como Entero\n    " +
            "mcm++\n    " +
            "mcm--\n    " +
            "mcm = 8\n    " +
            "mcm = 8\n    " +
            "mcm = 5 + 5 - 8 * 3\n" +
            "FinPrograma";
        }
        private void declaracionesPorTipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbPrograma.Text =
            "InicioPrograma ejemplo1\n    " +
            "Declarar numEntero Como Entero\n    " +
            "Declarar numReal Como Real\n    " +
            "Declarar mensaje Como Texto\n    " +
            "Declarar bandera Como Logico\n    " +
            "numEntero = 5\n    " +
            "numReal = 5.6\n    " +
            "mensaje = \"Mensaje de prueba\"\n    " +
            "bandera = Verdadero\n    " +
            "bandera = Falso\n" +
            "FinPrograma";
        }
        private void sentenciaSiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbPrograma.Text =
            "InicioPrograma ejemplo1\n    " +
            "Declarar numero Como Entero\n    " +
            "Si (numero == 0) Entonces\n        " +
            "Mostrar -> \"El numero es 0\"\n    " +
            "Sino\n        " +
            "Mostrar -> \"El numero no es 0\"\n    " +
            "FinSi\n" +
            "FinPrograma";
        }
        private void sentenciaMientrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbPrograma.Text =
            "InicioPrograma ejemplo1\n    " +
            "Declarar numero Como Entero\n    " +
            "Mientras numero <> 10 Entonces\n        " +
            "Mostrar-> \"Hola mundo\"\n    " +
            "FinMientras\n" +
            "FinPrograma";
        }
        //Metodo que se ejecutara aleditar el codigo en la seccion de programa
        private void rtbPrograma_TextChanged(object sender, EventArgs e)
        {
            rtbScanner.Clear();
            lblParser.Text = string.Empty;
            lblSemantico.Text = string.Empty;
            rtbCodigoIntermedio.Clear();
            scannerRealizado = false;
            parserRealizado = false;
            semanticoRealizado = false;
        }
    }
}
