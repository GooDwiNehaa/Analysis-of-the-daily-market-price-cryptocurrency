using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.Windows.Forms.DataVisualization.Charting;

namespace Анализ_ежедневной_рыночной_цены_криптовалюты
{
    class Work
    {
        private DataGridView dgv;
        private DataTable dt = new DataTable("Cryptocurrency");
        private DataSet ds = new DataSet();
        public static DataTable defoltDt { get; set; }
        public static DataSet dsf { get; set; }
        private static DataTable DataForPredict { get; set; }
        public static string[] FileData { get; set; }
        public static List<string> NameCryptocurrency { get; set; }
        public static List<string> ParamCryptocurrency { get; set; }
        public static List<int> YearCryptocurrency { get; set; }
        public static string nameF { get; set; }
        public static string nameP { get; set; }

        public Work(DataGridView dgv)
        {
            this.dgv = dgv;
        }

        public Work()
        {

        }

        public void ReadingData()
        {
            try
            {
                if (FileData != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        ds.Tables.RemoveAt(0);
                        dsf.Tables.RemoveAt(0);
                        dt.Clear();
                        dt = new DataTable("Cryptocurrency");
                        dgv.DataSource = null;
                    }

                    for (int i = 0; i < FileData.Length; i++)
                    {
                        FileData[i] = FileData[i].Replace(",", ";");
                    }

                    for (int i = 0; i < FileData.Length; i++)
                    {
                        FileData[i] = FileData[i].Replace(".", ",");
                    }

                    string[] str = FileData[0].Split(';');
                    string[] str1 = str;

                    dt.Columns.Add(str[0]);
                    dt.Columns.Add(str[1]);
                    dt.Columns.Add(str[2]);
                    dt.Columns.Add(str[3]);
                    dt.Columns.Add(str[4]);
                    dt.Columns.Add(str[5]);
                    dt.Columns.Add(str[6]);
                    dt.Columns.Add(str[7]);
                    dt.Columns.Add(str[8]);
                    dt.Columns.Add(str[9]);
                    dt.Columns.Add(str[10]);
                    dt.Columns.Add(str[11]);
                    dt.Columns.Add(str[12]);

                    for (int i = 1; i < FileData.Length; i++)
                    {
                        str = FileData[i].Split(';');
                        dt.Rows.Add(str[0], str[1], str[2], str[3], str[4], str[5], str[6], str[7], str[8], str[9], str[10], str[11], str[12]);
                    }

                    dgv.DataSource = dt;
                    defoltDt = new DataTable();
                    defoltDt = dt.Clone();
                    ds.Tables.Add(dt);
                    dsf = new DataSet();
                    dsf = ds.Copy();

                    var cryptoNames = from name in ds.Tables["Cryptocurrency"].AsEnumerable() select name["name"];

                    NameCryptocurrency = new List<string>();
                    ParamCryptocurrency = new List<string>();

                    foreach (var item in cryptoNames.Distinct())
                    {
                        NameCryptocurrency.Add(item.ToString());
                    }

                    for (int i = 4; i < str1.Length; i++)
                    {
                        ParamCryptocurrency.Add(str1[i]);
                    }
                }
                else
                {
                    MessageBox.Show("Выберите файл и нажмите ОК");
                }
            }
            catch (Exception)
            {
                dt.Clear();
                dt = new DataTable("Cryptocurrency");
                dgv.DataSource = null;
                MessageBox.Show("Неправильная структура файла или этот файл уже загружен!");
            }
        }

        public void DataFiltering(string nameCryptocurrency)
        {
            if (nameCryptocurrency == "")
            {
                dgv.DataSource = null;
                dgv.DataSource = dt;
            }
            else
            {
                try
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Clear();

                    dataTable = Filtration(nameCryptocurrency, dsf, defoltDt).Copy();

                    dgv.DataSource = dataTable;
                    DataForPredict = dataTable.Copy();

                    YearCryptocurrency = new List<int>();
                    YearCryptocurrency.Clear();

                    var crypto = from crypta in ds.Tables["Cryptocurrency"].AsEnumerable()
                                 where (string)crypta["name"] == nameCryptocurrency
                                 select crypta["date"];

                    foreach (var item in crypto)
                    {
                        YearCryptocurrency.Add(Convert.ToDateTime(item).Year);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Валюта названа неправильно!");
                }
            }
        }

