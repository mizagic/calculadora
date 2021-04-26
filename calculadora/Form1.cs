using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        private Calculadora c; 
        public class Calculadora
        {
            //atributos
            
            public int resultado { get; set; }
           
            //métodos
            internal void Somar(int valorOperacao)
            {

                this.resultado += valorOperacao;
            }
            internal void Dividir(int valorOperacao)
            {

                this.resultado /= valorOperacao;
            }
            internal void Multiplicar(int valorOperacao)
            {

                this.resultado *= valorOperacao;
            }

            internal void Subtrair(int valorOperacao)
            {
                this.resultado -= valorOperacao;
            }
        }
     
        private void Form1_Load(object sender, EventArgs e)
        {
            this.c = new Calculadora();
        }

        private void btnSomar_Click_1(object sender, EventArgs e)
        {
            string valorDigitado = tbValor.Text;
            
            
            int valorOperacao = int.Parse(valorDigitado);
           
            this.c.Somar(valorOperacao ); 
           
            this.c.Somar(valorOperacao);
            tbValor.Clear();
           
            tbResultado.Text = Convert.ToString(this.c.resultado);
           
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            string valorDigitado = tbValor.Text;
         
            int valorOperacao = int.Parse(valorDigitado);
            this.c.Subtrair(valorOperacao);
            tbValor.Clear();
            tbResultado.Text = Convert.ToString(this.c.resultado);
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            string valorDigitado = tbValor.Text;
            
            int valorOperacao = int.Parse(valorDigitado);
            this.c.Multiplicar(valorOperacao);
            tbValor.Clear();
            tbResultado.Text = Convert.ToString(this.c.resultado);
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            string valorDigitado = tbValor.Text;

            int valorOperacao = int.Parse(valorDigitado);
            this.c.Dividir(valorOperacao);
            tbValor.Clear();
            tbResultado.Text = Convert.ToString(this.c.resultado);
        }

     
        }

        }

    
