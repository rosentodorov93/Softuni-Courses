using SOLIDExercise.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDExercise.Appenders
{
    public abstract class Appender : IAppender
    {
        protected Appender(ILayout layOut)
        {
            LayOut = layOut;
        }

        public ILayout LayOut { get; }
        public ReportLevel TresholdLevel { get; set; }

        public abstract void Append(string date, ReportLevel level, string message);
        
    }
}
