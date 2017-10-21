using FP.Study.KNN.Perceptron.Data;

namespace FP.Study.KNN.Perceptron.Scenarios
{
    public class LogicXor : Scenario
    {
        public LogicXor()
        {
            InputNodeCount = 2;
            Pattern = new []
            {
                new Pattern(new double []{0,0}, 0),
                new Pattern(new double []{1,0}, 1),
                new Pattern(new double []{0,1}, 1),
                new Pattern(new double []{1,1}, 0)
            };
        }
    }
}
