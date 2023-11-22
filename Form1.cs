using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AnalizadorFinal
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// varaibles a considerarce
        /// </summary>
        public double Haltura = 0.005;
        public  double T ;
        public double Ozono = 0.005;
        public double Uv = 0.005;
        public string[] arreglo;
        public string[,] arreglo1= new string[28673, 4];
        public string[] dato;
        public int indicador = 0;
        //---indicadoires ----
        public string indicador1 = "0";
        public string indicador2 = "0";
        public string indicador3 = "0";
        public string indicador4 = "0";
        public string a= "0";
        public string ruta;
        //-------------------------

        public string linea = "";
        //----------------------------
        public Form1()
        {
            InitializeComponent();
        }

        // ID para poder mover la ventana--------

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        ///-------------
        
        /// botonoes de contropl de ventana
        /// ---------------------------------------
        private void salir_Click(object sender, EventArgs e)
        {
            // cerrar todo- anular todo
                this.Close();
        }

        private void maximisar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            maximisar.Visible = false;
            max.Visible = true;
        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void max_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            max.Visible = false;
            maximisar.Visible = true;
        }
        /// <summary>
        /// boton grafciar y mostrar los datos
        /// </summary>

        private void Graficar_Click(object sender, EventArgs e)
        {
            try
            {
                indicador1 = "0";
                    indicador2 = "0";
                    indicador3 = "0";
                    indicador4 = "0";
                Grafica.Series["G1"].Points.Clear();
                Grafica.Series["G2"].Points.Clear();
                // leemos los datos dek archivo txt: C:\Users\JOSE LUIS TARQUI\Documents\proyecto TECNONAUTAS
                char[] delims = new[] { '\r', '\n' };
                // StreamReader leer = new StreamReader(@"C:\Users\JOSE LUIS TARQUI\Documents\proyecto TECNONAUTAS\DATOS.txt");
                 StreamReader leer = new StreamReader(@"C:\DATOS.txt");
                linea = leer.ReadToEnd();
                //resepcion de datos del archivo de texto

                NumberFormatInfo formatProvider = new NumberFormatInfo();
                formatProvider.NumberDecimalSeparator = ".";
                // formatProvider.NumberGroupSeparator = ",";
                arreglo = linea.Split(delims, StringSplitOptions.RemoveEmptyEntries);
                Console.WriteLine(arreglo.Length);
                timer1.Start();
                timer1.Interval = Convert.ToInt32("100");
            }
            catch
            {
                MessageBox.Show("No se encontro el archivo");
            }
            if (Gozono.Checked == true)
            {
                indicador1 = "1";
            }
            if (Guv.Checked == true)
            {
                indicador2 = "1";
            }
            if (Ghaltura.Checked == true)
            {
                indicador3 = "1";
            }
            if (Gtiempo.Checked == true)
            {
                indicador4 = "1";
            }

            //////
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(indicador!=arreglo.Length)
            {
                indicador = indicador + 1;
                dato= arreglo[indicador].Split(',');
                for(int i = 0; i < dato.Length; i++)
                {
                    arreglo1[indicador, i] = dato[i];
                }
                Haltura = Convert.ToDouble(arreglo1[indicador,0])/1000;
                Ozono = Convert.ToDouble(arreglo1[indicador,1])*10;
                Uv = Convert.ToDouble(arreglo1[indicador, 2])/100;
                T = Convert.ToDouble(arreglo1[indicador, 3])/(60*60);
                
            }
            else
            {
                timer1.Stop();
            }
            a = indicador1 + indicador2 + indicador3 + indicador4;
            Console.WriteLine(a);

            switch (a)
            {
                case "1001":
                    if (Grafica.Series["G1"].Points.Count > Int16.Parse(textBox1.Text) && Transicion.Checked == true)
                    {
                        Grafica.Series["G1"].Points.RemoveAt(0);
                        Grafica.Update();
                    }
                    Grafica.Series["G1"].Points.AddXY(T, Ozono);
                    break;
                case "1100":
                    if (Grafica.Series["G1"].Points.Count > Int16.Parse(textBox1.Text) && Transicion.Checked == true)
                    {
                        Grafica.Series["G1"].Points.RemoveAt(0);
                        Grafica.Update();
                    }
                    Grafica.Series["G1"].Points.AddXY(Uv, Ozono);
                    break;
                case "0101":
                    if (Grafica.Series["G1"].Points.Count > Int16.Parse(textBox1.Text) && Transicion.Checked == true)
                    {
                        Grafica.Series["G1"].Points.RemoveAt(0);
                        Grafica.Update();
                    }
                    Grafica.Series["G1"].Points.AddXY(T, Uv);
                    break;
                case "1010":
                    if (Grafica.Series["G1"].Points.Count > Int16.Parse(textBox1.Text) && Transicion.Checked == true)
                    {
                        Grafica.Series["G1"].Points.RemoveAt(0);
                        Grafica.Update();
                    }
                    Grafica.Series["G1"].Points.AddXY(Haltura, Ozono);
                    break;
                case "0110":
                    if (Grafica.Series["G1"].Points.Count > Int16.Parse(textBox1.Text) && Transicion.Checked == true)
                    {
                        Grafica.Series["G1"].Points.RemoveAt(0);
                        Grafica.Update();
                    }
                    Grafica.Series["G1"].Points.AddXY(Haltura, Uv);
                    break;
                case "0011":
                    if (Grafica.Series["G1"].Points.Count > Int16.Parse(textBox1.Text) && Transicion.Checked == true)
                    {
                        Grafica.Series["G1"].Points.RemoveAt(0);
                        Grafica.Update();
                    }
                    Grafica.Series["G1"].Points.AddXY(Haltura, T);
                    break;
                case "1110":
                    if (Grafica.Series["G1"].Points.Count > Int16.Parse(textBox1.Text)&& Grafica.Series["G2"].Points.Count > Int16.Parse(textBox1.Text) && Transicion.Checked == true)
                    {
                        Grafica.Series["G1"].Points.RemoveAt(0);
                        Grafica.Series["G2"].Points.RemoveAt(0);
                        Grafica.Update();
                    }
                    Grafica.Series[0].Points.AddXY(Haltura, Uv);
                    Grafica.Series[1].Points.AddXY(Haltura, Ozono);
                    break;
                case "1101":
                    if (Grafica.Series["G1"].Points.Count > Int16.Parse(textBox1.Text) && Grafica.Series["G2"].Points.Count > Int16.Parse(textBox1.Text) && Transicion.Checked == true)
                    {
                        Grafica.Series["G1"].Points.RemoveAt(0);
                        Grafica.Series["G2"].Points.RemoveAt(0);
                        Grafica.Update();
                    }
                    Grafica.Series[0].Points.AddXY(T, Uv);
                    Grafica.Series[1].Points.AddXY(T, Ozono);
                    break;
                default:
                    Grafica.Series["G1"].Points.Clear();
                    Grafica.Series["G2"].Points.Clear();
                    break;
            }

        }

        private void Pausar_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Menu1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
