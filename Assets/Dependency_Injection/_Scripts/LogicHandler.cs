namespace DonzaiGameCorp
{
    public enum Choice
    {
        Rock,
        Paper,
        Scissors
    }

    public enum RoundResult
    {
        Player1Win,
        Player2Win,
        Draw
    }

    public class LogicHandler
    {
        private IUserInput _player1;
        private IUserInput _player2;

        public LogicHandler(IUserInput player1, IUserInput player2)
        {
            _player1 = player1;
            _player2 = player2;
        }

        public void PlayRound(out RoundResult result, out Choice p1, out Choice p2)
        {
            p1 = _player1.GetChoice();
            p2 = _player2.GetChoice();

            if (p1 == p2)
            {
                result = RoundResult.Draw;
                return;
            }

            if (p1 == Choice.Rock && p2 == Choice.Scissors || p1 == Choice.Paper && p2 == Choice.Rock || p1 == Choice.Scissors && p2 == Choice.Paper)
            {
                result = RoundResult.Player1Win;
                return;
            }

            result = RoundResult.Player2Win;
            return;
        }
    }
}

