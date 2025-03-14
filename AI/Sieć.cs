using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;

namespace Sieć
{
    class Sieć
    {
        // Pola -----------------------------------------------------------------------------------------------

        public static BPNN[] sieci;
        public static int konfiguracja = 0; // 0 - 10 sieci, 1 - 1 siec
        public static int LICZBA_PRZEDZIAŁÓW = 8;
        public static int LICZBA_CECH = LICZBA_PRZEDZIAŁÓW;

        private static double[][][] tablicaCech;
        private static int ilośćPlików;
        
        // Metody publiczne -----------------------------------------------------------------------------------

        public static void utwórzSiec(int przedziały, int neurony)
        {
            // 10 sieci do rozpoznania osobno cyfr
            if (konfiguracja == 1)
            {
                sieci = new BPNN[1];
                sieci[0] = new BPNN(przedziały, neurony, 10);
            }
            // 1 sieć do rozpoznania wszystkich cyfr
            else
            {
                sieci = new BPNN[10];
                for (int i = 0; i < 10; i++)
                {
                    sieci[i] = new BPNN(przedziały, neurony, 1);
                }
            }
        }

        public static string nauka(string katalog, int iteracje, double wspolczynnikUczenia, double momentum, int sieć)
        {
            Random rand = new Random();
            int plik;
            double[] oczekiwanaOdpSieci;
            double bladSieci = 0.0;

            // Alokacja pamięcia dla tablicy cech
            String filtr = "*_" + 0 + ".wav";  
            DirectoryInfo dirInfo = new DirectoryInfo(katalog);
            FileInfo[] pliki = dirInfo.GetFiles(filtr.ToString());
            ilośćPlików = pliki.Length;

            tablicaCech = new double[10][][];
            for (int p = 0; p < 10; p++)
            {
                tablicaCech[p] = new double[ilośćPlików][];
                for (int w = 0; w < ilośćPlików; w++)
                    tablicaCech[p][w] = new double[LICZBA_CECH];
            }

            // Wypełniamy tablicę cech na podstawie wszystkich plików w katalogu
            // c - cyfra
            // p - pliki
            // w - wektor
            for (int c = 0; c < 10; c++)
            {
                filtr = "*_" + c + ".wav";
                dirInfo = new DirectoryInfo(katalog);
                pliki = dirInfo.GetFiles(filtr.ToString());

                for (int p = 0; p < ilośćPlików; p++)
                {
                    String ścieżka = katalog + "/" + pliki[p].Name;

                    uint ilośćPróbek = 1;
                    int[] probki = parsowanieWave(ścieżka, ref ilośćPróbek);
                    double[] przejscia = oblicz(ref probki, ilośćPróbek);

                    //przepisanie gęstości przejść przez zero do dwuwymiarowej tablicy
                    for (int w = 0; w < LICZBA_CECH; w++)
                        tablicaCech[c][p][w] = przejscia[w];
                }
            }

            // Nauka sieci
            if (Sieć.konfiguracja == 0)
            {
                oczekiwanaOdpSieci = new double[1];
                int wylosowanaCyfra;

                for (int i = 0; i < iteracje; i++)
                {
                    // Losowanie, wektor cech pliku
                    plik = rand.Next() % ilośćPlików;

                    // Uczenie sieci dobrymi próbkami
                    if (i % 2 == 0) 
                    {
                        oczekiwanaOdpSieci[0] = 1.0;
                        bladSieci = Sieć.sieci[sieć].trainNetwork(tablicaCech[sieć][plik], oczekiwanaOdpSieci, wspolczynnikUczenia, momentum);
                    }
                    // Uczenie sieci innymi próbkami
                    else
                    {
                        // Losowanie odbywa się, dopóki nie zostanie wylosowana inna cyfra
                        while ((wylosowanaCyfra = rand.Next() % 10) == sieć) ;
                        oczekiwanaOdpSieci[0] = 0.0;
                        bladSieci = Sieć.sieci[sieć].trainNetwork(tablicaCech[wylosowanaCyfra][plik], oczekiwanaOdpSieci, wspolczynnikUczenia, momentum);
                    }

                    Program.getForm1().getProgressBar().Increment(1);
                }
            }
            else
            {
                oczekiwanaOdpSieci = new double[10];

                for (int i = 0; i < iteracje; i++)
                {
                    sieć = rand.Next() % 10;
                    for (int k = 0; k < 10; k++)
                    {
                        oczekiwanaOdpSieci[k] = 0.0;
                    }
                    oczekiwanaOdpSieci[sieć] = 1.0;

                    plik = rand.Next() % ilośćPlików;

                    bladSieci = Sieć.sieci[0].trainNetwork(tablicaCech[sieć][plik], oczekiwanaOdpSieci, wspolczynnikUczenia, momentum);
                    Program.getForm1().getProgressBar().Increment(1);
                }
            }

            // Obliczanie błędu sieci
            bladSieci /= iteracje;
            String bład;
            if (Sieć.konfiguracja == 0)
            {
                bład = "blad dla sieci " + sieć + " wynosi  " + bladSieci + "\n";
            }
            else
            {
                bład = "blad sieci wynosi  " + bladSieci + "\n";
            }

            return bład;
        }

