using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quizprogram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a = 0;
        int right = 0;
        int wrong = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button6.Visible = false;
            richTextBox1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            panel1.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            button7.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            
        }
        private void button5_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = false;
            button6.Visible = true;
            richTextBox1.Visible = true;
            timer1.Enabled = true;
            label1.Visible = true;
            label2.Visible = true; 
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            panel1.Visible = true;
            label12.Visible = true;
            label13.Visible = true;


            int r1 = 0;
            switch (r1)
            {
                case 0:
                    richTextBox1.Text = "Where is The White House?";
                    button1.Text = "Edinburgh";
                    button2.Text = "Westminster";
                    button3.Text = "California";
                    button4.Text = "Washington";
                    label13.Text = button4.Text;
                    label13.Visible = false;
                    break;
               
            }

        }



        private void button6_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;

            timer1.Enabled = true;
            int n1 = Convert.ToInt32(label4.Text);
            n1++;
            label4.Text = n1.ToString();
            if (n1 == 59)
            {
                label4.Text = "0";
                int n2 = Convert.ToInt32(label5.Text);
                n2++;
                label5.Text = n2.ToString();
            }
            int n3 = 30;
            n3--;
            label2.Text = n3.ToString();
            if (n3 == 0)
            {
                timer1.Enabled = false;
                MessageBox.Show("Time expired, pass the next question.");
            }
                a=a+1;
                int b=a+1;
                label7.Text = b.ToString();
                switch(a)
                {
                 case 1:
                    richTextBox1.Text = "Traditionally, Presidential elections are held in the USA in which month?";
                    button1.Text = "August";
                    button2.Text = "July";
                    button3.Text = "April";
                    button4.Text = "November";
                    label13.Text = button4.Text;
                    label13.Visible = false;
                    break;
                case 2:
                    richTextBox1.Text = "The pineapple is native to which part of the world?";
                    button1.Text = "South America";
                    button2.Text = "Pacific Islands";
                    button3.Text = "Africa";
                    button4.Text = "Australia";
                    label13.Text = button1.Text;
                    label13.Visible = false;
                    break;
                case 3:
                    richTextBox1.Text = "What is the highest point in Wales?";
                    button1.Text = "Llanelly";
                    button2.Text = "Portmeirion";
                    button3.Text = "Snowdon";
                    button4.Text = "Devil's Bridge";
                    label13.Text = button3.Text;
                    label13.Visible = false;
                    break;
                case 4:
                    richTextBox1.Text = "Which of these countries is immediately north of Bulgaria?";
                    button1.Text = "Netherlands";
                    button2.Text = "Romania";
                    button3.Text = "Belgium";
                    button4.Text = "Estonia";
                    label13.Text = button2.Text;
                    label13.Visible = false;
                    break;
                }
                if (a == 5)
                {
                    richTextBox1.Visible = false;
                    button1.Visible = false;
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;
                    label1.Visible = false;
                    label2.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;
                    timer1.Enabled = false;
                    panel2.Visible = false;
                    button6.Visible = false;
                    button7.Visible = true;
                    label14.Visible = true;
                    label15.Visible = true;
                    double succes;
                    succes=(right * 100) / 5;
                    label15.Text="%" + succes.ToString();
                }
            }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(label4.Text);
            n1++;
            label4.Text = n1.ToString();
            if (n1 == 59)
            {
                label4.Text = "0";
                int n2 = Convert.ToInt32(label5.Text);
                n2++;
                label5.Text = n2.ToString();
            }
            int n3 = Convert.ToInt32(label2.Text);
            n3--;
            label2.Text = n3.ToString();
            if (n3 == 0)
            {
                timer1.Enabled = false;
                MessageBox.Show("Time expired, pass the next question.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            timer1.Enabled = false;
            label13.Visible = true;
            if (button1.Text == label13.Text)
            {
                right++;
                label10.Text = right.ToString();
            }
            else
            {
                wrong++;
                label11.Text = wrong.ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            timer1.Enabled = false;
            label13.Visible = true;
            if (button2.Text == label13.Text)
            {
                right++;
                label10.Text = right.ToString();
            }
            else
            {
                wrong++;
                label11.Text = wrong.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            timer1.Enabled = false;
            label13.Visible = true;
            if (button3.Text == label13.Text)
            {
                right++;
                label10.Text = right.ToString();
            }
            else
            {
                wrong++;
                label11.Text = wrong.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            timer1.Enabled = false;
            label13.Visible = true;
            if (button4.Text == label13.Text)
            {
                right++;
                label10.Text = right.ToString();
            }
            else
            {
                wrong++;
                label11.Text = wrong.ToString();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
