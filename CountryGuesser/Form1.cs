using System.Text.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Diagnostics.PerformanceData;
using System.Globalization;

namespace CountryGuesser
{
    public partial class Form1 : Form
    {
        private Dictionary<int, Country> countries;
        private Random random = new Random();
        private int countryIndex1;
        private int countryIndex2;
        private int score = 0;
        private const string fileName = "population_scores.csv";
        private int highScore = 0;

        public Form1(Dictionary<int, Country> countries)
        {
            this.countries = countries;
            ScoreInputOutput.CreateScoreFile(fileName);
            highScore = ScoreInputOutput.FindHighestScore(fileName);
            InitializeComponent();
            DisplayCountries();
        }

        private void DisplayCountries()
        {

            countryIndex1 = random.Next(countries.Count);
            countryIndex2 = random.Next(countries.Count);

            while (countryIndex1 == countryIndex2)
            {
                countryIndex1 = random.Next(countries.Count);
            }

            countryNameLabel1.Text = countries[countryIndex1].Name;
            countryNameLabel2.Text = countries[countryIndex2].Name;

            scoreLabel.Text = $"Score: {score}";

            guessIndicatorLabel.Visible = false;
            countryInfoLabel1.Visible = false;
            countryInfoLabel2.Visible = false;

            highScoreLabel.Text = $"High Score: {highScore}";

            pictureBox1.ImageLocation = countries[countryIndex1].Flag;
            pictureBox2.ImageLocation = countries[countryIndex2].Flag;

            retryButton.Visible = false;
        }

        public void RefreshGame(bool guessIsCorrect)
        {

            if (guessIsCorrect)
            {
                ++score;
                DisplayCountries();
            }
            else
            {
                retryButton.Visible = true;
                pictureBox1.Click -= pictureBox1_Click;
                pictureBox2.Click -= pictureBox2_Click;

                if (score > highScore)
                {
                    highScore = score;
                }
                ScoreInputOutput.WriteScore(score, fileName);
            }
        }

        private async void CheckGuess(int guess)
        {
            (int chosenCountryIndex, int otherCountryIndex) = guess == 1 ? (countryIndex1, countryIndex2) : (countryIndex2, countryIndex1);

            bool correctGuess = countries[chosenCountryIndex].Population > countries[otherCountryIndex].Population;

            int populationDifference = countries[chosenCountryIndex].Population - countries[otherCountryIndex].Population;

            guessIndicatorLabel.Text = correctGuess
                ? $"Correct!\n{populationDifference:#,#}"
                : $"Wrong!\n{populationDifference:#,#}";

            guessIndicatorLabel.Visible = true;

            countryInfoLabel1.Text = $"Has\n{countries[countryIndex1].Population:#,#}\npopulation";
            countryInfoLabel1.Visible = true;

            countryInfoLabel2.Text = $"Has\n{countries[countryIndex2].Population:#,#}\npopulation";
            countryInfoLabel2.Visible = true;

            await Task.Delay(1500);

            RefreshGame(correctGuess);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CheckGuess(1);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CheckGuess(2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            score = 0;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox2.Click += pictureBox2_Click;
            DisplayCountries();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}