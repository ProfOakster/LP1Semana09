using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerManager1
{
    public class Player
    {
        private string Name { get; }

        private int Score { get; set; }

        public Player(string name, int score)
        {
            Name = name;
            Score = score;
        }
    }
}