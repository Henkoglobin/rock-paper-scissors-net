using RockPaperScissors.GameRules;
using static RockPaperScissors.GameRules.PlayerChoice;

namespace RockPaperScissorsTests.Mocks {

    static class PlayerChoiceMocks {
        public static IPlayerChoice CreateMock(Choices choice) {
            return new PlayerChoiceMock() { Choice = choice };
        }

        private class PlayerChoiceMock : IPlayerChoice {
            public Choices Choice { get; set; }
        }
    }
}
