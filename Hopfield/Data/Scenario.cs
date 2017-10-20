using Newtonsoft.Json;

namespace FP.Study.KNN.Hopfield.Data
{
    public class Scenario
    {
        [JsonProperty("columnCount")]
        public int ColumnCount { get; set; }

        [JsonProperty("lineCount")]
        public int LineCount { get; set; }

        [JsonProperty("pattern")]
        public Pattern[] Pattern { get; set; }

    }
}