using Less_Accurate_Calculator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private void btnOne_Click(object sender, EventArgs e) {
            rtbAnswer.Text += '1';
        }

        private void btnTwo_Click(object sender, EventArgs e) {
            rtbAnswer.Text += '2';
        }

        private void btnThree_Click(object sender, EventArgs e) {
            rtbAnswer.Text += '3';
        }

        private void btnFour_Click(object sender, EventArgs e) {
            rtbAnswer.Text += '4';
        }

        private void btnFive_Click(object sender, EventArgs e) {
            rtbAnswer.Text += '5';
        }

        private void btnSix_Click(object sender, EventArgs e) {
            rtbAnswer.Text += '6';
        }

        private void btnSeven_Click(object sender, EventArgs e) {
            rtbAnswer.Text += '7';
        }

        private void btnEight_Click(object sender, EventArgs e) {
            rtbAnswer.Text += '8';
        }

        private void btnNine_Click(object sender, EventArgs e) {
            rtbAnswer.Text += '9';
        }

        private void btnZero_Click(object sender, EventArgs e) {
            rtbAnswer.Text += '0';
        }

        private void btnDecimal_Click(object sender, EventArgs e) {
            rtbAnswer.Text += ',';
        }

        private void button13_Click(object sender, EventArgs e) {
            rtbAnswer.Text += " + ";
        }

        private void button15_Click(object sender, EventArgs e) {
            rtbAnswer.Text += " - ";
        }

        private void button14_Click(object sender, EventArgs e) {
            rtbAnswer.Text += " x ";
        }

        private void button16_Click(object sender, EventArgs e) {
            rtbAnswer.Text += " / ";
        }

        private async void btnEqual_Click(object sender, EventArgs e) {
            rtbAnswer.Text += " = ";
            rtbAnswer.Text += await ChatGPTClient.AskAsync(rtbAnswer.Text);
        }

        private void btnClear_Click(object sender, EventArgs e) {
            rtbAnswer.Clear();
        }
    }
}
