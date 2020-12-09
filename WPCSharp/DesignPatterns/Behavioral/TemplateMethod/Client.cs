﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPCSharp.DesignPatterns.Behavioral.Iterator;
using WPCSharp.DesignPatterns.Behavioral.Memento;
using WPCSharp.DesignPatterns.Behavioral.NullObject;
using WPCSharp.DesignPatterns.Behavioral.Strategy;

namespace WPCSharp.DesignPatterns.Behavioral.TemplateMethod
{
    public class Client
    {
        public static void Execute()
        {
            var fileLogger = new FileLogger();
            fileLogger.Log("Message to Log in File.");
            Console.WriteLine();
            var emailLogger = new EmailLogger();
            emailLogger.Log("Message to Log via Email.");
            Console.WriteLine();
            var databaseLogger = new DatabaseLogger();
            databaseLogger.Log("Message to Log in DB.");
        }
    }
}
