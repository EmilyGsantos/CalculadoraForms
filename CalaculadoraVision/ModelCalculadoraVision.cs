using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CalaculadoraVision
{
    class ModelCalculadoraVision
    {
        private double operacao;
      

        public ModelCalculadoraVision()
        {
            ConsultarOperacao = 0;
        }//fim do construtor

        public double ConsultarOperacao
        {
            get { return operacao; }
            set { this.operacao = value; }
        }//fim do método


        public double Somar(double num)
        {
            return ConsultarOperacao += num;
        }//fim do somar

        public double Subtrair(double num)
        {
            return ConsultarOperacao -= num;
        }//fim do subtrair

        public double Dividir(double num)
        {
            return ConsultarOperacao /= num;
        }//fim do somar

        public double Multiplicar(double num)
        {
            return ConsultarOperacao *= num;
        }//fim do somar

        public double Potencia(double num)
        {
            return ConsultarOperacao += Math.Pow(num,num); //( num para o numero) + ( num para a potencia)
        }// fim da potencia 


        public double Raiz(double num)
        {
            return ConsultarOperacao +=  Math.Sqrt(num);
        }// fim da raiz




        }//fim da classe
    }//fim do projeto 

   
