namespace Tyuiu.SchcapovMA.Sprint6.Task3.V16
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxTask_SMA = new GroupBox();
            dataGridViewValue_SMA = new DataGridView();
            textBoxTask_SMA = new TextBox();
            textBoxStrel_SMA = new TextBox();
            dataGridViewRes_SMA = new DataGridView();
            groupBoxRes_SMA = new GroupBox();
            textBoxRes_SMA = new TextBox();
            buttonRes_SMA = new Button();
            buttonAnswer_SMA = new Button();
            groupBoxTask_SMA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewValue_SMA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes_SMA).BeginInit();
            groupBoxRes_SMA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_SMA
            // 
            groupBoxTask_SMA.Controls.Add(dataGridViewValue_SMA);
            groupBoxTask_SMA.Controls.Add(textBoxTask_SMA);
            groupBoxTask_SMA.Dock = DockStyle.Left;
            groupBoxTask_SMA.Location = new Point(0, 0);
            groupBoxTask_SMA.Name = "groupBoxTask_SMA";
            groupBoxTask_SMA.Size = new Size(368, 395);
            groupBoxTask_SMA.TabIndex = 0;
            groupBoxTask_SMA.TabStop = false;
            groupBoxTask_SMA.Text = "Условие";
            // 
            // dataGridViewValue_SMA
            // 
            dataGridViewValue_SMA.BackgroundColor = SystemColors.Control;
            dataGridViewValue_SMA.BorderStyle = BorderStyle.None;
            dataGridViewValue_SMA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewValue_SMA.ColumnHeadersVisible = false;
            dataGridViewValue_SMA.Location = new Point(182, 68);
            dataGridViewValue_SMA.Name = "dataGridViewValue_SMA";
            dataGridViewValue_SMA.ReadOnly = true;
            dataGridViewValue_SMA.RowHeadersVisible = false;
            dataGridViewValue_SMA.RowHeadersWidth = 51;
            dataGridViewValue_SMA.Size = new Size(180, 211);
            dataGridViewValue_SMA.TabIndex = 3;
            dataGridViewValue_SMA.CellContentClick += dataGridViewRes_SMA_CellContentClick;
            // 
            // textBoxTask_SMA
            // 
            textBoxTask_SMA.BackColor = SystemColors.Control;
            textBoxTask_SMA.BorderStyle = BorderStyle.None;
            textBoxTask_SMA.Location = new Point(24, 46);
            textBoxTask_SMA.Multiline = true;
            textBoxTask_SMA.Name = "textBoxTask_SMA";
            textBoxTask_SMA.ReadOnly = true;
            textBoxTask_SMA.Size = new Size(192, 288);
            textBoxTask_SMA.TabIndex = 2;
            textBoxTask_SMA.Text = "Дана матрица 5 на 5\r\n14   1  -3   1  10\r\n\r\n 7  -3   5  -4   0\r\n\r\n-10 -19 -18  -9  19\r\n\r\n -2  -2 -16   2 -17\r\n\r\n -16   9   5 -10  16\r\n\r\nЗаменить четные значения в третьей строке на 0.\r\n";
            // 
            // textBoxStrel_SMA
            // 
            textBoxStrel_SMA.BackColor = SystemColors.Control;
            textBoxStrel_SMA.BorderStyle = BorderStyle.None;
            textBoxStrel_SMA.Location = new Point(377, 130);
            textBoxStrel_SMA.Name = "textBoxStrel_SMA";
            textBoxStrel_SMA.ReadOnly = true;
            textBoxStrel_SMA.Size = new Size(28, 20);
            textBoxStrel_SMA.TabIndex = 5;
            textBoxStrel_SMA.Text = "=>";
            textBoxStrel_SMA.TextChanged += textBoxStrel_SMA_TextChanged;
            // 
            // dataGridViewRes_SMA
            // 
            dataGridViewRes_SMA.BackgroundColor = SystemColors.Control;
            dataGridViewRes_SMA.BorderStyle = BorderStyle.None;
            dataGridViewRes_SMA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRes_SMA.ColumnHeadersVisible = false;
            dataGridViewRes_SMA.Location = new Point(30, 68);
            dataGridViewRes_SMA.Name = "dataGridViewRes_SMA";
            dataGridViewRes_SMA.ReadOnly = true;
            dataGridViewRes_SMA.RowHeadersVisible = false;
            dataGridViewRes_SMA.RowHeadersWidth = 51;
            dataGridViewRes_SMA.Size = new Size(184, 188);
            dataGridViewRes_SMA.TabIndex = 4;
            // 
            // groupBoxRes_SMA
            // 
            groupBoxRes_SMA.Controls.Add(buttonAnswer_SMA);
            groupBoxRes_SMA.Controls.Add(dataGridViewRes_SMA);
            groupBoxRes_SMA.Controls.Add(textBoxRes_SMA);
            groupBoxRes_SMA.Controls.Add(buttonRes_SMA);
            groupBoxRes_SMA.Location = new Point(411, 0);
            groupBoxRes_SMA.Name = "groupBoxRes_SMA";
            groupBoxRes_SMA.Size = new Size(319, 395);
            groupBoxRes_SMA.TabIndex = 0;
            groupBoxRes_SMA.TabStop = false;
            groupBoxRes_SMA.Text = "Вывод данных";
            // 
            // textBoxRes_SMA
            // 
            textBoxRes_SMA.BorderStyle = BorderStyle.None;
            textBoxRes_SMA.Location = new Point(30, 31);
            textBoxRes_SMA.Name = "textBoxRes_SMA";
            textBoxRes_SMA.ReadOnly = true;
            textBoxRes_SMA.Size = new Size(125, 20);
            textBoxRes_SMA.TabIndex = 4;
            textBoxRes_SMA.Text = "Результат:";
            // 
            // buttonRes_SMA
            // 
            buttonRes_SMA.Cursor = Cursors.Hand;
            buttonRes_SMA.FlatStyle = FlatStyle.Flat;
            buttonRes_SMA.Location = new Point(75, 319);
            buttonRes_SMA.Name = "buttonRes_SMA";
            buttonRes_SMA.Size = new Size(102, 40);
            buttonRes_SMA.TabIndex = 0;
            buttonRes_SMA.Text = "Выполнить";
            buttonRes_SMA.UseVisualStyleBackColor = true;
            buttonRes_SMA.Click += buttonRes_SMA_Click;
            // 
            // buttonAnswer_SMA
            // 
            buttonAnswer_SMA.Cursor = Cursors.Help;
            buttonAnswer_SMA.FlatStyle = FlatStyle.Flat;
            buttonAnswer_SMA.Location = new Point(29, 319);
            buttonAnswer_SMA.Name = "buttonAnswer_SMA";
            buttonAnswer_SMA.Size = new Size(40, 40);
            buttonAnswer_SMA.TabIndex = 1;
            buttonAnswer_SMA.Text = "?";
            buttonAnswer_SMA.UseVisualStyleBackColor = true;
            buttonAnswer_SMA.Click += buttonAnswer_SMA_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(731, 395);
            Controls.Add(textBoxStrel_SMA);
            Controls.Add(groupBoxRes_SMA);
            Controls.Add(groupBoxTask_SMA);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 3 | Вариант 16 | Щапов М. А.";
            Load += FormMain_Load;
            groupBoxTask_SMA.ResumeLayout(false);
            groupBoxTask_SMA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewValue_SMA).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes_SMA).EndInit();
            groupBoxRes_SMA.ResumeLayout(false);
            groupBoxRes_SMA.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxTask_SMA;
        private TextBox textBoxTask_SMA;
        private GroupBox groupBoxRes_SMA;
        private TextBox textBoxRes_SMA;
        private Button buttonRes_SMA;
        private Button buttonAnswer_SMA;
        private DataGridView dataGridViewValue_SMA;
        private DataGridView dataGridViewRes_SMA;
        private TextBox textBoxStrel_SMA;
    }
}
