using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Life
{
    public partial class Form1 : Form
    {
        int box_w = 20;
        int box_h = 20;
        int w, h;
        Label[,] lab;
        Life life;
        Color col_empty = Color.White;
        Color col_live = Color.Blue;
        Color col_born = Color.Green;
        Color col_dead = Color.Red;

        public Form1()
        {
            InitializeComponent();
            panel1.Controls.Clear();
            InitLabels();
        }

        private void Form1_Resize(object sender, System.EventArgs e)
        {
            panel1.Controls.Clear();
            InitLabels();
        }

        private void InitLabels()
        {
            w = panel1.Width / box_w;
            h = panel1.Height / box_h;

            life = new Life(w, h);
            lab = new Label[w, h];

            for (int i = 0; i < w; i++)
                for (int j = 0; j < h; j++)
                    AddLabel(i, j);
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            int x = ((Label)sender).Location.X / box_w;
            int y = ((Label)sender).Location.Y / box_h;
            int color = life.SwitchField(x, y);
            lab[x, y].BackColor = color == 1 ? col_live : col_empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            life.FaseOne();
            RefreshField();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            life.FaseTwo();
            RefreshField();
        }

        private void RefreshField()
        {
            for (int x = 0; x < w; x++)
                for (int y = 0; y < h; y++)
                    switch(life.ReadField(x,y))
                    {
                        case 0: lab[x, y].BackColor = col_empty; break;
                        case 1: lab[x, y].BackColor = col_live; break;
                        case 2: lab[x, y].BackColor = col_dead; break;
                        case -1: lab[x, y].BackColor = col_born; break;
                    }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            life.FaseOne();
            life.FaseTwo();
            RefreshField();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer.Enabled = !timer.Enabled;
            if (timer.Enabled)
            {
                button4.Text = "Timer is ON";
                button4.ForeColor = Color.Red;
            }
            else
            {
                button4.Text = "Timer is OFF";
                button4.ForeColor = Color.Black;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            InitLabels();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            life.FaseOne();
            life.FaseTwo();
            RefreshField();
        }

        private void AddLabel(int x, int y)
        {
            lab[x, y] = new Label();
            lab[x, y].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lab[x, y].Location = new System.Drawing.Point(x*box_w, y*box_h);
            lab[x, y].Size = new System.Drawing.Size(box_w + 1, box_h + 1);
            lab[x, y].Parent = panel1;
            lab[x, y].MouseClick += new System.Windows.Forms.MouseEventHandler(this.label1_MouseClick);

        }





    }
}
