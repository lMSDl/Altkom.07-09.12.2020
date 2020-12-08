using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Structural.Proxy
{
    public class Database : IDatabase
    {
        private int _connectionCounter = 0;

        public async Task<int?> RequestAsync(int parameter)
        {
            if(_connectionCounter >= 5)
            {
                Console.WriteLine($"Connection {parameter} dropped!");
                return null;
            }

            Console.WriteLine($"Connection open {++_connectionCounter}");
            await Task.Delay(1000);

            Console.WriteLine($"Request {parameter} completed ({_connectionCounter--})");

            return parameter;
        }
    }
}
