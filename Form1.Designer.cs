namespace AnalizadorFinal
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Menu1 = new System.Windows.Forms.Panel();
            this.maximisar = new System.Windows.Forms.PictureBox();
            this.max = new System.Windows.Forms.PictureBox();
            this.minimizar = new System.Windows.Forms.PictureBox();
            this.salir = new System.Windows.Forms.PictureBox();
            this.Graficador = new System.Windows.Forms.Panel();
            this.Grafica = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Control = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DatosFiltrar = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Filtrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Graficar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.Pausar = new System.Windows.Forms.Button();
            this.Gozono = new System.Windows.Forms.CheckBox();
            this.Gtiempo = new System.Windows.Forms.CheckBox();
            this.Ghaltura = new System.Windows.Forms.CheckBox();
            this.Guv = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.reanudar = new System.Windows.Forms.Panel();
            this.Transicion = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Menu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maximisar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salir)).BeginInit();
            this.Graficador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grafica)).BeginInit();
            this.Control.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.reanudar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu1
            // 
            this.Menu1.BackColor = System.Drawing.Color.Navy;
            this.Menu1.Controls.Add(this.maximisar);
            this.Menu1.Controls.Add(this.max);
            this.Menu1.Controls.Add(this.minimizar);
            this.Menu1.Controls.Add(this.salir);
            this.Menu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Menu1.Location = new System.Drawing.Point(0, 0);
            this.Menu1.Name = "Menu1";
            this.Menu1.Size = new System.Drawing.Size(1094, 37);
            this.Menu1.TabIndex = 0;
            this.Menu1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Menu1_MouseDown);
            // 
            // maximisar
            // 
            this.maximisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maximisar.Image = ((System.Drawing.Image)(resources.GetObject("maximisar.Image")));
            this.maximisar.Location = new System.Drawing.Point(1017, 6);
            this.maximisar.Margin = new System.Windows.Forms.Padding(4);
            this.maximisar.Name = "maximisar";
            this.maximisar.Size = new System.Drawing.Size(33, 31);
            this.maximisar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.maximisar.TabIndex = 7;
            this.maximisar.TabStop = false;
            this.maximisar.Click += new System.EventHandler(this.maximisar_Click);
            // 
            // max
            // 
            this.max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.max.Cursor = System.Windows.Forms.Cursors.Hand;
            this.max.Image = ((System.Drawing.Image)(resources.GetObject("max.Image")));
            this.max.Location = new System.Drawing.Point(1019, 6);
            this.max.Margin = new System.Windows.Forms.Padding(4);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(33, 31);
            this.max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.max.TabIndex = 6;
            this.max.TabStop = false;
            this.max.Visible = false;
            this.max.Click += new System.EventHandler(this.max_Click);
            // 
            // minimizar
            // 
            this.minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizar.Image = ((System.Drawing.Image)(resources.GetObject("minimizar.Image")));
            this.minimizar.Location = new System.Drawing.Point(978, 4);
            this.minimizar.Margin = new System.Windows.Forms.Padding(4);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(33, 31);
            this.minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimizar.TabIndex = 5;
            this.minimizar.TabStop = false;
            this.minimizar.Click += new System.EventHandler(this.minimizar_Click);
            // 
            // salir
            // 
            this.salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salir.Image = ((System.Drawing.Image)(resources.GetObject("salir.Image")));
            this.salir.Location = new System.Drawing.Point(1058, 4);
            this.salir.Margin = new System.Windows.Forms.Padding(4);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(33, 31);
            this.salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.salir.TabIndex = 4;
            this.salir.TabStop = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // Graficador
            // 
            this.Graficador.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Graficador.Controls.Add(this.Guv);
            this.Graficador.Controls.Add(this.Ghaltura);
            this.Graficador.Controls.Add(this.Gtiempo);
            this.Graficador.Controls.Add(this.Gozono);
            this.Graficador.Controls.Add(this.Grafica);
            this.Graficador.Dock = System.Windows.Forms.DockStyle.Right;
            this.Graficador.Location = new System.Drawing.Point(206, 37);
            this.Graficador.Name = "Graficador";
            this.Graficador.Size = new System.Drawing.Size(888, 560);
            this.Graficador.TabIndex = 1;
            // 
            // Grafica
            // 
            this.Grafica.BackColor = System.Drawing.Color.Black;
            this.Grafica.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            this.Grafica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Grafica.BackImageTransparentColor = System.Drawing.Color.Blue;
            this.Grafica.BackSecondaryColor = System.Drawing.Color.Navy;
            this.Grafica.BorderlineColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Grafica.BorderlineWidth = 2;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.LightGray;
            chartArea1.AxisX.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            chartArea1.AxisX2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.LightGray;
            chartArea1.AxisY.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            chartArea1.Name = "ChartArea1";
            this.Grafica.ChartAreas.Add(chartArea1);
            this.Grafica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Grafica.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            legend1.ForeColor = System.Drawing.Color.LightGray;
            legend1.Name = "Legend1";
            this.Grafica.Legends.Add(legend1);
            this.Grafica.Location = new System.Drawing.Point(0, 0);
            this.Grafica.Margin = new System.Windows.Forms.Padding(4);
            this.Grafica.Name = "Grafica";
            this.Grafica.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.Grafica.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Blue,
        System.Drawing.Color.Green,
        System.Drawing.Color.Magenta,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))),
        System.Drawing.Color.Black,
        System.Drawing.Color.Yellow,
        System.Drawing.Color.Purple,
        System.Drawing.Color.Maroon,
        System.Drawing.SystemColors.Highlight,
        System.Drawing.Color.Indigo,
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.Olive,
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0))))),
        System.Drawing.Color.LightCoral,
        System.Drawing.Color.Gold,
        System.Drawing.Color.GreenYellow,
        System.Drawing.Color.DarkTurquoise,
        System.Drawing.Color.DarkKhaki,
        System.Drawing.Color.DeepPink,
        System.Drawing.Color.Teal,
        System.Drawing.Color.SlateBlue};
            this.Grafica.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.LightSkyBlue;
            series1.LabelBackColor = System.Drawing.SystemColors.MenuText;
            series1.LabelBorderColor = System.Drawing.Color.Blue;
            series1.Legend = "Legend1";
            series1.MarkerColor = System.Drawing.Color.Red;
            series1.MarkerImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "G1";
            series1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            series1.XValueMember = "-10";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValueMembers = "-10";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.LabelBackColor = System.Drawing.Color.Lime;
            series2.LabelBorderColor = System.Drawing.Color.Blue;
            series2.Legend = "Legend1";
            series2.MarkerBorderColor = System.Drawing.Color.AliceBlue;
            series2.MarkerColor = System.Drawing.Color.Lime;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "G2";
            series2.XValueMember = "-10";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.YValueMembers = "-10";
            this.Grafica.Series.Add(series1);
            this.Grafica.Series.Add(series2);
            this.Grafica.Size = new System.Drawing.Size(888, 560);
            this.Grafica.TabIndex = 88;
            this.Grafica.Text = "Figura";
            // 
            // Control
            // 
            this.Control.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Control.Controls.Add(this.Transicion);
            this.Control.Controls.Add(this.textBox1);
            this.Control.Controls.Add(this.reanudar);
            this.Control.Controls.Add(this.panel4);
            this.Control.Controls.Add(this.panel3);
            this.Control.Controls.Add(this.panel2);
            this.Control.Controls.Add(this.panel1);
            this.Control.Dock = System.Windows.Forms.DockStyle.Left;
            this.Control.Location = new System.Drawing.Point(0, 37);
            this.Control.Name = "Control";
            this.Control.Size = new System.Drawing.Size(210, 560);
            this.Control.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Navy;
            this.panel3.Controls.Add(this.DatosFiltrar);
            this.panel3.Location = new System.Drawing.Point(3, 149);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 42);
            this.panel3.TabIndex = 2;
            // 
            // DatosFiltrar
            // 
            this.DatosFiltrar.BackColor = System.Drawing.SystemColors.Highlight;
            this.DatosFiltrar.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.DatosFiltrar.Location = new System.Drawing.Point(26, 3);
            this.DatosFiltrar.Multiline = true;
            this.DatosFiltrar.Name = "DatosFiltrar";
            this.DatosFiltrar.Size = new System.Drawing.Size(167, 36);
            this.DatosFiltrar.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.Filtrar);
            this.panel2.Location = new System.Drawing.Point(3, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 42);
            this.panel2.TabIndex = 1;
            // 
            // Filtrar
            // 
            this.Filtrar.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Filtrar.FlatAppearance.BorderSize = 0;
            this.Filtrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Filtrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Filtrar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filtrar.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Filtrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Filtrar.Location = new System.Drawing.Point(29, 4);
            this.Filtrar.Margin = new System.Windows.Forms.Padding(4);
            this.Filtrar.Name = "Filtrar";
            this.Filtrar.Size = new System.Drawing.Size(167, 34);
            this.Filtrar.TabIndex = 3;
            this.Filtrar.Text = "APLICAR FILTRO";
            this.Filtrar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.Graficar);
            this.panel1.Location = new System.Drawing.Point(3, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 89);
            this.panel1.TabIndex = 0;
            // 
            // Graficar
            // 
            this.Graficar.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Graficar.FlatAppearance.BorderSize = 0;
            this.Graficar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Graficar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Graficar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Graficar.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Graficar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Graficar.Location = new System.Drawing.Point(26, 8);
            this.Graficar.Margin = new System.Windows.Forms.Padding(4);
            this.Graficar.Name = "Graficar";
            this.Graficar.Size = new System.Drawing.Size(167, 77);
            this.Graficar.TabIndex = 3;
            this.Graficar.Text = "GRAFICAR";
            this.Graficar.UseVisualStyleBackColor = false;
            this.Graficar.Click += new System.EventHandler(this.Graficar_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Navy;
            this.panel4.Controls.Add(this.Pausar);
            this.panel4.Location = new System.Drawing.Point(3, 197);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 42);
            this.panel4.TabIndex = 3;
            // 
            // Pausar
            // 
            this.Pausar.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Pausar.FlatAppearance.BorderSize = 0;
            this.Pausar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Pausar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pausar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pausar.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Pausar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Pausar.Location = new System.Drawing.Point(29, 4);
            this.Pausar.Margin = new System.Windows.Forms.Padding(4);
            this.Pausar.Name = "Pausar";
            this.Pausar.Size = new System.Drawing.Size(167, 34);
            this.Pausar.TabIndex = 3;
            this.Pausar.Text = "Pausar";
            this.Pausar.UseVisualStyleBackColor = false;
            this.Pausar.Click += new System.EventHandler(this.Pausar_Click);
            // 
            // Gozono
            // 
            this.Gozono.AutoSize = true;
            this.Gozono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Gozono.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Gozono.Location = new System.Drawing.Point(798, 75);
            this.Gozono.Name = "Gozono";
            this.Gozono.Size = new System.Drawing.Size(68, 20);
            this.Gozono.TabIndex = 89;
            this.Gozono.Text = "Ozono";
            this.Gozono.UseVisualStyleBackColor = false;
            // 
            // Gtiempo
            // 
            this.Gtiempo.AutoSize = true;
            this.Gtiempo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Gtiempo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Gtiempo.Location = new System.Drawing.Point(798, 152);
            this.Gtiempo.Name = "Gtiempo";
            this.Gtiempo.Size = new System.Drawing.Size(76, 20);
            this.Gtiempo.TabIndex = 90;
            this.Gtiempo.Text = "Tiempo";
            this.Gtiempo.UseVisualStyleBackColor = false;
            // 
            // Ghaltura
            // 
            this.Ghaltura.AutoSize = true;
            this.Ghaltura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Ghaltura.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Ghaltura.Location = new System.Drawing.Point(798, 127);
            this.Ghaltura.Name = "Ghaltura";
            this.Ghaltura.Size = new System.Drawing.Size(72, 20);
            this.Ghaltura.TabIndex = 91;
            this.Ghaltura.Text = "Haltura";
            this.Ghaltura.UseVisualStyleBackColor = false;
            // 
            // Guv
            // 
            this.Guv.AutoSize = true;
            this.Guv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Guv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Guv.Location = new System.Drawing.Point(798, 101);
            this.Guv.Name = "Guv";
            this.Guv.Size = new System.Drawing.Size(46, 20);
            this.Guv.TabIndex = 92;
            this.Guv.Text = "Uv";
            this.Guv.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(29, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Reanudar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reanudar
            // 
            this.reanudar.BackColor = System.Drawing.Color.Navy;
            this.reanudar.Controls.Add(this.button1);
            this.reanudar.Location = new System.Drawing.Point(3, 245);
            this.reanudar.Name = "reanudar";
            this.reanudar.Size = new System.Drawing.Size(200, 42);
            this.reanudar.TabIndex = 4;
            // 
            // Transicion
            // 
            this.Transicion.AutoSize = true;
            this.Transicion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Transicion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Transicion.Location = new System.Drawing.Point(56, 305);
            this.Transicion.Name = "Transicion";
            this.Transicion.Size = new System.Drawing.Size(92, 20);
            this.Transicion.TabIndex = 93;
            this.Transicion.Text = "Transicion";
            this.Transicion.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.textBox1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox1.Location = new System.Drawing.Point(43, 331);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 28);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 597);
            this.Controls.Add(this.Control);
            this.Controls.Add(this.Graficador);
            this.Controls.Add(this.Menu1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Menu1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.maximisar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salir)).EndInit();
            this.Graficador.ResumeLayout(false);
            this.Graficador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grafica)).EndInit();
            this.Control.ResumeLayout(false);
            this.Control.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.reanudar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Menu1;
        private System.Windows.Forms.Panel Graficador;
        private System.Windows.Forms.Panel Control;
        private System.Windows.Forms.PictureBox maximisar;
        private System.Windows.Forms.PictureBox max;
        private System.Windows.Forms.PictureBox minimizar;
        private System.Windows.Forms.PictureBox salir;
        private System.Windows.Forms.DataVisualization.Charting.Chart Grafica;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Graficar;
        private System.Windows.Forms.Button Filtrar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox DatosFiltrar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button Pausar;
        private System.Windows.Forms.CheckBox Guv;
        private System.Windows.Forms.CheckBox Ghaltura;
        private System.Windows.Forms.CheckBox Gtiempo;
        private System.Windows.Forms.CheckBox Gozono;
        private System.Windows.Forms.Panel reanudar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox Transicion;
        private System.Windows.Forms.TextBox textBox1;
    }
}

