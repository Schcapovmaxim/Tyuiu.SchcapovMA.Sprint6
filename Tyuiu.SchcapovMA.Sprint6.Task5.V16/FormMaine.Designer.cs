namespace Tyuiu.SchcapovMA.Sprint6.Task5.V16
{
    partial class FormMaine
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelTask_SMA = new Panel();
            buttonAnswer_SMA = new Button();
            buttonRun_SMA = new Button();
            buttonOpenF_SMA = new Button();
            groupBoxTask_SMA = new GroupBox();
            textBox1 = new TextBox();
            panelChart_SMA = new Panel();
            chart_SMA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            splitter1 = new Splitter();
            panelDataGridView_SMA = new Panel();
            groupBoxOut_SMA = new GroupBox();
            dataGridView_SMA = new DataGridView();
            panelTask_SMA.SuspendLayout();
            groupBoxTask_SMA.SuspendLayout();
            panelChart_SMA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart_SMA).BeginInit();
            panelDataGridView_SMA.SuspendLayout();
            groupBoxOut_SMA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_SMA).BeginInit();
            SuspendLayout();
            // 
            // panelTask_SMA
            // 
            panelTask_SMA.BackColor = SystemColors.Control;
            panelTask_SMA.Controls.Add(buttonAnswer_SMA);
            panelTask_SMA.Controls.Add(buttonRun_SMA);
            panelTask_SMA.Controls.Add(buttonOpenF_SMA);
            panelTask_SMA.Controls.Add(groupBoxTask_SMA);
            panelTask_SMA.Dock = DockStyle.Top;
            panelTask_SMA.Location = new Point(0, 0);
            panelTask_SMA.Name = "panelTask_SMA";
            panelTask_SMA.Size = new Size(782, 122);
            panelTask_SMA.TabIndex = 0;
            // 
            // buttonAnswer_SMA
            // 
            buttonAnswer_SMA.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonAnswer_SMA.BackColor = Color.FromArgb(128, 128, 255);
            buttonAnswer_SMA.Cursor = Cursors.Help;
            buttonAnswer_SMA.Location = new Point(668, 23);
            buttonAnswer_SMA.Name = "buttonAnswer_SMA";
            buttonAnswer_SMA.Size = new Size(96, 66);
            buttonAnswer_SMA.TabIndex = 1;
            buttonAnswer_SMA.Text = "Справка";
            buttonAnswer_SMA.UseVisualStyleBackColor = false;
            buttonAnswer_SMA.Click += buttonAnswer_SMA_Click;
            // 
            // buttonRun_SMA
            // 
            buttonRun_SMA.BackColor = Color.FromArgb(128, 255, 128);
            buttonRun_SMA.Cursor = Cursors.Hand;
            buttonRun_SMA.Location = new Point(426, 23);
            buttonRun_SMA.Name = "buttonRun_SMA";
            buttonRun_SMA.Size = new Size(96, 66);
            buttonRun_SMA.TabIndex = 2;
            buttonRun_SMA.Text = "Выполнить";
            buttonRun_SMA.UseVisualStyleBackColor = false;
            buttonRun_SMA.Click += buttonRun_SMA_Click;
            buttonRun_SMA.MouseDown += buttonRun_SMA_MouseDown;
            buttonRun_SMA.MouseEnter += buttonRun_SMA_MouseEnter;
            buttonRun_SMA.MouseLeave += buttonRun_SMA_MouseLeave;
            // 
            // buttonOpenF_SMA
            // 
            buttonOpenF_SMA.BackColor = Color.FromArgb(128, 255, 255);
            buttonOpenF_SMA.Cursor = Cursors.Hand;
            buttonOpenF_SMA.Location = new Point(549, 23);
            buttonOpenF_SMA.Name = "buttonOpenF_SMA";
            buttonOpenF_SMA.Size = new Size(96, 66);
            buttonOpenF_SMA.TabIndex = 3;
            buttonOpenF_SMA.Text = "Открыть файл";
            buttonOpenF_SMA.UseVisualStyleBackColor = false;
            buttonOpenF_SMA.Click += buttonOpenF_SMA_Click;
            // 
            // groupBoxTask_SMA
            // 
            groupBoxTask_SMA.Controls.Add(textBox1);
            groupBoxTask_SMA.Location = new Point(0, 3);
            groupBoxTask_SMA.Name = "groupBoxTask_SMA";
            groupBoxTask_SMA.Size = new Size(416, 113);
            groupBoxTask_SMA.TabIndex = 0;
            groupBoxTask_SMA.TabStop = false;
            groupBoxTask_SMA.Text = "Условие:";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(25, 18);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(347, 87);
            textBox1.TabIndex = 0;
            textBox1.Text = "Прочитать данные из файла InPutFileTask5V16.txt. Вывести в dataGridView. \r\nВывести все положительные числа.\r\nПостроить диаграмму по этим значениям. ";
            // 
            // panelChart_SMA
            // 
            panelChart_SMA.BackColor = SystemColors.Control;
            panelChart_SMA.Controls.Add(chart_SMA);
            panelChart_SMA.Controls.Add(splitter1);
            panelChart_SMA.Dock = DockStyle.Fill;
            panelChart_SMA.Location = new Point(163, 122);
            panelChart_SMA.Name = "panelChart_SMA";
            panelChart_SMA.Size = new Size(619, 381);
            panelChart_SMA.TabIndex = 0;
            // 
            // chart_SMA
            // 
            chartArea1.Name = "ChartArea1";
            chart_SMA.ChartAreas.Add(chartArea1);
            chart_SMA.Dock = DockStyle.Fill;
            chart_SMA.Location = new Point(10, 0);
            chart_SMA.Name = "chart_SMA";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            chart_SMA.Series.Add(series1);
            chart_SMA.Size = new Size(609, 381);
            chart_SMA.TabIndex = 0;
            chart_SMA.Text = "chart1";
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(10, 381);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            // 
            // panelDataGridView_SMA
            // 
            panelDataGridView_SMA.BackColor = SystemColors.Control;
            panelDataGridView_SMA.Controls.Add(groupBoxOut_SMA);
            panelDataGridView_SMA.Dock = DockStyle.Left;
            panelDataGridView_SMA.Location = new Point(0, 122);
            panelDataGridView_SMA.Name = "panelDataGridView_SMA";
            panelDataGridView_SMA.Size = new Size(163, 381);
            panelDataGridView_SMA.TabIndex = 0;
            // 
            // groupBoxOut_SMA
            // 
            groupBoxOut_SMA.Controls.Add(dataGridView_SMA);
            groupBoxOut_SMA.Dock = DockStyle.Fill;
            groupBoxOut_SMA.Location = new Point(0, 0);
            groupBoxOut_SMA.Name = "groupBoxOut_SMA";
            groupBoxOut_SMA.Size = new Size(163, 381);
            groupBoxOut_SMA.TabIndex = 0;
            groupBoxOut_SMA.TabStop = false;
            groupBoxOut_SMA.Text = "Вывод данных";
            // 
            // dataGridView_SMA
            // 
            dataGridView_SMA.BackgroundColor = SystemColors.Control;
            dataGridView_SMA.BorderStyle = BorderStyle.None;
            dataGridView_SMA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_SMA.ColumnHeadersVisible = false;
            dataGridView_SMA.Dock = DockStyle.Fill;
            dataGridView_SMA.Location = new Point(3, 23);
            dataGridView_SMA.Name = "dataGridView_SMA";
            dataGridView_SMA.ReadOnly = true;
            dataGridView_SMA.RowHeadersVisible = false;
            dataGridView_SMA.RowHeadersWidth = 51;
            dataGridView_SMA.Size = new Size(157, 355);
            dataGridView_SMA.TabIndex = 0;
            // 
            // FormMaine
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 503);
            Controls.Add(panelChart_SMA);
            Controls.Add(panelDataGridView_SMA);
            Controls.Add(panelTask_SMA);
            MinimumSize = new Size(800, 550);
            Name = "FormMaine";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 5 | Вариант 16 | Щапов М. А.";
            panelTask_SMA.ResumeLayout(false);
            groupBoxTask_SMA.ResumeLayout(false);
            groupBoxTask_SMA.PerformLayout();
            panelChart_SMA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart_SMA).EndInit();
            panelDataGridView_SMA.ResumeLayout(false);
            groupBoxOut_SMA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_SMA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTask_SMA;
        private Panel panelChart_SMA;
        private Panel panelDataGridView_SMA;
        private Splitter splitter1;
        private GroupBox groupBoxTask_SMA;
        private GroupBox groupBoxOut_SMA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_SMA;
        private DataGridView dataGridView_SMA;
        private Button buttonAnswer_SMA;
        private Button buttonRun_SMA;
        private Button buttonOpenF_SMA;
        private TextBox textBox1;
    }
}
