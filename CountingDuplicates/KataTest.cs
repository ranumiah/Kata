using NUnit.Framework;

namespace CountingDuplicates
{
    [TestFixture]
    public class KataTest
    {
        [Test]
        public void EmptyStringReturnNoDuplicates()
        {
            Assert.AreEqual(0, Kata.DuplicateCount(""));
        }

        [Test]
        public void NoDuplicatesString()
        {
            Assert.AreEqual(0, Kata.DuplicateCount("abcde"));
        }

        [Test]
        public void MultipleDuplicatesAdjacentCharacters()
        {
            Assert.AreEqual(2, Kata.DuplicateCount("aabbcde"));
        }

        [Test]
        public void MultipleDuplicatesIgnoreCase()
        {
            Assert.AreEqual(2, Kata.DuplicateCount("aabBcde"), "should ignore case");
        }

        [Test]
        public void DuplicateNonAdjacentlyCharacters()
        {
            Assert.AreEqual(1, Kata.DuplicateCount("Indivisibility"));
        }

        [Test]
        public void MultipleDuplicatesNonAdjacentlyCharacters()
        {
            Assert.AreEqual(2, Kata.DuplicateCount("Indivisibilities"), "characters may not be adjacent");
        }
    }
}
