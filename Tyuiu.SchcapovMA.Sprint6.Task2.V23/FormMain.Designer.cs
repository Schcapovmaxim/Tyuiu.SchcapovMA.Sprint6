namespace Tyuiu.SchcapovMA.Sprint6.Task2.V23
{
    partial class FormTask_SMA
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
            groupBoxTask_SMA = new GroupBox();
            textBoxTask_SMA = new TextBox();
            groupBoxRes_SMA = new GroupBox();
            chartFunction_SMA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            textBoxRs_SMA = new TextBox();
            dataGridViewRes_SMA = new DataGridView();
            ColumnX_SMA = new DataGridViewTextBoxColumn();
            ColumnF_SMA = new DataGridViewTextBoxColumn();
            groupBoxInput_SMA = new GroupBox();
            textBoxEnd_SMA = new TextBox();
            textBoxSt_SMA = new TextBox();
            textBoxValInEnd_SMA = new TextBox();
            textBoxValInSt_SMA = new TextBox();
            buttonAns_SMA = new Button();
            buttonRes_SMA = new Button();
            groupBoxTask_SMA.SuspendLayout();
            groupBoxRes_SMA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_SMA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes_SMA).BeginInit();
            groupBoxInput_SMA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_SMA
            // 
            groupBoxTask_SMA.Controls.Add(textBoxTask_SMA);
            groupBoxTask_SMA.Location = new Point(0, 0);
            groupBoxTask_SMA.Name = "groupBoxTask_SMA";
            groupBoxTask_SMA.Size = new Size(564, 298);
            groupBoxTask_SMA.TabIndex = 0;
            groupBoxTask_SMA.TabStop = false;
            groupBoxTask_SMA.Text = "Условие";
            // 
            // textBoxTask_SMA
            // 
            textBoxTask_SMA.BackColor = SystemColors.ActiveCaption;
            textBoxTask_SMA.BorderStyle = BorderStyle.None;
            textBoxTask_SMA.Location = new Point(6, 26);
            textBoxTask_SMA.Multiline = true;
            textBoxTask_SMA.Name = "textBoxTask_SMA";
            textBoxTask_SMA.ReadOnly = true;
            textBoxTask_SMA.Size = new Size(415, 99);
            textBoxTask_SMA.TabIndex = 6;
            textBoxTask_SMA.Text = "Протабулировать функцию F(x) = 4-2x+(2+cos(x))/(2x- 2) \r\nна заданном диапозоне.Результат вывести в\r\nDataGridView и построить график функции.\r\n\r\n\r\n";
            // 
            // groupBoxRes_SMA
            // 
            groupBoxRes_SMA.Controls.Add(chartFunction_SMA);
            groupBoxRes_SMA.Controls.Add(textBoxRs_SMA);
            groupBoxRes_SMA.Controls.Add(dataGridViewRes_SMA);
            groupBoxRes_SMA.Location = new Point(570, 12);
            groupBoxRes_SMA.Name = "groupBoxRes_SMA";
            groupBoxRes_SMA.Size = new Size(472, 438);
            groupBoxRes_SMA.TabIndex = 0;
            groupBoxRes_SMA.TabStop = false;
            groupBoxRes_SMA.Text = "Вывод данных";
            // 
            // chartFunction_SMA
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_SMA.ChartAreas.Add(chartArea1);
            chartFunction_SMA.Location = new Point(148, 58);
            chartFunction_SMA.Name = "chartFunction_SMA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Name = "Series1";
            chartFunction_SMA.Series.Add(series1);
            chartFunction_SMA.Size = new Size(324, 368);
            chartFunction_SMA.TabIndex = 2;
            chartFunction_SMA.Text = "chart1";
            // 
            // textBoxRs_SMA
            // 
            textBoxRs_SMA.BackColor = SystemColors.ActiveCaption;
            textBoxRs_SMA.BorderStyle = BorderStyle.None;
            textBoxRs_SMA.Location = new Point(15, 26);
            textBoxRs_SMA.Name = "textBoxRs_SMA";
            textBoxRs_SMA.ReadOnly = true;
            textBoxRs_SMA.Size = new Size(125, 20);
            textBoxRs_SMA.TabIndex = 2;
            textBoxRs_SMA.Text = "Результат:";
            // 
            // dataGridViewRes_SMA
            // 
            dataGridViewRes_SMA.BackgroundColor = SystemColors.ControlLight;
            dataGridViewRes_SMA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRes_SMA.Columns.AddRange(new DataGridViewColumn[] { ColumnX_SMA, ColumnF_SMA });
            dataGridViewRes_SMA.Location = new Point(6, 58);
            dataGridViewRes_SMA.Name = "dataGridViewRes_SMA";
            dataGridViewRes_SMA.ReadOnly = true;
            dataGridViewRes_SMA.RowHeadersVisible = false;
            dataGridViewRes_SMA.RowHeadersWidth = 51;
            dataGridViewRes_SMA.Size = new Size(143, 368);
            dataGridViewRes_SMA.TabIndex = 0;
            // 
            // ColumnX_SMA
            // 
            ColumnX_SMA.HeaderText = "X";
            ColumnX_SMA.MinimumWidth = 6;
            ColumnX_SMA.Name = "ColumnX_SMA";
            ColumnX_SMA.ReadOnly = true;
            ColumnX_SMA.Width = 70;
            // 
            // ColumnF_SMA
            // 
            ColumnF_SMA.HeaderText = "F(X)";
            ColumnF_SMA.MinimumWidth = 6;
            ColumnF_SMA.Name = "ColumnF_SMA";
            ColumnF_SMA.ReadOnly = true;
            ColumnF_SMA.Width = 70;
            // 
            // groupBoxInput_SMA
            // 
            groupBoxInput_SMA.Controls.Add(textBoxEnd_SMA);
            groupBoxInput_SMA.Controls.Add(textBoxSt_SMA);
            groupBoxInput_SMA.Controls.Add(textBoxValInEnd_SMA);
            groupBoxInput_SMA.Controls.Add(textBoxValInSt_SMA);
            groupBoxInput_SMA.Location = new Point(0, 313);
            groupBoxInput_SMA.Name = "groupBoxInput_SMA";
            groupBoxInput_SMA.Size = new Size(369, 125);
            groupBoxInput_SMA.TabIndex = 0;
            groupBoxInput_SMA.TabStop = false;
            groupBoxInput_SMA.Text = "Ввод данных";
            // 
            // textBoxEnd_SMA
            // 
            textBoxEnd_SMA.BackColor = SystemColors.ActiveCaption;
            textBoxEnd_SMA.BorderStyle = BorderStyle.None;
            textBoxEnd_SMA.Location = new Point(182, 39);
            textBoxEnd_SMA.Name = "textBoxEnd_SMA";
            textBoxEnd_SMA.ReadOnly = true;
            textBoxEnd_SMA.Size = new Size(125, 20);
            textBoxEnd_SMA.TabIndex = 5;
            textBoxEnd_SMA.Text = "Конец шага:";
            // 
            // textBoxSt_SMA
            // 
            textBoxSt_SMA.BackColor = SystemColors.ActiveCaption;
            textBoxSt_SMA.BorderStyle = BorderStyle.None;
            textBoxSt_SMA.Location = new Point(6, 39);
            textBoxSt_SMA.Name = "textBoxSt_SMA";
            textBoxSt_SMA.Size = new Size(125, 20);
            textBoxSt_SMA.TabIndex = 4;
            textBoxSt_SMA.Text = "Старт шага:";
            // 
            // textBoxValInEnd_SMA
            // 
            textBoxValInEnd_SMA.Location = new Point(182, 72);
            textBoxValInEnd_SMA.Name = "textBoxValInEnd_SMA";
            textBoxValInEnd_SMA.Size = new Size(125, 27);
            textBoxValInEnd_SMA.TabIndex = 3;
            textBoxValInEnd_SMA.KeyPress += textBoxValInSt_SMA_KeyPress;
            // 
            // textBoxValInSt_SMA
            // 
            textBoxValInSt_SMA.Location = new Point(6, 72);
            textBoxValInSt_SMA.Name = "textBoxValInSt_SMA";
            textBoxValInSt_SMA.Size = new Size(125, 27);
            textBoxValInSt_SMA.TabIndex = 2;
            textBoxValInSt_SMA.KeyPress += textBoxValInSt_SMA_KeyPress;
            // 
            // buttonAns_SMA
            // 
            buttonAns_SMA.BackColor = Color.FromArgb(128, 255, 255);
            buttonAns_SMA.Cursor = Cursors.Help;
            buttonAns_SMA.Font = new Font("Segoe UI", 12F);
            buttonAns_SMA.Location = new Point(375, 353);
            buttonAns_SMA.Name = "buttonAns_SMA";
            buttonAns_SMA.Size = new Size(59, 59);
            buttonAns_SMA.TabIndex = 0;
            buttonAns_SMA.Text = "?";
            buttonAns_SMA.UseVisualStyleBackColor = false;
            buttonAns_SMA.Click += buttonAns_SMA_Click;
            // 
            // buttonRes_SMA
            // 
            buttonRes_SMA.BackColor = Color.FromArgb(128, 128, 255);
            buttonRes_SMA.Cursor = Cursors.Hand;
            buttonRes_SMA.Location = new Point(439, 353);
            buttonRes_SMA.Name = "buttonRes_SMA";
            buttonRes_SMA.Size = new Size(106, 59);
            buttonRes_SMA.TabIndex = 1;
            buttonRes_SMA.Text = "Выполнить";
            buttonRes_SMA.UseVisualStyleBackColor = false;
            buttonRes_SMA.Click += buttonRes_SMA_Click;
            buttonRes_SMA.MouseDown += buttonRes_SMA_MouseDown;
            buttonRes_SMA.MouseEnter += buttonRes_SMA_MouseEnter;
            buttonRes_SMA.MouseLeave += buttonRes_SMA_MouseLeave;
            // 
            // FormTask_SMA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1054, 450);
            Controls.Add(buttonRes_SMA);
            Controls.Add(buttonAns_SMA);
            Controls.Add(groupBoxInput_SMA);
            Controls.Add(groupBoxRes_SMA);
            Controls.Add(groupBoxTask_SMA);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "FormTask_SMA";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 2 | Вариант 23 | Щапов М. А.";
            groupBoxTask_SMA.ResumeLayout(false);
            groupBoxTask_SMA.PerformLayout();
            groupBoxRes_SMA.ResumeLayout(false);
            groupBoxRes_SMA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_SMA).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes_SMA).EndInit();
            groupBoxInput_SMA.ResumeLayout(false);
            groupBoxInput_SMA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_SMA;
        private GroupBox groupBoxRes_SMA;
        private GroupBox groupBoxInput_SMA;
        private TextBox textBoxValInEnd_SMA;
        private TextBox textBoxValInSt_SMA;
        private Button buttonAns_SMA;
        private Button buttonRes_SMA;
        private TextBox textBoxEnd_SMA;
        private TextBox textBoxSt_SMA;
        private TextBox textBoxTask_SMA;
        private DataGridView dataGridViewRes_SMA;
        private TextBox textBoxRs_SMA;
        private DataGridViewTextBoxColumn ColumnX_SMA;
        private DataGridViewTextBoxColumn ColumnF_SMA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_SMA;
    }
}
