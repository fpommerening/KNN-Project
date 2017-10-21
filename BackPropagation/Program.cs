using System;
using DotNeuralNet;
using FP.Study.KNN.BackPropagation.Scenarios;
using System.Linq;

namespace FP.Study.KNN.BackPropagation
{
    class Program
    {
        static void Main(string[] args)
        {
            double adjust = 0.01;
            int rounds = 1000;

            //var scenario = new LogicOr();
            //var scenario = new LogicXor();
            //var scenario = new LogicAnd();
            //var scenario = new Letters();
            var scenario = Helper.ReadScenarioFromFile("sample.json");
            //Helper.WriteScenarioToFile(scenario, "sample.json");

            var network = Helper.CreateAndTrainNetwork(scenario, adjust, rounds);
            try
            {
                CreateOutput(scenario, network, adjust, rounds);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("Programmende");
            Console.ReadLine();
        }

        private static void CreateOutput(Scenario scenario, Network network, double adjust, int rounds)
        {
            Console.WriteLine($"Anzahl Eingangswert {scenario.InputNodeCount} / Anzahl Muster {scenario.Pattern.Length}");
            Console.WriteLine($"Adjust: {adjust:R}  Anzahl Interationen {rounds}");
            for (int i = 0; i < scenario.Pattern.Length; i++)
            {
                var pattern = scenario.Pattern[i];
                network.Invalidate();

                for (int n = 0; n < scenario.InputNodeCount; n++)
                {
                    network.InputNodes[n].Value = pattern.Inputs[n];
                }
                Console.WriteLine($"Muster {i}");
                Console.WriteLine($"\tEingangswert(e): {string.Join(" / ", pattern.Inputs.Select(x => x.ToString("R")))}");
                Console.WriteLine($"\tAusgabewert(e) erwartet(e): {string.Join(" / ", pattern.Outputs.Select(x => x.ToString("R")))}");
                Console.WriteLine($"\tAusgabewert(e) ermittelt: : {string.Join(" / ", network.OutputNodes.Select(x => x.Value.ToString("R")))}");
            }

        }
    }
}
