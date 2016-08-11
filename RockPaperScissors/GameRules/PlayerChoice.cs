namespace RockPaperScissors.GameRules {
    public class PlayerChoice : IPlayerChoice {
        public enum Choices {
            Rock,
            Paper,
            Scissors
        }

        public Choices Choice { get; }
       

        public PlayerChoice(Choices choice) {
            this.Choice = choice;
        }
    }
}