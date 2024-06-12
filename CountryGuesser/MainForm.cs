using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CountryGuesser.Form1;

namespace CountryGuesser
{
    public partial class MainForm : Form
    {
        private static Dictionary<int, Country> countries = new Dictionary<int, Country>();
        private const string apiUrl = "https://restcountries.com/v3.1/all?fields=name,flags,population,area";
        public MainForm()
        {
            FetchData(apiUrl);
            InitializeComponent();
        }

        private async void FetchData(string url)
        {
            var client = new HttpClient();
            var endpoint = new Uri(url);

            try
            {
                var response = client.GetAsync(endpoint).Result;

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    var countryData = JsonSerializer.Deserialize<List<CountryData>>(result);

                    int countryIndex = 0;

                    foreach (var data in countryData)
                    {
                        if (data.population != 0)
                        {
                            countries.Add(countryIndex, new Country(data.name.common, data.flags.png,
                                data.population));

                            countryIndex++;
                        }
                    }
                }
                else
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");

            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Request Exception: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(countries);
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(countries);
            form2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
