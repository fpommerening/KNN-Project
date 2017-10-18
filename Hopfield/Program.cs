using System;
using FP.Study.KNN.Hopfield.Data;
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

                var scenario = new Scenario();
                scenario.ColumnCount = 3;
                scenario.LineCount = 5;
                scenario.Pattern = new Pattern[3];
                scenario.Pattern[0] = new Pattern
                {
                    Name = "Nummer 1",
                    Lines = new Line[]{
                        new Line{ Columns = new double[] {-1, -1, 1}},
                        new Line{ Columns = new double[] {-1, -1, 1}},
                        new Line{ Columns = new double[] {-1, -1, 1}},
                        new Line{ Columns = new double[] {-1, -1, 1}},
                        new Line{ Columns = new double[] {-1, -1, 1}},
                        }
                };
                scenario.Pattern[1] = new Pattern
                {
                    Name = "Nummer 2",
                    Lines = new Line[]{
                        new Line{ Columns = new double[] {1, 1, 1}},
                        new Line{ Columns = new double[] {-1, -1, 1}},
                        new Line{ Columns = new double[] {1, 1, 1}},
                        new Line{ Columns = new double[] {1, -1,-1}},
                        new Line{ Columns = new double[] {1, 1, 1}},
                        }
                };

                scenario.Pattern[2] = new Pattern
                {
                    Name = "Nummer 7",
                    Lines = new Line[]{
                        new Line{ Columns = new double[] {1, 1, 1}},
                        new Line{ Columns = new double[] {-1, -1, 1}},
                        new Line{ Columns = new double[] {-1, -1, 1}},
                        new Line{ Columns = new double[] {-1, -1, 1}},
                        new Line{ Columns = new double[] {-1, -1, 1}},
                        }
                };

                var testPattern = new Pattern
                {
                    Lines = new Line[]{
                        new Line{ Columns = new double[] {1, 1, 1}},
                        new Line{ Columns = new double[] {-1, -1, 1}},
                        new Line{ Columns = new double[] {1, 1, 1}},
                        new Line{ Columns = new double[] {-1, -1, 1}},
                        new Line{ Columns = new double[] {1, 1, 1}},
                        }
                };

                var network = new HopfieldNetwork();
                network.TeachWithHebbsRule(scenario);

                foreach (var p in scenario.Pattern)
                {
                    Console.WriteLine(p);
                    Console.WriteLine();
                }


                Console.WriteLine("Teste");
                Console.WriteLine(testPattern);


                var testingVector = Vector<double>.Build.DenseOfArray(testPattern.CreateVectorData(5, 3));
                NeuralVector outputVector;

                try
                {
                    outputVector = network.Test(new NeuralVector(testingVector));
                    var outputPattern = MapToPattern(outputVector, scenario.LineCount, scenario.ColumnCount);
                    Console.WriteLine("Ergebnis");
                    Console.WriteLine(outputPattern);
                }
                catch (Exception exception)
                {
                    Console.WriteLine("Error on Test");
                    Console.WriteLine(exception);
                }




            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Console.ReadLine();


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
