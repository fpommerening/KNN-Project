using Newtonsoft.Json;

namespace FP.Study.KNN.Hopfield.Data
{
    public class Line
    {
        [JsonProperty("columns")]
        public double[] Columns { get; set; }
    }
}