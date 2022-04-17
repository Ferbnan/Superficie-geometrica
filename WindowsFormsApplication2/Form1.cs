using System;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double radio,pi,area,volumen, circunferfencia,diametro;

            radio = Convert.ToDouble(textBox1.Text);
            pi = Math.PI;

            circunferfencia = 2*pi*radio;
            textBox2.Text = Convert.ToString (circunferfencia);

            area = pi * radio * radio;
            textBox3.Text = Convert.ToString(area);

            volumen = 4.0/3.0*pi*(radio*radio*radio);
            //volumen= (4/3)*pi*Math.Pow(radio,3);
            textBox4.Text = Convert.ToString (volumen);

            diametro = 2*radio;
            textBox5.Text = Convert.ToString(diametro);
        }

        /*Dejar limpios los campos de texto*/
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = ("");
            textBox2.Text = ("");
            textBox3.Text = ("");
            textBox4.Text = ("");
            textBox5.Text = ("");
        }


        /*Validación de campo en radio*/
        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false; 
        }
        private void validarVacio()
        {
            var verificacion = !string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox1.Text);
            button1.Enabled = verificacion;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            validarVacio();
        }
    }
}
