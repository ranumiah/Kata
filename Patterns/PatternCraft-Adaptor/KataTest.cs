using NUnit.Framework;

namespace PatternCraft_Adaptor
{
    [TestFixture]
    public class KataTest
    {
        [Test]
        public void _0_MarioAdapter_Can_Attack()
        {
            var marioAdapter = new MarioAdapter(new Mario());
            var target = new Target { Health = 33 };

            marioAdapter.Attack(target);

            Assert.AreEqual(30, target.Health);
        }
    }
}
