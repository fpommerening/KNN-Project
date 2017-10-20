using System;
using DotNeuralNet;
using DotNeuralNet.BackPropagation;
using FP.Study.KNN.BackPropagation.Scenarios;

namespace FP.Study.KNN.BackPropagation
{
    class Program
    {
        static void Main(string[] args)
        {
            Scenario scenario = null;
            //scenario = new LogicXor();

            //scenario = new LogicAnd();
            scenario = new Letters();

            var network = Helper.CreateAndTrainNetwork(scenario, 0.5, 10000);
            

            for (var r = 0; r < scenario.Pattern.Length; r++)
            {
                network.Invalidate();
                for (var i = 0; i < scenario.Pattern[r].Inputs.Length; i++)
                {
                    network.InputNodes[i].Value = scenario.Pattern[r].Inputs[i];
                }
                for (int i = 0; i < network.OutputNodes.Count; i++)
                {
                    Console.WriteLine(network.OutputNodes[i].Value);
                }

                Console.WriteLine("########################################");

                System.Threading.Thread.Sleep(2000);
            }

            Console.ReadLine();
        }

    }
}
