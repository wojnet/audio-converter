namespace audio_converter
{
    partial class Form1
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
            chooseAudioButton = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            logo = new Label();
            fileComponentList = new TableLayoutPanel();
            convertButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // chooseAudioButton
            // 
            chooseAudioButton.Cursor = Cursors.Hand;
            chooseAudioButton.Location = new Point(90, 110);
            chooseAudioButton.Name = "chooseAudioButton";
            chooseAudioButton.Size = new Size(200, 50);
            chooseAudioButton.TabIndex = 0;
            chooseAudioButton.Text = "choose audio files";
            chooseAudioButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Arrow;
            pictureBox1.Location = new Point(107, 200);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(162, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Location = new Point(107, 170);
            label1.Name = "label1";
            label1.Size = new Size(162, 20);
            label1.TabIndex = 2;
            label1.Text = "...or drop them here";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // logo
            // 
            logo.AutoSize = true;
            logo.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold);
            logo.ForeColor = Color.DodgerBlue;
            logo.Location = new Point(52, 43);
            logo.Name = "logo";
            logo.Size = new Size(284, 37);
            logo.TabIndex = 3;
            logo.Text = "SMOKE CONVERTER";
            logo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // fileComponentList
            // 
            fileComponentList.AutoScroll = true;
            fileComponentList.ColumnCount = 4;
            fileComponentList.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 46F));
            fileComponentList.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 146F));
            fileComponentList.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 107F));
            fileComponentList.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 37F));
            fileComponentList.Location = new Point(12, 268);
            fileComponentList.Name = "fileComponentList";
            fileComponentList.Size = new Size(358, 223);
            fileComponentList.TabIndex = 0;
            // 
            // convertButton
            // 
            convertButton.Cursor = Cursors.Hand;
            convertButton.Location = new Point(143, 510);
            convertButton.Name = "convertButton";
            convertButton.Size = new Size(94, 29);
            convertButton.TabIndex = 4;
            convertButton.Text = "convert";
            convertButton.UseVisualStyleBackColor = true;
            convertButton.Click += convertButton_Click;
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 553);
            Controls.Add(convertButton);
            Controls.Add(fileComponentList);
            Controls.Add(logo);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(chooseAudioButton);
            MaximizeBox = false;
            MaximumSize = new Size(400, 600);
            MinimumSize = new Size(400, 600);
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SMOKE CONVERTER";
            DragDrop += Form1_DragDrop;
            DragEnter += Form1_DragEnter;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button chooseAudioButton;
        private PictureBox pictureBox1;
        private Label label1;
        private Label logo;
        private TableLayoutPanel fileComponentList;
        private Button convertButton;
    }
}
