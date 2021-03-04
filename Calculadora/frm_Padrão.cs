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
    public partial class frm_Padrão : Form
    {
        //Método costrutor de "frm_Padrão", lembra-se que o método costrutor possui o mesmo nome da classe
        public frm_Padrão()
        {
            //Método responsável pelo Design
            InitializeComponent();
        }

        //Variaveis Globais
        double resultado;
        string operacao;

        private void txt_Visor_TextChanged(object sender, EventArgs e)
        {
            txt_Visor.Text = "0";
        }

        private void tsmi_Exibir_Click(object sender, EventArgs e)
        {

        }

        private void frm_Padrão_Load(object sender, EventArgs e)
        {

        }

        //Números
        private void btn_0_Click(object sender, EventArgs e)
        {
            if (operacao != "")
            {
                txt_Visor.Text = "0";
                operacao = "";
            }
            else
            {
                txt_Visor.Text += "0";
            }
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            if (operacao != "")
            {
                txt_Visor.Text = "1";
                operacao = "";
            }
            else
            {
                txt_Visor.Text += "1";
            }
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (operacao != "")
            {
                txt_Visor.Text = "2";
                operacao = "";
            }
            else
            {
                txt_Visor.Text += "2";
            }
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (operacao != "")
            {
                txt_Visor.Text = "3";
                operacao = "";
            }
            else
            {
                txt_Visor.Text += "3";
            }
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (operacao != "")
            {
                txt_Visor.Text = "4";
                operacao = "";
            }
            else
            {
                txt_Visor.Text += "4";
            }
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (operacao != "")
            {
                txt_Visor.Text = "5";
                operacao = "";
            }
            else
            {
                txt_Visor.Text += "5";
            }
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (operacao != "")
            {
                txt_Visor.Text = "6";
                operacao = "";
            }
            else
            {
                txt_Visor.Text += "6";
            }
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (operacao != "")
            {
                txt_Visor.Text = "7";
                operacao = "";
            }
            else
            {
                txt_Visor.Text += "7";
            }
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (operacao != "")
            {
                txt_Visor.Text = "8";
                operacao = "";
            }
            else
            {
                txt_Visor.Text += "8";
            }
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (operacao != "")
            {
                txt_Visor.Text = "9";
                operacao = "";
            }
            else
            {
                txt_Visor.Text += "9";
            }
        }

        //Operadores
        private void btn_Adição_Click(object sender, EventArgs e)
        {
            if (operacao == "*" || operacao == "-" || operacao == "/")
            {
                operacao = "+";
            }
            else
            {
                resultado += Convert.ToDouble(txt_Visor.Text);
                txt_Visor.Text = Convert.ToString(resultado);
                operacao = "+";
            }
          
        }

        private void btn_Subtração_Click(object sender, EventArgs e)
        {
            if (operacao == "*" || operacao == "+" || operacao == "/")
            {
                operacao = "-";
            }
            else
            {
                if (resultado == 0)
                {
                    resultado = Convert.ToDouble(txt_Visor.Text);
                }
                else
                {
                    resultado -= Convert.ToDouble(txt_Visor.Text);
                }
            }

            txt_Visor.Text = Convert.ToString(resultado);
            operacao = "-";
        }

        private void btn_Multiplicação_Click(object sender, EventArgs e)
        {
            if (operacao == "+" || operacao == "-" || operacao == "/")
            {
                operacao = "*";
            }
            else
            {
                if (resultado == 0)
                {
                    resultado = Convert.ToDouble(txt_Visor.Text);
                }
                else
                {
                    resultado *= Convert.ToDouble(txt_Visor.Text);
                }
            }

            txt_Visor.Text = Convert.ToString(resultado);
            operacao = "*";
        }

        private void btn_Divisão_Click(object sender, EventArgs e)
        {
            if (operacao == "+" || operacao == "-" || operacao == "/")
            {
                operacao = "*";
            }
            else
            {
                if (resultado == 0)
                {
                    resultado = Convert.ToDouble(txt_Visor.Text);
                }
                else
                {
                    resultado /= Convert.ToDouble(txt_Visor.Text);
                }
            }
            txt_Visor.Text = Convert.ToString(resultado);
            operacao = "/";
        }

        private void btn_Vírgula_Click(object sender, EventArgs e)
        {
         

        }

    }
}
