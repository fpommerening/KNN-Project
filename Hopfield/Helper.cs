using System.IO;
using System.Text;
using FP.Study.KNN.Hopfield.Data;
using FP.Study.KNN.Hopfield.Utility;
using Newtonsoft.Json;

namespace FP.Study.KNN.Hopfield
{
    public class Helper
    {
        public static void WriteScenarioToFile(Scenario scenario, string filePath)
        {
            string output = JsonConvert.SerializeObject(scenario, Formatting.Indented);
            File.WriteAllText("text.json", output, Encoding.UTF8);
        }

        public static Scenario ReadScenarioFromFile(string filePath)
        {
            var filecontent = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<Scenario>(filecontent);
        }

        public static Pattern MapToPattern(NeuralVector vector, int lineCount, int columnCount)
        {
            var pattern = new Pattern
            {
                Lines = new Line[lineCount]
            };

            for (int l = 0; l < lineCount; l++)
            {
                pattern.Lines[l] = new Line
                {
                    Columns = new double[columnCount]
                };

                for (int c = 0; c < columnCount; c++)
                {
                    pattern.Lines[l].Columns[c] = vector.Data[l * columnCount + c];
                }
            }
            return pattern;
        }
    }
}
