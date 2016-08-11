using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors.GameRules.GamePlay;
using RockPaperScissors.Players;
using static RockPaperScissors.GameRules.PlayerChoice;

namespace RockPaperScissorsTests.PlayerTests {
    [TestClass]
    public class PlayerATests {
        [TestMethod]
        public void TestAlwaysPaper() {
            var player = new PlayerA();

            var choices = from x in Enumerable.Range(0, 1000)
                          let choice = player.GetChoice().Choice
                          where choice != Choices.Paper
                          select choice;

            Assert.AreEqual(0, choices.Count());
        }
    }
}
