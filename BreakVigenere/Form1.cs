using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace BreakVigenere
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
        static bool kontrolloQelesin;
        static bool KontrolloQelesin(String qelesi)
        {
            kontrolloQelesin = Regex.IsMatch(qelesi, @"^[a-zA-Z]+$");
            return kontrolloQelesin;
        }
        private int alfabeti = 26;
        private string Qelesi;
        private void btnDekripto_Click(object sender, EventArgs e)
        {
            Qelesi = txtcelesi.Text.Trim().ToUpper();

            if (txtcelesi.Text.Trim() != "")
            {
                if (KontrolloQelesin(Qelesi))
                {
                    Form1 f1 = new Form1();

                    StringBuilder Plain = new StringBuilder(txtCipher.Text.ToString());

                    for (int i = 0, j = 0; i < txtCipher.Text.Length; i++)
                    {
                        if (txtCipher.Text[i] != ' ' && txtCipher.Text[i] >= 'A' && txtCipher.Text[i] <= 'Z')
                        {
                            Plain[i] = (char)((txtCipher.Text[i] - Qelesi[j] + alfabeti) % alfabeti + 'A');
                            j = ++j % Qelesi.Length;
                        }
                        else if (txtCipher.Text[i] != ' ' && txtCipher.Text[i] >= 'a' && txtCipher.Text[i] <= 'z')
                        {
                            Plain[i] = (char)((txtCipher.Text[i] - (Qelesi[j] + ('a' - 'A')) + alfabeti) % alfabeti + 'a');
                            j = ++j % Qelesi.Length;
                        }
                        else
                        {
                            Plain[i] = txtCipher.Text[i];
                        }
                    }
                    txtPlain.Text = Plain.ToString();

                }
                else
                {
                    MessageBox.Show("Jane te lejuara vetem shkronjat A-Z dhe a-z", "Gabim ne qeles");
                    txtcelesi.Focus();
                }
            }
            else
            {
                MessageBox.Show("Ju lutem mbusheni fushen e qelesit", "Gabim ne qeles");
                txtcelesi.Focus();
            }
        }
        static List<string> NdajeTekstinMeGjatesiTeQelesit(string teksti, int gjatesiaQelesit)
        {
            List<string> rezultati = new List<string>();
            StringBuilder[] sb = new StringBuilder[gjatesiaQelesit];

            for (int i = 0; i < gjatesiaQelesit; i++)
            {
                sb[i] = new StringBuilder();
            }

            for (int i = 0; i < teksti.Length; i++)
            {
                sb[i % gjatesiaQelesit].Append(teksti[i]);
            }

            foreach (var item in sb)
            {
                rezultati.Add(item.ToString());
            }

            return rezultati;
        }
        static Dictionary<char, double> AnalizoFrekuencen(string teksti)
		{
			if (teksti == null)
			{
				return null;
			}
			Dictionary<char, double> Frekuenca_e_Paraqitjes = new Dictionary<char, double>();
			int gjatesiaTekstit = teksti.Length;

			for (int i = 0; i < gjatesiaTekstit; i++)
			{
				char c = teksti[i];
				char qelesi = '#';

				if ((c >= 'a' && c <= 'z'))
				{
					qelesi = c;
				}

				if (c >= 'A' && c <= 'Z')
				{
					qelesi = (char)(c + 'a' - 'A');
				}

				if (Frekuenca_e_Paraqitjes.Keys.Contains(qelesi))
				{
					Frekuenca_e_Paraqitjes[qelesi] = Frekuenca_e_Paraqitjes[qelesi] + 1;
				}
				else
				{
					Frekuenca_e_Paraqitjes[qelesi] = 1;
				}
			}

			List<char> qelesit = Frekuenca_e_Paraqitjes.Keys.ToList();

			foreach (char c in qelesit)
			{
				Frekuenca_e_Paraqitjes[c] /= gjatesiaTekstit;
			}

			return Frekuenca_e_Paraqitjes;
		}
		public string GjejQelesin(int gjatesia_qelesit)
		{
			string VigenereCryptogram;

			VigenereCryptogram = txtCipher.Text;
			VigenereCryptogram = VigenereCryptogram.Replace(" ", "");

			int qelsi_gjatesia = gjatesia_qelesit;
			Dictionary<char, double> Frekuenca_e_Paraqitjes;
			List<char> QelesiChars = new List<char>();

			VigenereCryptogram.Replace(" ", "").Replace("\n", "").Replace("\r", "");

			List<string> TekstiZevendesues = NdajeTekstinMeGjatesiTeQelesit(VigenereCryptogram, qelsi_gjatesia);

			foreach (string ceasarCryptogram in TekstiZevendesues)
			{
				Frekuenca_e_Paraqitjes = AnalizoFrekuencen(ceasarCryptogram);

				double FrekuencaMaksimale = Frekuenca_e_Paraqitjes.Values.Max();

				char MaksimumChar = Frekuenca_e_Paraqitjes.Keys.Where(c => Frekuenca_e_Paraqitjes[c] == FrekuencaMaksimale).FirstOrDefault();
				char celesi1;
				celesi1 = (char)(MaksimumChar - 'e' + 'A');
				if ((int)celesi1 >= 64 && (int)celesi1 <= 90)
				{ QelesiChars.Add(celesi1); }
				else if ((int)celesi1 <= 64)
				{
					QelesiChars.Add((char)(celesi1 + 26));
				}


			}

			string VigenereQelesi = "";

			foreach (char c in QelesiChars)
			{
				VigenereQelesi += c;
			}

			return VigenereQelesi;
		}

		private void btnCeles_Click(object sender, EventArgs e)
		{
			string TekstiPaZbraztira;
			TekstiPaZbraztira = txtCipher.Text;
			TekstiPaZbraztira = TekstiPaZbraztira.Replace(" ", "");

			var array1 = TekstiPaZbraztira.ToArray();

			int[] NumratCelesa = new int[0];
			int[] NumratPerseritur = new int[0];

			int gjatesia = array1.Length;

			for (int i = 0; i < (gjatesia - 2); i++)
			{
				for (int j = i; j < (gjatesia - 2); j++)
				{

					if ((array1[i] == array1[j]) && (array1[i + 1] == array1[j + 1]) && (array1[i + 2] == array1[j + 2]))
					{
						Array.Resize(ref NumratCelesa, NumratCelesa.Length + 1);
						NumratCelesa[NumratCelesa.Length - 1] = j - i;
					}
				}
			}

			int Gjatesia = NumratCelesa.Length;

			for (int i = 0; i < Gjatesia; i++)
			{
				for (int j = 2; j < (int)((NumratCelesa[i] / 2) + 1); j++)
				{
					if (NumratCelesa[i] % j == 0)
					{
						Array.Resize(ref NumratPerseritur, NumratPerseritur.Length + 1);
						NumratPerseritur[NumratPerseritur.Length - 1] = j;
					}
				}
			}
		}
}
