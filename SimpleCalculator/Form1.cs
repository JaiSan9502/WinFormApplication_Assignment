﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        double operand1, operand2, result;
        Operations oper = new Operations();

        private void btnSub_Click(object sender, EventArgs e)
        {
            result = oper.Sub(Convert.ToDouble(txtOperand1.Text),Convert.ToDouble(txtOperand2.Text));
            txtResult.Text = result.ToString();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            result = oper.Mul(Convert.ToDouble(txtOperand1.Text),Convert.ToDouble(txtOperand2.Text));
            txtResult.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            result = oper.Div(Convert.ToDouble(txtOperand1.Text),Convert.ToDouble(txtOperand2.Text));
            txtResult.Text = result.ToString();
        }

        private void txtOperand1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar)==false && char.IsControl(e.KeyChar) && (e.KeyChar=='.'? txtOperand1.Text.Contains('.')==true:true))
            e.Handled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            result = oper.Add(Convert.ToDouble(txtOperand1.Text),Convert.ToDouble(txtOperand2.Text));
            txtResult.Text = result.ToString();
        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}
