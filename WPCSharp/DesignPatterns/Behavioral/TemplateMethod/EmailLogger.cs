using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Behavioral.TemplateMethod
{
    public class EmailLogger : Logger<IDisposable>
    {
        protected override void OnPostSerialize()
        {
        }

        protected override void OnCloseService()
        {
        }

        protected override void SaveLog(IDisposable service, string messageToLog)
    {
        Console.WriteLine("Sending Email with Log Message : " + messageToLog);
    }

        protected override IDisposable ConnectToService()
        {
            return null;
        }
    }
}
