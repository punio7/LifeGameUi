﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeGameUi
{
    public class Plansza
    {
        public readonly int Szerokosc;
        public readonly int Dlugosc;

        private char[][] komorki;
        private const char MARTWA_KOMORKA = ' ';
        private const char ZYWA_KOMORKA = 'O';

        public Plansza(int szerokosc, int dlugosc)
        {
            Szerokosc = szerokosc;
            Dlugosc = dlugosc;
            komorki = new char[dlugosc][];
            for (int i = 0; i < dlugosc; i++)
            {
                komorki[i] = new char[szerokosc];
            }

            for (int x = 0; x < szerokosc; x++)
            {
                for (int y = 0; y < dlugosc; y++)
                {
                    komorki[y][x] = MARTWA_KOMORKA;
                }
            }
        }

        public void Zaludnij(int ileKomorek)
        {
            Random losowanie = new Random();
            for (int i = 0; i < ileKomorek; i++)
            {
                int x, y;
                while (true)
                {
                    x = losowanie.Next(0, Szerokosc);
                    y = losowanie.Next(0, Dlugosc);
                    if (!CzyZyje(x, y))
                    {
                        Ozyj(x, y);
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }

        public bool CzyZyje(int x, int y)
        {
            return Pobierz(x, y) == ZYWA_KOMORKA;
        }

        private bool czyJestPozaPlansza(int x, int y)
        {
            return x < 0 || x >= Szerokosc || y < 0 || y >= Dlugosc;
        }

        public char Pobierz(int x, int y)
        {
            if (czyJestPozaPlansza(x, y))
            {
                return MARTWA_KOMORKA;
            }
            return komorki[y][x];
        }

        public void Ozyj(int x, int y)
        {
            if (czyJestPozaPlansza(x, y))
            {
                return;
            }
            komorki[y][x] = ZYWA_KOMORKA;
        }

        public void Usmierc(int x, int y)
        {
            if (czyJestPozaPlansza(x, y))
            {
                return;
            }
            komorki[y][x] = MARTWA_KOMORKA;
        }
    }
}
