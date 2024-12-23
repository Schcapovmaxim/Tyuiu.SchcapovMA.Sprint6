namespace Tyuiu.SchcapovMA.Sprint6.Task6.V11
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBoxCat_SMA = new PictureBox();
            buttonOk_SMA = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCat_SMA).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxCat_SMA
            // 
            pictureBoxCat_SMA.Image = (Image)resources.GetObject("pictureBoxCat_SMA.Image");
            pictureBoxCat_SMA.Location = new Point(42, 12);
            pictureBoxCat_SMA.Name = "pictureBoxCat_SMA";
            pictureBoxCat_SMA.Size = new Size(190, 250);
            pictureBoxCat_SMA.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxCat_SMA.TabIndex = 0;
            pictureBoxCat_SMA.TabStop = false;
            // 
            // buttonOk_SMA
            // 
            buttonOk_SMA.Location = new Point(554, 240);
            buttonOk_SMA.Name = "buttonOk_SMA";
            buttonOk_SMA.Size = new Size(94, 29);
            buttonOk_SMA.TabIndex = 2;
            buttonOk_SMA.Text = "Ок";
            buttonOk_SMA.UseVisualStyleBackColor = true;
            buttonOk_SMA.Click += buttonOk_SMA_Click;
            // 
            // label1
            // 
            label1.Location = new Point(272, 24);
            label1.Name = "label1";
            label1.Size = new Size(366, 200);
            label1.TabIndex = 3;
            label1.Text = resources.GetString("label1.Text");
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 281);
            Controls.Add(label1);
            Controls.Add(buttonOk_SMA);
            Controls.Add(pictureBoxCat_SMA);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxCat_SMA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxCat_SMA;
        private Button buttonOk_SMA;
        private Label label1;
    }
}