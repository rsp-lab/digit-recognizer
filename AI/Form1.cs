using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Sieć
{
    public partial class Form1 : Form
    {
        // Metody publiczne ---------------------------------------------------------------------------------

        public Form1()
        {
            InitializeComponent();
        }

        public ProgressBar getProgressBar()
        {
            return progressBar;
        }

        public TextBox getTextBox0()
        {
            return textBox0;
        }

        public TextBox getTextBox1()
        {
            return textBox1;
        }

        public TextBox getTextBox2()
        {
            return textBox2;
        }

        public TextBox getTextBox3()
        {
            return textBox3;
        }

        public TextBox getTextBox4()
        {
            return textBox4;
        }

        public TextBox getTextBox5()
        {
            return textBox5;
        }

        public TextBox getTextBox6()
        {
            return textBox6;
        }

        public TextBox getTextBox7()
        {
            return textBox7;
        }

        public TextBox getTextBox8()
        {
            return textBox8;
        }

        public TextBox getTextBox9()
        {
            return textBox9;
        }

        public Label getLabelNumber()
        {
            return labelNumber;
        }

        // Zdarzenia ----------------------------------------------------------------------------------------

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialogWAV.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxLoadFile.Text = openFileDialogWAV.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBox.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void buttonConfig0_Click(object sender, EventArgs e)
        {
            // Konifguracja 0, oznacza 10 sieci osobno dla każdej cyfry
            Sieć.konfiguracja = 0;
            labelConfigShow.Text = "10 sieci z 1 wyjściem";
        }

        private void buttonConfig1_Click(object sender, EventArgs e)
        {
            // Konifguracja 1, oznacza 1 sieć dla wszystkich cyfr
            Sieć.konfiguracja = 1;
            labelConfigShow.Text = "1 sieć z 10 wyjściami";
        }

        private void buttonRecognize_Click(object sender, EventArgs e)
        {
            // Poszukiwanie błędu
            if (textBoxLoadFile.Text.Equals(""))
            {
                MessageBox.Show(this, "Wprowadź ścieżkę do pliku!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Rozpoznawanie próbek
            Sieć.rozpoznaj(textBoxLoadFile.Text);
            labelRecognition.Visible = true;
            labelNumber.Visible = true;
        }

        private void buttonLearnAll_Click(object sender, EventArgs e)
        {
            // Poszukiwanie błędu
            String błąd = "";
            if (textBox.Text.Equals(""))
            {
                błąd += "Musisz wybrać katalog, w którym znajdują się próbko do nauki!\n";
            }
            if (textBoxLearnRate.Text.Equals(""))
            {
                błąd += "Musisz ustawić współczynnik uczenia sieci!\n";
            }
            if (textBoxMomentum.Text.Equals(""))
            {
                błąd += "Musisz ustawić pęd (momentum)!\n";
            }
            if (textBoxNeuron.Text.Equals(""))
            {
                błąd += "Musisz wybrać ilość neuronów, które znajdą się w warstwie ukrytej!\n";
            }
            if (!błąd.Equals(""))
            {
                MessageBox.Show(this, błąd, "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Pobieranie parametrów sieci z kontrolek
            int przedziały = int.Parse(numericUpDownLayerNumber.Value.ToString());
            int neurony = int.Parse(textBoxNeuron.Text);
            int iteracje = int.Parse(numericUpDownIterations.Value.ToString());
            double wsp = double.Parse(textBoxLearnRate.Text);
            double momentum = double.Parse(textBoxMomentum.Text);
            string katalog = textBox.Text;

            // Tworzenie sieci i jej trenowanie
            Sieć.LICZBA_PRZEDZIAŁÓW = przedziały;
            Sieć.LICZBA_CECH = przedziały;
            Sieć.utwórzSiec(Sieć.LICZBA_PRZEDZIAŁÓW, neurony);
            StringBuilder builder = new StringBuilder("");

            // konfiguracja = 0 oznacza 10 sieci
            if (Sieć.konfiguracja == 0)
            {
                progressBar.Minimum = 0;
                progressBar.Maximum = iteracje * 10;
                progressBar.Value = 0;
                for (int sieć = 0; sieć < 10; sieć++)
                {
                    builder.Append(Sieć.nauka(katalog, iteracje, wsp, momentum, sieć));
                }
            }
            else
            {
                progressBar.Minimum = 0;
                progressBar.Maximum = iteracje;
                progressBar.Value = 0;
                builder.Append(Sieć.nauka(katalog, iteracje, wsp, momentum, -1));
            }
            labelNorth.Text = "Sieć została nauczona";
            MessageBox.Show(Program.getForm1(), "Sieć została nauczona\n\n" + builder.ToString(), "Koniec", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // MouseHover ---------------------------------------------------------------------------------------

        private void buttonLearn_MouseHover(object sender, EventArgs e)
        {
            labelNorth.Text = "Rozpocznij naukę sieci";
        }

        private void buttonRecognize_MouseHover(object sender, EventArgs e)
        {
            labelNorth.Text = "Rozpoznaj próbkę na podstawie pliku";
        }

        private void buttonLearnAll_MouseHover(object sender, EventArgs e)
        {
            labelNorth.Text = "Rozpocznij uczenie sieci";     
        }

        private void buttonConfig0_MouseHover(object sender, EventArgs e)
        {
            labelNorth.Text = "Osobna sieć do rozpoznania każdej cyfry"; 
        }

        private void buttonConfig1_MouseHover(object sender, EventArgs e)
        {
            labelNorth.Text = "Jedna sieć rozpoznaje wszystkie cyfry"; 
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            labelNorth.Text = "Wybierz próbkę do rozpoznania";
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            labelNorth.Text = "Wczytaj katalog z próbkami";
        }

        private void textBoxLoadFile_TextChanged(object sender, EventArgs e)
        {
            String[] _string = textBoxLoadFile.Text.Split('_');
            String temp = _string[4].Substring(0, 1);
            String cyfry = "0123456789";
            if (_string.Length >= 4)
            {
                if (cyfry.IndexOf(temp) != -1)
                {
                    buttonRecognize_Click(sender, e);
                }
            }
         }
    }
}
