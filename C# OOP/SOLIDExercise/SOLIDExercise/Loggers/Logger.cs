using SOLIDExercise.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDExercise
{
    public class Logger : ILogger
    {
        private List<IAppender> Appenders;
        public Logger(params IAppender[] appenders)
        {
            Appenders = new List<IAppender>();
            Appenders.AddRange(appenders);
        }

        public IAppender Appender { get; private set; }

        public void Info(string date, string message)

        {
            AppendAllAppenders(date, ReportLevel.Info, message);
        }

        public void Warning(string date, string message)
        {
            AppendAllAppenders(date, ReportLevel.Warrning, message);
        }

        public void Error(string date,string message)
        {
            AppendAllAppenders(date, ReportLevel.Error, message);
        }

        public void Critical(string date, string message)
        {
            AppendAllAppenders(date, ReportLevel.Critical, message);
        }

        public void Fatal(string date, string message)
        {
            AppendAllAppenders(date, ReportLevel.Fatal, message);
        }

       private void AppendAllAppenders(string date,ReportLevel level,string message)
        {
            foreach (var appender in Appenders)
            {
                if (level >= appender.TresholdLevel)
                {
                    appender.Append(date, level, message);
                }
                
            }
        }

    }
}
