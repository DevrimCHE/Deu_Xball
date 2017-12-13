using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEUProje
{
    public partial class Form1 : Form
    {
        Form2 OyunEkranı = new Form2();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            OyunEkranı.TSatır = hScrollBar1.Value;
            OyunEkranı.TSutun = hScrollBar2.Value;
            OyunEkranı.KalanHak = hScrollBar3.Value;
            OyunEkranı.Hız = hScrollBar4.Value;
            OyunEkranı.Width = OyunEkranı.TSutun*OyunEkranı.TuglaW + (10 * OyunEkranı.TSutun)+10;
            OyunEkranı.ShowDialog();
            OyunEkranı = new Form2();
        }

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = "Satır Sayısı = " + hScrollBar1.Value;
            OyunEkranı.TSatır = hScrollBar1.Value;
        }

        private void hScrollBar2_ValueChanged(object sender, EventArgs e)
        {
            label2.Text = "Sütun Sayısı = " + hScrollBar2.Value;
            OyunEkranı.TSutun = hScrollBar2.Value;
        }

        private void hScrollBar3_ValueChanged(object sender, EventArgs e)
        {
            label3.Text = "Hak Sayısı = " + hScrollBar3.Value;
            OyunEkranı.KalanHak = hScrollBar3.Value;
        }

        private void hScrollBar4_Scroll(object sender, ScrollEventArgs e)
        {
            label4.Text = "Hız = " + hScrollBar4.Value;
            OyunEkranı.Hız = hScrollBar4.Value;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                OyunEkranı.TuglaRenk = dlg.Color;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                OyunEkranı.CubukRenk = dlg.Color;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                OyunEkranı.BackColor = dlg.Color;
            }
        }
    }
}
