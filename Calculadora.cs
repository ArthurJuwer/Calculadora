using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        // variaveis globais

        

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
    }
}
