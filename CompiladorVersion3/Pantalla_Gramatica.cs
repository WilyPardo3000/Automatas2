using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompiladorVersion3
{
    public partial class Pantalla_Gramatica : Form
    {
        private Gramatica gramatica;
        public Pantalla_Gramatica(Gramatica gramatica, string title)
        {
            InitializeComponent();
            this.gramatica = gramatica;
            this.Text = title;
        }

        private void Pantalla_Gramatica_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            foreach (Token item in gramatica.ObtenerTokens())
            {
                dataGridView1.Rows.Add(item.Nombre, item.Lexema, item.Codigo);
            }
        }
    }
}
