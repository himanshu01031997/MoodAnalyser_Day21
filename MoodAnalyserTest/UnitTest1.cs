using MoodAnanlyser;
namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            string Expected = "SAD";
            string message = "I am in ANY mood";
            MoodAnalyser MA = new MoodAnalyser(message);

            //Act
            string mood = MA.AnalyseMood();

            //Assert
            Assert.AreNotEqual(Expected, mood);



        }
    }
}