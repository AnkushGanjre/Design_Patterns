using TMPro;
using UnityEngine;

namespace DonzaiGameCorp
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] TextMeshProUGUI _resultText;

        public void OnChoiceMade(int choice)
        {
            HumanPlayer _humanPlayer = new HumanPlayer();
            ComputerPlayer _computerPlayer = new ComputerPlayer();

            // Pass the choice to HumanPlayer
            _humanPlayer.SetChoice(choice);

            LogicHandler gm = new LogicHandler(_humanPlayer, _computerPlayer);
            gm.PlayRound(out RoundResult result, out Choice p1, out Choice p2);

            if (result == RoundResult.Player1Win)
            {
                _resultText.text = $"Player Wins!!!\r\n\r\n<size=100>Player: {p1}\r\n Computer: {p2}";
            }
            else if (result == RoundResult.Player2Win)
            {
                _resultText.text = $"Computer Wins!!!\r\n\r\n<size=100>Player: {p1}\r\n Computer: {p2}";
            }
            else
            {
                _resultText.text = $"It's a Draw\r\n\r\n<size=100>Player: {p1}\r\n Computer: {p2}";
            }
        }
    }
}

