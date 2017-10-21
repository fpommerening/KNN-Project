using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using DotNeuralNet;
using DotNeuralNet.BackPropagation;
using Newtonsoft.Json;

namespace FP.Study.KNN.BackPropagation
{
    public static class Helper
    {
        public static Network CreateNetwork(Scenario scenario)
        {
            return new Network(scenario.InputNodeCount, scenario.HiddenNodeCount, scenario.OutputNodeCount);
        }

        public static IEnumerable<BackPropagationTrainingRow> GetTrainingRows(Scenario scenario)
        {
            return scenario.Pattern.Select(pattern => new BackPropagationTrainingRow(pattern.Inputs, pattern.Outputs));
        }

        public static Network CreateAndTrainNetwork(Scenario scenario,  double adjust, int rounds)
        {
            var network = CreateNetwork(scenario);
            var trainer = new BackPropagationTrainer(network);
            var rows = GetTrainingRows(scenario);
            trainer.Train(rows, adjust, rounds);
            return network;
        }

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
    }
}
