using SOLIDExercise.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDExercise
{
    public interface ILogger
    {
        public IAppender Appender { get;}
        public void Info(string date, string message);
        public void Warning(string date, string message);
        public void Error(string date, string message);
        public void Critical(string date, string message);
        public void Fatal(string date, string message);
    }
}
