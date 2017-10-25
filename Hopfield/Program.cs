using System;
using FP.Study.KNN.Hopfield.Data;
using FP.Study.KNN.Hopfield.Scenarios;
using FP.Study.KNN.Hopfield.Utility;
using MathNet.Numerics.LinearAlgebra;

namespace FP.Study.KNN.Hopfield
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var numbers = new Numbers();
                var letter = new Letters();

                //var scenario = numbers.CreateScenario_3_5_0();
                //     var testNumber = new Pattern
                //     {
                //        Lines = new Line[]{
                //            new Line{ Columns = new double[] {1, 1, 1}},
                //            new Line{ Columns = new double[] {-1, -1, 1}},
                //            new Line{ Columns = new double[] {1, 1, 1}},
                //            new Line{ Columns = new double[] {1, -1, -1}},
                //            new Line{ Columns = new double[] {1, 1, 1}},
                //           }
                //   };
                //var testPattern = numbers.Number7;

                var scenario = letter.CreateScenario_SelectionBig();
                var testPattern = letter.LetterA;

                //ExecuteSingle(scenario, testPattern);
                ExecuteSeries(scenario,testPattern);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Console.ReadLine();
        }

        static void ExecuteSingle(Scenario scenario, Pattern testPattern)
        {
            try
            {
                var network = new HopfieldNetwork();
                network.TeachWithHebbsRule(scenario);

                var testingVector = Vector<double>.Build.DenseOfArray(testPattern.CreateVectorData(7, 7));

                var outputVector = network.Test(new NeuralVector(testingVector));
                var outputPattern = Helper.MapToPattern(outputVector, scenario.LineCount, scenario.ColumnCount);

                Console.WriteLine("Ergebnis");
                Console.WriteLine(outputPattern);
            }
            catch (Exception exception)
            {
                Console.WriteLine("Error on Test");
                Console.WriteLine(exception);
            }
        }

        static void ExecuteSeries(Scenario scenario, Pattern testPattern)
        {
            int matchCount = 0;
            int nonMatchCount = 0;

            for (int i = 0; i < 1000; i++)
            {
                try
                {
                    var network = new HopfieldNetwork();
                    network.TeachWithHebbsRule(scenario);

                    var testingVector = Vector<double>.Build.DenseOfArray(testPattern.CreateVectorData(7, 7));

                    var outputVector = network.Test(new NeuralVector(testingVector));
                    var outputPattern = Helper.MapToPattern(outputVector, scenario.LineCount, scenario.ColumnCount);

                    if (outputPattern.IsEqualValue(testPattern))
                    {
                        matchCount++;
                    }
                    else
                    {
                        nonMatchCount++;
                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine("Error on Test");
                    Console.WriteLine(exception);
                }
            }
            Console.Write($"Ergebnis: Korrekt {matchCount} - Falsch {nonMatchCount}");
        }

    }
}
