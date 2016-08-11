using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors.GameRules;
using RockPaperScissorsTests.Mocks;
using static RockPaperScissors.GameRules.PlayerChoice;

namespace RockPaperScissorsTests {
    [TestClass]
    public class GameRuleTests {
        [TestMethod]
        public void TestRockVsPaper() {
            var rock = PlayerChoiceMocks.CreateMock(Choices.Rock);
            var paper = PlayerChoiceMocks.CreateMock(Choices.Paper);

            var winner = (new Rules()).GetWinner(rock, paper);

            Assert.AreEqual(paper, winner);
        }

        [TestMethod]
        public void TestPaperVsRock() {
            var rock = PlayerChoiceMocks.CreateMock(Choices.Rock);
            var paper = PlayerChoiceMocks.CreateMock(Choices.Paper);

            var winner = (new Rules()).GetWinner(paper, rock);

            Assert.AreEqual(paper, winner);
        }

        [TestMethod]
        public void TestRockVsScissors() {
            var rock = PlayerChoiceMocks.CreateMock(Choices.Rock);
            var scissors = PlayerChoiceMocks.CreateMock(Choices.Scissors);

            var winner = (new Rules()).GetWinner(rock, scissors);

            Assert.AreEqual(rock, winner);
        }

        [TestMethod]
        public void TestScissorsVsRocks() {
            var rock = PlayerChoiceMocks.CreateMock(Choices.Rock);
            var scissors = PlayerChoiceMocks.CreateMock(Choices.Scissors);

            var winner = (new Rules()).GetWinner(scissors, rock);

            Assert.AreEqual(rock, winner);
        }

        [TestMethod]
        public void TestPaperVsScissors() {
            var paper = PlayerChoiceMocks.CreateMock(Choices.Paper);
            var scissors = PlayerChoiceMocks.CreateMock(Choices.Scissors);

            var winner = (new Rules()).GetWinner(paper, scissors);

            Assert.AreEqual(scissors, winner);
        }

        [TestMethod]
        public void TestScissorsVsPaper() {
            var paper = PlayerChoiceMocks.CreateMock(Choices.Paper);
            var scissors = PlayerChoiceMocks.CreateMock(Choices.Scissors);

            var winner = (new Rules()).GetWinner(scissors, paper);

            Assert.AreEqual(scissors, winner);
        }
    }
}
