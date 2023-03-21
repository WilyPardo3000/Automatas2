
namespace CompiladorVersion3
{
    partial class Pantalla_Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analisisLexicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analisisSintacticoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analisisSemanticoSemanticoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generacionIntermediaCodigoIntermedioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejemplosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vacioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.declaracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lecturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impresionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aritmeticoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.declaracionesPorTipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sentenciaSiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sentenciaMientrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compiladorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gramaticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gramaticaActualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rtbPrograma = new System.Windows.Forms.RichTextBox();
            this.lblPrograma = new System.Windows.Forms.Label();
            this.rtbScanner = new System.Windows.Forms.RichTextBox();
            this.btnScanner = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSemantico = new System.Windows.Forms.Button();
            this.btnParser = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSemantico = new System.Windows.Forms.Label();
            this.lblParser = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.rtbCodigoIntermedio = new System.Windows.Forms.RichTextBox();
            this.btn_CodigoIntermedio = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tlpPrincipal.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.fasesToolStripMenuItem,
            this.ejemplosToolStripMenuItem,
            this.compiladorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(946, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.nuevoToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.guardarComoToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.guardarComoToolStripMenuItem.Text = "Guardar como";
            this.guardarComoToolStripMenuItem.Click += new System.EventHandler(this.guardarComoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(147, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // fasesToolStripMenuItem
            // 
            this.fasesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.analisisLexicoToolStripMenuItem,
            this.analisisSintacticoToolStripMenuItem,
            this.analisisSemanticoSemanticoToolStripMenuItem,
            this.generacionIntermediaCodigoIntermedioToolStripMenuItem});
            this.fasesToolStripMenuItem.Name = "fasesToolStripMenuItem";
            this.fasesToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.fasesToolStripMenuItem.Text = "Fases";
            // 
            // analisisLexicoToolStripMenuItem
            // 
            this.analisisLexicoToolStripMenuItem.Name = "analisisLexicoToolStripMenuItem";
            this.analisisLexicoToolStripMenuItem.Size = new System.Drawing.Size(305, 22);
            this.analisisLexicoToolStripMenuItem.Text = "Analisis Lexico (Scanner)";
            this.analisisLexicoToolStripMenuItem.Click += new System.EventHandler(this.analisisLexicoToolStripMenuItem_Click);
            // 
            // analisisSintacticoToolStripMenuItem
            // 
            this.analisisSintacticoToolStripMenuItem.Name = "analisisSintacticoToolStripMenuItem";
            this.analisisSintacticoToolStripMenuItem.Size = new System.Drawing.Size(305, 22);
            this.analisisSintacticoToolStripMenuItem.Text = "Analisis Sintactico (Parser)";
            this.analisisSintacticoToolStripMenuItem.Click += new System.EventHandler(this.analisisSintacticoToolStripMenuItem_Click);
            // 
            // analisisSemanticoSemanticoToolStripMenuItem
            // 
            this.analisisSemanticoSemanticoToolStripMenuItem.Name = "analisisSemanticoSemanticoToolStripMenuItem";
            this.analisisSemanticoSemanticoToolStripMenuItem.Size = new System.Drawing.Size(305, 22);
            this.analisisSemanticoSemanticoToolStripMenuItem.Text = "Analisis Semantico (Semantico)";
            this.analisisSemanticoSemanticoToolStripMenuItem.Click += new System.EventHandler(this.analisisSemanticoSemanticoToolStripMenuItem_Click);
            // 
            // generacionIntermediaCodigoIntermedioToolStripMenuItem
            // 
            this.generacionIntermediaCodigoIntermedioToolStripMenuItem.Name = "generacionIntermediaCodigoIntermedioToolStripMenuItem";
            this.generacionIntermediaCodigoIntermedioToolStripMenuItem.Size = new System.Drawing.Size(305, 22);
            this.generacionIntermediaCodigoIntermedioToolStripMenuItem.Text = "Generacion intermedia (Codigo Intermedio)";
            this.generacionIntermediaCodigoIntermedioToolStripMenuItem.Click += new System.EventHandler(this.generacionIntermediaCodigoIntermedioToolStripMenuItem_Click);
            // 
            // ejemplosToolStripMenuItem
            // 
            this.ejemplosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vacioToolStripMenuItem,
            this.declaracionToolStripMenuItem,
            this.lecturaToolStripMenuItem,
            this.impresionToolStripMenuItem,
            this.aritmeticoToolStripMenuItem,
            this.declaracionesPorTipoToolStripMenuItem,
            this.sentenciaSiToolStripMenuItem,
            this.sentenciaMientrasToolStripMenuItem});
            this.ejemplosToolStripMenuItem.Name = "ejemplosToolStripMenuItem";
            this.ejemplosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.ejemplosToolStripMenuItem.Text = "Ejemplos";
            // 
            // vacioToolStripMenuItem
            // 
            this.vacioToolStripMenuItem.Name = "vacioToolStripMenuItem";
            this.vacioToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.vacioToolStripMenuItem.Text = "Vacio";
            this.vacioToolStripMenuItem.Click += new System.EventHandler(this.vacioToolStripMenuItem_Click);
            // 
            // declaracionToolStripMenuItem
            // 
            this.declaracionToolStripMenuItem.Name = "declaracionToolStripMenuItem";
            this.declaracionToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.declaracionToolStripMenuItem.Text = "Declaracion";
            this.declaracionToolStripMenuItem.Click += new System.EventHandler(this.declaracionToolStripMenuItem_Click);
            // 
            // lecturaToolStripMenuItem
            // 
            this.lecturaToolStripMenuItem.Name = "lecturaToolStripMenuItem";
            this.lecturaToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.lecturaToolStripMenuItem.Text = "Lectura";
            this.lecturaToolStripMenuItem.Click += new System.EventHandler(this.lecturaToolStripMenuItem_Click);
            // 
            // impresionToolStripMenuItem
            // 
            this.impresionToolStripMenuItem.Name = "impresionToolStripMenuItem";
            this.impresionToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.impresionToolStripMenuItem.Text = "Impresion";
            this.impresionToolStripMenuItem.Click += new System.EventHandler(this.impresionToolStripMenuItem_Click);
            // 
            // aritmeticoToolStripMenuItem
            // 
            this.aritmeticoToolStripMenuItem.Name = "aritmeticoToolStripMenuItem";
            this.aritmeticoToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.aritmeticoToolStripMenuItem.Text = "Aritmetico";
            this.aritmeticoToolStripMenuItem.Click += new System.EventHandler(this.aritmeticoToolStripMenuItem_Click);
            // 
            // declaracionesPorTipoToolStripMenuItem
            // 
            this.declaracionesPorTipoToolStripMenuItem.Name = "declaracionesPorTipoToolStripMenuItem";
            this.declaracionesPorTipoToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.declaracionesPorTipoToolStripMenuItem.Text = "Declaraciones por tipo";
            this.declaracionesPorTipoToolStripMenuItem.Click += new System.EventHandler(this.declaracionesPorTipoToolStripMenuItem_Click);
            // 
            // sentenciaSiToolStripMenuItem
            // 
            this.sentenciaSiToolStripMenuItem.Name = "sentenciaSiToolStripMenuItem";
            this.sentenciaSiToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.sentenciaSiToolStripMenuItem.Text = "Sentencia Si";
            this.sentenciaSiToolStripMenuItem.Click += new System.EventHandler(this.sentenciaSiToolStripMenuItem_Click);
            // 
            // sentenciaMientrasToolStripMenuItem
            // 
            this.sentenciaMientrasToolStripMenuItem.Name = "sentenciaMientrasToolStripMenuItem";
            this.sentenciaMientrasToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.sentenciaMientrasToolStripMenuItem.Text = "Sentencia Mientras";
            this.sentenciaMientrasToolStripMenuItem.Click += new System.EventHandler(this.sentenciaMientrasToolStripMenuItem_Click);
            // 
            // compiladorToolStripMenuItem
            // 
            this.compiladorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gramaticaToolStripMenuItem,
            this.gramaticaActualToolStripMenuItem});
            this.compiladorToolStripMenuItem.Name = "compiladorToolStripMenuItem";
            this.compiladorToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.compiladorToolStripMenuItem.Text = "Compilador";
            // 
            // gramaticaToolStripMenuItem
            // 
            this.gramaticaToolStripMenuItem.Name = "gramaticaToolStripMenuItem";
            this.gramaticaToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.gramaticaToolStripMenuItem.Text = "Gramatica";
            this.gramaticaToolStripMenuItem.Click += new System.EventHandler(this.gramaticaToolStripMenuItem_Click);
            // 
            // gramaticaActualToolStripMenuItem
            // 
            this.gramaticaActualToolStripMenuItem.Name = "gramaticaActualToolStripMenuItem";
            this.gramaticaActualToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.gramaticaActualToolStripMenuItem.Text = "Gramatica Actual";
            this.gramaticaActualToolStripMenuItem.Click += new System.EventHandler(this.gramaticaActualToolStripMenuItem_Click);
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpPrincipal.ColumnCount = 2;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpPrincipal.Controls.Add(this.tableLayoutPanel5, 1, 1);
            this.tlpPrincipal.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tlpPrincipal.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tlpPrincipal.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tlpPrincipal.Location = new System.Drawing.Point(11, 26);
            this.tlpPrincipal.Margin = new System.Windows.Forms.Padding(2);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 2;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpPrincipal.Size = new System.Drawing.Size(928, 512);
            this.tlpPrincipal.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.button2, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(466, 258);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(460, 252);
            this.tableLayoutPanel5.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(2, 2);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(456, 46);
            this.button2.TabIndex = 7;
            this.button2.Text = "Codigo objeto";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.rtbPrograma, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPrograma, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rtbScanner, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnScanner, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(460, 252);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // rtbPrograma
            // 
            this.rtbPrograma.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbPrograma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbPrograma.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbPrograma.Location = new System.Drawing.Point(2, 52);
            this.rtbPrograma.Margin = new System.Windows.Forms.Padding(2);
            this.rtbPrograma.Name = "rtbPrograma";
            this.rtbPrograma.Size = new System.Drawing.Size(226, 198);
            this.rtbPrograma.TabIndex = 3;
            this.rtbPrograma.Text = "";
            this.rtbPrograma.WordWrap = false;
            this.rtbPrograma.TextChanged += new System.EventHandler(this.rtbPrograma_TextChanged);
            // 
            // lblPrograma
            // 
            this.lblPrograma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrograma.AutoSize = true;
            this.lblPrograma.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold);
            this.lblPrograma.Location = new System.Drawing.Point(2, 9);
            this.lblPrograma.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrograma.Name = "lblPrograma";
            this.lblPrograma.Size = new System.Drawing.Size(226, 31);
            this.lblPrograma.TabIndex = 0;
            this.lblPrograma.Text = "Programa";
            this.lblPrograma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtbScanner
            // 
            this.rtbScanner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbScanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbScanner.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbScanner.Location = new System.Drawing.Point(232, 52);
            this.rtbScanner.Margin = new System.Windows.Forms.Padding(2);
            this.rtbScanner.Name = "rtbScanner";
            this.rtbScanner.ReadOnly = true;
            this.rtbScanner.Size = new System.Drawing.Size(226, 198);
            this.rtbScanner.TabIndex = 4;
            this.rtbScanner.Text = "";
            this.rtbScanner.WordWrap = false;
            // 
            // btnScanner
            // 
            this.btnScanner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScanner.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold);
            this.btnScanner.Location = new System.Drawing.Point(232, 2);
            this.btnScanner.Margin = new System.Windows.Forms.Padding(2);
            this.btnScanner.Name = "btnScanner";
            this.btnScanner.Size = new System.Drawing.Size(226, 46);
            this.btnScanner.TabIndex = 6;
            this.btnScanner.Text = "Scanner";
            this.btnScanner.UseVisualStyleBackColor = true;
            this.btnScanner.Click += new System.EventHandler(this.btnScanner_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(466, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(460, 252);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btnSemantico, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnParser, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(456, 46);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // btnSemantico
            // 
            this.btnSemantico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSemantico.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold);
            this.btnSemantico.Location = new System.Drawing.Point(230, 2);
            this.btnSemantico.Margin = new System.Windows.Forms.Padding(2);
            this.btnSemantico.Name = "btnSemantico";
            this.btnSemantico.Size = new System.Drawing.Size(224, 42);
            this.btnSemantico.TabIndex = 8;
            this.btnSemantico.Text = "Semántico";
            this.btnSemantico.UseVisualStyleBackColor = true;
            this.btnSemantico.Click += new System.EventHandler(this.btnSemantico_Click);
            // 
            // btnParser
            // 
            this.btnParser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnParser.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold);
            this.btnParser.Location = new System.Drawing.Point(2, 2);
            this.btnParser.Margin = new System.Windows.Forms.Padding(2);
            this.btnParser.Name = "btnParser";
            this.btnParser.Size = new System.Drawing.Size(224, 42);
            this.btnParser.TabIndex = 7;
            this.btnParser.Text = "Parser";
            this.btnParser.UseVisualStyleBackColor = true;
            this.btnParser.Click += new System.EventHandler(this.btnParser_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Controls.Add(this.lblSemantico, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.lblParser, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 53);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(454, 196);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // lblSemantico
            // 
            this.lblSemantico.AutoSize = true;
            this.lblSemantico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSemantico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSemantico.Font = new System.Drawing.Font("Arial", 14F);
            this.lblSemantico.ForeColor = System.Drawing.Color.Red;
            this.lblSemantico.Location = new System.Drawing.Point(2, 98);
            this.lblSemantico.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSemantico.Name = "lblSemantico";
            this.lblSemantico.Size = new System.Drawing.Size(450, 98);
            this.lblSemantico.TabIndex = 10;
            this.lblSemantico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblParser
            // 
            this.lblParser.AutoSize = true;
            this.lblParser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblParser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblParser.Font = new System.Drawing.Font("Arial", 14F);
            this.lblParser.ForeColor = System.Drawing.Color.Red;
            this.lblParser.Location = new System.Drawing.Point(2, 0);
            this.lblParser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblParser.Name = "lblParser";
            this.lblParser.Size = new System.Drawing.Size(450, 98);
            this.lblParser.TabIndex = 9;
            this.lblParser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.rtbCodigoIntermedio, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.btn_CodigoIntermedio, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(2, 258);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(460, 252);
            this.tableLayoutPanel4.TabIndex = 11;
            // 
            // rtbCodigoIntermedio
            // 
            this.rtbCodigoIntermedio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbCodigoIntermedio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbCodigoIntermedio.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbCodigoIntermedio.ForeColor = System.Drawing.Color.Black;
            this.rtbCodigoIntermedio.Location = new System.Drawing.Point(2, 52);
            this.rtbCodigoIntermedio.Margin = new System.Windows.Forms.Padding(2);
            this.rtbCodigoIntermedio.Name = "rtbCodigoIntermedio";
            this.rtbCodigoIntermedio.ReadOnly = true;
            this.rtbCodigoIntermedio.Size = new System.Drawing.Size(456, 198);
            this.rtbCodigoIntermedio.TabIndex = 8;
            this.rtbCodigoIntermedio.Text = "";
            this.rtbCodigoIntermedio.WordWrap = false;
            // 
            // btn_CodigoIntermedio
            // 
            this.btn_CodigoIntermedio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CodigoIntermedio.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold);
            this.btn_CodigoIntermedio.Location = new System.Drawing.Point(2, 2);
            this.btn_CodigoIntermedio.Margin = new System.Windows.Forms.Padding(2);
            this.btn_CodigoIntermedio.Name = "btn_CodigoIntermedio";
            this.btn_CodigoIntermedio.Size = new System.Drawing.Size(456, 46);
            this.btn_CodigoIntermedio.TabIndex = 7;
            this.btn_CodigoIntermedio.Text = "Codigo intermedio";
            this.btn_CodigoIntermedio.UseVisualStyleBackColor = true;
            this.btn_CodigoIntermedio.Click += new System.EventHandler(this.btn_CodigoIntermedio_Click);
            // 
            // Pantalla_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 547);
            this.Controls.Add(this.tlpPrincipal);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Pantalla_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compilador lenguaje Ta-mal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tlpPrincipal.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analisisLexicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analisisSintacticoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejemplosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vacioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem declaracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lecturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impresionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aritmeticoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compiladorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gramaticaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gramaticaActualToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox rtbPrograma;
        private System.Windows.Forms.Label lblPrograma;
        private System.Windows.Forms.RichTextBox rtbScanner;
        private System.Windows.Forms.Button btnScanner;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnSemantico;
        private System.Windows.Forms.Button btnParser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label lblSemantico;
        private System.Windows.Forms.Label lblParser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.RichTextBox rtbCodigoIntermedio;
        private System.Windows.Forms.Button btn_CodigoIntermedio;
        private System.Windows.Forms.ToolStripMenuItem declaracionesPorTipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sentenciaSiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sentenciaMientrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analisisSemanticoSemanticoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generacionIntermediaCodigoIntermedioToolStripMenuItem;
    }
}

