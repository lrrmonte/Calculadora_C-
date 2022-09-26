﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc_padrao
{
    public partial class Form1 : Form
    {
        bool clicar_operadores = false;
        string operacao;
        double num1,num2,resultado;
        bool ativar_calculo = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void clicar_num(int num)
        {
            if (clicar_operadores == false)
                tb_numero.Text += num;
            else
                tb_numero.Text = num.ToString();

            clicar_operadores = false;
        }
        private void operadores(string operacao)
        {
            clicar_operadores = true;
            if (ativar_calculo == true)
                calcular();
            this.operacao = operacao;
            num1 =double.Parse(tb_numero.Text);
            ativar_calculo=true;
        }
        private void calcular()
        {
            num2=double.Parse(tb_numero.Text);

            switch (operacao)
            {
                case "/":
                    resultado = num1 / num2;
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;
                case "-":
                    resultado=num1 - num2;
                    break;
                case "+":
                    resultado=num1 + num2;
                    break;
            }
            tb_numero.Text = resultado.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            clicar_num(0);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            clicar_num(1);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            clicar_num(2);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            clicar_num(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clicar_num(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            clicar_num(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            clicar_num(6);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clicar_num(7);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clicar_num(8);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clicar_num(9);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            operadores("/");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            operadores("*");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            tb_numero.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            int numero = tb_numero.Text.Length;
            if(numero>0)
            tb_numero.Text = tb_numero.Text.Substring(0, numero - 1);

        }

        private void button12_Click(object sender, EventArgs e)
        {
            calcular();
            ativar_calculo = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            tb_numero.Text += ",";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            operadores("-");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            operadores("+");
        }

    }
}
