using FP.Study.KNN.BackPropagation.Data;

namespace FP.Study.KNN.BackPropagation
{
    public class Scenario
    {
        public int InputNodeCount { get; set; }

        public int HiddenNodeCount { get; set; }

        public int OutputNodeCount { get; set; }

        public Pattern[] Pattern { get; set; }
    }
}
