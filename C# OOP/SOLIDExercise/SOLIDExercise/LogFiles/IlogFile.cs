using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDExercise.LogFiles
{
    public interface IlogFile
    {
        public int Size { get;}
        void Write(string message);
    }
}
