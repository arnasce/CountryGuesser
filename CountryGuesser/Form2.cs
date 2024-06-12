using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;
using Label = System.Windows.Forms.Label;

namespace CountryGuesser
{
    public partial class Form2 : Form
    {
        private Dictionary<int, Country> countries;
        private Random random = new Random();
        private int countryIndex1;
        private int countryIndex2;
        private int countryIndex3;
        private int countryIndex4;
        private int correctCountryIndex;
        private int score = 0;
        private int highScore = 0;
        private const string fileName = "flag_scores.csv";

        public Form2(Dictionary<int, Country> countries)
        {
            this.countries = countries;
            ScoreInputOutput.CreateScoreFile(fileName);
            highScore = ScoreInputOutput.FindHighestScore(fileName);
            InitializeComponent();
            DisplayCountries();
        }

        private void DisplayCountries()
        {
            retryButton.Visible = false;
            indicatorLabel.Visible = false;
            currentScoreLabel.Text = $"Score: {score}";
            highScoreLabel.Text = $"High Score: {highScore}";
            correctAnswerLabel1.ForeColor = Color.Green;
            correctAnswerLabel2.ForeColor = Color.Green;
            correctAnswerLabel3.ForeColor = Color.Green;
            correctAnswerLabel4.ForeColor = Color.Green;
            correctAnswerLabel1.Visible = false;
            correctAnswerLabel2.Visible = false;
            correctAnswerLabel3.Visible = false;
            correctAnswerLabel4.Visible = false;

            List<int> randomIndexes = countries.Keys.OrderBy(number => random.Next()).Take(4).ToList();

            countryIndex1 = randomIndexes[0];
            countryIndex2 = randomIndexes[1];
            countryIndex3 = randomIndexes[2];
            countryIndex4 = randomIndexes[3];

            countryFlagPictureBox1.ImageLocation = countries[countryIndex1].Flag;
            countryFlagPictureBox2.ImageLocation = countries[countryIndex2].Flag;
            countryFlagPictureBox3.ImageLocation = countries[countryIndex3].Flag;
            countryFlagPictureBox4.ImageLocation = countries[countryIndex4].Flag;

            countryFlagPictureBox1.Tag = countryIndex1;
            countryFlagPictureBox2.Tag = countryIndex2;
            countryFlagPictureBox3.Tag = countryIndex3;
            countryFlagPictureBox4.Tag = countryIndex4;

            correctCountryIndex = randomIndexes[random.Next(randomIndexes.Count)];
            countryNameLabel.Text = countries[correctCountryIndex].Name;
        }

        public void CheckGuess(int guessedCountryIndex)
        {
            if (correctCountryIndex == guessedCountryIndex)
            {
                indicatorLabel.ForeColor = Color.Green;
                indicatorLabel.Text = "Correct!";
                score++;

                DisplayCountries();
            }
            else
            {
                countryFlagPictureBox1.Click -= countryFlag1_Click;
                countryFlagPictureBox2.Click -= countryFlag2_Click;
                countryFlagPictureBox3.Click -= countryFlag3_Click;
                countryFlagPictureBox4.Click -= countryFlag4_Click;

                CheckCorrectAnswerLabel(countryFlagPictureBox1, correctAnswerLabel1);
                CheckCorrectAnswerLabel(countryFlagPictureBox2, correctAnswerLabel2);
                CheckCorrectAnswerLabel(countryFlagPictureBox3, correctAnswerLabel3);
                CheckCorrectAnswerLabel(countryFlagPictureBox4, correctAnswerLabel4);

                indicatorLabel.ForeColor = Color.Red;
                indicatorLabel.Text = "Wrong!";


                if (score > highScore)
                {
                    highScore = score;
                }
                ScoreInputOutput.WriteScore(score, fileName);
                score = 0;

                retryButton.Visible = true;
            }
            indicatorLabel.Visible = true;
        }

        private void CheckCorrectAnswerLabel(PictureBox pictureBox, Label label)
        {
            if ((int)pictureBox.Tag == correctCountryIndex)
            {
                label.Text = "Correct Answer";
                label.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void countryFlag1_Click(object sender, EventArgs e)
        {
            CheckGuess(countryIndex1);
        }

        private void countryFlag2_Click(object sender, EventArgs e)
        {
            CheckGuess(countryIndex2);
        }

        private void countryFlag3_Click(object sender, EventArgs e)
        {
            CheckGuess(countryIndex3);
        }

        private void countryFlag4_Click(object sender, EventArgs e)
        {
            CheckGuess(countryIndex4);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            countryFlagPictureBox1.Click += countryFlag1_Click;
            countryFlagPictureBox2.Click += countryFlag2_Click;
            countryFlagPictureBox3.Click += countryFlag3_Click;
            countryFlagPictureBox4.Click += countryFlag4_Click;
            DisplayCountries();
        }
    }
}
