using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        // variaveis globais
        double numero1 = 0, numero2 = 0; // double = numeros com virgula
        char operador; // 


        public Calculadora()
        {
            InitializeComponent();
        }

        

        private void adicionarNumero(object sender, EventArgs e)
        {
            /* 
                Pegar o valor do texto de cada botão acionado(click)
                printar dentro do textbox os valores
                verificar se o primeiro valor digitado é 0
                nao adicionar nada caso pare na verificação
            */
            var button = ((Button)sender);

            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "";
            }
            txtResultado.Text += button.Text;
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            /* 
                Pegar o valor da tag de cada botão acionado(click)
                variaveis receberem o valor de cada verificacao 
                Printarem na tela
                               
            */
            numero2 = Convert.ToDouble(txtResultado.Text);

            if (operador == '+')
            {
                txtResultado.Text = (numero1 + numero2).ToString();
                numero1 = Convert.ToDouble(txtResultado.Text);
            }
            else if (operador == '-')
            {
                txtResultado.Text = (numero1 - numero2).ToString();
                numero1 = Convert.ToDouble(txtResultado.Text);
            }
            else if (operador == '*')
            {
                txtResultado.Text = (numero1 * numero2).ToString();
                numero1 = Convert.ToDouble(txtResultado.Text);
            }
            else if (operador == '/')
            {
                if (txtResultado.Text != "0")
                {
                    txtResultado.Text = (numero1 / numero2).ToString();
                    numero1 = Convert.ToDouble(txtResultado.Text);
                }
                else
                {
                    MessageBox.Show("Não é possivel dividir números por 0");
                }
            }

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            /* 
                Limpar o atual valor
            */
            txtResultado.Text = "0";
        }
        private void btnAC_Click(object sender, EventArgs e)
        {
            /* 
                Limpar todos os valores                
            */
            txtResultado.Text = "0";
            numero1 = 0;
            numero2 = 0;
            operador = '\0';
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text.Length > 1)
            {
                txtResultado.Text = txtResultado.Text.Substring(0, txtResultado.Text.Length - 1);
            }
            else
            {
                txtResultado.Text = "0";
            }
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            /* 
                clicar no botao e acionar verificação
                Verificação, caso conter for diferente de ","
                printar na tela uma virgula
                
            */
            if (!txtResultado.Text.Contains(","))
            {
                txtResultado.Text += ",";
            }
        }
        private void ClickOperador(object sender, EventArgs e)
        {
            /* 
                Pegar o valor da tag de cada botão acionado(click)
                variaveis receberem o valor de cada verificacao 
                Printarem na tela
                Recurso de MATH utilizado
            */
            var button = ((Button)sender);

            numero1 = Convert.ToDouble(txtResultado.Text);
            operador = Convert.ToChar(button.Tag);

            txtResultado.Text = "0";

            if (operador == '√')
            {
                numero1 = Math.Sqrt(numero1);
                txtResultado.Text = numero1.ToString();
            }
            else if (operador == '%')
            {
                numero1 = numero1 / 100;
                txtResultado.Text = numero1.ToString();
            }
            else if (operador == '±')
            {
                numero1 = numero1 * -1;
                txtResultado.Text = numero1.ToString();

            }


        }
    }
}
