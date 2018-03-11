using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EncrypterApp
{
    public partial class EncrypterApp : Form
    {
        public EncrypterApp()
        {
            InitializeComponent();
        }
        /* This allows to move borderless window*/
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by: Rohit Kadhe");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            // isVisible in properties is set to false; remember!!
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
            // isVisible in properties is set to false; remember!!
        }

        private void EncryptMessage_Click(object sender, EventArgs e)
        {
            string input = textBox2.Text;
            encrypt(input);
        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        void encrypt(string message)
        {
            int[] code = new int[100000];
            string codeString = "";
            /*Converts code from a string to a int*/

            for (int i = 0; i < message.Length; i++)
            {
                code[i] = message[i];

            }
            for (int i = 0; i < message.Length; i++)
            {
                codeString += code[i].ToString();
            }

            richTextBox1.Text = codeString;

        }

        void decrypt(string message)
        {

            int[] decodedMessage = new int[100000]; int[] intermediate = new int[100000];
            int sum = 0, pos = 0, j = 0;
            string finalDecodedM = "";

            /*Converts code from stringType to intType*/
            for (int i = 0; i < message.Length; i++)
            {
                intermediate[i] = message[i] - '0';
            }
            /*Converts code from a number to string*/
            while (j <= message.Length)
            {
                if (sum > 25)
                {
                    decodedMessage[pos] = sum;
                    sum = 0;
                    pos++;
                }
                else
                {
                    sum = (sum * 10) + intermediate[j];
                    j++;
                }
            }
            /*Prints converted code*/
            for (int k = 0; k < message.Length; k++)
            {
                finalDecodedM += Convert.ToChar(decodedMessage[k]).ToString();

            }
            richTextBox2.Text = finalDecodedM;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void DecryptMessage_Click(object sender, EventArgs e)
        {
            string message = textBox1.Text;
            decrypt(message);

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearAllFieldsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}