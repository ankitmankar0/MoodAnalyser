using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserProblem;

namespace MoodAnalyserProblem
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenMood_WhenSad_ShouldReturn_SAD_MOOD()
        {
            //Arrange
            string moodMessage = "I am in Sad Mood";
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string expected = "SAD";

            //Act
            string actual = moodAnalyser.AnalyseMood(moodMessage);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenMood_WhenHappy_ShouldReturn_HAPPY_MOOD()
        {
            //Arrange
            string moodMessage = "I am in Any Mood";
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string expected = "HAPPY";

            //Act
            string actual = moodAnalyser.AnalyseMood(moodMessage);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenMood_WhenNull_ShouldReturn_HAPPY_MOOD()
        {
            //Arrange
            string moodMessage = null;
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string expected = "HAPPY";

            //Act
            string actual = moodAnalyser.AnalyseMood(moodMessage);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}