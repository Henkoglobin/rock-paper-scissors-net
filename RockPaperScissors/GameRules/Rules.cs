using System.Collections.Generic;
using static RockPaperScissors.GameRules.PlayerChoice;

namespace RockPaperScissors.GameRules {
    public class Rules : IRules {
        private Dictionary<Choices, Choices> options = new Dictionary<Choices, Choices>() {
            [Choices.Paper] = Choices.Rock,
            [Choices.Rock] = Choices.Scissors,
            [Choices.Scissors] = Choices.Paper
        };

        public IPlayerChoice GetWinner(IPlayerChoice a, IPlayerChoice b) {
            if(a.Choice == b.Choice) {
                return null;
            }

            if(options[a.Choice] == b.Choice) {
                return a;
            } else {
                return b;
            }
        }
    }
}