using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Calculator_1._0
{
    public partial class Form1 : Form
    {

        string _firstNumb = null;
        string _secondNumb = null;
        double _first = 0;
        double _second = 0;
        double sum = 0;
        string character = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizebtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void NumpadItem_Click(object sender, EventArgs e)
        {
            var numb = sender as BunifuTileButton;
            resultscreen.Text += numb.LabelText;

            if (resultscreen.Text.ToString().Length >= 10)
            {
                MessageBox.Show("the number is too large", "Big Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                resultscreen.Text = "0";
                _firstNumb = null;
                _secondNumb = null;
            }

            if (_firstNumb != null)
            {
                _firstNumb = resultscreen.Text;
            }
            else
            {
                _secondNumb = resultscreen.Text;
            }
        }



        private void CalculateThat(object sender, EventArgs e)
        {
            _first = Convert.ToDouble(resultscreen.Text.ToString());
            resultscreen.Text = "";
            dot.Enabled = true;

            var opr = sender as BunifuTileButton;
            character = opr.LabelText;

        }
        private void clear_Click(object sender, EventArgs e)
        {
            resultscreen.Text = "";
        } 


        private void equal_Click(object sender, EventArgs e)
        {

            _second = Convert.ToDouble(resultscreen.Text.ToString());

            switch (character)
            {
                case "+":
                    {
                        sum = _first + _second;
                    }
                    break;

                case "-":
                    {
                        sum = _first - _second;
                    }
                    break;
                case "x":
                    {
                        sum = _first * _second;
                    }
                    break;
                case "/":
                    {
                        if (_second == 0)
                        {
                            MessageBox.Show("Cannot divide by zero‬");

                        }
                        else
                        {
                            sum = _first / _second;
                        }
                    }
                    break;

            }
            _first = 0;
            _second = 0;
            _firstNumb = null;
            _secondNumb = null;
            resultscreen.Text = sum.ToString(); 

        } 

        private void dot_Click(object sender, EventArgs e)
        {
            if (resultscreen.Text.Contains("."))
            {
                dot.Enabled = false;
            }
            else
            {
                resultscreen.Text += ".";
            }
        }

       
    }
}
