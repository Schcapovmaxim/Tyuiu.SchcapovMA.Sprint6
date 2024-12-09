namespace Tyuiu.SchcapovMA.Sprint6.Task0.V13
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
            groupBoxTask = new GroupBox();
            pictureBoxFormule_SMA = new PictureBox();
            textBoxTask_SMA = new TextBox();
            groupBoxOutput_SMA = new GroupBox();
            textBoxRes_SMA = new TextBox();
            textBoxResult_SMA = new TextBox();
            buttonDoneAnswer_SMA = new Button();
            buttonDoneRes_SMA = new Button();
            groupBoxTaskInput_SMA = new GroupBox();
            textBoxValX_SMA = new TextBox();
            textBoxValueX_SMA = new TextBox();
            groupBoxTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormule_SMA).BeginInit();
            groupBoxOutput_SMA.SuspendLayout();
            groupBoxTaskInput_SMA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(pictureBoxFormule_SMA);
            groupBoxTask.Controls.Add(textBoxTask_SMA);
            groupBoxTask.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxTask.Location = new Point(12, 22);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(595, 141);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // pictureBoxFormule_SMA
            // 
            pictureBoxFormule_SMA.Image = Properties.Resources.такс0;
            pictureBoxFormule_SMA.Location = new Point(283, 60);
            pictureBoxFormule_SMA.Name = "pictureBoxFormule_SMA";
            pictureBoxFormule_SMA.Size = new Size(125, 62);
            pictureBoxFormule_SMA.TabIndex = 0;
            pictureBoxFormule_SMA.TabStop = false;
            // 
            // textBoxTask_SMA
            // 
            textBoxTask_SMA.BackColor = SystemColors.Control;
            textBoxTask_SMA.BorderStyle = BorderStyle.None;
            textBoxTask_SMA.Location = new Point(6, 80);
            textBoxTask_SMA.Multiline = true;
            textBoxTask_SMA.Name = "textBoxTask_SMA";
            textBoxTask_SMA.ReadOnly = true;
            textBoxTask_SMA.Size = new Size(333, 27);
            textBoxTask_SMA.TabIndex = 5;
            textBoxTask_SMA.Text = "Вычислить выражение по формуле";
            // 
            // groupBoxOutput_SMA
            // 
            groupBoxOutput_SMA.Controls.Add(textBoxRes_SMA);
            groupBoxOutput_SMA.Controls.Add(textBoxResult_SMA);
            groupBoxOutput_SMA.Location = new Point(351, 256);
            groupBoxOutput_SMA.Name = "groupBoxOutput_SMA";
            groupBoxOutput_SMA.Size = new Size(250, 100);
            groupBoxOutput_SMA.TabIndex = 1;
            groupBoxOutput_SMA.TabStop = false;
            groupBoxOutput_SMA.Text = "Вывод данных";
            // 
            // textBoxRes_SMA
            // 
            textBoxRes_SMA.BackColor = SystemColors.Control;
            textBoxRes_SMA.BorderStyle = BorderStyle.None;
            textBoxRes_SMA.Location = new Point(72, 26);
            textBoxRes_SMA.Name = "textBoxRes_SMA";
            textBoxRes_SMA.ReadOnly = true;
            textBoxRes_SMA.Size = new Size(125, 20);
            textBoxRes_SMA.TabIndex = 8;
            textBoxRes_SMA.Text = "Результат";
            // 
            // textBoxResult_SMA
            // 
            textBoxResult_SMA.BackColor = SystemColors.Control;
            textBoxResult_SMA.Cursor = Cursors.No;
            textBoxResult_SMA.Location = new Point(69, 53);
            textBoxResult_SMA.Name = "textBoxResult_SMA";
            textBoxResult_SMA.ReadOnly = true;
            textBoxResult_SMA.Size = new Size(125, 27);
            textBoxResult_SMA.TabIndex = 3;
            // 
            // buttonDoneAnswer_SMA
            // 
            buttonDoneAnswer_SMA.Cursor = Cursors.Help;
            buttonDoneAnswer_SMA.FlatStyle = FlatStyle.Flat;
            buttonDoneAnswer_SMA.Location = new Point(378, 362);
            buttonDoneAnswer_SMA.Name = "buttonDoneAnswer_SMA";
            buttonDoneAnswer_SMA.Size = new Size(30, 29);
            buttonDoneAnswer_SMA.TabIndex = 7;
            buttonDoneAnswer_SMA.Text = "?";
            buttonDoneAnswer_SMA.UseVisualStyleBackColor = true;
            buttonDoneAnswer_SMA.Click += buttonDoneAnswer_SMA_Click;
            // 
            // buttonDoneRes_SMA
            // 
            buttonDoneRes_SMA.Cursor = Cursors.Hand;
            buttonDoneRes_SMA.Location = new Point(423, 362);
            buttonDoneRes_SMA.Name = "buttonDoneRes_SMA";
            buttonDoneRes_SMA.Size = new Size(128, 29);
            buttonDoneRes_SMA.TabIndex = 2;
            buttonDoneRes_SMA.Text = "Выполнить";
            buttonDoneRes_SMA.UseVisualStyleBackColor = true;
            buttonDoneRes_SMA.Click += buttonDoneRes_SMA_Click;
            // 
            // groupBoxTaskInput_SMA
            // 
            groupBoxTaskInput_SMA.Controls.Add(textBoxValX_SMA);
            groupBoxTaskInput_SMA.Controls.Add(textBoxValueX_SMA);
            groupBoxTaskInput_SMA.Location = new Point(6, 256);
            groupBoxTaskInput_SMA.Name = "groupBoxTaskInput_SMA";
            groupBoxTaskInput_SMA.Size = new Size(339, 125);
            groupBoxTaskInput_SMA.TabIndex = 0;
            groupBoxTaskInput_SMA.TabStop = false;
            groupBoxTaskInput_SMA.Text = "Ввод данных";
            // 
            // textBoxValX_SMA
            // 
            textBoxValX_SMA.BackColor = SystemColors.Control;
            textBoxValX_SMA.BorderStyle = BorderStyle.None;
            textBoxValX_SMA.Location = new Point(65, 26);
            textBoxValX_SMA.Name = "textBoxValX_SMA";
            textBoxValX_SMA.ReadOnly = true;
            textBoxValX_SMA.Size = new Size(125, 20);
            textBoxValX_SMA.TabIndex = 6;
            textBoxValX_SMA.Text = "Переменная X:";
            // 
            // textBoxValueX_SMA
            // 
            textBoxValueX_SMA.Location = new Point(65, 64);
            textBoxValueX_SMA.Name = "textBoxValueX_SMA";
            textBoxValueX_SMA.Size = new Size(125, 27);
            textBoxValueX_SMA.TabIndex = 4;
            textBoxValueX_SMA.KeyPress += textBoxValueX_SMA_KeyPress;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 412);
            Controls.Add(groupBoxTaskInput_SMA);
            Controls.Add(buttonDoneAnswer_SMA);
            Controls.Add(groupBoxTask);
            Controls.Add(buttonDoneRes_SMA);
            Controls.Add(groupBoxOutput_SMA);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 13 | Щапов М. А.";
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormule_SMA).EndInit();
            groupBoxOutput_SMA.ResumeLayout(false);
            groupBoxOutput_SMA.PerformLayout();
            groupBoxTaskInput_SMA.ResumeLayout(false);
            groupBoxTaskInput_SMA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask;
        private PictureBox pictureBoxFormule_SMA;
        private GroupBox groupBoxOutput_SMA;
        private GroupBox groupBoxTaskInput_SMA;
        private Button buttonDoneRes_SMA;
        private TextBox textBoxTask_SMA;
        private TextBox textBoxResult_SMA;
        private TextBox textBoxValueX_SMA;
        private TextBox textBoxValX_SMA;
        private TextBox textBoxRes_SMA;
        private Button buttonDoneAnswer_SMA;
    }
}
