using MoodAnalyzer;
using NUnit.Framework;

namespace ModeAnalyzerTest
{
    public class MoodTest
        {


            [Test]
            public void GivenString_WhenTests_ShouldReturnHappyMood()
            {
                Analyzer mood = new Analyzer();
                string actual = mood.AnalyseMood("Sad");
                Assert.Pass(actual, "Sad");
            }
            [Test]
            public void GivenString_WhenTests_ShouldReturnSadMood()
            {
                Analyzer mood = new Analyzer();
                string actual = mood.AnalyseMood("Happy");
                Assert.Pass(actual, "Happy");
            }
        }
    }

   