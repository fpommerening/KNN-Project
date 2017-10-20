
using FP.Study.KNN.Hopfield.Data;


namespace FP.Study.KNN.Hopfield.Scenarios
{
    public class Numbers
    {
        public Pattern Number1 { get; } =
            new Pattern
            {
                Name = "Nummer 1",
                Lines = new[]
                {
                    new Line {Columns = new double[] {-1, -1, 1}},
                    new Line {Columns = new double[] {-1, -1, 1}},
                    new Line {Columns = new double[] {-1, -1, 1}},
                    new Line {Columns = new double[] {-1, -1, 1}},
                    new Line {Columns = new double[] {-1, -1, 1}},
                }
            };

        public Pattern Number2 { get; } =
            new Pattern
            {
                Name = "Nummer 2",
                Lines = new[]
                {
                    new Line {Columns = new double[] {1, 1, 1}},
                    new Line {Columns = new double[] {-1, -1, 1}},
                    new Line {Columns = new double[] {1, 1, 1}},
                    new Line {Columns = new double[] {1, -1, -1}},
                    new Line {Columns = new double[] {1, 1, 1}},
                }
            };

        public Pattern Number3 { get; } =

            new Pattern
            {
                Name = "Nummer 3",
                Lines = new Line[]
                {
                    new Line {Columns = new double[] {1, 1, 1}},
                    new Line {Columns = new double[] {-1, -1, 1}},
                    new Line {Columns = new double[] {1, 1, 1}},
                    new Line {Columns = new double[] {-1, -1, 1}},
                    new Line {Columns = new double[] {1, 1, 1}},
                }
            };

        public Pattern Number4 { get; } =
            new Pattern
            {
                Name = "Nummer 4",
                Lines = new Line[]
                {
                    new Line {Columns = new double[] {1, -1, 1}},
                    new Line {Columns = new double[] {1, -1, 1}},
                    new Line {Columns = new double[] {1, 1, 1}},
                    new Line {Columns = new double[] {-1, -1, 1}},
                    new Line {Columns = new double[] {-1, -1, 1}},
                }
            };

        public Pattern Number5 { get; } =
            new Pattern
            {
                Name = "Nummer 5",
                Lines = new Line[]
                {
                    new Line {Columns = new double[] {1, 1, 1}},
                    new Line {Columns = new double[] {1, -1, -1}},
                    new Line {Columns = new double[] {1, 1, 1}},
                    new Line {Columns = new double[] {-1, -1, 1}},
                    new Line {Columns = new double[] {1, 1, 1}},
                }
            };

        public Pattern Number6 { get; } =

            new Pattern
            {
                Name = "Nummer 6",
                Lines = new Line[]
                {
                    new Line {Columns = new double[] {1, 1, 1}},
                    new Line {Columns = new double[] {1, -1, -1}},
                    new Line {Columns = new double[] {1, 1, 1}},
                    new Line {Columns = new double[] {1, -1, 1}},
                    new Line {Columns = new double[] {1, 1, 1}},
                }
            };

        public Pattern Number7 { get; } =
            new Pattern
            {
                Name = "Nummer 7",
                Lines = new Line[]
                {
                    new Line {Columns = new double[] {1, 1, 1}},
                    new Line {Columns = new double[] {-1, -1, 1}},
                    new Line {Columns = new double[] {-1, -1, 1}},
                    new Line {Columns = new double[] {-1, -1, 1}},
                    new Line {Columns = new double[] {-1, -1, 1}},
                }
            };

        public Pattern Number8 { get; } =

            new Pattern
            {
                Name = "Nummer 8",
                Lines = new Line[]
                {
                    new Line {Columns = new double[] {1, 1, 1}},
                    new Line {Columns = new double[] {1, -1, 1}},
                    new Line {Columns = new double[] {1, 1, 1}},
                    new Line {Columns = new double[] {1, -1, 1}},
                    new Line {Columns = new double[] {1, 1, 1}},
                }
            };

        public Pattern Number9 { get; } =

            new Pattern
            {
                Name = "Nummer 9",
                Lines = new Line[]
                {
                    new Line {Columns = new double[] {1, 1, 1}},
                    new Line {Columns = new double[] {1, -1, 1}},
                    new Line {Columns = new double[] {1, 1, 1}},
                    new Line {Columns = new double[] {-1, -1, 1}},
                    new Line {Columns = new double[] {1, 1, 1}},
                }
            };

        public Pattern Number0 { get; } =

            new Pattern
            {
                Name = "Nummer 0",
                Lines = new Line[]
                {
                    new Line {Columns = new double[] {1, 1, 1}},
                    new Line {Columns = new double[] {1, -1, 1}},
                    new Line {Columns = new double[] {1, -1, 1}},
                    new Line {Columns = new double[] {1, -1, 1}},
                    new Line {Columns = new double[] {1, 1, 1}},
                }
            };




        public Scenario CreateScenario_1_2_7()
        {
            return new Scenario
            {
                ColumnCount = 3,
                LineCount = 5,
                Pattern = new[]
                {
                    Number1,
                    Number2,
                    Number7
                }
            };
        }

        public Scenario CreateScenario_All()
        {
            return new Scenario
            {
                ColumnCount = 3,
                LineCount = 5,
                Pattern = new[]
                {
                    Number1,
                    Number2,
                    Number3,
                    Number4,
                    Number5,
                    Number6,
                    Number7,
                    Number8,
                    Number9,
                    Number0
                }
            };
        }

    }
}