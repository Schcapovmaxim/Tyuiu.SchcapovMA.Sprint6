namespace Tyuiu.SchcapovMA.Sprint6.Task1.V26
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
            textBoxTask_SMA = new TextBox();
            groupBoxInput_SMA = new GroupBox();
            textBoxInEnd_SMA = new TextBox();
            textBoxInStart_SMA = new TextBox();
            textBoxInValEnd_SMA = new TextBox();
            textBoxInValStart_SMA = new TextBox();
            groupBoxResult_SMA = new GroupBox();
            textBoxOutRes_SMA = new TextBox();
            textBoxResult_SMA = new TextBox();
            buttonAnswer_SMA = new Button();
            buttonRes_SMA = new Button();
            groupBoxTask_SMA.SuspendLayout();
            groupBoxInput_SMA.SuspendLayout();
            groupBoxResult_SMA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_SMA
            // 
            groupBoxTask_SMA.Controls.Add(textBoxTask_SMA);
            groupBoxTask_SMA.Location = new Point(0, 0);
            groupBoxTask_SMA.Name = "groupBoxTask_SMA";
            groupBoxTask_SMA.Size = new Size(544, 316);
            groupBoxTask_SMA.TabIndex = 0;
            groupBoxTask_SMA.TabStop = false;
            groupBoxTask_SMA.Text = "Условие";
            // 
            // textBoxTask_SMA
            // 
            textBoxTask_SMA.BackColor = SystemColors.Control;
            textBoxTask_SMA.BorderStyle = BorderStyle.None;
            textBoxTask_SMA.Location = new Point(6, 26);
            textBoxTask_SMA.Multiline = true;
            textBoxTask_SMA.Name = "textBoxTask_SMA";
            textBoxTask_SMA.ReadOnly = true;
            textBoxTask_SMA.Size = new Size(496, 67);
            textBoxTask_SMA.TabIndex = 0;
            textBoxTask_SMA.Text = "Написать программу, которая выводит таблицу значений функции:\r\nF(x) = (2cos(x))/(2x-1)+2 + cos(x) - 5x + 3 \r\n(произвести табулирование) f(x) на заданном диапазоне.\r\n";
            // 
            // groupBoxInput_SMA
            // 
            groupBoxInput_SMA.Controls.Add(textBoxInEnd_SMA);
            groupBoxInput_SMA.Controls.Add(textBoxInStart_SMA);
            groupBoxInput_SMA.Controls.Add(textBoxInValEnd_SMA);
            groupBoxInput_SMA.Controls.Add(textBoxInValStart_SMA);
            groupBoxInput_SMA.Location = new Point(12, 332);
            groupBoxInput_SMA.Name = "groupBoxInput_SMA";
            groupBoxInput_SMA.Size = new Size(314, 106);
            groupBoxInput_SMA.TabIndex = 0;
            groupBoxInput_SMA.TabStop = false;
            groupBoxInput_SMA.Text = "Ввод данных";
            // 
            // textBoxInEnd_SMA
            // 
            textBoxInEnd_SMA.BackColor = SystemColors.Control;
            textBoxInEnd_SMA.BorderStyle = BorderStyle.None;
            textBoxInEnd_SMA.Location = new Point(137, 35);
            textBoxInEnd_SMA.Name = "textBoxInEnd_SMA";
            textBoxInEnd_SMA.ReadOnly = true;
            textBoxInEnd_SMA.Size = new Size(125, 20);
            textBoxInEnd_SMA.TabIndex = 4;
            textBoxInEnd_SMA.Text = "Конец шага:";
            // 
            // textBoxInStart_SMA
            // 
            textBoxInStart_SMA.BackColor = SystemColors.Control;
            textBoxInStart_SMA.BorderStyle = BorderStyle.None;
            textBoxInStart_SMA.Location = new Point(6, 35);
            textBoxInStart_SMA.Name = "textBoxInStart_SMA";
            textBoxInStart_SMA.ReadOnly = true;
            textBoxInStart_SMA.Size = new Size(125, 20);
            textBoxInStart_SMA.TabIndex = 3;
            textBoxInStart_SMA.Text = "Старт шага:";
            // 
            // textBoxInValEnd_SMA
            // 
            textBoxInValEnd_SMA.Location = new Point(137, 73);
            textBoxInValEnd_SMA.Name = "textBoxInValEnd_SMA";
            textBoxInValEnd_SMA.Size = new Size(125, 27);
            textBoxInValEnd_SMA.TabIndex = 2;
            textBoxInValEnd_SMA.KeyPress += textBoxInValStart_SMA_KeyPress;
            // 
            // textBoxInValStart_SMA
            // 
            textBoxInValStart_SMA.Location = new Point(6, 73);
            textBoxInValStart_SMA.Name = "textBoxInValStart_SMA";
            textBoxInValStart_SMA.Size = new Size(125, 27);
            textBoxInValStart_SMA.TabIndex = 1;
            textBoxInValStart_SMA.KeyPress += textBoxInValStart_SMA_KeyPress;
            // 
            // groupBoxResult_SMA
            // 
            groupBoxResult_SMA.Controls.Add(textBoxOutRes_SMA);
            groupBoxResult_SMA.Controls.Add(textBoxResult_SMA);
            groupBoxResult_SMA.Dock = DockStyle.Right;
            groupBoxResult_SMA.Location = new Point(567, 0);
            groupBoxResult_SMA.Name = "groupBoxResult_SMA";
            groupBoxResult_SMA.Size = new Size(250, 450);
            groupBoxResult_SMA.TabIndex = 0;
            groupBoxResult_SMA.TabStop = false;
            groupBoxResult_SMA.Text = "Вывод данных";
            // 
            // textBoxOutRes_SMA
            // 
            textBoxOutRes_SMA.BackColor = SystemColors.Control;
            textBoxOutRes_SMA.BorderStyle = BorderStyle.None;
            textBoxOutRes_SMA.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxOutRes_SMA.Location = new Point(6, 85);
            textBoxOutRes_SMA.Multiline = true;
            textBoxOutRes_SMA.Name = "textBoxOutRes_SMA";
            textBoxOutRes_SMA.ScrollBars = ScrollBars.Vertical;
            textBoxOutRes_SMA.Size = new Size(235, 347);
            textBoxOutRes_SMA.TabIndex = 9;
            // 
            // textBoxResult_SMA
            // 
            textBoxResult_SMA.BackColor = SystemColors.Control;
            textBoxResult_SMA.BorderStyle = BorderStyle.None;
            textBoxResult_SMA.Location = new Point(6, 59);
            textBoxResult_SMA.Name = "textBoxResult_SMA";
            textBoxResult_SMA.ReadOnly = true;
            textBoxResult_SMA.Size = new Size(125, 20);
            textBoxResult_SMA.TabIndex = 7;
            textBoxResult_SMA.Text = "Результат:";
            // 
            // buttonAnswer_SMA
            // 
            buttonAnswer_SMA.BackColor = Color.DarkTurquoise;
            buttonAnswer_SMA.Cursor = Cursors.Help;
            buttonAnswer_SMA.Location = new Point(332, 355);
            buttonAnswer_SMA.Name = "buttonAnswer_SMA";
            buttonAnswer_SMA.Size = new Size(108, 81);
            buttonAnswer_SMA.TabIndex = 5;
            buttonAnswer_SMA.Text = "Справка";
            buttonAnswer_SMA.UseVisualStyleBackColor = false;
            buttonAnswer_SMA.Click += buttonAnswer_SMA_Click;
            // 
            // buttonRes_SMA
            // 
            buttonRes_SMA.BackColor = Color.GreenYellow;
            buttonRes_SMA.Cursor = Cursors.Hand;
            buttonRes_SMA.Location = new Point(446, 355);
            buttonRes_SMA.Name = "buttonRes_SMA";
            buttonRes_SMA.Size = new Size(99, 81);
            buttonRes_SMA.TabIndex = 6;
            buttonRes_SMA.Text = "Выполнить";
            buttonRes_SMA.UseVisualStyleBackColor = false;
            buttonRes_SMA.Click += buttonRes_SMA_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 450);
            Controls.Add(buttonRes_SMA);
            Controls.Add(buttonAnswer_SMA);
            Controls.Add(groupBoxInput_SMA);
            Controls.Add(groupBoxResult_SMA);
            Controls.Add(groupBoxTask_SMA);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 1 | Вариант 26 | Щапов М. А.";
            groupBoxTask_SMA.ResumeLayout(false);
            groupBoxTask_SMA.PerformLayout();
            groupBoxInput_SMA.ResumeLayout(false);
            groupBoxInput_SMA.PerformLayout();
            groupBoxResult_SMA.ResumeLayout(false);
            groupBoxResult_SMA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_SMA;
        private TextBox textBoxTask_SMA;
        private GroupBox groupBoxInput_SMA;
        private TextBox textBoxInEnd_SMA;
        private TextBox textBoxInStart_SMA;
        private TextBox textBoxInValEnd_SMA;
        private TextBox textBoxInValStart_SMA;
        private GroupBox groupBoxResult_SMA;
        private Button buttonAnswer_SMA;
        private TextBox textBoxResult_SMA;
        private Button buttonRes_SMA;
        private TextBox textBoxOutRes_SMA;
    }
}
