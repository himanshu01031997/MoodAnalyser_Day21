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
        [TestMethod]
        [DataRow(null)]
        public void HandleExceptiontest(string message)
        {
            // Arrange
            string expected = "HAPPY";
            MoodAnalyser MA1 = new MoodAnalyser(message);

            //Act
            string mood = MA1.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, mood);


        }

    }
}
