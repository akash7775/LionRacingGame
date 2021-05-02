using System.Windows.Forms;

namespace LionRacingGame
{
    public class Jo : Punter
    {
        public Jo(Bet MyBet, Label MaximumBet, int Cash, Label MyLabel) : base(MyBet, MaximumBet, Cash, MyLabel)
        {
        }

        public override void setPunterName()
        {
            Name = "Jo";
        }
    }
}
