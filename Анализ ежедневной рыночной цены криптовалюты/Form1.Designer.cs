namespace Анализ_ежедневной_рыночной_цены_криптовалюты
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Look = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CryptoCombo = new System.Windows.Forms.ComboBox();
            this.GraphicCombo = new System.Windows.Forms.ComboBox();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CryptocurrencyParametersCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FunctionsCombo = new System.Windows.Forms.ComboBox();
            this.Computation = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ComboYear2 = new System.Windows.Forms.ComboBox();
            this.ComboYear1 = new System.Windows.Forms.ComboBox();
            this.ForecastingButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Криптоволюта:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Тип графика:";
            // 
            // Look
            // 
            this.Look.Location = new System.Drawing.Point(340, 75);
            this.Look.Name = "Look";
            this.Look.Size = new System.Drawing.Size(380, 48);
            this.Look.TabIndex = 1;
            this.Look.Text = "Построить график";
            this.Look.UseVisualStyleBackColor = true;
            this.Look.Click += new System.EventHandler(this.Look_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1410, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // CryptoCombo
            // 
            this.CryptoCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CryptoCombo.FormattingEnabled = true;
            this.CryptoCombo.Items.AddRange(new object[] {
            ""});
            this.CryptoCombo.Location = new System.Drawing.Point(130, 44);
            this.CryptoCombo.Name = "CryptoCombo";
            this.CryptoCombo.Size = new System.Drawing.Size(186, 24);
            this.CryptoCombo.TabIndex = 3;
            this.CryptoCombo.SelectedIndexChanged += new System.EventHandler(this.CryptoCombo_SelectedIndexChanged);
            // 
            // GraphicCombo
            // 
            this.GraphicCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GraphicCombo.FormattingEnabled = true;
            this.GraphicCombo.Items.AddRange(new object[] {
            "",
            "Date + Rank now",
            "Date + Open",
            "Date + High",
            "Date + Low",
            "Date + Close",
            "Date + Volume",
            "Date + Market",
            "Date + Close ratio",
            "Date + Spread",
            "Market + Volume"});
            this.GraphicCombo.Location = new System.Drawing.Point(439, 44);
            this.GraphicCombo.Name = "GraphicCombo";
            this.GraphicCombo.Size = new System.Drawing.Size(281, 24);
            this.GraphicCombo.TabIndex = 3;
            // 
            // DGV
            // 
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(12, 264);
            this.DGV.Name = "DGV";
            this.DGV.RowHeadersWidth = 51;
            this.DGV.RowTemplate.Height = 24;
            this.DGV.Size = new System.Drawing.Size(842, 574);
            this.DGV.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.Chart1.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.Chart1.Legends.Add(legend1);
            this.Chart1.Location = new System.Drawing.Point(873, 264);
            this.Chart1.Name = "Chart1";
            this.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 2;
            this.Chart1.Series.Add(series1);
            this.Chart1.Size = new System.Drawing.Size(525, 574);
            this.Chart1.TabIndex = 5;
            this.Chart1.Text = "chart1";
            // 
            // CryptocurrencyParametersCombo
            // 
            this.CryptocurrencyParametersCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CryptocurrencyParametersCombo.FormattingEnabled = true;
            this.CryptocurrencyParametersCombo.Items.AddRange(new object[] {
            ""});
            this.CryptocurrencyParametersCombo.Location = new System.Drawing.Point(721, 138);
            this.CryptocurrencyParametersCombo.Name = "CryptocurrencyParametersCombo";
            this.CryptocurrencyParametersCombo.Size = new System.Drawing.Size(155, 24);
            this.CryptocurrencyParametersCombo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(627, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Параметры:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(900, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Функции:";
            // 
            // FunctionsCombo
            // 
            this.FunctionsCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FunctionsCombo.FormattingEnabled = true;
            this.FunctionsCombo.Items.AddRange(new object[] {
            "",
            "Минимальное значение",
            "Максимальное значение",
            "Среднее значение"});
            this.FunctionsCombo.Location = new System.Drawing.Point(977, 138);
            this.FunctionsCombo.Name = "FunctionsCombo";
            this.FunctionsCombo.Size = new System.Drawing.Size(197, 24);
            this.FunctionsCombo.TabIndex = 8;
            // 
            // Computation
            // 
            this.Computation.Location = new System.Drawing.Point(630, 168);
            this.Computation.Name = "Computation";
            this.Computation.Size = new System.Drawing.Size(544, 48);
            this.Computation.TabIndex = 9;
            this.Computation.Text = "Вычислить";
            this.Computation.UseVisualStyleBackColor = true;
            this.Computation.Click += new System.EventHandler(this.Computation_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ComboYear2);
            this.groupBox1.Controls.Add(this.ComboYear1);
            this.groupBox1.Location = new System.Drawing.Point(743, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 86);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите диапозон дат:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(149, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 55);
            this.label5.TabIndex = 1;
            this.label5.Text = "-";
            // 
            // ComboYear2
            // 
            this.ComboYear2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboYear2.FormattingEnabled = true;
            this.ComboYear2.Location = new System.Drawing.Point(195, 31);
            this.ComboYear2.Name = "ComboYear2";
            this.ComboYear2.Size = new System.Drawing.Size(121, 24);
            this.ComboYear2.TabIndex = 0;
            // 
            // ComboYear1
            // 
            this.ComboYear1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboYear1.FormattingEnabled = true;
            this.ComboYear1.Location = new System.Drawing.Point(22, 31);
            this.ComboYear1.Name = "ComboYear1";
            this.ComboYear1.Size = new System.Drawing.Size(121, 24);
            this.ComboYear1.TabIndex = 0;
            // 
            // ForecastingButton
            // 
            this.ForecastingButton.Location = new System.Drawing.Point(19, 74);
            this.ForecastingButton.Name = "ForecastingButton";
            this.ForecastingButton.Size = new System.Drawing.Size(304, 66);
            this.ForecastingButton.TabIndex = 11;
            this.ForecastingButton.Text = "Прогнозирование...";
            this.ForecastingButton.UseVisualStyleBackColor = true;
            this.ForecastingButton.Click += new System.EventHandler(this.ForecastingButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 863);
            this.Controls.Add(this.ForecastingButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Computation);
            this.Controls.Add(this.FunctionsCombo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CryptocurrencyParametersCombo);
            this.Controls.Add(this.Chart1);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.GraphicCombo);
            this.Controls.Add(this.CryptoCombo);
            this.Controls.Add(this.Look);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Анализ ежедневной рыночной цены криптовалюты";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Look;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ComboBox CryptoCombo;
        private System.Windows.Forms.ComboBox GraphicCombo;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
        private System.Windows.Forms.ComboBox CryptocurrencyParametersCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox FunctionsCombo;
        private System.Windows.Forms.Button Computation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ComboYear2;
        private System.Windows.Forms.ComboBox ComboYear1;
        private System.Windows.Forms.Button ForecastingButton;
    }
}

