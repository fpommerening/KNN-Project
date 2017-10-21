using Newtonsoft.Json;

namespace FP.Study.KNN.Perceptron.Data
{
    public class Scenario
    {
        [JsonProperty("inputNodeCount")]
        public int InputNodeCount { get; set; }

        [JsonProperty("pattern")]
        public Pattern[] Pattern { get; set; }
    }
}
