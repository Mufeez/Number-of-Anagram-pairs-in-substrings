using Microsoft.VisualStudio.TestTools.UnitTesting;
using Number_of_anagram_pairs_of_substring_in__strings;

namespace Anagram_pair_calculator__Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string[] mainStrings = { "qaqa", "xdzxmvpnaa", "zzzz", "ability" };
            int[] countOfPairs= AnagramPairCalculator.anagramPairCalculator(mainStrings);

            Assert.AreEqual(countOfPairs[0], 5);

            Assert.AreEqual(countOfPairs[1], 3);

            Assert.AreEqual(countOfPairs[2], 10);

            Assert.AreEqual(countOfPairs[3], 2);
        }
    }
}
