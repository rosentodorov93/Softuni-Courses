﻿using SOLIDExercise.Appenders;
using SOLIDExercise.Enums;
using SOLIDExercise.Layouts;
using SOLIDExercise.LogFiles;
using System;

namespace SOLIDExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var simpleLayout = new SimpleLayout();
            var consoleAppender = new ConsoleAppender(simpleLayout);

            var file = new LogFile();
            var fileAppender = new FileAppender(simpleLayout, file);

            var logger = new Logger(consoleAppender, fileAppender);
            logger.Error("3/26/2015 2:08:11 PM", "Error parsing JSON.");
            Console.WriteLine(file.Size);
        }
    }
}
