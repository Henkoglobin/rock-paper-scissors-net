using static RockPaperScissors.GameRules.PlayerChoice;

namespace RockPaperScissors.GameRules {
    public interface IPlayerChoice {
        Choices Choice { get; }
    }
}
