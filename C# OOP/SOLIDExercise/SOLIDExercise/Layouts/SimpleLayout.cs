using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDExercise
{
    public class SimpleLayout : ILayout
    {
        public SimpleLayout()
        {

        }

        public string Format => "{0} - {1} - {2}";
    }
}
