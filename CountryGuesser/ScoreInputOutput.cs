using static System.Formats.Asn1.AsnWriter;

public static class ScoreInputOutput
{
    public static void CreateScoreFile(string file)
    {
        if (!File.Exists(file))
        {
            using (StreamWriter writer = new StreamWriter(file, true))
            {
                writer.WriteLine("Time,Score");
            }
        }

    }
    public static void WriteScore(int score, string file)
    {
        using (StreamWriter writer = new StreamWriter(file, true))
        {
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            writer.WriteLine($"{timestamp},{score}");
        }
    }

    public static Dictionary<string, int> ReadScore(string file)
    {
        Dictionary<string, int> scores = new Dictionary<string, int>();

        using (StreamReader reader = new StreamReader(file))
        {
            reader.ReadLine();

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');

                string timestamp = values[0];
                int score = int.Parse(values[1]);

                scores.Add(timestamp, score);
            }
        }

        return scores;
    }

    public static int FindHighestScore(string file)
    {
        Dictionary<string, int> scores = ReadScore(file);

        if (scores.Values.Any())
        {
            int maxScore = scores.Values.Max();
            return maxScore;
        }
        else
        {
            return 0;
        }
    }
}