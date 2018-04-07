using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeGameUi
{
    public partial class PlanszaPanel : UserControl
    {
        public Plansza Plansza { get; set; }
        public Pen Pen { get; set; }

        public PlanszaPanel()
        {
            InitializeComponent();

            Pen = new Pen(Color.Blue, 2);
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (Plansza != null)
            {
                for (int y = 0; y < Plansza.Dlugosc; y++)
                {
                    for (int x = 0; x < Plansza.Szerokosc; x++)
                    {
                        if (Plansza.CzyZyje(x, y))
                        {
                            rysujKomorke(e.Graphics, x, y);
                        }
                    }
                }
            }
        }

        private void rysujKomorke(Graphics graphics, int x, int y)
        {
            graphics.DrawEllipse(Pen, wspolrzedneEkranowe(x, y));
        }

        private Rectangle wspolrzedneEkranowe(int x, int y)
        {
            return new Rectangle(
                1 + 12 * x,
                1 + 12 * y,
                11, 11);
        }

        public Tuple<int, int> MaxWymairPlanszy()
        {
            int x = (Width - 1) / 12;
            int y = (Height - 1) / 12;

            return new Tuple<int, int>(x, y);
        }
    }
}
