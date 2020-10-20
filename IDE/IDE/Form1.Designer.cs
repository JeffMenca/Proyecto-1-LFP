namespace IDE
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GuardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarErroresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compilarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compilarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reiniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbnumColumna = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lbnumlinea = new System.Windows.Forms.Label();
            this.lbLinea = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbCodigo = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.rtbErrores = new System.Windows.Forms.RichTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.exportarToolStripMenuItem,
            this.compilarToolStripMenuItem,
            this.temaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(764, 25);
            this.menuStrip1.TabIndex = 0;
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.GuardarToolStripMenuItem,
            this.guardarComoToolStripMenuItem,
            this.toolStripMenuItem1});
            this.archivoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(63, 21);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.nuevoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo proyecto";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.abrirToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.abrirToolStripMenuItem.Text = "Abrir proyecto";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // GuardarToolStripMenuItem
            // 
            this.GuardarToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.GuardarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem";
            this.GuardarToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.GuardarToolStripMenuItem.Text = "Guardar";
            this.GuardarToolStripMenuItem.Click += new System.EventHandler(this.eliminarProyectoToolStripMenuItem_Click);
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.guardarComoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.guardarComoToolStripMenuItem.Text = "Guardar como";
            this.guardarComoToolStripMenuItem.Click += new System.EventHandler(this.guardarComoToolStripMenuItem_Click);
            // 
            // exportarToolStripMenuItem
            // 
            this.exportarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarErroresToolStripMenuItem});
            this.exportarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            this.exportarToolStripMenuItem.Size = new System.Drawing.Size(70, 21);
            this.exportarToolStripMenuItem.Text = "Exportar";
            // 
            // exportarErroresToolStripMenuItem
            // 
            this.exportarErroresToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.exportarErroresToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exportarErroresToolStripMenuItem.Name = "exportarErroresToolStripMenuItem";
            this.exportarErroresToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.exportarErroresToolStripMenuItem.Text = "Exportar errores";
            this.exportarErroresToolStripMenuItem.Click += new System.EventHandler(this.exportarErroresToolStripMenuItem_Click);
            // 
            // compilarToolStripMenuItem
            // 
            this.compilarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compilarToolStripMenuItem1,
            this.reiniciarToolStripMenuItem});
            this.compilarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.compilarToolStripMenuItem.Name = "compilarToolStripMenuItem";
            this.compilarToolStripMenuItem.Size = new System.Drawing.Size(73, 21);
            this.compilarToolStripMenuItem.Text = "Compilar";
            // 
            // compilarToolStripMenuItem1
            // 
            this.compilarToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.compilarToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.compilarToolStripMenuItem1.Name = "compilarToolStripMenuItem1";
            this.compilarToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.compilarToolStripMenuItem1.Text = "Compilar";
            this.compilarToolStripMenuItem1.Click += new System.EventHandler(this.compilarToolStripMenuItem1_Click);
            // 
            // reiniciarToolStripMenuItem
            // 
            this.reiniciarToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.reiniciarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reiniciarToolStripMenuItem.Name = "reiniciarToolStripMenuItem";
            this.reiniciarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.reiniciarToolStripMenuItem.Text = "Reiniciar";
            this.reiniciarToolStripMenuItem.Click += new System.EventHandler(this.reiniciarToolStripMenuItem_Click);
            // 
            // temaToolStripMenuItem
            // 
            this.temaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darkToolStripMenuItem,
            this.lightToolStripMenuItem});
            this.temaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.temaToolStripMenuItem.Name = "temaToolStripMenuItem";
            this.temaToolStripMenuItem.Size = new System.Drawing.Size(51, 21);
            this.temaToolStripMenuItem.Text = "Tema";
            // 
            // darkToolStripMenuItem
            // 
            this.darkToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.darkToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            this.darkToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.darkToolStripMenuItem.Text = "Dark";
            this.darkToolStripMenuItem.Click += new System.EventHandler(this.darkToolStripMenuItem_Click);
            // 
            // lightToolStripMenuItem
            // 
            this.lightToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.lightToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            this.lightToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.lightToolStripMenuItem.Text = "Light";
            this.lightToolStripMenuItem.Click += new System.EventHandler(this.lightToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Location = new System.Drawing.Point(0, 486);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 25);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(0, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(764, 36);
            this.panel2.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(42, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(30, 29);
            this.button4.TabIndex = 3;
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Image = global::IDE.Properties.Resources.saveas;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(104, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 29);
            this.button3.TabIndex = 2;
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Image = global::IDE.Properties.Resources.save;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(73, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 29);
            this.button2.TabIndex = 1;
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = global::IDE.Properties.Resources.compilarIcono;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(148, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Iniciar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.panel16);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.panel15);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.panel10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.panel14);
            this.panel3.Controls.Add(this.panel13);
            this.panel3.Controls.Add(this.panel12);
            this.panel3.Controls.Add(this.panel11);
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Location = new System.Drawing.Point(0, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(149, 426);
            this.panel3.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(43, 383);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Palabras reservadas";
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.Lime;
            this.panel16.Location = new System.Drawing.Point(12, 380);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(19, 19);
            this.panel16.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(43, 342);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Comentario";
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.Red;
            this.panel15.Location = new System.Drawing.Point(12, 342);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(19, 19);
            this.panel15.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(43, 310);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Sentencia \'=\'   \';\'";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Pink;
            this.panel10.Location = new System.Drawing.Point(12, 304);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(19, 19);
            this.panel10.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(47, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Operadores";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(47, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Caracter";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(48, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Error";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(45, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Booleano";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(45, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Texto / cadena";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(45, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Decimal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(47, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Entero";
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.Blue;
            this.panel14.Location = new System.Drawing.Point(12, 269);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(19, 19);
            this.panel14.TabIndex = 5;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.Peru;
            this.panel13.Location = new System.Drawing.Point(12, 231);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(19, 19);
            this.panel13.TabIndex = 5;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Yellow;
            this.panel12.Location = new System.Drawing.Point(12, 195);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(19, 19);
            this.panel12.TabIndex = 5;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Orange;
            this.panel11.Location = new System.Drawing.Point(12, 158);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(19, 19);
            this.panel11.TabIndex = 5;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.LightGray;
            this.panel9.Location = new System.Drawing.Point(12, 120);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(19, 19);
            this.panel9.TabIndex = 5;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.LightBlue;
            this.panel8.Location = new System.Drawing.Point(12, 84);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(19, 19);
            this.panel8.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Orchid;
            this.panel7.Location = new System.Drawing.Point(12, 46);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(19, 19);
            this.panel7.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel6.Controls.Add(this.label2);
            this.panel6.Location = new System.Drawing.Point(0, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(149, 21);
            this.panel6.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(3, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de dato";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel5.Controls.Add(this.lbnumColumna);
            this.panel5.Controls.Add(this.label16);
            this.panel5.Controls.Add(this.lbnumlinea);
            this.panel5.Controls.Add(this.lbLinea);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(151, 385);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(613, 20);
            this.panel5.TabIndex = 2;
            // 
            // lbnumColumna
            // 
            this.lbnumColumna.AutoSize = true;
            this.lbnumColumna.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbnumColumna.Location = new System.Drawing.Point(324, 4);
            this.lbnumColumna.Name = "lbnumColumna";
            this.lbnumColumna.Size = new System.Drawing.Size(0, 13);
            this.lbnumColumna.TabIndex = 4;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(278, 4);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "Columna";
            // 
            // lbnumlinea
            // 
            this.lbnumlinea.AutoSize = true;
            this.lbnumlinea.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbnumlinea.Location = new System.Drawing.Point(207, 4);
            this.lbnumlinea.Name = "lbnumlinea";
            this.lbnumlinea.Size = new System.Drawing.Size(0, 13);
            this.lbnumlinea.TabIndex = 2;
            // 
            // lbLinea
            // 
            this.lbLinea.AutoSize = true;
            this.lbLinea.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbLinea.Location = new System.Drawing.Point(175, 4);
            this.lbLinea.Name = "lbLinea";
            this.lbLinea.Size = new System.Drawing.Size(33, 13);
            this.lbLinea.TabIndex = 1;
            this.lbLinea.Text = "Linea";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(8, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Errores";
            // 
            // rtbCodigo
            // 
            this.rtbCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.rtbCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbCodigo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbCodigo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rtbCodigo.Location = new System.Drawing.Point(148, 66);
            this.rtbCodigo.Name = "rtbCodigo";
            this.rtbCodigo.Size = new System.Drawing.Size(615, 318);
            this.rtbCodigo.TabIndex = 5;
            this.rtbCodigo.Text = "";
            this.rtbCodigo.Click += new System.EventHandler(this.rtbCodigo_Click);
            this.rtbCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbCodigo_KeyPress);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // rtbErrores
            // 
            this.rtbErrores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbErrores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.rtbErrores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbErrores.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbErrores.ForeColor = System.Drawing.Color.Red;
            this.rtbErrores.Location = new System.Drawing.Point(151, 405);
            this.rtbErrores.Name = "rtbErrores";
            this.rtbErrores.ReadOnly = true;
            this.rtbErrores.Size = new System.Drawing.Size(612, 82);
            this.rtbErrores.TabIndex = 6;
            this.rtbErrores.Text = "";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.Location = new System.Drawing.Point(148, 384);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 110);
            this.panel4.TabIndex = 2;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
            this.toolStripMenuItem1.Text = "Eliminar";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(764, 511);
            this.Controls.Add(this.rtbCodigo);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.rtbErrores);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IDE - Mencode";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compilarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temaToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem darkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compilarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reiniciarToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbCodigo;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GuardarToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox rtbErrores;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label lbnumlinea;
        private System.Windows.Forms.Label lbLinea;
        private System.Windows.Forms.Label lbnumColumna;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ToolStripMenuItem exportarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarErroresToolStripMenuItem;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;

    }
}

