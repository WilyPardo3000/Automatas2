﻿
namespace CompiladorVersion3
{
    partial class Pantalla_Gramatica
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cToken = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLexema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoSegumiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cToken,
            this.cLexema,
            this.codigoSegumiento});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 1;
            // 
            // cToken
            // 
            this.cToken.HeaderText = "Tokens";
            this.cToken.MinimumWidth = 6;
            this.cToken.Name = "cToken";
            this.cToken.ReadOnly = true;
            this.cToken.Width = 125;
            // 
            // cLexema
            // 
            this.cLexema.HeaderText = "Lexemas";
            this.cLexema.MinimumWidth = 6;
            this.cLexema.Name = "cLexema";
            this.cLexema.ReadOnly = true;
            this.cLexema.Width = 125;
            // 
            // codigoSegumiento
            // 
            this.codigoSegumiento.HeaderText = "Codigo";
            this.codigoSegumiento.MinimumWidth = 6;
            this.codigoSegumiento.Name = "codigoSegumiento";
            this.codigoSegumiento.Width = 125;
            // 
            // Pantalla_Gramatica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Pantalla_Gramatica";
            this.Text = "Pantalla_Gramatica";
            this.Load += new System.EventHandler(this.Pantalla_Gramatica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cToken;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLexema;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoSegumiento;
    }
}