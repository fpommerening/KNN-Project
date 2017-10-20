using System;
using System.Collections.Generic;
using System.Text;

namespace FP.Study.KNN.BackPropagation.Data
{
    public class Pattern
    {
        public Pattern()
        {
            
        }

        public Pattern(double[] inputs, double[] outputs)
        {
            Inputs = inputs;
            Outputs = outputs;
        }

        public double[] Inputs { get;  set; }

        public double[] Outputs { get; set; }
    }
}
