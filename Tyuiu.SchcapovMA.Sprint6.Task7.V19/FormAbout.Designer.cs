namespace Tyuiu.SchcapovMA.Sprint6.Task7.V19
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
            label_SMA = new Label();
            pictureBoxCat_SMA = new PictureBox();
            buttonOk_SMA = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCat_SMA).BeginInit();
            SuspendLayout();
            // 
            // label_SMA
            // 
            label_SMA.AutoSize = true;
            label_SMA.Location = new Point(236, 24);
            label_SMA.Name = "label_SMA";
            label_SMA.Size = new Size(366, 180);
            label_SMA.TabIndex = 0;
            label_SMA.Text = resources.GetString("label_SMA.Text");
            // 
            // pictureBoxCat_SMA
            // 
            pictureBoxCat_SMA.Image = (Image)resources.GetObject("pictureBoxCat_SMA.Image");
            pictureBoxCat_SMA.Location = new Point(34, 24);
            pictureBoxCat_SMA.Name = "pictureBoxCat_SMA";
            pictureBoxCat_SMA.Size = new Size(175, 248);
            pictureBoxCat_SMA.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCat_SMA.TabIndex = 1;
            pictureBoxCat_SMA.TabStop = false;
            // 
            // buttonOk_SMA
            // 
            buttonOk_SMA.Image = (Image)resources.GetObject("buttonOk_SMA.Image");
            buttonOk_SMA.Location = new Point(490, 246);
            buttonOk_SMA.Name = "buttonOk_SMA";
            buttonOk_SMA.Size = new Size(90, 47);
            buttonOk_SMA.TabIndex = 2;
            buttonOk_SMA.TabStop = false;
            buttonOk_SMA.UseVisualStyleBackColor = true;
            buttonOk_SMA.Click += buttonOk_SMA_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 305);
            Controls.Add(buttonOk_SMA);
            Controls.Add(pictureBoxCat_SMA);
            Controls.Add(label_SMA);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAbout";
            ((System.ComponentModel.ISupportInitialize)pictureBoxCat_SMA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_SMA;
        private PictureBox pictureBoxCat_SMA;
        private Button buttonOk_SMA;
    }
}