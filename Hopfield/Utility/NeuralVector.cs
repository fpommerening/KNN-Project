/*
Source:
Repository: https://github.com/LukaszRabiec/NeuralNetworks
Hash: 92f253add51669ed979af8ad2d571292ccd702be
Path: NeuralNetworks/Utility/NeuralVector.cs
 */

using MathNet.Numerics.LinearAlgebra;

namespace FP.Study.KNN.Hopfield.Utility
{
    public class NeuralVector
    {
        public Vector<double> Data { get; set; }
        public int Class { get; set; }

        public NeuralVector(Vector<double> inputData)
        {
            Data = inputData;
            Class = default(int);
        }

        public NeuralVector(Vector<double> inputData, int inputClass)
        {
            Data = inputData;
            Class = inputClass;
        }


    }
}
