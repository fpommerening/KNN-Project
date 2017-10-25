using FP.Study.KNN.Hopfield.Data;

namespace FP.Study.KNN.Hopfield.Scenarios
{
    public class Letters
    {
        public Pattern LetterA { get; } = new Pattern
        {
            Name = "A",
            Lines = new[]
            {
                new Line {Columns = new double[] {-1, -1, -1, 1, -1, -1, -1}},
                new Line {Columns = new double[] {-1, -1, 1, -1, 1, -1, -1}},
                new Line {Columns = new double[] {-1, 1, -1, -1, -1, 1, -1}},
                new Line {Columns = new double[] {-1, 1, 1, 1, 1, 1, -1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, 1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, 1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, 1}}
            }
        };


        public Pattern LetterB { get; } = new Pattern
        {
            Name = "B",
            Lines = new []
            {
                new Line {Columns = new double[] {1, 1, 1, 1, 1, 1, -1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, 1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, 1}},
                new Line {Columns = new double[] {1, 1, 1, 1, 1, 1, -1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1,  1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, 1}},
                new Line {Columns = new double[] {1, 1, 1, 1, 1, 1, -1}}
            }
        };

        public Pattern LetterC { get; } = new Pattern
        {
            Name = "C",
            Lines = new []
            {
                new Line {Columns = new double[] {-1, 1, 1, 1, 1, 1, 1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, -1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, -1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, -1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1,  -1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, -1}},
                new Line {Columns = new double[] {-1, 1, 1, 1, 1, 1, 1}}
            }
        };

        public Pattern LetterD { get; } = new Pattern
        {
            Name = "D",
            Lines = new []
            {
                new Line {Columns = new double[] {1, 1, 1, 1, 1, 1, -1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, 1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, 1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, 1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, 1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, 1}},
                new Line {Columns = new double[] {1, 1, 1, 1, 1, 1, -1}}
            }
        };

        public Pattern LetterE { get; } = new Pattern
        {
            Name = "E",
            Lines = new []
            {
                new Line {Columns = new double[] {1, 1, 1, 1, 1, 1, 1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, -1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, -1}},
                new Line {Columns = new double[] {1, 1, 1, 1, 1, 1, 1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, -1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, -1}},
                new Line {Columns = new double[] {1, 1, 1, 1, 1, 1, 1}}
            }
        };

        public Pattern LetterF { get; } = new Pattern
        {
            Name = "F",
            Lines = new []
            {
                new Line {Columns = new double[] {1, 1, 1, 1, 1, 1, 1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, -1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, -1}},
                new Line {Columns = new double[] {1, 1, 1, 1, -1, -1, -1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1,  -1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, -1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, -1}}
            }
        };

        public Pattern LetterG { get; } = new Pattern
        {
            Name = "G",
            Lines = new []
            {
                new Line {Columns = new double[] {-1, 1, 1, 1, 1, 1, -1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, 1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, -1}},
                new Line {Columns = new double[] {1, -1, -1, 1, 1, 1, -1}},
                new Line {Columns = new double[] {1, -1, -1, 1, -1, -1, 1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, 1}},
                new Line {Columns = new double[] {-1, 1, 1, 1, 1, 1, -1}}
            }
        };

