﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class MoodAnalyzerException:Exception
    {
        public enum ExceptionType
        {
                EMPTY_MOOD ,NULL_MOOD
        }
        public ExceptionType exceptionType;
        public MoodAnalyzerException(ExceptionType type,string message):base(message)
        {
            this.exceptionType = type;
        }

    }
}
