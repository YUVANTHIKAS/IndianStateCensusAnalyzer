﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCensusAnalyzer
{
    public class CensusAnalyzerException : Exception
    {
        public enum ExceptionType
        {
            FILE_INCORRECT, FILE_NOT_EXISTS, HEADER_INCORRECT, DELIMITER_INCORRECT
        }
        public ExceptionType type;
        public CensusAnalyzerException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }

    }
}
