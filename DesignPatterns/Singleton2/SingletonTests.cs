using Autofac;
using NUnit.Framework;

namespace Singleton_With_Tests_And_DI
{
    [TestFixture]
    public class SingletonTests
    {
        [Test]
        public void IsSingletonTest()
        {
            var db = SingletonDatabase.Instance;
            var db2 = SingletonDatabase.Instance;

            Assert.That(db, Is.SameAs(db2));
            Assert.AreEqual(1, SingletonDatabase.Count);
        }

        // We shouldn't test the real database object like that,
        // because we can't rely on the live database values, cause it can be changed on the real world
        // This is the singleton problem
        [Test]
        public void SingletonTotalPopulationTest()
        {
            var rf = new SingletonRecordFinder();
            var names = new[] { "Seoul", "Mexico City" };
            int total = rf.GetTotalPopulation(names);

            Assert.AreEqual(17500000 + 17400000, total);
        }

        // This is much better test than that above,
        // because it uses the set-up singleton database object, not the real one
        [Test]
        public void ConfigurablePopulationTest()
        {
            var rf = new ConfigurableRecordFinder(new DummyDatabase());
            var names = new[] { "alpha", "gamma" };
            int total = rf.GetTotalPopulation(names);

            Assert.AreEqual(1+3, total);
        }

        // This is the test which is using the DI which can be configurated to use a single instance of a given object (just a singleton)
        [Test]
        public void DIPopulationTest()
        {
            var cb = new ContainerBuilder();
            cb.RegisterType<OrdinaryDatabase>()
                .As<IDatabase>()
                .SingleInstance();
            cb.RegisterType<ConfigurableRecordFinder>();

            using (var c = cb.Build())
            {
                var rf = c.Resolve<ConfigurableRecordFinder>();
            }
        }
    }
}
