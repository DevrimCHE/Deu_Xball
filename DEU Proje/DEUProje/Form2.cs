using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace DEUProje
{
    public partial class Form2 : Form
    {
        ArrayList TuglaVeri = new ArrayList();
        public Color TuglaRenk = Color.FromKnownColor(KnownColor.YellowGreen), CubukRenk = Color.FromKnownColor(KnownColor.DeepSkyBlue);
        int Xilerle, Yilerle;
        bool Kont = true;
        public int TuglaW = 80, TuglaH = 35, Puan = 0;
        public int TSatır, TSutun, KalanHak, Hız;
        int ToplamTug;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Cubuk.BackColor = CubukRenk;
            Pozisyon();
            Tuglalar();
            ToplamTug = TSatır * TSutun;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = "Kalan Hak Sayısı = " + KalanHak + " Puan = " + Puan;
            //Çubuk
            if(Top.Top+Top.Size.Height >= Cubuk.Top && Top.Left >= Cubuk.Left && Top.Left <= Cubuk.Left + Cubuk.Size.Width && Top.Top <= Cubuk.Top + Cubuk.Size.Height )
            {
                Xilerle *=-1;
            }
            //Üst
            if(Top.Top <= 0)
            {
                Xilerle *= -1;
            }
            //Sag
            if (Top.Left >= this.Size.Width - Top.Size.Width)
            {
                Yilerle *= -1;
            }
            //Sol
            if(Top.Left <= 0 )
            {
                Yilerle *= -1;
            }
            //Yanma(Alt)
            if(Top.Top >= this.Size.Height - Top.Size.Height)
            {
                Xilerle *= -1;
                Pozisyon();
                KalanHak--;
                Puan -= 100;
                if (KalanHak < 0)
                {
                    Xilerle = 0;
                    Yilerle = 0;
                    MessageBox.Show("Oyun Bitti Kaybettiniz", "Kalan Hak Sayısı = " + KalanHak + " Puan = " + Puan);
                    this.Dispose();
                }
            }
            
            //Tugla
            TuglaCarp();
            
            //İlerle
            Top.Top += Xilerle;
            Top.Left += Yilerle;
        }

        private void Pozisyon()
        {
            Cubuk.Left = (this.Width / 2) - (Cubuk.Size.Width / 2);
            Top.Left = Cubuk.Left + (Cubuk.Size.Width / 2);
            Top.Top = Cubuk.Top - 20;
            button1.Left = Cubuk.Left;
            button2.Left = Cubuk.Left + (Cubuk.Size.Width / 2) + Top.Size.Width;
        }

        private void TuglaCarp()
        {
            Rectangle TopKutusu = new Rectangle();
            Rectangle TuglaKutusu = new Rectangle();

            TopKutusu.X = Top.Left;
            TopKutusu.Y = Top.Top;
            TopKutusu.Width = Top.Size.Width;
            TopKutusu.Height = Top.Size.Height;
            for (int i = 0; i < TuglaVeri.Count; i++) 
            {
                Button tug = ((Button)TuglaVeri[i]);
                TuglaKutusu.X = tug.Left;
                TuglaKutusu.Y = tug.Top;
                TuglaKutusu.Width = tug.Width;
                TuglaKutusu.Height = tug.Height;
                
                // Kesişme Durumu
                if ( TuglaKutusu.IntersectsWith(TopKutusu))
                {
                    ToplamTug--;
                    TuglaVeri.RemoveAt(i);
                    Puan += 25;
                    tug.Dispose();
                    //Çarpma Açısı
                    if (Top.Top > tug.Top+1 && Top.Top < tug.Top+tug.Height-1)
                    {
                        Yilerle *= -1;
                    }
                    else if (Top.Left > tug.Left+1 && Top.Left < tug.Left+tug.Width-1)
                    {
                        Xilerle *=-1;
                    }
                    else
                    {
                        Xilerle *= -1;
                        Yilerle *= -1;
                    }

                    //Oyun Bitti
                    if (ToplamTug<=0)
                    {
                        Xilerle = 0;
                        Yilerle = 0;
                        MessageBox.Show("Oyun Bitti Kazandınız Toplam Puanınız = "+(KalanHak*125+Puan),"Kalan Hak Sayısı = " + KalanHak + " Puan = " + Puan);
                        this.Dispose();
                    }
                }
            }
        }

        private void Tuglalar()
        {
            for (int j = 0; j < TSutun; j++)
            {
                for (int i = 0; i < TSatır; i++)
                {
                    Button Hedef = new Button();
                    Hedef.Location = new Point(j * (TuglaW + 10), i * (TuglaH + 15));
                    Hedef.Size = new Size(TuglaW, TuglaH);
                    Hedef.BackColor = TuglaRenk;
                    Hedef.Enabled = false;
                    TuglaVeri.Add(Hedef);
                    this.Controls.Add(Hedef);
                }
            }
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (Kont == true)
            {
                if ((e.X - Cubuk.Size.Width / 2) > 0 && e.X < this.Size.Width - (Cubuk.Size.Width/2))
                {
                    Cubuk.Left = e.X - (Cubuk.Size.Width / 2);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Xilerle = Hız *-1;
            Yilerle = Hız * -1;
            button1.Visible = false;
            button2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Xilerle = Hız * -1;
            Yilerle = Hız;
            button1.Visible = false;
            button2.Visible = false;
        }

        private void Form2_Deactivate(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Form2_Activated(object sender, EventArgs e)
        {
            timer2.Enabled = false;
        }

    }
}
