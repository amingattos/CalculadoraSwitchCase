using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraSwitchCase
{
    public partial class Calculadora : Form
    {
        //VARIAVEIS
        decimal nr1=0, nr2=0, res=0;
        string operacao;
        public Calculadora()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            if (txtb_valor1.Text != "" && txtb_valor2.Text != "")
            {
                nr1 = Convert.ToDecimal(txtb_valor1.Text);
                nr2 = Convert.ToDecimal(txtb_valor2.Text);

                if (rb_somar.Checked)
                {
                    operacao = "+";
                }else if (rb_subtrair.Checked)
                {
                    operacao = "-";
                }
                else if (rb_multiplicar.Checked)
                {
                    operacao = "*";
                }
                else if (rb_dividir.Checked)
                {
                    operacao = "/";
                }
                else if (rb_porcento.Checked)
                {
                    operacao = "%";
                }
                else
                {
                    MessageBox.Show("Selecione a Operação.");
                    txtb_resuldado.Clear();
                }
            }else
            {
                MessageBox.Show("Insira os valores 1 e 2.");
                txtb_resuldado.Clear();
            }
            
            switch (operacao)
            {
                case "+":
                    res = nr1 + nr2;
                    break;
                case "-":
                    res = nr1 - nr2;
                    break;
                case "*":
                    res = nr1 * nr2;
                    break;
                case "/":
                    res = nr1 / nr2;
                    break;
                case "%":
                    res = nr1 / 100 * nr2;
                    break;
                default:
                    break;
            }

            txtb_resuldado.Text = Convert.ToString(res);
        }
    }
}
