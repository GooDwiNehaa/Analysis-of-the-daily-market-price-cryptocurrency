using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Анализ_ежедневной_рыночной_цены_криптовалюты
{
    public partial class Form1 : Form
    {
        Work work;
        public static object SelectedCryptocurrency { get; set; }
        public Form1()
        {
            InitializeComponent();
            work = new Work(DGV);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Csv files (*.csv)|*.csv";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Work.FileData = File.ReadAllLines(openFileDialog1.FileName, Encoding.UTF8);
                openFileDialog1.Dispose();
            }
            else
            {
                MessageBox.Show("Выберите файл и нажмите ОК");
                openFileDialog1.Dispose();
            }

            work.ReadingData();

            if (Work.NameCryptocurrency != null)
            {
                CryptoCombo.Items.Clear();
                CryptoCombo.Items.Add("");

                for (int i = 0; i < Work.NameCryptocurrency.Count; i++)
                {
                    CryptoCombo.Items.Add(Work.NameCryptocurrency[i]);
                }
            }
            else
            {
                MessageBox.Show("Файл невыбран!");
            }

            if (Work.ParamCryptocurrency != null)
            {
                CryptocurrencyParametersCombo.Items.Clear();
                CryptocurrencyParametersCombo.Items.Add("");

                for (int i = 0; i < Work.ParamCryptocurrency.Count; i++)
                {
                    CryptocurrencyParametersCombo.Items.Add(Work.ParamCryptocurrency[i]);
                }
            }
            else
            {
                MessageBox.Show("Файл невыбран!");
            }
        }

        private void CryptoCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            work.DataFiltering(CryptoCombo.SelectedItem.ToString());

            ComboYear1.Items.Clear();
            ComboYear1.Items.Add("");
            ComboYear2.Items.Clear();
            ComboYear2.Items.Add("");

            if (Work.YearCryptocurrency != null)
            {
                foreach (var item in Work.YearCryptocurrency.Distinct())
                {
                    ComboYear1.Items.Add(Convert.ToInt32(item));
                    ComboYear2.Items.Add(Convert.ToInt32(item));
                }
            }
        }

        private void Look_Click(object sender, EventArgs e)
        {
            if (CryptoCombo.SelectedItem == null || GraphicCombo.SelectedItem == null)
            {
                MessageBox.Show("Прежде чем построить график, загрузите файл(если он еще не загружен), выберите криптовалюту и тип графика!");
            }
            else
            {
                work.BuildAGraph(Chart1, CryptoCombo.SelectedItem.ToString(), GraphicCombo.SelectedItem.ToString(), GraphicCombo.SelectedIndex);
            }
        }

        private void Computation_Click(object sender, EventArgs e)
        {
            if (CryptocurrencyParametersCombo.SelectedItem != null && CryptoCombo.SelectedItem != null && FunctionsCombo.SelectedIndex != -1)
            {
                if (ComboYear1.SelectedItem != null && ComboYear2.SelectedItem != null)
                {
                    if (ComboYear1.SelectedItem.ToString() != "" && ComboYear2.SelectedItem.ToString() != "")
                    {
                        ForComputation(Convert.ToInt32(ComboYear1.SelectedItem), Convert.ToInt32(ComboYear2.SelectedItem));
                    }
                    else if (ComboYear1.SelectedItem.ToString() != "" && ComboYear2.SelectedItem.ToString() == "")
                    {
                        ForComputation(Convert.ToInt32(ComboYear1.SelectedItem), 0);
                    }
                    else if (ComboYear1.SelectedItem.ToString() == "" && ComboYear2.SelectedItem.ToString() != "")
                    {
                        ForComputation(0, Convert.ToInt32(ComboYear2.SelectedItem));
                    }
                    else if (ComboYear1.SelectedItem.ToString() == "" && ComboYear2.SelectedItem.ToString() == "")
                    {
                        ForComputation(0, 0);
                    }
                }
                else if (ComboYear1.SelectedItem != null && ComboYear2.SelectedItem == null)
                {
                    if (ComboYear1.SelectedItem.ToString() == "")
                    {
                        ForComputation(0, 0);
                    }
                    else
                    {
                        ForComputation(Convert.ToInt32(ComboYear1.SelectedItem), 0);

                    }
                }
                else if (ComboYear1.SelectedItem == null && ComboYear2.SelectedItem != null)
                {
                    if (ComboYear2.SelectedItem.ToString() == "")
                    {
                        ForComputation(0, 0);
                    }
                    else
                    {
                        ForComputation(0, Convert.ToInt32(ComboYear2.SelectedItem));
                    }

                }
                else if (ComboYear1.SelectedItem == null && ComboYear2.SelectedItem == null)
                {
                    ForComputation(0, 0);
                }
                else
                {
                    MessageBox.Show("Выберите диапазон дат!");
                }
            }
            else
            {
                MessageBox.Show("Выберите параметр, функцию и криптовалюту!");
            }
        }

        private void ForComputation(int year1, int year2)
        {
            string value = work.Calculate(
                    CryptocurrencyParametersCombo.SelectedItem.ToString(),
                    CryptoCombo.SelectedItem.ToString(),
                    FunctionsCombo.SelectedIndex,
                    year1,
                    year2);

            if (value != "")
            {
                Form2 form2 = new Form2(value, Work.nameP, Work.nameF);
                form2.Show();
            }
            else
            {
                MessageBox.Show("Выберите параметр, функцию и криптовалюту!");
            }
        }

        private void ForecastingButton_Click(object sender, EventArgs e)
        {
            if (CryptoCombo.SelectedItem != null)
            {
                if (CryptoCombo.SelectedItem.ToString() == "")
                {
                    SelectedCryptocurrency = CryptoCombo.Items[1].ToString();
                }
                else
                {
                    SelectedCryptocurrency = CryptoCombo.SelectedItem;
                }

                Form3 form3 = new Form3();
                form3.Show();
                DataForecasts dataForecasts = new DataForecasts();
            }
            else
            {
                MessageBox.Show("Загрузите файл(если он еще не загружен) и выберите криптовалюту!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] res = Properties.Resources.crypto_markets.Split(new char[] { '\n' });
            Work.FileData = res.Take(res.Length - 1).ToArray();
            work.ReadingData();

            if (Work.NameCryptocurrency != null)
            {
                CryptoCombo.Items.Clear();
                CryptoCombo.Items.Add("");

                for (int i = 0; i < Work.NameCryptocurrency.Count; i++)
                {
                    CryptoCombo.Items.Add(Work.NameCryptocurrency[i]);
                }
            }

            if (Work.ParamCryptocurrency != null)
            {
                CryptocurrencyParametersCombo.Items.Clear();
                CryptocurrencyParametersCombo.Items.Add("");

                for (int i = 0; i < Work.ParamCryptocurrency.Count; i++)
                {
                    CryptocurrencyParametersCombo.Items.Add(Work.ParamCryptocurrency[i]);
                }
            }
        }
    }
}
