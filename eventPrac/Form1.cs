using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eventPrac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //sender에서 온 걸 가지고 어디서 이벤트를 발생했는지 알 수 있다.

            Button btn = (Button)sender;
            btn.Text = "으엑";
            btn.Enabled = false;
            
            //textBox1.Text += "♠";
            //label1.Text += "♠";
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //마우스 x값이랑 y값 알 수 있다.
            label1.Text = "x : " + e.X + "/ Y : " + e.Y;
        
        }

        private int elapsedTime = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsedTime++;
            label2.Text = ""+elapsedTime;
        }

        //reset button
        private void button6_Click(object sender, EventArgs e)
        {
            elapsedTime = 0;
            label2.Text = "";
            timer1.Start();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
