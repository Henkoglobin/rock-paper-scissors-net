using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors.Players;
using RockPaperScissorsTests.Mocks;
using static RockPaperScissors.GameRules.PlayerChoice;

namespace RockPaperScissorsTests.PlayerTests {
    [TestClass]
    public class PlayerBTests {
        [TestMethod]
        public void TestRandomness() {
            // Test random selection of choices with a mocked RNG
            var numChoices = Enum.GetValues(typeof(Choices)).Length;
            var random = RandomMocks.CreateMock(numChoices);

            var player = new PlayerB(random);

            var choiceGroups = from x in Enumerable.Range(0, 1000)
                               let choice = player.GetChoice().Choice
                               group choice by choice into choiceGroup
                               select choiceGroup;

            var min = choiceGroups.Min(x => x.Count());
            var max = choiceGroups.Max(x => x.Count());

            Assert.IsTrue(max - min <= 1);
        }
    }
}