        public static void rozpoznaj(string file)
        {
            // Odczytywanie pliku
            String[] cyfraPlik = file.Split('_');
            uint iloscProbek = 1;
            int cyfra = -1;
            double _max = -1.0;
            double[] wynik = new double[10];
            int[] probki = parsowanieWave(file, ref iloscProbek);
            double[] przejscia = oblicz(ref probki, iloscProbek);

            // Pobieranie odpowiedzi sieci na zadanych wektor cech
            if (Sieć.konfiguracja == 0)
            {
                for (int i = 0; i < 10; i++)
                {
                    wynik[i] = Sieć.sieci[i].Response(przejscia);
                }
            }
            else
            {
                wynik = Sieć.sieci[0].ResponseTab(przejscia);
            }

            // Sprawdzenie, dla której cyfry odpowiedź jest największa
            for (int i = 0; i < 10; i++)
            {
                if (wynik[i] > _max)
                {
                    _max = wynik[i];
                    cyfra = i;
                }
            }

            #region Ustawienie kolorów

            Program.getForm1().getTextBox0().ForeColor = Color.Black;
            Program.getForm1().getTextBox1().ForeColor = Color.Black;
            Program.getForm1().getTextBox2().ForeColor = Color.Black;
            Program.getForm1().getTextBox3().ForeColor = Color.Black;
            Program.getForm1().getTextBox4().ForeColor = Color.Black;
            Program.getForm1().getTextBox5().ForeColor = Color.Black;
            Program.getForm1().getTextBox6().ForeColor = Color.Black;
            Program.getForm1().getTextBox7().ForeColor = Color.Black;
            Program.getForm1().getTextBox8().ForeColor = Color.Black;
            Program.getForm1().getTextBox9().ForeColor = Color.Black;
            if (cyfraPlik[4].Equals("0.wav"))
            {
                Program.getForm1().getTextBox0().ForeColor = Color.Red;
            }
            if (cyfraPlik[4].Equals("1.wav"))
            {
                Program.getForm1().getTextBox1().ForeColor = Color.Red;
            }
            if (cyfraPlik[4].Equals("2.wav"))
            {
                Program.getForm1().getTextBox2().ForeColor = Color.Red;
            }
            if (cyfraPlik[4].Equals("3.wav"))
            {
                Program.getForm1().getTextBox3().ForeColor = Color.Red;
            }
            if (cyfraPlik[4].Equals("4.wav"))
            {
                Program.getForm1().getTextBox4().ForeColor = Color.Red;
            }
            if (cyfraPlik[4].Equals("5.wav"))
            {
                Program.getForm1().getTextBox5().ForeColor = Color.Red;
            }
            if (cyfraPlik[4].Equals("6.wav"))
            {
                Program.getForm1().getTextBox6().ForeColor = Color.Red;
            }
            if (cyfraPlik[4].Equals("7.wav"))
            {
                Program.getForm1().getTextBox7().ForeColor = Color.Red;
            }
            if (cyfraPlik[4].Equals("8.wav"))
            {
                Program.getForm1().getTextBox8().ForeColor = Color.Red;
            }
            if (cyfraPlik[4].Equals("9.wav"))
            {
                Program.getForm1().getTextBox9().ForeColor = Color.Red;
            }
            if (cyfra == 0)
            {
                Program.getForm1().getTextBox0().ForeColor = Color.Green;
            }
            if (cyfra == 1)
            {
                Program.getForm1().getTextBox1().ForeColor = Color.Green;
            }
            if (cyfra == 2)
            {
                Program.getForm1().getTextBox2().ForeColor = Color.Green;
            }
            if (cyfra == 3)
            {
                Program.getForm1().getTextBox3().ForeColor = Color.Green;
            }
            if (cyfra == 4)
            {
                Program.getForm1().getTextBox4().ForeColor = Color.Green;
            }
            if (cyfra == 5)
            {
                Program.getForm1().getTextBox5().ForeColor = Color.Green;
            }
            if (cyfra == 6)
            {
                Program.getForm1().getTextBox6().ForeColor = Color.Green;
            }
            if (cyfra == 7)
            {
                Program.getForm1().getTextBox7().ForeColor = Color.Green;
            }
            if (cyfra == 8)
            {
                Program.getForm1().getTextBox8().ForeColor = Color.Green;
            }
            if (cyfra == 9)
            {
                Program.getForm1().getTextBox9().ForeColor = Color.Green;
            }

            #endregion

            Program.getForm1().getTextBox0().Text = Math.Round(wynik[0], 4).ToString();
            Program.getForm1().getTextBox1().Text = Math.Round(wynik[1], 4).ToString();
            Program.getForm1().getTextBox2().Text = Math.Round(wynik[2], 4).ToString();
            Program.getForm1().getTextBox3().Text = Math.Round(wynik[3], 4).ToString();
            Program.getForm1().getTextBox4().Text = Math.Round(wynik[4], 4).ToString();
            Program.getForm1().getTextBox5().Text = Math.Round(wynik[5], 4).ToString();
            Program.getForm1().getTextBox6().Text = Math.Round(wynik[6], 4).ToString();
            Program.getForm1().getTextBox7().Text = Math.Round(wynik[7], 4).ToString();
            Program.getForm1().getTextBox8().Text = Math.Round(wynik[8], 4).ToString();
            Program.getForm1().getTextBox9().Text = Math.Round(wynik[9], 4).ToString();
            Program.getForm1().getLabelNumber().Text = cyfra.ToString();
        }

