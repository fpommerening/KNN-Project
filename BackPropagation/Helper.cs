using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DotNeuralNet;
using DotNeuralNet.BackPropagation;

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
    }
}
