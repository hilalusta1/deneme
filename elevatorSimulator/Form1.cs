using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elevatorSimulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kabin.Location = new Point(kat1kapi.Location.X - 45, 450);
            acikkapi.Location = new Point(kat1kapi.Location.X, kat1kapi.Location.Y);
            acikkapi.Visible = true;
        }
        private void ikincikatcagirma_Click(object sender, EventArgs e)
        {
            acikkapi.Visible = false;
            kabin.Location = new Point(kat2kapi.Location.X - 45, 400);
            acikkapi.Location = new Point(kat2kapi.Location.X, kat2kapi.Location.Y);
            acikkapi.Visible = true;
        }

        private void ücüncükatcagirma_Click(object sender, EventArgs e)
        {
            acikkapi.Visible = false;
            kabin.Location = new Point(solkapikat3.Location.X - 45, 350);
            acikkapi.Location = new Point(solkapikat3.Location.X, solkapikat3.Location.Y);
            acikkapi.Visible = true;
        }

        private void dördüncükatcagirma_Click(object sender, EventArgs e)
        {
            acikkapi.Visible = false;
            kabin.Location = new Point(solkapikat4.Location.X - 45, 300);
            acikkapi.Location = new Point(solkapikat4.Location.X, solkapikat4.Location.Y);
            acikkapi.Visible = true;
        }

        private void besincikatcagirma_Click(object sender, EventArgs e)
        {
            acikkapi.Visible = false;
            kabin.Location = new Point(solkapikat5.Location.X - 45, 250);
            acikkapi.Location = new Point(solkapikat5.Location.X, solkapikat5.Location.Y);
            acikkapi.Visible = true;
        }

        private void altincikatcagirma_Click(object sender, EventArgs e)
        {
            acikkapi.Visible = false;
            kabin.Location = new Point(solkapikat6.Location.X - 45, 200);
            acikkapi.Location = new Point(solkapikat6.Location.X, solkapikat6.Location.Y);
            acikkapi.Visible = true;
        }

        private void yedincikatcagirma_Click(object sender, EventArgs e)
        {
            acikkapi.Visible = false;
            kabin.Location = new Point(solkapikat7.Location.X - 45, 150);
            acikkapi.Location = new Point(solkapikat7.Location.X, solkapikat7.Location.Y);
            acikkapi.Visible = true;
        }

        private void sekizincikatcagirma_Click(object sender, EventArgs e)
        {
            acikkapi.Visible = false;
            kabin.Location = new Point(solkapikat8.Location.X - 45, 100);
            acikkapi.Location = new Point(solkapikat8.Location.X, solkapikat8.Location.Y);
            acikkapi.Visible = true;
        }

        private void dokuzuncukatcagirma_Click(object sender, EventArgs e)
        {
            acikkapi.Visible = false;
            kabin.Location = new Point(solkapikat9.Location.X - 45, 50);
            acikkapi.Location = new Point(solkapikat9.Location.X, solkapikat9.Location.Y);
            acikkapi.Visible = true;
        }

        private void onuncukatcagirma_Click(object sender, EventArgs e)
        {
            acikkapi.Visible = false;
            kabin.Location = new Point(solkapikat10.Location.X - 45, 0);
            acikkapi.Location = new Point(solkapikat10.Location.X, solkapikat10.Location.Y);
            acikkapi.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
}
