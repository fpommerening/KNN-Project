using System;
using System.Linq;
using Newtonsoft.Json;

namespace FP.Study.KNN.Hopfield.Data
{
    public class Pattern
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("lines")]
        public Line[] Lines { get; set; }

        public double[] CreateVectorData(int lineCount, int columnCount)
        {
            var vectorData = new double[columnCount * lineCount];
            for (int l = 0; l < lineCount; l++)
            {
                for (int c = 0; c < columnCount; c++)
                {
                    vectorData[l * columnCount + c] = Lines[l].Columns[c];
                }
            }
            return vectorData;
        }

        public bool IsEqualValue(Pattern valueToCompare)
        {
            if (this.Lines == null && valueToCompare.Lines != null ||
                this.Lines != null && valueToCompare.Lines == null ||
                this.Lines == null && valueToCompare.Lines == null)
            {
                return false;
            }

            if (this.Lines.Length != valueToCompare.Lines.Length)
            {
                return false;

            }

            for (int l = 0; l < this.Lines.Length; l++)
            {
                if (this.Lines[l].Columns.Length != valueToCompare.Lines[l].Columns.Length)
                {
                    return false;
                }
                for (var c  = 0; c < this.Lines[l].Columns.Length; c++)
                {
                    if (Math.Abs(this.Lines[l].Columns[c] - valueToCompare.Lines[l].Columns[c]) > 0.0000001)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public override string ToString()
        {
            var sb = new System.Text.StringBuilder();
            foreach(var line in Lines)
            {
                sb.AppendLine($"   {string.Join(' ', line.Columns.Select(c => c < 0 ? " " : "*"))}   ");
            }
            return sb.ToString();
        }
    }
}