﻿using System;
namespace MoodAnalyzer
{
    public class Analyzer
    {
        string message;
        public Analyzer(string message)
        {
            this.message = message;
        }
        public string AnalyseMood()
        {
            try
            {
                if (message.ToLower().Contains("sad"))
                {
                    return "Sad";
                }
                else
                {
                    return "Happy";
                }
                return message;
            }
            catch (Exception)
            {
                return "Happy";
            }
        }
        //try
        //{
        //    if (message == null)
        //    {
        //        throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.NULL_MOOD, "Message is Null");
        //    }
        //    if (message.Equals(""))
        //    {
        //        throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.EMPTY_MOOD, "Message is Empty");
        //    }

        //    if (message.ToLower().Contains("sad"))
        //    {
        //        return "Sad";
        //    }
        //}
        //catch (MoodAnalyzerException)
        //{
        //    throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.EMPTY_MOOD, "Message is Empty");
        //}
        //return "Happy";
    }
    }