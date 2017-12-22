using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test
{
    public partial class Form3 : Form
    {
        TreeNode form_node;
        public static bool corrPass = false;
        private MainForm mainForm = null;

        public Form3(TreeNode curr, Form callingForm)
        {
            mainForm = callingForm as MainForm; 
            InitializeComponent();
            form_node = curr;
            textBox1.UseSystemPasswordChar = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0000")
            {
                corrPass = true;
                PairwiseComparisons f2 = new PairwiseComparisons(form_node, mainForm);
                f2.Show();
                Close();
            }
            else
            {
                Close();
                MessageBox.Show("Неверный пароль");
            }


        }
    }
}
