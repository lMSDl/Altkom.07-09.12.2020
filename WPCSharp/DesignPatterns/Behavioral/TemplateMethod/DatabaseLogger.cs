using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Behavioral.TemplateMethod
{
    public class DatabaseLogger : Logger<DatabaseService>
    {
        protected override void OnPostSerialize()
        {
        }

        protected override void OnCloseService()
        {
            Console.WriteLine("Closing Db connection");
        }

        protected override void SaveLog(DatabaseService service, string messageToLog)
        {
            service.Insert(messageToLog);
        }

        protected override DatabaseService ConnectToService()
        {
            Console.WriteLine("Connecting to Database.");
            return new DatabaseService();
        }
    }
}
