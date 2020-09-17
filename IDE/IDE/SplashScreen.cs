using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;



namespace IDE
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            //Se le asigna un fondo transparente
            this.BackColor = Color.Blue;
            TransparencyKey = Color.Blue;
        }
        //Metodo al iniciar 
        private void SplashScreen_Load(object sender, EventArgs e)
        {
            //El timer para el progressbar iniciaba
            timer1.Start();
        }
        //Metodo mientras el timer avanza
        private void timer1_Tick(object sender, EventArgs e)
        {
            //La progressbar aumenta
            progressBar1.Increment(4);
            if (progressBar1.Value == 100)
            {
                //El tiempo para y se abre el formulario
                timer1.Stop();
                Form1 formulario = new Form1();
                formulario.Show();
                this.Visible = false;
            }
        }
    }
}
