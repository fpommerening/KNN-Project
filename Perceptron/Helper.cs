using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using DotNeuralNet.Perceptrons;
using FP.Study.KNN.Perceptron.Data;
using Newtonsoft.Json;

namespace FP.Study.KNN.Perceptron
{
    public static class Helper
    {
        public static IEnumerable<PerceptronTrainingRow> GetTrainingRows(Scenario scenario)
        {
            return scenario.Pattern.Select(pattern => new PerceptronTrainingRow(pattern.Inputs, pattern.Output));
        }

        public static DotNeuralNet.Perceptrons.Perceptron CreateAndTrainPerceptron(Scenario scenario, Func<double, double> activationFunction,
            double adjust, int rounds)
        {
            var perceptron = new DotNeuralNet.Perceptrons.Perceptron(scenario.InputNodeCount);

            perceptron.ActivationFunction = activationFunction;
            var trainer = new PerceptronTrainer(perceptron);
            trainer.Train(GetTrainingRows(scenario).ToArray(), adjust, rounds);
            return perceptron;
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
