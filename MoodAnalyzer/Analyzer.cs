using System;
namespace MoodAnalyzer
{
    public class Analyzer
    {
        public string AnalyseMood(string message)
        {
            if(message.ToLower().Contains("sad"))
            {
                return "Sad";
            }
            return "Happy";
        }
    }
}    