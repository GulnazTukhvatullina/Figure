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

        private Bitmap draw;
        private Graphics paper;

        public Form1()
        {
            InitializeComponent();
            draw = new Bitmap(panel1.Width, panel1.Height);
            paper = Graphics.FromImage(draw);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form2 = new Form2();
            //form2.Show();
            if (form2.ShowDialog(this) == DialogResult.OK)
            {
                var paper = panel1.CreateGraphics();
                var pen = new Pen(Color.Blue, 5);
                if (form2.X !=null && form2.Y != null && form2.R != null)
                {
                    paper.DrawEllipse(pen, Convert.ToInt32(form2.X.Text), Convert.ToInt32(form2.Y.Text), Convert.ToInt32(form2.R.Text),
                         Convert.ToInt32(form2.R.Text));
                }
                
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
                if (form4.X1 != null && form4.Y1 != null && form4.LX2 != null && form4.LY2 != null)
                {
                    paper.DrawLine(new Pen(Color.Green, 2), Convert.ToInt32(form4.X1.Text), Convert.ToInt32(form4.Y1.Text),
                        Convert.ToInt32(form4.LX2.Text), Convert.ToInt32(form4.LY2.Text));
                }
            }
        }
        private void Line_MouseHover(object sender, EventArgs e)
        {
            if (form4 != null)
                form4.BackColor = Color.Azure;
        }

        private void Square_Click(object sender, EventArgs e)
        {
            form4 = new Form4();
            if (form4.ShowDialog(this) == DialogResult.OK)
            {
                var paper = panel1.CreateGraphics();
                if (form4.X1 != null && form4.Y1 != null && form4.LX2 != null && form4.LY2 != null)
                {
                    paper.DrawLine(new Pen(Color.Green, 2), Convert.ToInt32(form4.X1.Text), Convert.ToInt32(form4.Y1.Text),
                        Convert.ToInt32(form4.LX2.Text), Convert.ToInt32(form4.LY2.Text));
                }
            }
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

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != " ")
                draw.Save(saveFileDialog1.FileName);
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != " ")
            {
                draw = (Bitmap)Image.FromFile(openFileDialog1.FileName);
                panel1.BackgroundImage = draw;
            }
        }
    }
}
