namespace RockPaperScissors.GameRules {
    public interface IRules {
        IPlayerChoice GetWinner(IPlayerChoice a, IPlayerChoice b);
    }
}