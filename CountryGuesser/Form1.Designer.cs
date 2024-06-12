namespace CountryGuesser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            countryNameLabel1 = new Label();
            countryNameLabel2 = new Label();
            panel1 = new Panel();
            countryInfoLabel1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            scoreLabel = new Label();
            guessIndicatorLabel = new Label();
            panel5 = new Panel();
            retryButton = new Button();
            panel6 = new Panel();
            countryInfoLabel2 = new Label();
            highScoreLabel = new Label();
            exitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Location = new Point(-1, 49);
            pictureBox1.MinimumSize = new Size(150, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(301, 159);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Location = new Point(0, 49);
            pictureBox2.MinimumSize = new Size(150, 75);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(300, 162);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // countryNameLabel1
            // 
            countryNameLabel1.Dock = DockStyle.Bottom;
            countryNameLabel1.Font = new Font("Segoe UI", 13.8239994F, FontStyle.Regular, GraphicsUnit.Point);
            countryNameLabel1.Location = new Point(0, 21);
            countryNameLabel1.MinimumSize = new Size(250, 32);
            countryNameLabel1.Name = "countryNameLabel1";
            countryNameLabel1.Size = new Size(301, 32);
            countryNameLabel1.TabIndex = 2;
            countryNameLabel1.Text = "countryNameLabel1";
            countryNameLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // countryNameLabel2
            // 
            countryNameLabel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            countryNameLabel2.Font = new Font("Segoe UI", 13.8239994F, FontStyle.Regular, GraphicsUnit.Point);
            countryNameLabel2.Location = new Point(0, 21);
            countryNameLabel2.MinimumSize = new Size(250, 32);
            countryNameLabel2.Name = "countryNameLabel2";
            countryNameLabel2.Size = new Size(300, 32);
            countryNameLabel2.TabIndex = 3;
            countryNameLabel2.Text = "countryNameLabel2";
            countryNameLabel2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(55, 120);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 211);
            panel1.TabIndex = 4;
            // 
            // countryInfoLabel1
            // 
            countryInfoLabel1.Dock = DockStyle.Top;
            countryInfoLabel1.Font = new Font("Segoe UI", 12.096F, FontStyle.Regular, GraphicsUnit.Point);
            countryInfoLabel1.Location = new Point(0, 0);
            countryInfoLabel1.Name = "countryInfoLabel1";
            countryInfoLabel1.Size = new Size(300, 140);
            countryInfoLabel1.TabIndex = 10;
            countryInfoLabel1.Text = "countryInfoLabel1";
            countryInfoLabel1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(427, 120);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 211);
            panel2.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.Controls.Add(countryNameLabel1);
            panel3.Location = new Point(54, 110);
            panel3.Name = "panel3";
            panel3.Size = new Size(301, 53);
            panel3.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel4.Controls.Add(countryNameLabel2);
            panel4.Location = new Point(427, 110);
            panel4.Name = "panel4";
            panel4.Size = new Size(300, 53);
            panel4.TabIndex = 7;
            // 
            // scoreLabel
            // 
            scoreLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            scoreLabel.AutoSize = true;
            scoreLabel.Font = new Font("Segoe UI", 12.096F, FontStyle.Regular, GraphicsUnit.Point);
            scoreLabel.Location = new Point(616, 31);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(111, 30);
            scoreLabel.TabIndex = 8;
            scoreLabel.Text = "scoreLabel";
            // 
            // guessIndicatorLabel
            // 
            guessIndicatorLabel.Anchor = AnchorStyles.Top;
            guessIndicatorLabel.AutoSize = true;
            guessIndicatorLabel.Font = new Font("Segoe UI", 16.128F, FontStyle.Bold, GraphicsUnit.Point);
            guessIndicatorLabel.Location = new Point(312, 23);
            guessIndicatorLabel.Name = "guessIndicatorLabel";
            guessIndicatorLabel.Size = new Size(277, 38);
            guessIndicatorLabel.TabIndex = 9;
            guessIndicatorLabel.Text = "guessIndicatorLabel";
            guessIndicatorLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.Controls.Add(countryInfoLabel1);
            panel5.Location = new Point(55, 337);
            panel5.Name = "panel5";
            panel5.Size = new Size(300, 140);
            panel5.TabIndex = 11;
            // 
            // retryButton
            // 
            retryButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            retryButton.Location = new Point(462, 453);
            retryButton.Name = "retryButton";
            retryButton.Size = new Size(109, 44);
            retryButton.TabIndex = 14;
            retryButton.Text = "Retry";
            retryButton.UseVisualStyleBackColor = true;
            retryButton.Click += button1_Click;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel6.Controls.Add(countryInfoLabel2);
            panel6.Location = new Point(427, 336);
            panel6.Name = "panel6";
            panel6.Size = new Size(300, 141);
            panel6.TabIndex = 12;
            // 
            // countryInfoLabel2
            // 
            countryInfoLabel2.Dock = DockStyle.Top;
            countryInfoLabel2.Font = new Font("Segoe UI", 12.096F, FontStyle.Regular, GraphicsUnit.Point);
            countryInfoLabel2.Location = new Point(0, 0);
            countryInfoLabel2.Name = "countryInfoLabel2";
            countryInfoLabel2.Size = new Size(300, 141);
            countryInfoLabel2.TabIndex = 0;
            countryInfoLabel2.Text = "countryrInfoLabel2";
            countryInfoLabel2.TextAlign = ContentAlignment.TopCenter;
            // 
            // highScoreLabel
            // 
            highScoreLabel.AutoSize = true;
            highScoreLabel.Font = new Font("Segoe UI", 12.096F, FontStyle.Regular, GraphicsUnit.Point);
            highScoreLabel.Location = new Point(54, 31);
            highScoreLabel.Name = "highScoreLabel";
            highScoreLabel.Size = new Size(154, 30);
            highScoreLabel.TabIndex = 13;
            highScoreLabel.Text = "highScoreLabel";
            // 
            // exitButton
            // 
            exitButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            exitButton.Location = new Point(587, 453);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(140, 44);
            exitButton.TabIndex = 15;
            exitButton.Text = "Exit to menu";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 527);
            Controls.Add(exitButton);
            Controls.Add(retryButton);
            Controls.Add(highScoreLabel);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(guessIndicatorLabel);
            Controls.Add(scoreLabel);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(800, 575);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Guess population";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label countryNameLabel1;
        private Label countryNameLabel2;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label scoreLabel;
        private Label guessIndicatorLabel;
        private Label countryInfoLabel1;
        private Panel panel5;
        private Panel panel6;
        private Label countryInfoLabel2;
        private Label highScoreLabel;
        private Button retryButton;
        private Button exitButton;
    }
}