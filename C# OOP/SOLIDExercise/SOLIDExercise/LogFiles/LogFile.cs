using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOLIDExercise.LogFiles
{
    public class LogFile : IlogFile
    {
        private StringBuilder stringBuilder;
        public LogFile()
        {
            this.stringBuilder = new StringBuilder();     
        }
        public int Size => this.stringBuilder.ToString().Where(c => char.IsLetter(c)).Sum(c => c);

        public void Write(string message)
        {
            stringBuilder.Append(message);
            
        }
    }
}
