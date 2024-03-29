﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3InfixToPostfix
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            this.Text = Application.ProductName+", "+Application.CompanyName;
        }

        private void aboutInfixToPoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutProject3 aboutBox = new AboutProject3();
            aboutBox.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void inputInfixDataFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileContentsListBox.DataSource = Toolbox.GetSentencesFromFile();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            string msg = Application.ProductName + ", version " + Application.ProductVersion +
                ",\nproduced by " + Application.CompanyName + ".";

            msg += "\n\n" + DateTime.Today.ToLongDateString();

            MessageBox.Show("Thank you for using " + msg,
                "Goodbye", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fileContentsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            InfixExpressionTextBox.Text = fileContentsListBox.SelectedItem.ToString();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            InfixExpressionTextBox.Text = "";
            PostfixTextBox.Text = "";
        }

        private void generatePostfixBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
