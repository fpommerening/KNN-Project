using System.Linq;

namespace FP.Study.KNN.Hopfield.Data
{
    public class Pattern
    {
        public string Name { get; set; }
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

        public override string ToString()
        {
            var sb = new System.Text.StringBuilder();
            foreach(var line in Lines)
            {
                sb.AppendLine(string.Join(' ', line.Columns.Select(c=>c < 0 ? " " : "*")));
            }
            return sb.ToString();
        }
    }
}