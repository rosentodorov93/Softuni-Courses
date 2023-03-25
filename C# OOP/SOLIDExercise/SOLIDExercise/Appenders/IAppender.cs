using SOLIDExercise.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDExercise
{
    public interface IAppender
    {
        public ILayout LayOut { get;}
        public ReportLevel TresholdLevel { get; set; }
        public void Append(string date, ReportLevel level, string message);
    }
}
