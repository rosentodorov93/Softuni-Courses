using SOLIDExercise.Appenders;
using SOLIDExercise.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDExercise
{
    public class ConsoleAppender : Appender
    {
        public ConsoleAppender(ILayout layOut) 
            : base(layOut)
        {
        }

        public override void Append(string date,ReportLevel level,string mesage)
        {
            Console.WriteLine(string.Format(LayOut.Format,date,level,mesage));
        }
    }
}
