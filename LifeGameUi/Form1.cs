using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeGameUi
{
    public partial class Form1 : Form
    {
        private Plansza plansza;
        private Sasiedzi sasiedzi;

        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (plansza == null)
            {
                var wymiary = planszaPanel1.MaxWymairPlanszy();
                plansza = new Plansza(wymiary.Item1, wymiary.Item2);
                sasiedzi = new Sasiedzi(plansza);
                int liczbaKomorek = int.Parse(liczbaKomorekTB.Text);
                plansza.Zaludnij(liczbaKomorek);
                planszaPanel1.Plansza = plansza; 
                planszaPanel1.Refresh();
            }

            timer1.Start();
        }

        private static Plansza Aktualizuj(Plansza plansza, Sasiedzi sasiedzi)
        {
            sasiedzi.Aktualizuj();

            for (int x = 0; x < plansza.Szerokosc; x++)
            {
                for (int y = 0; y < plansza.Dlugosc; y++)
                {
                    int liczbaSasiadow = sasiedzi.ZywiSasiedzi(x, y);
                    if (!plansza.CzyZyje(x, y))
                    {
                        if (liczbaSasiadow == 3)
                        {
                            plansza.Ozyj(x, y);
                        }
                    }
                    else
                    {
                        if (liczbaSasiadow == 2 || liczbaSasiadow == 3)
                        {
                            plansza.Ozyj(x, y);
                        }
                        else
                        {
                            plansza.Usmierc(x, y);
                        }
                    }
                }
            }

            return plansza;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Aktualizuj(plansza, sasiedzi);
            planszaPanel1.Refresh();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void wyczyscButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            planszaPanel1.Plansza = null;
            plansza = null;
            sasiedzi = null;
            planszaPanel1.Refresh();
        }
    }
}
