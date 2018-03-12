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
        
        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by: Rohit Kadhe");
        }

        private void EncryptMessage_Click(object sender, EventArgs e)
        {
            string input = textBox2.Text;
            encrypt(input);
        }

        /*Message encryption logic*/
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

        /*Message decryption logic*/
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
        /*decrypt function caller*/
        private void DecryptMessage_Click(object sender, EventArgs e)
        {
            string message = textBox1.Text;
            decrypt(message);
        }
        /*Clears all textboxes*/
        private void clearAllFieldsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
        }
        /*Quits application*/
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            InstructionsPanel.Hide();
        }
    }
}