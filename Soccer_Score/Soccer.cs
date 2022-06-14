using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soccer_Score
{
    internal class Soccer
    {
        public string Team1 { get; set; }
        public string Team2 { get; set; }
        public int Score1 { get; set; }
        public int Score2 { get; set; }
        public int Completion { get; set; }
        //Note -- Dont forget to put getter and setter

         public Soccer(string team1, string team2, int score1, int score2, int completion)
         {
             Team1 = team1;
             Team2 = team2;
             Score1 = score1;
             Score2 = score2;
             Completion = completion;
         }

    }
}
