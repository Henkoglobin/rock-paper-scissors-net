using RockPaperScissors.GameRules;
using RockPaperScissors.GameRules.GamePlay;
using static RockPaperScissors.GameRules.PlayerChoice;

namespace RockPaperScissors.Players {
    public class PlayerA : IPlayer {
        public PlayerChoice GetChoice() {
            return new PlayerChoice(Choices.Paper);
        }
    }
}
