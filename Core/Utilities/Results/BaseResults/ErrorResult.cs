﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results.BaseResults
{
    public class ErrorResult : Result
    {
        public ErrorResult(string message) : base(true, message)
        {

        }
        public ErrorResult() : base(true)
        {

        }
    }
}