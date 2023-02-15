using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RVmIVn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (rdbRomanNumeral.Checked)
            {
                int decimalNumber;
                if (int.TryParse(txtInput.Text, out decimalNumber))
                {
                    string romanNumeral = ConvertToRomanNumeral(decimalNumber);
                    txtOutput.Text = romanNumeral;
                }
                else
                {
                    MessageBox.Show("Input Invalido. Tenta colocar um Número Decimal.", "Erro", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else if (rdbDecimal.Checked)
            {
                string romanNumeral = txtInput.Text.ToUpper();
                int decimalNumber = ConvertToDecimal(romanNumeral);
                if (decimalNumber != -1)
                {
                    txtOutput.Text = decimalNumber.ToString();
                }
                else
                {
                    MessageBox.Show("Input Invalido. Tenta colocar um Número Romano.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private static string ConvertToRomanNumeral(int decimalNumber)
        {
            StringBuilder romanNumeralBuilder = new StringBuilder();

            int[] values = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] numerals = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

            for (int i = 0; i < values.Length; i++)
            {
                while (decimalNumber >= values[i])
                {
                    decimalNumber -= values[i];
                    romanNumeralBuilder.Append(numerals[i]);
                }
            }

            return romanNumeralBuilder.ToString();
        }

        private static int ConvertToDecimal(string romanNumeral)
        {
            Dictionary<char, int> romanValues = new Dictionary<char, int>()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

            int result = 0;
            int prevValue = 0;

            foreach (char c in romanNumeral)
            {
                int currentValue;
                if (!romanValues.TryGetValue(c, out currentValue))
                {
                    return -1;
                }

                result += currentValue;

                if (prevValue < currentValue)
                {
                    result -= 2 * prevValue;
                }

                prevValue = currentValue;
            }

            return result;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
            txtOutput.Text = "";
        }

        

        private void rdbRomanNumeral_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbDecimal_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text == "")
            {
                MessageBox.Show("Para copiar o Output, é preciso haver Output." +
                    "\n\nPeço-te se não for muito maçante, escreve alguma coisa no Input.", "Sem Output", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Clipboard.SetText(txtOutput.Text);
                MessageBox.Show("Copiado com sucesso!", "Copiado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            txtInput.Text = Clipboard.GetText();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            string message = "Se for sobre alguns caracteres que levam acentuação, alguns caracteres não estão disponiveis devido de não haver uma tradução certa para o caracter." +
               "\n\nSe não for sobre isso, sê livre de ir ao meu Website para relatar sobre algum problema.";
            string ws = Environment.NewLine + "\nhttps://h3nr1qu3x.github.io/website/contact.html";
            MessageBox.Show(message + ws, "Ajuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
