namespace ReverseWords__with_Test_
{
    public class Tests
    {
        [Test]
        public void SplitTests()
        {
            var testString = "this is a test";
            var result = Kata.Split(testString, ' ');

            Assert.AreEqual("test", result[3]);
            Assert.AreEqual("a", result[2]);
            Assert.AreEqual("is", result[1]);
            Assert.AreEqual("this", result[0]);
        }

        [Test]
        public void ReverseTests()
        {
            var testList = new List<string>()
            {
                "this", "is", "a", "test"
            };

            var result = Kata.Reverse(testList);

            Assert.AreEqual(testList[0], result[3]);
            Assert.AreEqual(testList[1], result[2]);
            Assert.AreEqual(testList[2], result[1]);
            Assert.AreEqual(testList[3], result[0]);

        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual("world! hello", Kata.ReverseWords("hello world!"));

        }
    }
}