        // Metody prywatne ------------------------------------------------------------------------------------

        private static int[] parsowanieWave(string file, ref uint nSamples)
        {
            // Buffor na dane
            byte[] buf = new byte[4];

            FileStream fStream = new FileStream(file, FileMode.Open, FileAccess.Read);
            BinaryReader binRead = new BinaryReader(fStream);

            #region plik WAVE

            // RIFF
            binRead.Read(buf, 0, 4);
            // Rozmiar danych
            binRead.ReadUInt32();
            // plik WAVE
            binRead.Read(buf, 0, 4);
            // format
            binRead.Read(buf, 0, 4);
            // rozmiar części opisującej format
            binRead.Read(buf, 0, 4);
            // wFormatTag
            short wFormatTag = binRead.ReadInt16();
            // nChannels
            short numberOfChannels = binRead.ReadInt16();
            // nSamplesPerSec
            int sampleRate = binRead.ReadInt32();
            // nAvgBytesPerSec
            int bytesPerSecond = binRead.ReadInt32();
            // nBlockAlign
            short blockAlign = binRead.ReadInt16();
            // wBitsPerSample
            short bitsPerSample = binRead.ReadInt16();
            if (bitsPerSample != 16)
            {
                System.Console.WriteLine("Liczba bitów na próbkę musi wynosić 16!");
                return new int[1] { 0 };
            }
            // Data
            binRead.Read(buf, 0, 4);
            // Rozmiar danych dźwiękowych
            uint dataSize = binRead.ReadUInt32();
            // Dzielenie ze względu na stereo
            nSamples = Convert.ToUInt32(dataSize / 2);
            int[] samples = new int[nSamples];

            // Odczytywanie każdej próbki i zapisywanie do tablicy
            for (uint j = 0; j < nSamples; j++)
                samples[j] = binRead.ReadInt16();

            #endregion

            binRead.Close();
            fStream.Close();

            return samples;
        }

        private static double[] oblicz(ref int[] probki, uint iloscProbek)
        {
            double[] temp = new double[LICZBA_CECH];

            // Obliczenie wartości średniej i obniżanie próbek o składową stałą
            long średniaLong = 0;
            for (uint j = 0; j < iloscProbek; j++)
                średniaLong += probki[j];
            średniaLong /= iloscProbek;
            int średniaInt = Convert.ToInt32(średniaLong);
            for (uint j = 0; j < iloscProbek; j++)
                probki[j] -= średniaInt;

            // Obliczanie progu alfa (10% wartości sumy próbek), suma nie może być ujemna
            int suma = 0;
            for (uint j = 0; j < iloscProbek; j++)
                suma += probki[j];
            int alfa = Convert.ToInt32(Math.Abs(0.1 * suma));

            // Ilość próbek przypadających na przedział
            double probekNaPrzedzial = iloscProbek / LICZBA_PRZEDZIAŁÓW;
            int próbka = probki[0];
            if (próbka == 0)
                próbka = 1;
            for (int m = 0; m < LICZBA_PRZEDZIAŁÓW; m++)
            {
                // Numer próbki
                uint numer;
                // Maksymalna ilośc próbek w przedziale
                uint Max = Convert.ToUInt32((m + 1) * probekNaPrzedzial);
                // Liczba przejść do obliczenia gęstości
                int liczba = 0;

                // Zliczanie przejść przez zero
                for (numer = Convert.ToUInt32((m * probekNaPrzedzial)); numer < Max; numer++)
                {
                    if (Math.Abs(probki[numer]) > alfa)
                    {
                        if (próbka * probki[numer] < 0)
                        {
                            próbka = probki[numer];
                            liczba++;
                        }
                    }
                }

                // Zwracanie wektora cech
                temp[m] = Convert.ToDouble(liczba) / probekNaPrzedzial;
            }

            // Normalizowanie wektora cech
            double mnoznik = 1.0;
            double max = 0.0;
            for (int i = 0; i < LICZBA_CECH; i++)
            {
                if (temp[i] > max)
                    max = temp[i];
            }
            mnoznik = mnoznik / max;
            for (int i = 0; i < LICZBA_CECH; i++)
                temp[i] *= mnoznik;
            return temp;
        }
    }
}
