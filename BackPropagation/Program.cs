using System;
using DotNeuralNet;
using DotNeuralNet.BackPropagation;

namespace FP.Study.KNN.BackPropagation
{
    class Program
    {
        static void Main(string[] args)
        {
            var network = new Network(2, 4, 1);


            //Helper_InitWeights(network);

            var trainer = new BackPropagationTrainer(network);

            var rows = new[] {
                new BackPropagationTrainingRow(new[] { -1.0, -1.0}, new[] { -1.0  }) ,
                new BackPropagationTrainingRow(new[] { -1.0, 1.0}, new[] {-1.0  }) ,
                new BackPropagationTrainingRow(new[] { 1.0, -1.0}, new[] {-1.0  }) ,
                new BackPropagationTrainingRow(new[] { 1.0, 1.0}, new[] {1.0  })

                };

            trainer.Train(rows, 0.5, 10000);

           
            for (var r = 0; r < rows.Length; r++)
            {
                network.Invalidate();
                for (var i = 0; i < rows[r].Inputs.Length; i++)
                {
                    network.InputNodes[i].Value = rows[r].Inputs[i];
                }
                Console.WriteLine(network.OutputNodes[0].Value);
            }
        }

    }
}
