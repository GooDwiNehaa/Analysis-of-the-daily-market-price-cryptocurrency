using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Анализ_ежедневной_рыночной_цены_криптовалюты
{
    public partial class Form3 : Form
    {
        Work work;
        private List<List<object>> lists = new List<List<object>>();
        private List<List<object>> listsInput = new List<List<object>>();
        private List<List<object>> listsInputCopy = new List<List<object>>();
        public static string nameC { get; set; }
        public static int srok { get; set; }
        public Form3()
        {
            InitializeComponent();
            work = new Work(DGV2);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Work.NameCryptocurrency.Count; i++)
            {
                CryptoComboBox.Items.Add(Work.NameCryptocurrency[i]);
            }

            CryptoComboBox.SelectedItem = Form1.SelectedCryptocurrency;
        }

        private void CryptoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            lists.Clear();
            DGV2.Columns.Clear();
            DGV2.Rows.Clear();

            if (CryptoComboBox.SelectedItem != null)
            {
                lists = work.DataTransfer(CryptoComboBox.SelectedItem.ToString(), Work.dsf, Work.defoltDt);

                nameC = CryptoComboBox.SelectedItem.ToString();

                FillingTheTable(lists, DGV2);
            }
            else
            {
                MessageBox.Show("Выберите криптоволюту!");
            }

            PredictButton.Enabled = true;
        }

        private void PredictButton_Click(object sender, EventArgs e)
        {
            DataForecasts dataForecasts = new DataForecasts();

            if (numericUpDown1.Value > 0)
            {
                srok = Convert.ToInt32(numericUpDown1.Value);
                listsInput = dataForecasts.ExcelDataForecasting(srok);
                listsInputCopy = listsInput.ToList();

                DGV2.Columns.Clear();
                DGV2.Rows.Clear();

                FillingTheTable(listsInput, DGV2);

                listsInput.Clear();
            }
            else
            {
                MessageBox.Show("Срок прогнозирования должен быть больше нуля!");
            }

            PredictButton.Enabled = false;
        }

        private void FillingTheTable(List<List<object>> list, DataGridView dgv)
        {
            dgv.Columns.Add("", "");

            for (int i = 1; i < list[0].Count; i++)
            {
                dgv.Columns.Add(list[0][i].ToString(), list[0][i].ToString());
            }

            dgv.Rows.Add(list.Count - 1);

            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = 0; j < list[i].Count; j++)
                {
                    dgv.Rows[i].Cells[j].Value = list[i + 1][j].ToString();
                }
            }
        }

        private void BuildAGraphButton_Click(object sender, EventArgs e)
        {
            if (TypeGraph.SelectedIndex != -1)
            {
                BuildAGraph(listsInputCopy, TypeGraph.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Выберите тип графика!");
            }
            
        }

        private void BuildAGraph(List<List<object>> listsInputs, int index)
        {
            try
            {
                chart1.Series.Clear();

                for (int i = 1; i < listsInputs.Count; i++)
                {
                    chart1.Series.Add(listsInputs[i][0].ToString());
                }

                for (int i = 0; i < chart1.Series.Count; i++)
                {
                    chart1.Series[i].ChartType = SeriesChartType.Line;
                }

                List<double> x = new List<double>();
                List<double> y = new List<double>();

                for (int i = 1; i < listsInputs[0].Count; i++)
                {
                    x.Add(Convert.ToDouble(listsInputs[0][i]));
                }

                for (int i = 0; i < chart1.Series.Count - 1; i++)
                {
                    for (int j = 1; j < listsInputs[0].Count; j++)
                    {
                        y.Add(Convert.ToDouble(listsInputs[i + 1][j]));
                    }

                    for (int j = 0; j < x.Count; j++)
                    {
                        chart1.Series[i].Points.AddXY(x[j], y[j]);
                    }

                    if (index == 0)
                    {
                        chart1.Series[0].Enabled = false;
                        chart1.Series[1].Enabled = false;
                        chart1.Series[2].Enabled = false;
                        chart1.Series[3].Enabled = false;
                        chart1.Series[4].Enabled = false;
                        chart1.Series[7].Enabled = false;
                        chart1.Series[8].Enabled = false;
                    }
                    else if (index == 1)
                    {
                        chart1.Series[5].Enabled = false;
                        chart1.Series[6].Enabled = false;
                    }

                    y.Clear();
                    listsInput.Clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Прежде чем построить график, сначала спрогнозируйте данные и выберите тип графика!");
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 0)
            {
                numericUpDown1.Value = 1;
            }
        }
    }
}
