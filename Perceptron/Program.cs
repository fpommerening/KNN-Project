using System;
using System.Linq;
using FP.Study.KNN.Perceptron.Data;
using FP.Study.KNN.Perceptron.Scenarios;


namespace FP.Study.KNN.Perceptron
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Func<double, double> activationFunction = x => x >= 1 ? 1 : 0;

                double adjust = 0.01;
                int rounds = 10;

                //var scenario = new LogicAnd();
                //var scenario = new LogicXor();
                var scenario = new LogicOr();
                //var scenario = Helper.ReadScenarioFromFile("sample.json");

                var perceptron = Helper.CreateAndTrainPerceptron(scenario, activationFunction, adjust, rounds);

                CreateOutput(scenario, perceptron, adjust, rounds);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();
        }

        private static void CreateOutput(Scenario scenario, DotNeuralNet.Perceptrons.Perceptron perceptron, double adjust, int rounds)
        {
            Console.WriteLine($"Anzahl Eingangswert {scenario.InputNodeCount} / Anzahl Muster {scenario.Pattern.Length}");
            Console.WriteLine($"Adjust: {adjust:R}  Anzahl Interationen {rounds}");
            for (int i = 0; i < scenario.Pattern.Length; i++)
            {
                var pattern = scenario.Pattern[i];
                for (int n = 0; n < scenario.InputNodeCount; n++)
                {
                    perceptron.Inputs[n] = pattern.Inputs[n];
                }
                Console.WriteLine($"Muster {i}");
                Console.WriteLine($"\tEingangswert(e): {string.Join(" / ", pattern.Inputs.Select(x=>x.ToString("R")))}");
                Console.WriteLine($"\tAusgabewert erwartet: {pattern.Output:R} ermittelt: {perceptron.Output:R}");
            }
        }
    }
}
