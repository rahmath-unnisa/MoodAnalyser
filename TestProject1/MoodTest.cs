using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace ModeAnalyzerTest
{
    public class MoodTest
    {
        [Test]
        public void GivenString_WhenTests_ShouldReturnEmpty()
        {
            try
            {
                Analyzer mood = new Analyzer("");
                string actual = mood.AnalyseMood();
            }
            catch (MoodAnalyzerException ex)
            {
                Assert.AreEqual(ex.Message, "Message is Empty");
            }
        }
        [Test]
        public void GivenString_WhenTests_ShouldReturnNull()
        {
            try
            {
              Analyzer mood = new Analyzer(null);
                string actual = mood.AnalyseMood();
            }
            catch (MoodAnalyzerException ex)
            {
                Assert.AreEqual(ex.Message, "Message is Null");
            }
        }
        // [Test]
        //public void GivenString_WhenTests_ShouldReturnSadMood()
        //{
        //  Analyzer mood = new Analyzer("I am in Sad Mood");
        //string actual = mood.AnalyseMood();
        //Assert.Pass(actual, "Sad");
        //}
    }
}

