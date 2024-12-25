namespace Tyuiu.SchcapovMA.Sprint6.Task7.V19
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
            buttonOpenFile_SMA = new Button();
            buttonOutPutRes_SMA = new Button();
            buttonSaveFile_SMA = new Button();
            buttonHelp_SMA = new Button();
            panelTask_SMA = new Panel();
            groupBoxTask_SMA = new GroupBox();
            textBoxTask_SMA = new TextBox();
            splitContainerData_SMA = new SplitContainer();
            groupBoxInput_SMA = new GroupBox();
            dataGridViewInPut_SMA = new DataGridView();
            groupBoxOutPut_SMA = new GroupBox();
            dataGridViewOutPut_SMA = new DataGridView();
            saveFileDialog_SMA = new SaveFileDialog();
            toolTip_SMA = new ToolTip(components);
            openFileDialog_SMA = new OpenFileDialog();
            panelHead_SMA.SuspendLayout();
            panelTask_SMA.SuspendLayout();
            groupBoxTask_SMA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerData_SMA).BeginInit();
            splitContainerData_SMA.Panel1.SuspendLayout();
            splitContainerData_SMA.Panel2.SuspendLayout();
            splitContainerData_SMA.SuspendLayout();
            groupBoxInput_SMA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInPut_SMA).BeginInit();
            groupBoxOutPut_SMA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutPut_SMA).BeginInit();
            SuspendLayout();
            // 
            // panelHead_SMA
            // 
            panelHead_SMA.Controls.Add(buttonOpenFile_SMA);
            panelHead_SMA.Controls.Add(buttonOutPutRes_SMA);
            panelHead_SMA.Controls.Add(buttonSaveFile_SMA);
            panelHead_SMA.Controls.Add(buttonHelp_SMA);
            panelHead_SMA.Dock = DockStyle.Top;
            panelHead_SMA.Location = new Point(0, 0);
            panelHead_SMA.Name = "panelHead_SMA";
            panelHead_SMA.Size = new Size(812, 88);
            panelHead_SMA.TabIndex = 0;
            // 
            // buttonOpenFile_SMA
            // 
            buttonOpenFile_SMA.Cursor = Cursors.Hand;
            buttonOpenFile_SMA.Image = (Image)resources.GetObject("buttonOpenFile_SMA.Image");
            buttonOpenFile_SMA.Location = new Point(14, 12);
            buttonOpenFile_SMA.Name = "buttonOpenFile_SMA";
            buttonOpenFile_SMA.Size = new Size(77, 60);
            buttonOpenFile_SMA.TabIndex = 0;
            buttonOpenFile_SMA.TabStop = false;
            toolTip_SMA.SetToolTip(buttonOpenFile_SMA, "Выберите файл для чтения");
            buttonOpenFile_SMA.UseVisualStyleBackColor = true;
            buttonOpenFile_SMA.Click += buttonOpenFile_SMA_Click_1;
            // 
            // buttonOutPutRes_SMA
            // 
            buttonOutPutRes_SMA.Cursor = Cursors.Hand;
            buttonOutPutRes_SMA.Enabled = false;
            buttonOutPutRes_SMA.Image = (Image)resources.GetObject("buttonOutPutRes_SMA.Image");
            buttonOutPutRes_SMA.Location = new Point(122, 12);
            buttonOutPutRes_SMA.Name = "buttonOutPutRes_SMA";
            buttonOutPutRes_SMA.Size = new Size(77, 60);
            buttonOutPutRes_SMA.TabIndex = 1;
            buttonOutPutRes_SMA.TabStop = false;
            toolTip_SMA.SetToolTip(buttonOutPutRes_SMA, "Нажмите для получения новой матрицы по условию задачи");
            buttonOutPutRes_SMA.UseVisualStyleBackColor = true;
            buttonOutPutRes_SMA.Click += buttonOutPutRes_SMA_Click_1;
            // 
            // buttonSaveFile_SMA
            // 
            buttonSaveFile_SMA.Cursor = Cursors.Hand;
            buttonSaveFile_SMA.Enabled = false;
            buttonSaveFile_SMA.Image = (Image)resources.GetObject("buttonSaveFile_SMA.Image");
            buttonSaveFile_SMA.Location = new Point(226, 12);
            buttonSaveFile_SMA.Name = "buttonSaveFile_SMA";
            buttonSaveFile_SMA.Size = new Size(77, 60);
            buttonSaveFile_SMA.TabIndex = 2;
            buttonSaveFile_SMA.TabStop = false;
            toolTip_SMA.SetToolTip(buttonSaveFile_SMA, "Сохранить файл");
            buttonSaveFile_SMA.UseVisualStyleBackColor = true;
            buttonSaveFile_SMA.Click += buttonSaveFile_SMA_Click;
            // 
            // buttonHelp_SMA
            // 
            buttonHelp_SMA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_SMA.Cursor = Cursors.Help;
            buttonHelp_SMA.Image = (Image)resources.GetObject("buttonHelp_SMA.Image");
            buttonHelp_SMA.Location = new Point(704, 12);
            buttonHelp_SMA.Name = "buttonHelp_SMA";
            buttonHelp_SMA.Size = new Size(77, 60);
            buttonHelp_SMA.TabIndex = 3;
            buttonHelp_SMA.TabStop = false;
            toolTip_SMA.SetToolTip(buttonHelp_SMA, "Справка");
            buttonHelp_SMA.UseVisualStyleBackColor = true;
            buttonHelp_SMA.Click += buttonHelp_SMA_Click;
            // 
            // panelTask_SMA
            // 
            panelTask_SMA.Controls.Add(groupBoxTask_SMA);
            panelTask_SMA.Dock = DockStyle.Top;
            panelTask_SMA.Location = new Point(0, 88);
            panelTask_SMA.Name = "panelTask_SMA";
            panelTask_SMA.Size = new Size(812, 99);
            panelTask_SMA.TabIndex = 1;
            // 
            // groupBoxTask_SMA
            // 
            groupBoxTask_SMA.Controls.Add(textBoxTask_SMA);
            groupBoxTask_SMA.Dock = DockStyle.Fill;
            groupBoxTask_SMA.Location = new Point(0, 0);
            groupBoxTask_SMA.Name = "groupBoxTask_SMA";
            groupBoxTask_SMA.Size = new Size(812, 99);
            groupBoxTask_SMA.TabIndex = 3;
            groupBoxTask_SMA.TabStop = false;
            groupBoxTask_SMA.Text = "Условие:";
            // 
            // textBoxTask_SMA
            // 
            textBoxTask_SMA.BackColor = SystemColors.Control;
            textBoxTask_SMA.BorderStyle = BorderStyle.None;
            textBoxTask_SMA.Dock = DockStyle.Fill;
            textBoxTask_SMA.Location = new Point(3, 23);
            textBoxTask_SMA.Multiline = true;
            textBoxTask_SMA.Name = "textBoxTask_SMA";
            textBoxTask_SMA.ReadOnly = true;
            textBoxTask_SMA.Size = new Size(806, 73);
            textBoxTask_SMA.TabIndex = 2;
            textBoxTask_SMA.TabStop = false;
            textBoxTask_SMA.Text = resources.GetString("textBoxTask_SMA.Text");
            // 
            // splitContainerData_SMA
            // 
            splitContainerData_SMA.BackColor = SystemColors.Control;
            splitContainerData_SMA.Dock = DockStyle.Fill;
            splitContainerData_SMA.Location = new Point(0, 187);
            splitContainerData_SMA.Name = "splitContainerData_SMA";
            // 
            // splitContainerData_SMA.Panel1
            // 
            splitContainerData_SMA.Panel1.BackColor = SystemColors.Control;
            splitContainerData_SMA.Panel1.Controls.Add(groupBoxInput_SMA);
            // 
            // splitContainerData_SMA.Panel2
            // 
            splitContainerData_SMA.Panel2.BackColor = SystemColors.Control;
            splitContainerData_SMA.Panel2.Controls.Add(groupBoxOutPut_SMA);
            splitContainerData_SMA.Size = new Size(812, 266);
            splitContainerData_SMA.SplitterDistance = 402;
            splitContainerData_SMA.TabIndex = 2;
            // 
            // groupBoxInput_SMA
            // 
            groupBoxInput_SMA.Controls.Add(dataGridViewInPut_SMA);
            groupBoxInput_SMA.Dock = DockStyle.Fill;
            groupBoxInput_SMA.Location = new Point(0, 0);
            groupBoxInput_SMA.Name = "groupBoxInput_SMA";
            groupBoxInput_SMA.Size = new Size(402, 266);
            groupBoxInput_SMA.TabIndex = 0;
            groupBoxInput_SMA.TabStop = false;
            groupBoxInput_SMA.Text = "Ввод:";
            // 
            // dataGridViewInPut_SMA
            // 
            dataGridViewInPut_SMA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInPut_SMA.ColumnHeadersVisible = false;
            dataGridViewInPut_SMA.Dock = DockStyle.Fill;
            dataGridViewInPut_SMA.Location = new Point(3, 23);
            dataGridViewInPut_SMA.Name = "dataGridViewInPut_SMA";
            dataGridViewInPut_SMA.RowHeadersVisible = false;
            dataGridViewInPut_SMA.RowHeadersWidth = 51;
            dataGridViewInPut_SMA.ScrollBars = ScrollBars.None;
            dataGridViewInPut_SMA.Size = new Size(396, 240);
            dataGridViewInPut_SMA.TabIndex = 0;
            // 
            // groupBoxOutPut_SMA
            // 
            groupBoxOutPut_SMA.Controls.Add(dataGridViewOutPut_SMA);
            groupBoxOutPut_SMA.Dock = DockStyle.Fill;
            groupBoxOutPut_SMA.Location = new Point(0, 0);
            groupBoxOutPut_SMA.Name = "groupBoxOutPut_SMA";
            groupBoxOutPut_SMA.Size = new Size(406, 266);
            groupBoxOutPut_SMA.TabIndex = 0;
            groupBoxOutPut_SMA.TabStop = false;
            groupBoxOutPut_SMA.Text = "Вывод:";
            // 
            // dataGridViewOutPut_SMA
            // 
            dataGridViewOutPut_SMA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutPut_SMA.ColumnHeadersVisible = false;
            dataGridViewOutPut_SMA.Dock = DockStyle.Fill;
            dataGridViewOutPut_SMA.Location = new Point(3, 23);
            dataGridViewOutPut_SMA.Name = "dataGridViewOutPut_SMA";
            dataGridViewOutPut_SMA.RowHeadersVisible = false;
            dataGridViewOutPut_SMA.RowHeadersWidth = 51;
            dataGridViewOutPut_SMA.ScrollBars = ScrollBars.None;
            dataGridViewOutPut_SMA.Size = new Size(400, 240);
            dataGridViewOutPut_SMA.TabIndex = 1;
            // 
            // toolTip_SMA
            // 
            toolTip_SMA.ToolTipIcon = ToolTipIcon.Info;
            toolTip_SMA.ToolTipTitle = "Подсказка";
            // 
            // openFileDialog_SMA
            // 
            openFileDialog_SMA.FileName = "openFileDialog_SMA";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 453);
            Controls.Add(splitContainerData_SMA);
            Controls.Add(panelTask_SMA);
            Controls.Add(panelHead_SMA);
            MinimumSize = new Size(830, 500);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7 | Вариант 19 | Щапов М. А.";
            Load += FormMain_Load;
            panelHead_SMA.ResumeLayout(false);
            panelTask_SMA.ResumeLayout(false);
            groupBoxTask_SMA.ResumeLayout(false);
            groupBoxTask_SMA.PerformLayout();
            splitContainerData_SMA.Panel1.ResumeLayout(false);
            splitContainerData_SMA.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerData_SMA).EndInit();
            splitContainerData_SMA.ResumeLayout(false);
            groupBoxInput_SMA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInPut_SMA).EndInit();
            groupBoxOutPut_SMA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutPut_SMA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHead_SMA;
        private Panel panelTask_SMA;
        private SplitContainer splitContainerData_SMA;
        private Button buttonOpenFile_SMA;
        private Button buttonOutPutRes_SMA;
        private Button buttonSaveFile_SMA;
        private Button buttonHelp_SMA;
        private GroupBox groupBoxTask_SMA;
        private TextBox textBoxTask_SMA;
        private GroupBox groupBoxInput_SMA;
        private DataGridView dataGridViewOutPut_SMA;
        private GroupBox groupBoxOutPut_SMA;
        private DataGridView dataGridViewInPut_SMA;
        private SaveFileDialog saveFileDialog_SMA;
        private ToolTip toolTip_SMA;
        private OpenFileDialog openFileDialog_SMA;
    }
}
