using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pry.TimerPicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Tomato;

            timer1.Enabled = true;
            //Refresca o dispara la pagina cada 1 segundo, esta en milisegundos,
            timer1.Interval = 1000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Indicacion para que no se sobreescriba
            ss.Items.Clear();
            ss.Items.Add("Hora actual ---->");
            //Agregar el temporizador a la barra 
            ss.Items.Add(DateTime.Now.ToString("hh:mm:ss"));
            //Mostrar la hora en el label
            label1.Text = DateTime.Now.ToString("hh:mm:ss");
            //Si la hora es igual a , termian el temporizador y muestra mensaje
            if (label1.Text == "11:42:35" )
            {
                timer1.Enabled = false;
                label1.Text = "EL TEMPORIZADOR TERMINÓ";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Agregarle un mensaje al boton en la barra
            ss.Items.Add("Hola a todos");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //limpiar la barra
            ss.Items.Clear();
        }

        private void ss_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
