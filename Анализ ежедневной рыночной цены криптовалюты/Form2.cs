using System;
using System.Windows.Forms;

namespace Анализ_ежедневной_рыночной_цены_криптовалюты
{
    public partial class Form2 : Form
    {

        public Form2(string ReceivedValue, string nameP, string nameF)
        {
            InitializeComponent();
            FieldValue.Text = ReceivedValue;
            this.Text = nameP;
            FuncName.Text = nameF;
        }

        private void CloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
