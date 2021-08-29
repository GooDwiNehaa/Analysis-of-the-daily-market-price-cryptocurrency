namespace Анализ_ежедневной_рыночной_цены_криптовалюты
{
    partial class Form2
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
            this.FieldValue = new System.Windows.Forms.TextBox();
            this.CloseWindow = new System.Windows.Forms.Button();
            this.FuncName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FieldValue
            // 
            this.FieldValue.Location = new System.Drawing.Point(12, 20);
            this.FieldValue.Name = "FieldValue";
            this.FieldValue.ReadOnly = true;
            this.FieldValue.Size = new System.Drawing.Size(335, 22);
            this.FieldValue.TabIndex = 0;
            // 
            // CloseWindow
            // 
            this.CloseWindow.Location = new System.Drawing.Point(12, 48);
            this.CloseWindow.Name = "CloseWindow";
            this.CloseWindow.Size = new System.Drawing.Size(335, 53);
            this.CloseWindow.TabIndex = 1;
            this.CloseWindow.Text = "Закрыть";
            this.CloseWindow.UseVisualStyleBackColor = true;
            this.CloseWindow.Click += new System.EventHandler(this.CloseWindow_Click);
            // 
            // FuncName
            // 
            this.FuncName.AutoSize = true;
            this.FuncName.Dock = System.Windows.Forms.DockStyle.Left;
            this.FuncName.Location = new System.Drawing.Point(0, 0);
            this.FuncName.Name = "FuncName";
            this.FuncName.Size = new System.Drawing.Size(46, 17);
            this.FuncName.TabIndex = 2;
            this.FuncName.Text = "label1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 109);
            this.Controls.Add(this.FuncName);
            this.Controls.Add(this.CloseWindow);
            this.Controls.Add(this.FieldValue);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Вычисления";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FieldValue;
        private System.Windows.Forms.Button CloseWindow;
        private System.Windows.Forms.Label FuncName;
    }
}