        public void BuildAGraph(Chart chart, string nameCryptocurrency, string nameGraph, int index)
        {
            if (nameCryptocurrency == "")
            {
                MessageBox.Show("Выберите криптовалюту, если выбирать не из чего, тогда загрузите файл!");
            }
            else if (nameGraph == "")
            {
                MessageBox.Show("Выберите тип графика!");
            }
            else if (index == 1)
            {
                Graph("date", "ranknow", chart, nameCryptocurrency, nameGraph, index);
            }
            else if (index == 2)
            {
                Graph("date", "open", chart, nameCryptocurrency, nameGraph, index);
            }
            else if (index == 3)
            {
                Graph("date", "high", chart, nameCryptocurrency, nameGraph, index);
            }
            else if (index == 4)
            {
                Graph("date", "low", chart, nameCryptocurrency, nameGraph, index);
            }
            else if (index == 5)
            {
                Graph("date", "close", chart, nameCryptocurrency, nameGraph, index);
            }
            else if (index == 6)
            {
                Graph("date", "volume", chart, nameCryptocurrency, nameGraph, index);
            }
            else if (index == 7)
            {
                Graph("date", "market", chart, nameCryptocurrency, nameGraph, index);
            }
            else if (index == 8)
            {
                Graph("date", "close_ratio", chart, nameCryptocurrency, nameGraph, index);
            }
            else if (index == 9)
            {
                Graph("date", "spread", chart, nameCryptocurrency, nameGraph, index);
            }
            else if (index == 10)
            {
                Graph("market", "volume", chart, nameCryptocurrency, nameGraph, index);
            }
        }

        private void Graph(string X, string Y, Chart chart, string nameCryptocurrency, string nameGraph, int index)
        {
            chart.Titles.Clear();
            chart.Legends[0].Enabled = false;

            if (chart.Series[0].Points.Count > 0)
            {
                chart.Series.Remove(chart.Series[0]);
                chart.Series.Add("Series1");
            }

            List<SpecificData> specificDatas = new List<SpecificData>();


            var cryptos = from crypta in ds.Tables["Cryptocurrency"].AsEnumerable()
                          select new
                          {
                              X = crypta[X],
                              Y = crypta[Y]
                          };

            foreach (var item in cryptos)
            {
                if (X == "market")
                {
                    specificDatas.Add(new SpecificData(Convert.ToDouble(item.X), Convert.ToDouble(item.Y)));
                    chart.Series[0].XValueType = ChartValueType.Double;
                }
                else
                {
                    specificDatas.Add(new SpecificData(Convert.ToDateTime(item.X), Convert.ToDouble(item.Y)));
                    chart.Series[0].XValueType = ChartValueType.Date;
                }
            }

            chart.Series[0].XValueMember = "X";
            chart.Series[0].YValueMembers = "Y";

            chart.DataSource = specificDatas;
            chart.Titles.Add(nameGraph);

            chart.DataBind();

            var symbol = from sym in ds.Tables["Cryptocurrency"].AsEnumerable()
                         where (string)sym["name"] == nameCryptocurrency
                         select sym["symbol"];

            foreach (var item in symbol.Distinct())
            {
                chart.Series[0].LegendText = item.ToString();
            }

            chart.Legends[0].Enabled = true;
            specificDatas.Clear();
        }

