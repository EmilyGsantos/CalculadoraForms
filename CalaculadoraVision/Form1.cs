using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalaculadoraVision
{
    public partial class Form1 : Form
        
    {
        ModelCalculadoraVision modelo;
        public Form1()
        {
            InitializeComponent();
            this.modelo = new ModelCalculadoraVision();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }// campo para COLETAR  numéro e Mostrar Resultado 

        
        

        private void button1_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = "" + this.modelo.Somar(Convert.ToDouble(textBox1.Text)); // textbox1 é o que esta guardando a resposta do user 
            
        }// botao soma 

        private void button2_Click(object sender, EventArgs e)
        {
           textBox1.Text = "" + this.modelo.Subtrair(Convert.ToDouble(textBox1.Text));
        }// botao subtração 

        private void button3_Click(object sender, EventArgs e)
        {
           textBox1.Text = "" + this.modelo.Dividir(Convert.ToDouble(textBox1.Text));
        }// botao divisão 

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "" + this.modelo.Multiplicar(Convert.ToDouble(textBox1.Text));
        }// multiplicação 

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "" + this.modelo.Potencia(Convert.ToDouble(textBox1.Text));
        }// potencia 

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "" + this.modelo.Raiz(Convert.ToDouble(textBox1.Text));
        }// raiz 
    }// fim da classe 
}// fim do projeto 
