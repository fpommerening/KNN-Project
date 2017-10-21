using Newtonsoft.Json;

namespace FP.Study.KNN.Perceptron.Data
{
    public class Pattern
    {
        public Pattern()
        {
            
        }

        public Pattern(double[] inputs, double output)
        {
            Inputs = inputs;
            Output = output;
        }


        [JsonProperty("inputs")]
        public double[] Inputs { get; set; }

        [JsonProperty("output")]
        public double Output { get; set; }
    }
}
