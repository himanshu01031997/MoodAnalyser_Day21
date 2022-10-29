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
        //[TestMethod]
        //[DataRow(null)]
        //public void HandleExceptiontest(string message)
        //{
        //    // Arrange
        //    string expected = "HAPPY";
        //    MoodAnalyser MA1 = new MoodAnalyser(message);

        //    //Act
        //    string mood = MA1.AnalyseMood();

        //    //Assert
        //    Assert.AreEqual(expected, mood);


        //}
        [TestMethod]
        public void GivenEmptyMoodShouldAnalyseException_Indicating_EmptyMood()
        {
            try
            {
                string message = "";//empty
                MoodAnalyser MA2=new MoodAnalyser(message);
                string mood = MA2.AnalyseMood();
            }
            catch(MoodAnalyserCustumException e)
            {
                Assert.AreEqual("mood should not be empty", e.Message);
            }
        }
        [TestMethod]

        public void Given_Null_Mood_ShouldThrowMoodAnalyseException()
        {
            try
            {
                string message = null;
                MoodAnalyser MA3 = new MoodAnalyser(message);
                string mood = MA3.AnalyseMood();
            }
            catch(MoodAnalyserCustumException e)
            {
                Assert.AreEqual("mood should not be empty",e.Message);
            }
        }



    }
}