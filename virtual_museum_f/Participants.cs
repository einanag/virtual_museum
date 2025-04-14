using System.Collections.Generic;
using System.Linq;

namespace virtual_museum_f
{
    public class Participants
    {
        public string Name { get; set; }
        public List<int> Scores { get; set; }

        public Participants(string name)
        {
            Name = name;
            Scores = new List<int>();
        }

        public double AverageScore => Scores.Count > 0 ? Scores.Average() : 0;
    }
}