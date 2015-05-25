namespace NeuroVoice2_0
{
    partial class F_Entrenar
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.B_Reconocer = new System.Windows.Forms.Button();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu_Salir = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Pref_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.CB_Letra = new System.Windows.Forms.ComboBox();
            this.P_Grabar = new System.Windows.Forms.Panel();
            this.B_Grabar = new System.Windows.Forms.Button();
            this.CB_Disp = new System.Windows.Forms.ComboBox();
            this.L_Nombre = new System.Windows.Forms.Label();
            this.TB_Nombre = new System.Windows.Forms.TextBox();
            this.GV_Audios = new System.Windows.Forms.DataGridView();
            this.L_Letra = new System.Windows.Forms.Label();
            this.T_Tiempo = new System.Windows.Forms.Timer(this.components);
            this.Archivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Letra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reproducir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Borrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.B_Entrenar = new System.Windows.Forms.Button();
            this.Menu.SuspendLayout();
            this.P_Grabar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_Audios)).BeginInit();
            this.SuspendLayout();
            // 
            // B_Reconocer
            // 
            this.B_Reconocer.Location = new System.Drawing.Point(12, 406);
            this.B_Reconocer.Name = "B_Reconocer";
            this.B_Reconocer.Size = new System.Drawing.Size(81, 23);
            this.B_Reconocer.TabIndex = 0;
            this.B_Reconocer.Text = "Reconocedor";
            this.B_Reconocer.UseVisualStyleBackColor = true;
            this.B_Reconocer.Click += new System.EventHandler(this.B_Reconocer_Click);
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.toolStripMenuItem1});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(948, 24);
            this.Menu.TabIndex = 1;
            this.Menu.Text = "Menu";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.Menu_Salir});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(93, 6);
            // 
            // Menu_Salir
            // 
            this.Menu_Salir.Name = "Menu_Salir";
            this.Menu_Salir.Size = new System.Drawing.Size(96, 22);
            this.Menu_Salir.Text = "Salir";
            this.Menu_Salir.Click += new System.EventHandler(this.Menu_Salir_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Pref_Menu});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // Pref_Menu
            // 
            this.Pref_Menu.Name = "Pref_Menu";
            this.Pref_Menu.Size = new System.Drawing.Size(138, 22);
            this.Pref_Menu.Text = "Preferencias";
            this.Pref_Menu.Click += new System.EventHandler(this.Pref_Menu_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // CB_Letra
            // 
            this.CB_Letra.FormattingEnabled = true;
            this.CB_Letra.Items.AddRange(new object[] {
            "A",
            "E",
            "I",
            "O",
            "U"});
            this.CB_Letra.Location = new System.Drawing.Point(6, 41);
            this.CB_Letra.Name = "CB_Letra";
            this.CB_Letra.Size = new System.Drawing.Size(39, 21);
            this.CB_Letra.TabIndex = 2;
            // 
            // P_Grabar
            // 
            this.P_Grabar.Controls.Add(this.B_Entrenar);
            this.P_Grabar.Controls.Add(this.B_Grabar);
            this.P_Grabar.Controls.Add(this.CB_Disp);
            this.P_Grabar.Controls.Add(this.L_Nombre);
            this.P_Grabar.Controls.Add(this.TB_Nombre);
            this.P_Grabar.Controls.Add(this.GV_Audios);
            this.P_Grabar.Controls.Add(this.L_Letra);
            this.P_Grabar.Controls.Add(this.CB_Letra);
            this.P_Grabar.Location = new System.Drawing.Point(13, 28);
            this.P_Grabar.Name = "P_Grabar";
            this.P_Grabar.Size = new System.Drawing.Size(455, 380);
            this.P_Grabar.TabIndex = 3;
            // 
            // B_Grabar
            // 
            this.B_Grabar.Location = new System.Drawing.Point(157, 41);
            this.B_Grabar.Name = "B_Grabar";
            this.B_Grabar.Size = new System.Drawing.Size(39, 23);
            this.B_Grabar.TabIndex = 8;
            this.B_Grabar.Text = "Rec";
            this.B_Grabar.UseVisualStyleBackColor = true;
            this.B_Grabar.Click += new System.EventHandler(this.B_Grabar_Click);
            // 
            // CB_Disp
            // 
            this.CB_Disp.FormattingEnabled = true;
            this.CB_Disp.Location = new System.Drawing.Point(7, 4);
            this.CB_Disp.Name = "CB_Disp";
            this.CB_Disp.Size = new System.Drawing.Size(190, 21);
            this.CB_Disp.TabIndex = 7;
            this.CB_Disp.SelectedIndexChanged += new System.EventHandler(this.CB_Disp_SelectedIndexChanged);
            // 
            // L_Nombre
            // 
            this.L_Nombre.AutoSize = true;
            this.L_Nombre.Location = new System.Drawing.Point(51, 24);
            this.L_Nombre.Name = "L_Nombre";
            this.L_Nombre.Size = new System.Drawing.Size(44, 13);
            this.L_Nombre.TabIndex = 6;
            this.L_Nombre.Text = "Nombre";
            // 
            // TB_Nombre
            // 
            this.TB_Nombre.Location = new System.Drawing.Point(51, 41);
            this.TB_Nombre.Name = "TB_Nombre";
            this.TB_Nombre.Size = new System.Drawing.Size(100, 20);
            this.TB_Nombre.TabIndex = 5;
            // 
            // GV_Audios
            // 
            this.GV_Audios.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GV_Audios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_Audios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Archivo,
            this.Letra,
            this.Reproducir,
            this.Borrar});
            this.GV_Audios.Location = new System.Drawing.Point(7, 67);
            this.GV_Audios.Name = "GV_Audios";
            this.GV_Audios.Size = new System.Drawing.Size(445, 305);
            this.GV_Audios.TabIndex = 4;
            this.GV_Audios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GV_Audios_CellClick);
            // 
            // L_Letra
            // 
            this.L_Letra.AutoSize = true;
            this.L_Letra.Location = new System.Drawing.Point(3, 25);
            this.L_Letra.Name = "L_Letra";
            this.L_Letra.Size = new System.Drawing.Size(31, 13);
            this.L_Letra.TabIndex = 3;
            this.L_Letra.Text = "Letra";
            // 
            // T_Tiempo
            // 
            this.T_Tiempo.Interval = 1000;
            this.T_Tiempo.Tick += new System.EventHandler(this.T_Tiempo_Tick);
            // 
            // Archivo
            // 
            this.Archivo.HeaderText = "Archivo";
            this.Archivo.Name = "Archivo";
            this.Archivo.ReadOnly = true;
            // 
            // Letra
            // 
            this.Letra.HeaderText = "Letra";
            this.Letra.Name = "Letra";
            this.Letra.ReadOnly = true;
            // 
            // Reproducir
            // 
            this.Reproducir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Reproducir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Reproducir.HeaderText = "Reproducir";
            this.Reproducir.Name = "Reproducir";
            this.Reproducir.Text = "Play";
            this.Reproducir.ToolTipText = "Play";
            this.Reproducir.UseColumnTextForButtonValue = true;
            this.Reproducir.Width = 65;
            // 
            // Borrar
            // 
            this.Borrar.HeaderText = "Borrar";
            this.Borrar.Name = "Borrar";
            this.Borrar.Text = "Borrar";
            this.Borrar.UseColumnTextForButtonValue = true;
            this.Borrar.Width = 50;
            // 
            // B_Entrenar
            // 
            this.B_Entrenar.Location = new System.Drawing.Point(285, 19);
            this.B_Entrenar.Name = "B_Entrenar";
            this.B_Entrenar.Size = new System.Drawing.Size(75, 23);
            this.B_Entrenar.TabIndex = 9;
            this.B_Entrenar.Text = "Entrenar";
            this.B_Entrenar.UseVisualStyleBackColor = true;
            this.B_Entrenar.Click += new System.EventHandler(this.B_Entrenar_Click);
            // 
            // F_Entrenar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 441);
            this.Controls.Add(this.P_Grabar);
            this.Controls.Add(this.B_Reconocer);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.Menu;
            this.Name = "F_Entrenar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrenamiento";
            this.Load += new System.EventHandler(this.F_Entrenar_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.P_Grabar.ResumeLayout(false);
            this.P_Grabar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_Audios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_Reconocer;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menu_Salir;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Pref_Menu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ComboBox CB_Letra;
        private System.Windows.Forms.Panel P_Grabar;
        private System.Windows.Forms.Label L_Letra;
        private System.Windows.Forms.DataGridView GV_Audios;
        private System.Windows.Forms.ComboBox CB_Disp;
        private System.Windows.Forms.Label L_Nombre;
        private System.Windows.Forms.TextBox TB_Nombre;
        private System.Windows.Forms.Button B_Grabar;
        private System.Windows.Forms.Timer T_Tiempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Archivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Letra;
        private System.Windows.Forms.DataGridViewButtonColumn Reproducir;
        private System.Windows.Forms.DataGridViewButtonColumn Borrar;
        private System.Windows.Forms.Button B_Entrenar;
    }
}

