using UnityEngine;

namespace DonzaiGameCorp
{
    public class ComputerPlayer : IUserInput
    {
        public Choice GetChoice()
        {
            int num = Random.Range(0, 3);
            return (Choice)num;
        }
    }
}

