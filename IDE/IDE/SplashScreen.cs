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
            this.BackColor = Color.Blue;
            TransparencyKey = Color.Blue;
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            
            timer1.Start();
        }
    
   

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(4);
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                Form1 formulario = new Form1();
                formulario.Show();
                this.Visible = false;
            }

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        } 

    }
}
