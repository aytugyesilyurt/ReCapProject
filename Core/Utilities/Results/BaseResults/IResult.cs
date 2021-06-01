using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results.BaseResults
{
    // for basic voids [ void Add() --> IResult Add() ] [Doing methots with message and feedback]
    public interface IResult
    {
        public bool Success { get; }
        public string Message { get; }
    }
}
