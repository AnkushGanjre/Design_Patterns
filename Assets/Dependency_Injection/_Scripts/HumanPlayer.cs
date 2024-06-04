namespace DonzaiGameCorp
{
    public class HumanPlayer : IUserInput
    {
        private int _input;

        // Set the int based on button input
        public void SetChoice(int input)
        {
            _input = input;
        }

        public Choice GetChoice()
        {
            Choice result;

            if (_input == 1)
            {
                result = Choice.Rock;
            }
            else if (_input == 2)
            {
                result = Choice.Paper;
            }
            else
            {
                result = Choice.Scissors;
            }

            return result;
        }
    }
}

