﻿using System.Windows.Forms;

namespace LionRacingGame
{
    public class Ali : Punter
    {
        public Ali(Bet bet, Label MaximumBet, int Cash, Label label) : base(bet, MaximumBet, Cash, label)
        {
        }

        public override void setPunterName()
        {
            Name = "Ali";
        }
    }
}
