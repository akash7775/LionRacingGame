using System.Windows.Forms;

namespace LionRacingGame
{
    public class Mary : Punter
    {
        public Mary(Bet bet, Label MaximumBet, int Cash, Label label) : base(bet, MaximumBet, Cash, label)
        {
        }

        public override void setPunterName()
        {
            Name = "Mary";
        }
    }
}
