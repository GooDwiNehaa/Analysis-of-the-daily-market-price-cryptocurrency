namespace Анализ_ежедневной_рыночной_цены_криптовалюты
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.DGV2 = new System.Windows.Forms.DataGridView();
            this.CryptoComboBox = new System.Windows.Forms.ComboBox();
            this.TypeGraph = new System.Windows.Forms.ComboBox();
            this.PredictButton = new System.Windows.Forms.Button();
            this.BuildAGraphButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.DGV2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV2
            // 
            this.DGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV2.Location = new System.Drawing.Point(12, 405);
            this.DGV2.Name = "DGV2";
            this.DGV2.RowHeadersWidth = 51;
            this.DGV2.RowTemplate.Height = 24;
            this.DGV2.Size = new System.Drawing.Size(1357, 352);
            this.DGV2.TabIndex = 0;
            // 
            // CryptoComboBox
            // 
            this.CryptoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CryptoComboBox.FormattingEnabled = true;
            this.CryptoComboBox.Location = new System.Drawing.Point(102, 111);
            this.CryptoComboBox.Name = "CryptoComboBox";
            this.CryptoComboBox.Size = new System.Drawing.Size(199, 24);
            this.CryptoComboBox.TabIndex = 3;
            this.CryptoComboBox.SelectedIndexChanged += new System.EventHandler(this.CryptoComboBox_SelectedIndexChanged);
            // 
            // TypeGraph
            // 
            this.TypeGraph.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeGraph.FormattingEnabled = true;
            this.TypeGraph.Items.AddRange(new object[] {
            "market + volume",
            "Остальные параметры"});
            this.TypeGraph.Location = new System.Drawing.Point(332, 111);
            this.TypeGraph.Name = "TypeGraph";
            this.TypeGraph.Size = new System.Drawing.Size(199, 24);
            this.TypeGraph.TabIndex = 3;
            // 
            // PredictButton
            // 
            this.PredictButton.Location = new System.Drawing.Point(102, 213);
            this.PredictButton.Name = "PredictButton";
            this.PredictButton.Size = new System.Drawing.Size(199, 52);
            this.PredictButton.TabIndex = 4;
            this.PredictButton.Text = "Спрогнозировать";
            this.PredictButton.UseVisualStyleBackColor = true;
            this.PredictButton.Click += new System.EventHandler(this.PredictButton_Click);
            // 
            // BuildAGraphButton
            // 
            this.BuildAGraphButton.Location = new System.Drawing.Point(332, 213);
            this.BuildAGraphButton.Name = "BuildAGraphButton";
            this.BuildAGraphButton.Size = new System.Drawing.Size(199, 52);
            this.BuildAGraphButton.TabIndex = 4;
            this.BuildAGraphButton.Text = "Построить график";
            this.BuildAGraphButton.UseVisualStyleBackColor = true;
            this.BuildAGraphButton.Click += new System.EventHandler(this.BuildAGraphButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Тип графика:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Криптоволюта:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(307, 162);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Срок прогнозирования:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(433, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "лет/год";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(653, 15);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(716, 373);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 769);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BuildAGraphButton);
            this.Controls.Add(this.PredictButton);
            this.Controls.Add(this.TypeGraph);
            this.Controls.Add(this.CryptoComboBox);
            this.Controls.Add(this.DGV2);
            this.Name = "Form3";
            this.Text = "Прогнозирование данных";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV2;
        private System.Windows.Forms.ComboBox CryptoComboBox;
        private System.Windows.Forms.ComboBox TypeGraph;
        private System.Windows.Forms.Button PredictButton;
        private System.Windows.Forms.Button BuildAGraphButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}