namespace ExampleTestProject
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TearDown]
        public void TearDown()
        { }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}
