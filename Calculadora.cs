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
        double numero1 = 0, numero2 = 0;
        char operador;


        public Calculadora()
        {
            InitializeComponent();
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

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
        private void ClickOperador(object sender, EventArgs e)
        {
            var button = ((Button)sender);

            numero1 = Convert.ToDouble(txtResultado.Text);
            operador = Convert.ToChar(button.Tag);

            txtResultado.Text = "0";
        }
    }
}
