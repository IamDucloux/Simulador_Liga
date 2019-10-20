using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulador_Liga
{
    public partial class Form1 : Form
    {
        int contadorseg = 0;
        


        void mensajeDeTimer(object myobje,EventArgs prueba)
        {
            string counter = null;
            counter = timer1.ToString();

            MessageBox.Show(counter+"Se ha cumplido el tiempo del timer");
            timer1.Stop();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            
            if (contadorseg!=30)
            {
                contadorseg += 1;
                label5.Text = contadorseg.ToString();
            }
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
            //timer1.Tick += new EventHandler(mensajeDeTimer);

           
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