        public string Calculate(string name, string nameCryptocurrency, int index, int min, int max)
        {
            if (nameCryptocurrency != "")
            {
                List<double> list = new List<double>();

                if (name == "")
                {
                    MessageBox.Show("Выберите параметр, функцию и криптовалюту!");
                    return "";
                }
                else if (index == 0)
                {
                    MessageBox.Show("Выберите параметр, функцию и криптовалюту!");
                    return "";
                }
                else
                {
                    list.Clear();

                    if (min != 0 && max != 0)
                    {
                        var cryptos = from crypta in ds.Tables["Cryptocurrency"].AsEnumerable()
                                      where ((string)crypta["name"] == nameCryptocurrency) && (Convert.ToDateTime(crypta["date"]).Year >= min) && (Convert.ToDateTime(crypta["date"]).Year <= max)
                                      select crypta[name];

                        return PickFunc(list, cryptos, name, index);
                    }
                    else if (min != 0 && max == 0)
                    {
                        var cryptos = from crypta in ds.Tables["Cryptocurrency"].AsEnumerable()
                                      where ((string)crypta["name"] == nameCryptocurrency) && (Convert.ToDateTime(crypta["date"]).Year >= min)
                                      select crypta[name];

                        return PickFunc(list, cryptos, name, index);
                    }
                    else if (min == 0 && max != 0)
                    {
                        var cryptos = from crypta in ds.Tables["Cryptocurrency"].AsEnumerable()
                                      where ((string)crypta["name"] == nameCryptocurrency) && (Convert.ToDateTime(crypta["date"]).Year <= max)
                                      select crypta[name];

                        return PickFunc(list, cryptos, name, index);
                    }
                    else if (min == 0 && max == 0)
                    {
                        var cryptos = from crypta in ds.Tables["Cryptocurrency"].AsEnumerable()
                                      where ((string)crypta["name"] == nameCryptocurrency)
                                      select crypta[name];

                        return PickFunc(list, cryptos, name, index);
                    }
                    else
                    {
                        return "";
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите криптовалюту!");
                return "";
            }
        }

        private string PickFunc(List<double> list, EnumerableRowCollection erc, string name, int index)
        {
            nameP = name;

            foreach (var item in erc)
            {
                list.Add(Convert.ToDouble(item));
            }

            if (index == 1)
            {
                nameF = "Минимальное значение:";
                return list.Min().ToString();
            }
            else if (index == 2)
            {
                nameF = "Максимальное значение:";
                return list.Max().ToString();
            }
            else if (index == 3)
            {
                nameF = "Среднее значение:";
                return list.Average().ToString();
            }
            else
            {
                return "";
            }
        }

        public List<List<object>> DataTransfer(string nameCryptocurrency, DataSet dataSet, DataTable dataTable)
        {
            DataTable dtp = new DataTable();
            dtp.Clear();

            if (nameCryptocurrency == "")
            {
                nameCryptocurrency = dgv.Rows[0].Cells[2].Value.ToString();
                dtp = Filtration(nameCryptocurrency, dataSet, dataTable).Copy();
            }
            else
            {
                dtp = Filtration(nameCryptocurrency, dataSet, dataTable).Copy();
            }

            dtp.TableName = "CryptocurrencyPredict";
            DataSet dsp = new DataSet();

            if (dsp.Tables.Count > 0)
            {
                dsp.Tables.RemoveAt(0);
            }

            dsp.Tables.Add(dtp);

            List<List<object>> lists = new List<List<object>>();
            lists.Clear();
            List<double> vals = new List<double>();

            lists.Add(new List<object>() { "" });

            var cryptos = from crypta in dsp.Tables["CryptocurrencyPredict"].AsEnumerable()
                          where (string)crypta["name"] == nameCryptocurrency
                          select Convert.ToDateTime(crypta["date"]).Year;

            foreach (var item in cryptos.Distinct())
            {
                lists[0].Add(item.ToString());
            }

            for (int i = 4; i < dtp.Columns.Count; i++)
            {
                lists.Add(new List<object>() { dtp.Columns[i].ToString() });
            }

            for (int i = 0; i < lists.Count - 1; i++)
            {
                for (int j = 1; j < lists[0].Count; j++)
                {
                    var crypto = from crypta in dsp.Tables["CryptocurrencyPredict"].AsEnumerable()
                                 where ((string)crypta["name"] == nameCryptocurrency) & (Convert.ToDateTime(crypta["date"]).Year == Convert.ToInt32(lists[0][j]))
                                 select Convert.ToDouble(crypta[lists[i + 1][0].ToString()]);

                    foreach (var item in crypto)
                    {
                        vals.Add(item);
                    }

                    lists[i + 1].Add(vals.Average().ToString());

                    crypto = null;
                    vals.Clear();
                }
            }

            return lists;
        }

        private DataTable Filtration(string nameCryptocurrency, DataSet dataSet, DataTable dataTable)
        {
            var filteredTable = from crypta in dataSet.Tables["Cryptocurrency"].AsEnumerable()
                                where (string)crypta["Name"] == nameCryptocurrency
                                select new
                                {
                                    Slug = crypta["slug"],
                                    Symbol = crypta["symbol"],
                                    Name = crypta["name"],
                                    Date = crypta["date"],
                                    RankNow = crypta["ranknow"],
                                    Open = crypta["open"],
                                    High = crypta["high"],
                                    Low = crypta["low"],
                                    Close = crypta["close"],
                                    Volume = crypta["volume"],
                                    Market = crypta["market"],
                                    Close_ratio = crypta["close_ratio"],
                                    Spread = crypta["spread"]
                                };

            dataTable.Rows.Clear();

            foreach (var item in filteredTable)
            {
                defoltDt.Rows.Add(new object[] {
                        item.Slug.ToString(),
                        item.Symbol.ToString(),
                        item.Name.ToString(),
                        item.Date.ToString(),
                        item.RankNow.ToString(),
                        item.Open.ToString(),
                        item.High.ToString(),
                        item.Low.ToString(),
                        item.Close.ToString(),
                        item.Volume.ToString(),
                        item.Market.ToString(),
                        item.Close_ratio.ToString(),
                        item.Spread.ToString()});
            }

            filteredTable = null;

            return dataTable;
        }
    }
}
