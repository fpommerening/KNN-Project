﻿using FP.Study.KNN.Perceptron.Data;

namespace FP.Study.KNN.Perceptron.Scenarios
{
    public class LogicAnd : Scenario
    {
        public LogicAnd()
        {
            InputNodeCount = 2;
            Pattern = new[]
            {
                new Pattern(new double []{0.0, 0.0}, 0.0),
                new Pattern(new double []{1.0, 0.0}, 0.0),
                new Pattern(new double []{0.0, 1.0}, 0.0),
                new Pattern(new double []{1.0, 1.0}, 1.0)
            };

        }
    }
}
