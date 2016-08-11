using System;

namespace RockPaperScissorsTests.Mocks {
    static class RandomMocks {
        public static Random CreateMock(int numChoices) {
            return new RandomMock(numChoices);
        }

        private class RandomMock : Random {
            double i = 0;
            private int numChoices;

            public RandomMock(int numChoices) {
                this.numChoices = numChoices;
            }

            protected override double Sample() {
                i = (i + 1) % this.numChoices;
                return (i / numChoices);
            }
        }
    }
}
