namespace CountryGuesser
{
    partial class Form2
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
            countryFlagPictureBox1 = new PictureBox();
            countryFlagPictureBox2 = new PictureBox();
            countryFlagPictureBox3 = new PictureBox();
            countryFlagPictureBox4 = new PictureBox();
            highScoreLabel = new Label();
            currentScoreLabel = new Label();
            exitButton = new Button();
            retryButton = new Button();
            indicatorLabel = new Label();
            correctAnswerLabel1 = new Label();
            correctAnswerLabel2 = new Label();
            correctAnswerLabel3 = new Label();
            correctAnswerLabel4 = new Label();
            countryNameLabel = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)countryFlagPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)countryFlagPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)countryFlagPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)countryFlagPictureBox4).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // countryFlagPictureBox1
            // 
            countryFlagPictureBox1.BackgroundImageLayout = ImageLayout.Center;
            countryFlagPictureBox1.Cursor = Cursors.Hand;
            countryFlagPictureBox1.Location = new Point(47, 160);
            countryFlagPictureBox1.MaximumSize = new Size(452, 239);
            countryFlagPictureBox1.MinimumSize = new Size(150, 75);
            countryFlagPictureBox1.Name = "countryFlagPictureBox1";
            countryFlagPictureBox1.Size = new Size(301, 159);
            countryFlagPictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            countryFlagPictureBox1.TabIndex = 1;
            countryFlagPictureBox1.TabStop = false;
            countryFlagPictureBox1.Click += countryFlag1_Click;
            // 
            // countryFlagPictureBox2
            // 
            countryFlagPictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            countryFlagPictureBox2.BackgroundImageLayout = ImageLayout.Center;
            countryFlagPictureBox2.Cursor = Cursors.Hand;
            countryFlagPictureBox2.Location = new Point(433, 160);
            countryFlagPictureBox2.MinimumSize = new Size(150, 75);
            countryFlagPictureBox2.Name = "countryFlagPictureBox2";
            countryFlagPictureBox2.Size = new Size(301, 159);
            countryFlagPictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            countryFlagPictureBox2.TabIndex = 2;
            countryFlagPictureBox2.TabStop = false;
            countryFlagPictureBox2.Click += countryFlag2_Click;
            // 
            // countryFlagPictureBox3
            // 
            countryFlagPictureBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            countryFlagPictureBox3.BackgroundImageLayout = ImageLayout.Center;
            countryFlagPictureBox3.Cursor = Cursors.Hand;
            countryFlagPictureBox3.Location = new Point(47, 380);
            countryFlagPictureBox3.MinimumSize = new Size(150, 75);
            countryFlagPictureBox3.Name = "countryFlagPictureBox3";
            countryFlagPictureBox3.Size = new Size(301, 159);
            countryFlagPictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            countryFlagPictureBox3.TabIndex = 3;
            countryFlagPictureBox3.TabStop = false;
            countryFlagPictureBox3.Click += countryFlag3_Click;
            // 
            // countryFlagPictureBox4
            // 
            countryFlagPictureBox4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            countryFlagPictureBox4.BackgroundImageLayout = ImageLayout.Center;
            countryFlagPictureBox4.Cursor = Cursors.Hand;
            countryFlagPictureBox4.Location = new Point(433, 380);
            countryFlagPictureBox4.MinimumSize = new Size(150, 75);
            countryFlagPictureBox4.Name = "countryFlagPictureBox4";
            countryFlagPictureBox4.Size = new Size(301, 159);
            countryFlagPictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            countryFlagPictureBox4.TabIndex = 4;
            countryFlagPictureBox4.TabStop = false;
            countryFlagPictureBox4.Click += countryFlag4_Click;
            // 
            // highScoreLabel
            // 
            highScoreLabel.AutoSize = true;
            highScoreLabel.Font = new Font("Segoe UI", 12.096F, FontStyle.Regular, GraphicsUnit.Point);
            highScoreLabel.Location = new Point(53, 27);
            highScoreLabel.Name = "highScoreLabel";
            highScoreLabel.Size = new Size(154, 30);
            highScoreLabel.TabIndex = 14;
            highScoreLabel.Text = "highScoreLabel";
            // 
            // currentScoreLabel
            // 
            currentScoreLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            currentScoreLabel.AutoSize = true;
            currentScoreLabel.Font = new Font("Segoe UI", 12.096F, FontStyle.Regular, GraphicsUnit.Point);
            currentScoreLabel.Location = new Point(555, 27);
            currentScoreLabel.Name = "currentScoreLabel";
            currentScoreLabel.Size = new Size(179, 30);
            currentScoreLabel.TabIndex = 15;
            currentScoreLabel.Text = "currentScoreLabel";
            // 
            // exitButton
            // 
            exitButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            exitButton.Location = new Point(594, 593);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(140, 44);
            exitButton.TabIndex = 16;
            exitButton.Text = "Exit to menu";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += button1_Click;
            // 
            // retryButton
            // 
            retryButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            retryButton.Location = new Point(471, 593);
            retryButton.Name = "retryButton";
            retryButton.Size = new Size(109, 44);
            retryButton.TabIndex = 18;
            retryButton.Text = "Retry";
            retryButton.UseVisualStyleBackColor = true;
            retryButton.Click += button2_Click;
            // 
            // indicatorLabel
            // 
            indicatorLabel.Anchor = AnchorStyles.Top;
            indicatorLabel.AutoSize = true;
            indicatorLabel.Font = new Font("Segoe UI", 13.8239994F, FontStyle.Bold, GraphicsUnit.Point);
            indicatorLabel.Location = new Point(342, 104);
            indicatorLabel.Name = "indicatorLabel";
            indicatorLabel.Size = new Size(177, 32);
            indicatorLabel.TabIndex = 19;
            indicatorLabel.Text = "indicatorLabel";
            // 
            // correctAnswerLabel1
            // 
            correctAnswerLabel1.AutoSize = true;
            correctAnswerLabel1.Font = new Font("Segoe UI", 10.9439993F, FontStyle.Bold, GraphicsUnit.Point);
            correctAnswerLabel1.Location = new Point(127, 132);
            correctAnswerLabel1.Name = "correctAnswerLabel1";
            correctAnswerLabel1.Size = new Size(199, 25);
            correctAnswerLabel1.TabIndex = 21;
            correctAnswerLabel1.Text = "correctAnswerLabel1";
            // 
            // correctAnswerLabel2
            // 
            correctAnswerLabel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            correctAnswerLabel2.AutoSize = true;
            correctAnswerLabel2.Font = new Font("Segoe UI", 10.9439993F, FontStyle.Bold, GraphicsUnit.Point);
            correctAnswerLabel2.Location = new Point(503, 132);
            correctAnswerLabel2.Name = "correctAnswerLabel2";
            correctAnswerLabel2.Size = new Size(199, 25);
            correctAnswerLabel2.TabIndex = 22;
            correctAnswerLabel2.Text = "correctAnswerLabel2";
            // 
            // correctAnswerLabel3
            // 
            correctAnswerLabel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            correctAnswerLabel3.AutoSize = true;
            correctAnswerLabel3.Font = new Font("Segoe UI", 10.9439993F, FontStyle.Bold, GraphicsUnit.Point);
            correctAnswerLabel3.Location = new Point(127, 352);
            correctAnswerLabel3.Name = "correctAnswerLabel3";
            correctAnswerLabel3.Size = new Size(199, 25);
            correctAnswerLabel3.TabIndex = 23;
            correctAnswerLabel3.Text = "correctAnswerLabel3";
            // 
            // correctAnswerLabel4
            // 
            correctAnswerLabel4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            correctAnswerLabel4.AutoSize = true;
            correctAnswerLabel4.Font = new Font("Segoe UI", 10.9439993F, FontStyle.Bold, GraphicsUnit.Point);
            correctAnswerLabel4.Location = new Point(503, 352);
            correctAnswerLabel4.Name = "correctAnswerLabel4";
            correctAnswerLabel4.Size = new Size(199, 25);
            correctAnswerLabel4.TabIndex = 24;
            correctAnswerLabel4.Text = "correctAnswerLabel4";
            // 
            // countryNameLabel
            // 
            countryNameLabel.Anchor = AnchorStyles.Top;
            countryNameLabel.AutoSize = true;
            countryNameLabel.Font = new Font("Segoe UI", 16.128F, FontStyle.Bold, GraphicsUnit.Point);
            countryNameLabel.Location = new Point(3, -16);
            countryNameLabel.MaximumSize = new Size(280, 100);
            countryNameLabel.MinimumSize = new Size(280, 100);
            countryNameLabel.Name = "countryNameLabel";
            countryNameLabel.Size = new Size(280, 100);
            countryNameLabel.TabIndex = 17;
            countryNameLabel.Text = "countryNameLabel";
            countryNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.Controls.Add(countryNameLabel);
            panel1.Location = new Point(255, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(283, 79);
            panel1.TabIndex = 20;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 662);
            Controls.Add(correctAnswerLabel4);
            Controls.Add(correctAnswerLabel3);
            Controls.Add(correctAnswerLabel2);
            Controls.Add(correctAnswerLabel1);
            Controls.Add(panel1);
            Controls.Add(indicatorLabel);
            Controls.Add(retryButton);
            Controls.Add(exitButton);
            Controls.Add(currentScoreLabel);
            Controls.Add(highScoreLabel);
            Controls.Add(countryFlagPictureBox4);
            Controls.Add(countryFlagPictureBox3);
            Controls.Add(countryFlagPictureBox2);
            Controls.Add(countryFlagPictureBox1);
            MinimumSize = new Size(800, 575);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Guess Flag";
            ((System.ComponentModel.ISupportInitialize)countryFlagPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)countryFlagPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)countryFlagPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)countryFlagPictureBox4).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox countryFlagPictureBox1;
        private PictureBox countryFlagPictureBox2;
        private PictureBox countryFlagPictureBox3;
        private PictureBox countryFlagPictureBox4;
        private Label highScoreLabel;
        private Label currentScoreLabel;
        private Button exitButton;
        private Button retryButton;
        private Label indicatorLabel;
        private Label correctAnswerLabel1;
        private Label correctAnswerLabel2;
        private Label correctAnswerLabel3;
        private Label correctAnswerLabel4;
        private Label countryNameLabel;
        private Panel panel1;
    }
}