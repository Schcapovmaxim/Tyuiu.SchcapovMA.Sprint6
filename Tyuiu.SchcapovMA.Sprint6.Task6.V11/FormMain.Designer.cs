namespace Tyuiu.SchcapovMA.Sprint6.Task6.V11
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelHead_SMA = new Panel();
            OpenFile_SMA = new Button();
            buttonDone_SMA = new Button();
            buttonHelp_SMA = new Button();
            groupBoxTask_SMA = new GroupBox();
            textBoxTask_SMA = new TextBox();
            panelInPut_SMA = new Panel();
            groupBoxInPut_SMA = new GroupBox();
            textBoxInPut_SMA = new TextBox();
            panelOutPut_SMA = new Panel();
            splitter_SMA = new Splitter();
            groupBoxOutPut_SMA = new GroupBox();
            textBoxOutPut_SMA = new TextBox();
            openFileDialogTask_SMA = new OpenFileDialog();
            toolTip_SMA = new ToolTip(components);
            panelHead_SMA.SuspendLayout();
            groupBoxTask_SMA.SuspendLayout();
            panelInPut_SMA.SuspendLayout();
            groupBoxInPut_SMA.SuspendLayout();
            panelOutPut_SMA.SuspendLayout();
            groupBoxOutPut_SMA.SuspendLayout();
            SuspendLayout();
            // 
            // panelHead_SMA
            // 
            panelHead_SMA.Controls.Add(OpenFile_SMA);
            panelHead_SMA.Controls.Add(buttonDone_SMA);
            panelHead_SMA.Controls.Add(buttonHelp_SMA);
            panelHead_SMA.Controls.Add(groupBoxTask_SMA);
            panelHead_SMA.Dock = DockStyle.Top;
            panelHead_SMA.Location = new Point(0, 0);
            panelHead_SMA.Name = "panelHead_SMA";
            panelHead_SMA.Size = new Size(877, 161);
            panelHead_SMA.TabIndex = 0;
            // 
            // OpenFile_SMA
            // 
            OpenFile_SMA.Cursor = Cursors.Hand;
            OpenFile_SMA.Image = (Image)resources.GetObject("OpenFile_SMA.Image");
            OpenFile_SMA.Location = new Point(53, 7);
            OpenFile_SMA.Name = "OpenFile_SMA";
            OpenFile_SMA.Size = new Size(80, 75);
            OpenFile_SMA.TabIndex = 1;
            toolTip_SMA.SetToolTip(OpenFile_SMA, "Открыть файл\r\nВыберите нужный файл для обработки");
            OpenFile_SMA.UseVisualStyleBackColor = true;
            OpenFile_SMA.Click += OpenFile_SMA_Click;
            // 
            // buttonDone_SMA
            // 
            buttonDone_SMA.Cursor = Cursors.Hand;
            buttonDone_SMA.Enabled = false;
            buttonDone_SMA.Image = (Image)resources.GetObject("buttonDone_SMA.Image");
            buttonDone_SMA.Location = new Point(161, 7);
            buttonDone_SMA.Name = "buttonDone_SMA";
            buttonDone_SMA.Size = new Size(80, 75);
            buttonDone_SMA.TabIndex = 2;
            toolTip_SMA.SetToolTip(buttonDone_SMA, "Производит поиск в файле и выводит предпоследнее слово каждой строки");
            buttonDone_SMA.UseVisualStyleBackColor = true;
            buttonDone_SMA.Click += buttonDone_SMA_Click;
            // 
            // buttonHelp_SMA
            // 
            buttonHelp_SMA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_SMA.Cursor = Cursors.Help;
            buttonHelp_SMA.Image = (Image)resources.GetObject("buttonHelp_SMA.Image");
            buttonHelp_SMA.Location = new Point(785, 7);
            buttonHelp_SMA.Name = "buttonHelp_SMA";
            buttonHelp_SMA.Size = new Size(80, 75);
            buttonHelp_SMA.TabIndex = 3;
            toolTip_SMA.SetToolTip(buttonHelp_SMA, "Сведения о программе");
            buttonHelp_SMA.UseVisualStyleBackColor = true;
            buttonHelp_SMA.Click += buttonHelp_SMA_Click;
            // 
            // groupBoxTask_SMA
            // 
            groupBoxTask_SMA.Controls.Add(textBoxTask_SMA);
            groupBoxTask_SMA.Dock = DockStyle.Bottom;
            groupBoxTask_SMA.Location = new Point(0, 88);
            groupBoxTask_SMA.Name = "groupBoxTask_SMA";
            groupBoxTask_SMA.Size = new Size(877, 73);
            groupBoxTask_SMA.TabIndex = 2;
            groupBoxTask_SMA.TabStop = false;
            groupBoxTask_SMA.Text = "Условие:";
            // 
            // textBoxTask_SMA
            // 
            textBoxTask_SMA.BorderStyle = BorderStyle.None;
            textBoxTask_SMA.Dock = DockStyle.Fill;
            textBoxTask_SMA.Location = new Point(3, 23);
            textBoxTask_SMA.Multiline = true;
            textBoxTask_SMA.Name = "textBoxTask_SMA";
            textBoxTask_SMA.ReadOnly = true;
            textBoxTask_SMA.Size = new Size(871, 47);
            textBoxTask_SMA.TabIndex = 0;
            textBoxTask_SMA.TabStop = false;
            textBoxTask_SMA.Text = resources.GetString("textBoxTask_SMA.Text");
            // 
            // panelInPut_SMA
            // 
            panelInPut_SMA.Controls.Add(groupBoxInPut_SMA);
            panelInPut_SMA.Dock = DockStyle.Left;
            panelInPut_SMA.Location = new Point(0, 161);
            panelInPut_SMA.Name = "panelInPut_SMA";
            panelInPut_SMA.Size = new Size(427, 357);
            panelInPut_SMA.TabIndex = 0;
            // 
            // groupBoxInPut_SMA
            // 
            groupBoxInPut_SMA.Controls.Add(textBoxInPut_SMA);
            groupBoxInPut_SMA.Dock = DockStyle.Fill;
            groupBoxInPut_SMA.Location = new Point(0, 0);
            groupBoxInPut_SMA.Name = "groupBoxInPut_SMA";
            groupBoxInPut_SMA.Size = new Size(427, 357);
            groupBoxInPut_SMA.TabIndex = 2;
            groupBoxInPut_SMA.TabStop = false;
            groupBoxInPut_SMA.Text = "Ввод:";
            // 
            // textBoxInPut_SMA
            // 
            textBoxInPut_SMA.Dock = DockStyle.Fill;
            textBoxInPut_SMA.Enabled = false;
            textBoxInPut_SMA.Location = new Point(3, 23);
            textBoxInPut_SMA.Multiline = true;
            textBoxInPut_SMA.Name = "textBoxInPut_SMA";
            textBoxInPut_SMA.ReadOnly = true;
            textBoxInPut_SMA.Size = new Size(421, 331);
            textBoxInPut_SMA.TabIndex = 1;
            // 
            // panelOutPut_SMA
            // 
            panelOutPut_SMA.Controls.Add(splitter_SMA);
            panelOutPut_SMA.Controls.Add(groupBoxOutPut_SMA);
            panelOutPut_SMA.Dock = DockStyle.Fill;
            panelOutPut_SMA.Location = new Point(427, 161);
            panelOutPut_SMA.Name = "panelOutPut_SMA";
            panelOutPut_SMA.Size = new Size(450, 357);
            panelOutPut_SMA.TabIndex = 0;
            // 
            // splitter_SMA
            // 
            splitter_SMA.Location = new Point(0, 0);
            splitter_SMA.Name = "splitter_SMA";
            splitter_SMA.Size = new Size(10, 357);
            splitter_SMA.TabIndex = 1;
            splitter_SMA.TabStop = false;
            // 
            // groupBoxOutPut_SMA
            // 
            groupBoxOutPut_SMA.Controls.Add(textBoxOutPut_SMA);
            groupBoxOutPut_SMA.Dock = DockStyle.Fill;
            groupBoxOutPut_SMA.Location = new Point(0, 0);
            groupBoxOutPut_SMA.Name = "groupBoxOutPut_SMA";
            groupBoxOutPut_SMA.Size = new Size(450, 357);
            groupBoxOutPut_SMA.TabIndex = 0;
            groupBoxOutPut_SMA.TabStop = false;
            groupBoxOutPut_SMA.Text = "Вывод:";
            // 
            // textBoxOutPut_SMA
            // 
            textBoxOutPut_SMA.Dock = DockStyle.Fill;
            textBoxOutPut_SMA.Enabled = false;
            textBoxOutPut_SMA.Location = new Point(3, 23);
            textBoxOutPut_SMA.Multiline = true;
            textBoxOutPut_SMA.Name = "textBoxOutPut_SMA";
            textBoxOutPut_SMA.ReadOnly = true;
            textBoxOutPut_SMA.Size = new Size(444, 331);
            textBoxOutPut_SMA.TabIndex = 0;
            // 
            // openFileDialogTask_SMA
            // 
            openFileDialogTask_SMA.FileName = "openFileDialog1";
            // 
            // toolTip_SMA
            // 
            toolTip_SMA.ToolTipIcon = ToolTipIcon.Info;
            toolTip_SMA.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 518);
            Controls.Add(panelOutPut_SMA);
            Controls.Add(panelInPut_SMA);
            Controls.Add(panelHead_SMA);
            MinimumSize = new Size(895, 565);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 11 | Щапов М. А.";
            panelHead_SMA.ResumeLayout(false);
            groupBoxTask_SMA.ResumeLayout(false);
            groupBoxTask_SMA.PerformLayout();
            panelInPut_SMA.ResumeLayout(false);
            groupBoxInPut_SMA.ResumeLayout(false);
            groupBoxInPut_SMA.PerformLayout();
            panelOutPut_SMA.ResumeLayout(false);
            groupBoxOutPut_SMA.ResumeLayout(false);
            groupBoxOutPut_SMA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHead_SMA;
        private Panel panelInPut_SMA;
        private Panel panelOutPut_SMA;
        private GroupBox groupBoxInPut_SMA;
        private GroupBox groupBoxOutPut_SMA;
        private GroupBox groupBoxTask_SMA;
        private Splitter splitter_SMA;
        private TextBox textBoxTask_SMA;
        private Button OpenFile_SMA;
        private Button buttonDone_SMA;
        private Button buttonHelp_SMA;
        private TextBox textBoxInPut_SMA;
        private TextBox textBoxOutPut_SMA;
        private OpenFileDialog openFileDialogTask_SMA;
        private ToolTip toolTip_SMA;
    }
}
