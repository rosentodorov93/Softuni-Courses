using SOLIDExercise.Enums;
using SOLIDExercise.LogFiles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SOLIDExercise.Appenders
{
    public class FileAppender : Appender
    {
        private const string FilePath = "../../../Result/Output.txt";
        public FileAppender(ILayout layOut, IlogFile logFile) 
            : base(layOut)
        {
            LogFile = logFile;
        }
        public IlogFile LogFile { get; set; }
        public override void Append(string date, ReportLevel level, string message)
        {
            string appendMessage = string.Format(LayOut.Format, date, level, message);
            LogFile.Write(appendMessage + Environment.NewLine);
            File.AppendAllText(FilePath, appendMessage + Environment.NewLine);
        }
    }
}
