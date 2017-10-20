using System;
using FP.Study.KNN.BackPropagation.Data;

namespace FP.Study.KNN.BackPropagation.Scenarios
{
    public class LogicAnd : Scenario
    {
        public LogicAnd()
        {
            InputNodeCount = 2;
            HiddenNodeCount = 2;
            OutputNodeCount = 1;
            Pattern = new Pattern[]
            {
                new Pattern(new Double[] {0, 0}, new Double[] {0}),
                new Pattern(new Double[] {1, 0}, new Double[] {0}),
                new Pattern(new Double[] {0, 1}, new Double[] {0}),
                new Pattern(new Double[] {1, 1}, new Double[] {1}),
            };
        }
    }
}
