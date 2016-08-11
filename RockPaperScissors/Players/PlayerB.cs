using System;
using System.Linq;
using RockPaperScissors.GameRules;
using RockPaperScissors.GameRules.GamePlay;
using static RockPaperScissors.GameRules.PlayerChoice;

namespace RockPaperScissors.Players {
    public class PlayerB : IPlayer {
        private readonly Choices[] possibleChoices;
        private readonly Random random;

        public PlayerB(Random random) {
            this.random = random;
            this.possibleChoices = Enum.GetValues(typeof(Choices))
                .OfType<Choices>()
                .ToArray();
        }

        public PlayerChoice GetChoice() {
            return new PlayerChoice(possibleChoices[this.random.Next(possibleChoices.Length)]);
        }
    }
}
