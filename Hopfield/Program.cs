﻿using System;
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
                var numbers = new Scenarios.Numbers();



                //     var testPattern = new Pattern
                //     {
                //        Lines = new Line[]{
                //            new Line{ Columns = new double[] {1, 1, 1}},
                //            new Line{ Columns = new double[] {-1, -1, 1}},
                //            new Line{ Columns = new double[] {1, 1, 1}},
                //            new Line{ Columns = new double[] {1, -1, -1}},
                //            new Line{ Columns = new double[] {1, 1, 1}},
                //           }
                //   };

                //var scenario = numbers.CreateScenario_1_2_7();

                var letter = new Letters();
                var scenario = letter.CreateScenario_Selection();

                var testPattern = letter.LetterA;

                int matchCount = 0;
                int nonMatchCount = 0;

                for (int i = 0; i < 10; i++)
                {

                    try
                    {
                        var network = new HopfieldNetwork();
                        network.TeachWithHebbsRule(scenario);


                        //  Console.WriteLine("Teste");
                        //  Console.WriteLine(testPattern);

                        var testingVector = Vector<double>.Build.DenseOfArray(testPattern.CreateVectorData(7, 7));

                        NeuralVector outputVector;

                        outputVector = network.Test(new NeuralVector(testingVector));
                        var outputPattern = MapToPattern(outputVector, scenario.LineCount, scenario.ColumnCount);

                        Console.WriteLine("Ergebnis");
                        Console.WriteLine(outputPattern);

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
                Console.Write($"Treffer {matchCount} - {nonMatchCount}");
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
