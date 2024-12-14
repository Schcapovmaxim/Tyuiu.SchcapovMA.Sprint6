namespace Tyuiu.SchcapovMA.Sprint6.Task4.V18
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMaine));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            panelHead_SMA = new Panel();
            buttonAnswer_SMA = new Button();
            buttonSave_SMA = new Button();
            buttonRes_SMA = new Button();
            groupBoxIn_SMA = new GroupBox();
            textBoxValInEnd_SMA = new TextBox();
            textBoxValInSt_SMA = new TextBox();
            textBoxInEn_SMA = new TextBox();
            textBoxInSt_SMA = new TextBox();
            groupBoxTask_SMA = new GroupBox();
            textBoxTask_SMA = new TextBox();
            panel2 = new Panel();
            groupBoxTexOut_SMA = new GroupBox();
            textBoxOut_SMA = new TextBox();
            panel3 = new Panel();
            chartView_SMA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            splitter1 = new Splitter();
            panelHead_SMA.SuspendLayout();
            groupBoxIn_SMA.SuspendLayout();
            groupBoxTask_SMA.SuspendLayout();
            panel2.SuspendLayout();
            groupBoxTexOut_SMA.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartView_SMA).BeginInit();
            SuspendLayout();
            // 
            // panelHead_SMA
            // 
            panelHead_SMA.BackColor = Color.FromArgb(128, 255, 255);
            panelHead_SMA.Controls.Add(buttonAnswer_SMA);
            panelHead_SMA.Controls.Add(buttonSave_SMA);
            panelHead_SMA.Controls.Add(buttonRes_SMA);
            panelHead_SMA.Controls.Add(groupBoxIn_SMA);
            panelHead_SMA.Controls.Add(groupBoxTask_SMA);
            panelHead_SMA.Dock = DockStyle.Top;
            panelHead_SMA.Location = new Point(0, 0);
            panelHead_SMA.Name = "panelHead_SMA";
            panelHead_SMA.Size = new Size(982, 125);
            panelHead_SMA.TabIndex = 0;
            // 
            // buttonAnswer_SMA
            // 
            buttonAnswer_SMA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAnswer_SMA.BackColor = Color.FromArgb(0, 192, 192);
            buttonAnswer_SMA.Cursor = Cursors.Help;
            buttonAnswer_SMA.Location = new Point(879, 29);
            buttonAnswer_SMA.Name = "buttonAnswer_SMA";
            buttonAnswer_SMA.Size = new Size(95, 85);
            buttonAnswer_SMA.TabIndex = 5;
            buttonAnswer_SMA.Text = "Справка";
            buttonAnswer_SMA.UseVisualStyleBackColor = false;
            buttonAnswer_SMA.Click += buttonAnswer_SMA_Click;
            // 
            // buttonSave_SMA
            // 
            buttonSave_SMA.BackColor = Color.DodgerBlue;
            buttonSave_SMA.Cursor = Cursors.Hand;
            buttonSave_SMA.Location = new Point(779, 29);
            buttonSave_SMA.Name = "buttonSave_SMA";
            buttonSave_SMA.Size = new Size(95, 85);
            buttonSave_SMA.TabIndex = 4;
            buttonSave_SMA.Text = "Сохранить";
            buttonSave_SMA.UseVisualStyleBackColor = false;
            buttonSave_SMA.Click += buttonSave_SMA_Click;
            buttonSave_SMA.MouseDown += buttonSave_SMA_MouseDown;
            buttonSave_SMA.MouseEnter += buttonSave_SMA_MouseEnter;
            buttonSave_SMA.MouseLeave += buttonSave_SMA_MouseLeave;
            // 
            // buttonRes_SMA
            // 
            buttonRes_SMA.BackColor = Color.FromArgb(128, 128, 255);
            buttonRes_SMA.Cursor = Cursors.Hand;
            buttonRes_SMA.Location = new Point(679, 29);
            buttonRes_SMA.Name = "buttonRes_SMA";
            buttonRes_SMA.Size = new Size(95, 85);
            buttonRes_SMA.TabIndex = 3;
            buttonRes_SMA.Text = "Выполнить";
            buttonRes_SMA.UseVisualStyleBackColor = false;
            buttonRes_SMA.Click += buttonRes_SMA_Click;
            buttonRes_SMA.MouseDown += buttonRes_SMA_MouseDown;
            buttonRes_SMA.MouseEnter += buttonRes_SMA_MouseEnter;
            buttonRes_SMA.MouseLeave += buttonRes_SMA_MouseLeave;
            // 
            // groupBoxIn_SMA
            // 
            groupBoxIn_SMA.Controls.Add(textBoxValInEnd_SMA);
            groupBoxIn_SMA.Controls.Add(textBoxValInSt_SMA);
            groupBoxIn_SMA.Controls.Add(textBoxInEn_SMA);
            groupBoxIn_SMA.Controls.Add(textBoxInSt_SMA);
            groupBoxIn_SMA.Location = new Point(420, 3);
            groupBoxIn_SMA.Name = "groupBoxIn_SMA";
            groupBoxIn_SMA.Size = new Size(250, 116);
            groupBoxIn_SMA.TabIndex = 2;
            groupBoxIn_SMA.TabStop = false;
            groupBoxIn_SMA.Text = "Ввод данных:";
            // 
            // textBoxValInEnd_SMA
            // 
            textBoxValInEnd_SMA.Location = new Point(125, 64);
            textBoxValInEnd_SMA.Name = "textBoxValInEnd_SMA";
            textBoxValInEnd_SMA.Size = new Size(100, 27);
            textBoxValInEnd_SMA.TabIndex = 3;
            textBoxValInEnd_SMA.KeyPress += textBoxValInSt_SMA_KeyPress;
            // 
            // textBoxValInSt_SMA
            // 
            textBoxValInSt_SMA.Location = new Point(9, 64);
            textBoxValInSt_SMA.Name = "textBoxValInSt_SMA";
            textBoxValInSt_SMA.Size = new Size(100, 27);
            textBoxValInSt_SMA.TabIndex = 2;
            textBoxValInSt_SMA.KeyPress += textBoxValInSt_SMA_KeyPress;
            // 
            // textBoxInEn_SMA
            // 
            textBoxInEn_SMA.BackColor = Color.FromArgb(128, 255, 255);
            textBoxInEn_SMA.BorderStyle = BorderStyle.None;
            textBoxInEn_SMA.Location = new Point(119, 38);
            textBoxInEn_SMA.Name = "textBoxInEn_SMA";
            textBoxInEn_SMA.ReadOnly = true;
            textBoxInEn_SMA.Size = new Size(113, 20);
            textBoxInEn_SMA.TabIndex = 1;
            textBoxInEn_SMA.Text = "Конец шага:";
            // 
            // textBoxInSt_SMA
            // 
            textBoxInSt_SMA.BackColor = Color.FromArgb(128, 255, 255);
            textBoxInSt_SMA.BorderStyle = BorderStyle.None;
            textBoxInSt_SMA.Location = new Point(6, 38);
            textBoxInSt_SMA.Name = "textBoxInSt_SMA";
            textBoxInSt_SMA.ReadOnly = true;
            textBoxInSt_SMA.Size = new Size(106, 20);
            textBoxInSt_SMA.TabIndex = 0;
            textBoxInSt_SMA.Text = "Старт шага:";
            // 
            // groupBoxTask_SMA
            // 
            groupBoxTask_SMA.BackColor = Color.FromArgb(128, 255, 255);
            groupBoxTask_SMA.Controls.Add(textBoxTask_SMA);
            groupBoxTask_SMA.Location = new Point(12, 3);
            groupBoxTask_SMA.Name = "groupBoxTask_SMA";
            groupBoxTask_SMA.Padding = new Padding(1);
            groupBoxTask_SMA.Size = new Size(389, 116);
            groupBoxTask_SMA.TabIndex = 1;
            groupBoxTask_SMA.TabStop = false;
            groupBoxTask_SMA.Text = "Условие:";
            // 
            // textBoxTask_SMA
            // 
            textBoxTask_SMA.BackColor = Color.FromArgb(128, 255, 255);
            textBoxTask_SMA.BorderStyle = BorderStyle.None;
            textBoxTask_SMA.Location = new Point(6, 26);
            textBoxTask_SMA.Multiline = true;
            textBoxTask_SMA.Name = "textBoxTask_SMA";
            textBoxTask_SMA.ReadOnly = true;
            textBoxTask_SMA.Size = new Size(379, 84);
            textBoxTask_SMA.TabIndex = 0;
            textBoxTask_SMA.Text = resources.GetString("textBoxTask_SMA.Text");
            // 
            // panel2
            // 
            panel2.BackColor = Color.LimeGreen;
            panel2.Controls.Add(groupBoxTexOut_SMA);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 125);
            panel2.Name = "panel2";
            panel2.Size = new Size(247, 378);
            panel2.TabIndex = 0;
            // 
            // groupBoxTexOut_SMA
            // 
            groupBoxTexOut_SMA.BackColor = SystemColors.Control;
            groupBoxTexOut_SMA.Controls.Add(textBoxOut_SMA);
            groupBoxTexOut_SMA.Dock = DockStyle.Fill;
            groupBoxTexOut_SMA.Location = new Point(0, 0);
            groupBoxTexOut_SMA.Name = "groupBoxTexOut_SMA";
            groupBoxTexOut_SMA.Padding = new Padding(3, 5, 3, 3);
            groupBoxTexOut_SMA.Size = new Size(247, 378);
            groupBoxTexOut_SMA.TabIndex = 0;
            groupBoxTexOut_SMA.TabStop = false;
            groupBoxTexOut_SMA.Text = "Вывод:";
            // 
            // textBoxOut_SMA
            // 
            textBoxOut_SMA.BackColor = SystemColors.HighlightText;
            textBoxOut_SMA.Dock = DockStyle.Fill;
            textBoxOut_SMA.Location = new Point(3, 25);
            textBoxOut_SMA.Multiline = true;
            textBoxOut_SMA.Name = "textBoxOut_SMA";
            textBoxOut_SMA.ReadOnly = true;
            textBoxOut_SMA.ScrollBars = ScrollBars.Vertical;
            textBoxOut_SMA.Size = new Size(241, 350);
            textBoxOut_SMA.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(128, 128, 255);
            panel3.Controls.Add(chartView_SMA);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(247, 125);
            panel3.Name = "panel3";
            panel3.Size = new Size(735, 378);
            panel3.TabIndex = 0;
            // 
            // chartView_SMA
            // 
            chartArea1.Name = "ChartArea1";
            chartView_SMA.ChartAreas.Add(chartArea1);
            chartView_SMA.Dock = DockStyle.Fill;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            chartView_SMA.Legends.Add(legend1);
            chartView_SMA.Location = new Point(0, 0);
            chartView_SMA.Name = "chartView_SMA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartView_SMA.Series.Add(series1);
            chartView_SMA.Size = new Size(735, 378);
            chartView_SMA.TabIndex = 0;
            chartView_SMA.Text = "chart1";
            title1.Font = new Font("Microsoft Sans Serif", 11F);
            title1.ForeColor = Color.Blue;
            title1.Name = "Title1";
            title1.Text = "График функции 2x-3/(x+cos(x))+5";
            chartView_SMA.Titles.Add(title1);
            // 
            // splitter1
            // 
            splitter1.Location = new Point(247, 125);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 378);
            splitter1.TabIndex = 1;
            splitter1.TabStop = false;
            // 
            // FormMaine
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 503);
            Controls.Add(splitter1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panelHead_SMA);
            MinimumSize = new Size(1000, 500);
            Name = "FormMaine";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4 | Вариант 18 | Щапов М. А.";
            panelHead_SMA.ResumeLayout(false);
            groupBoxIn_SMA.ResumeLayout(false);
            groupBoxIn_SMA.PerformLayout();
            groupBoxTask_SMA.ResumeLayout(false);
            groupBoxTask_SMA.PerformLayout();
            panel2.ResumeLayout(false);
            groupBoxTexOut_SMA.ResumeLayout(false);
            groupBoxTexOut_SMA.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartView_SMA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHead_SMA;
        private Panel panel2;
        private Panel panel3;
        private Splitter splitter1;
        private GroupBox groupBoxTexOut_SMA;
        private TextBox textBoxOut_SMA;
        private GroupBox groupBoxTask_SMA;
        private TextBox textBoxTask_SMA;
        private GroupBox groupBoxIn_SMA;
        private TextBox textBoxValInEnd_SMA;
        private TextBox textBoxValInSt_SMA;
        private TextBox textBoxInEn_SMA;
        private TextBox textBoxInSt_SMA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartView_SMA;
        private Button buttonAnswer_SMA;
        private Button buttonSave_SMA;
        private Button buttonRes_SMA;
    }
}