        public Pattern LetterH { get; } = new Pattern
        {
            Name = "H",
            Lines = new []
            {
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, 1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, 1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, 1}},
                new Line {Columns = new double[] {1, 1, 1, 1, 1, 1, 1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, 1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, 1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, 1}}
            }
        };

        public Pattern LetterI { get; } = new Pattern
        {
            Name = "I",
            Lines = new []
            {
                new Line {Columns = new double[] {-1, -1, -1, 1, -1, -1, -1}},
                new Line {Columns = new double[] {-1, -1, -1, 1, -1, -1, -1}},
                new Line {Columns = new double[] {-1, -1, -1, 1, -1, -1, -1}},
                new Line {Columns = new double[] {-1, -1, -1, 1, -1, -1, -1}},
                new Line {Columns = new double[] {-1, -1, -1, 1, -1, -1,  -1}},
                new Line {Columns = new double[] {-1, -1, -1, 1, -1, -1, -1}},
                new Line {Columns = new double[] {-1, -1, -1, 1, -1, -1, -1}}
            }
        };

        public Pattern LetterJ { get; } = new Pattern
        {
            Name = "J",
            Lines = new []
            {
                new Line {Columns = new double[] {-1, -1, -1, 1, -1, -1, -1}},
                new Line {Columns = new double[] {-1, -1, -1, 1, -1, -1, -1}},
                new Line {Columns = new double[] {-1, -1, -1, 1, -1, -1, -1}},
                new Line {Columns = new double[] {-1, -1, -1, 1, -1, -1, -1}},
                new Line {Columns = new double[] {-1, -1, -1, 1, -1, -1,  -1}},
                new Line {Columns = new double[] {1, -1, -1, 1, -1, -1, -1}},
                new Line {Columns = new double[] {-1, 1, 1, -1, -1, -1, -1}}
            }
        };

        public Pattern LetterK { get; } = new Pattern
        {
            Name = "K",
            Lines = new []
            {
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, 1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, 1, -1}},
                new Line {Columns = new double[] {1, -1, -1, -1, 1, -1, -1}},
                new Line {Columns = new double[] {1, 1, 1, 1, -1, -1, -1}},
                new Line {Columns = new double[] {1, -1, -1, -1, 1, -1,  -1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, 1, -1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, 1}}
            }
        };

        public Pattern LetterL { get; } = new Pattern
        {
            Name = "L",
            Lines = new []
            {
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, -1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, -1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, -1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, -1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1,  -1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, -1}},
                new Line {Columns = new double[] {1, 1, 1, 1, 1, 1, 1}}
            }
        };

        public Pattern LetterM { get; } = new Pattern
        {
            Name = "M",
            Lines = new []
            {
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, 1}},
                new Line {Columns = new double[] {1, 1, -1, -1, -1, 1, 1}},
                new Line {Columns = new double[] {1, -1, 1, -1, 1, -1, 1}},
                new Line {Columns = new double[] {1, -1, -1, 1, -1, -1, 1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, 1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, 1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, 1}}
            }
        };

        public Pattern LetterN { get; } = new Pattern
        {
            Name = "N",
            Lines = new []
            {
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, 1}},
                new Line {Columns = new double[] {1, 1, -1, -1, -1, -1, 1}},
                new Line {Columns = new double[] {1, -1, 1, -1, -1, -1, 1}},
                new Line {Columns = new double[] {1, -1, -1, 1, -1, -1, 1}},
                new Line {Columns = new double[] {1, -1, -1, -1, 1, -1, 1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, 1, 1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, 1}}
            }
        };

        public Pattern LetterO { get; } = new Pattern
        {
            Name = "O",
            Lines = new []
            {
                new Line {Columns = new double[] {-1, 1, 1, 1, 1, 1, -1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, 1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, 1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, 1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, 1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, 1}},
                new Line {Columns = new double[] {-1, 1, 1, 1, 1, 1, -1}}
            }
        };

        public Pattern LetterP { get; } = new Pattern
        {
            Name = "P",
            Lines = new []
            {
                new Line {Columns = new double[] {1, 1, 1, 1, 1, 1, -1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, 1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, 1}},
                new Line {Columns = new double[] {1, 1, 1, 1, 1, 1, -1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1,  -1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, -1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, -1}}
            }
        };

        public Pattern LetterQ { get; } = new Pattern
        {
            Name = "Q",
            Lines = new []
            {
                new Line {Columns = new double[] {-1, 1, 1, 1, 1, 1, -1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, 1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, 1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, 1}},
                new Line {Columns = new double[] {1, -1, -1, 1, 1, -1, 1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, 1, 1}},
                new Line {Columns = new double[] {-1, 1, 1, 1, 1, 1, -1}}
            }
        };

        public Pattern LetterR { get; } = new Pattern
        {
            Name = "R",
            Lines = new []
            {
                new Line {Columns = new double[] {1, 1, 1, 1, 1, 1, -1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, 1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, 1}},
                new Line {Columns = new double[] {1, 1, 1, 1, 1, 1, -1}},
                new Line {Columns = new double[] {1, -1, -1, -1, 1, -1,  -1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, 1, -1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, 1}}
            }
        };

        public Pattern LetterS { get; } = new Pattern
        {
            Name = "S",
            Lines = new []
            {
                new Line {Columns = new double[] {-1, 1, 1, 1, 1, 1, -1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, 1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, -1}},
                new Line {Columns = new double[] {-1, 1, 1, 1, 1, -1, -1}},
                new Line {Columns = new double[] {-1, -1, -1, -1, -1, 1, -1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, 1}},
                new Line {Columns = new double[] {-1, 1, 1, 1, 1, 1, -1}}
            }
        };

        public Pattern LetterT { get; } = new Pattern
        {
            Name = "T",
            Lines = new []
            {
                new Line {Columns = new double[] {1, 1, 1, 1, 1, 1, 1}},
                new Line {Columns = new double[] {-1, -1, -1, 1, -1, -1, -1}},
                new Line {Columns = new double[] {-1, -1, -1, 1, -1, -1, -1}},
                new Line {Columns = new double[] {-1, -1, -1, 1, -1, -1, -1}},
                new Line {Columns = new double[] {-1, -1, -1, 1, -1, -1,  -1}},
                new Line {Columns = new double[] {-1, -1, -1, 1, -1, -1, -1}},
                new Line {Columns = new double[] {-1, -1, -1, 1, -1, -1, -1}}
            }
        };

        public Pattern LetterU { get; } = new Pattern
        {
            Name = "U",
            Lines = new []
            {
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, 1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, 1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, 1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, 1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, 1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, 1}},
                new Line {Columns = new double[] {-1, 1, 1, 1, 1, 1, -1}},
            }
        };

        public Pattern LetterV { get; } = new Pattern
        {
            Name = "V",
            Lines = new []
            {
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, 1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, 1}},
                new Line {Columns = new double[] {-1, 1, -1, -1, -1, 1, -1}},
                new Line {Columns = new double[] {-1, 1, -1, -1, -1, 1, -1}},
                new Line {Columns = new double[] {-1, -1, 1, -1, 1, -1,  -1}},
                new Line {Columns = new double[] {-1, -1, 1, -1, 1, -1, -1}},
                new Line {Columns = new double[] {-1, -1, -1, 1, -1, -1, -1}}
            }
        };

        public Pattern LetterW { get; } = new Pattern
        {
            Name = "W",
            Lines = new []
            {
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, 1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, 1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, 1}},
                new Line {Columns = new double[] {1, -1, -1, 1, -1, -1, 1}},
                new Line {Columns = new double[] {1, -1, 1, -1, 1, -1, 1}},
                new Line {Columns = new double[] {1, 1, -1, -1, -1, 1, 1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, 1}}
            }
        };

        public Pattern LetterX { get; } = new Pattern
        {
            Name = "X",
            Lines = new []
            {
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, 1}},
                new Line {Columns = new double[] {-1, 1, -1, -1, -1, 1, -1}},
                new Line {Columns = new double[] {-1, -1, 1, -1, 1, -1, -1}},
                new Line {Columns = new double[] {-1, -1, -1, 1, -1, -1, -1}},
                new Line {Columns = new double[] {-1, -1, 1, -1, 1, -1, -1}},
                new Line {Columns = new double[] {-1, 1, -1, -1, -1, 1, -1}},
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, 1}}
            }
        };

        public Pattern LetterY { get; } = new Pattern
        {
            Name = "Y",
            Lines = new []
            {
                new Line {Columns = new double[] {1, -1, -1, -1, -1, -1, 1}},
                new Line {Columns = new double[] {-1, 1, -1, -1, -1, 1, -1}},
                new Line {Columns = new double[] {-1, -1, 1, -1, 1, -1, -1}},
                new Line {Columns = new double[] {-1, -1, -1, 1, -1, -1, -1}},
                new Line {Columns = new double[] {-1, -1, -1, 1, -1, -1, -1}},
                new Line {Columns = new double[] {-1, -1, -1, 1, -1, -1, -1}},
                new Line {Columns = new double[] {-1, -1, -1, 1, -1, -1, -1}}
            }
        };

        public Pattern LetterZ { get; } = new Pattern
        {
            Name = "Z",
            Lines = new []
            {
                new Line {Columns = new double[] {1, 1, 1, 1, 1, 1, 1}},
                new Line {Columns = new double[] {-1, -1, -1, -1, -1, 1, -1}},
                new Line {Columns = new double[] {-1, -1, -1, -1, 1, -1, -1}},
                new Line {Columns = new double[] {-1, -1, -1, 1, -1, -1, -1}},
                new Line {Columns = new double[] {-1, -1, 1, -1, -1, -1, -1}},
                new Line {Columns = new double[] {-1, 1, -1, -1, -1, -1, -1}},
                new Line {Columns = new double[] {1, 1, 1, 1, 1, 1, 1}}
            }
        };

        public Scenario CreateScenario_All()
        {
            return new Scenario
            {
                ColumnCount = 7,
                LineCount = 7,
                Pattern = new[]
                {
                    LetterA, LetterB, LetterC, LetterD, LetterE, LetterF,
                    LetterG, LetterH, LetterI, LetterJ, LetterK, LetterL, LetterM,
                    LetterN, LetterO, LetterP, LetterQ, LetterR, LetterS,
                    LetterT, LetterU, LetterV, LetterW, LetterX, LetterY, LetterZ
                }
            };
        }


        public Scenario CreateScenario_SelectionSmall()
        {
            return new Scenario
            {
                ColumnCount = 7,
                LineCount = 7,
                Pattern = new[]
                {
                    LetterA,  LetterK, LetterN,  
                        LetterT, LetterX
                }
            };
        }

        public Scenario CreateScenario_SelectionBig()
        {
            return new Scenario
            {
                ColumnCount = 7,
                LineCount = 7,
                Pattern = new[]
                {
                    LetterA,   LetterE, LetterF,  LetterI,
                     LetterK, LetterN,  LetterO,
                    LetterS,    LetterT, LetterX
                }
            };
        }

    }
}
