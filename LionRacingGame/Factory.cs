using System;
using System.Windows.Forms;

namespace LionRacingGame
{
    public class Factory
    {
        public Punter getPunter(String Name, Label MaximumBet, Label bet)
        {
            Punter p;
            switch (Name.ToLower())
            {
                case "jo":
                    p = new Jo(null, MaximumBet, 50, bet);
                    break;

                case "mary":
                    p = new Mary(null, MaximumBet, 50, bet);
                    break;

                case "ali":
                    p = new Ali(null, MaximumBet, 50, bet);
                    break;

                default:
                    p = null;
                    break;
            }
            p.setPunterName();
            return p;
        }
    }
}
