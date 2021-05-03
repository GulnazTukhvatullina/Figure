using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private Form2 form2;
        private Form4 form4;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form2 = new Form2();
            //form2.Show();
            if (form2.ShowDialog(this) == DialogResult.OK)
            {
                var paper = panel1.CreateGraphics();
                var pen = new Pen(Color.Blue, 5);
                paper.DrawEllipse(pen, 40, 40, 50, 50);
            }
        }
        private void button1_MouseHover(object sender, EventArgs e)
        {
            if (form2 != null)
                form2.BackColor = Color.Azure;
        }

        private void Line_Click(object sender, EventArgs e)
        {
            form4 = new Form4();
            //form4.Show();
            if (form4.ShowDialog(this) == DialogResult.OK)
            {
                var paper = panel1.CreateGraphics();
                var pen = new Pen(Color.Blue, 5);
                paper.DrawLine(new Pen(Color.Green, 6), new Point(60, 30), new Point(150, 70));
            }
        }
        private void Line_MouseHover(object sender, EventArgs e)
        {
            if (form4 != null)
                form4.BackColor = Color.Azure;
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            var paper = panel1.CreateGraphics();
            var pen = new Pen(Color.Red, 5);
            paper.DrawEllipse(pen, e.X, e.Y, 50, 50);
        }

        private void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var paper = panel1.CreateGraphics();
            var pen = new Pen(Color.Blue, 5);
            paper.DrawLine(new Pen(Color.Yellow, 6), new Point(e.X, e.Y), new Point(150, 70));
        }
    }
}
