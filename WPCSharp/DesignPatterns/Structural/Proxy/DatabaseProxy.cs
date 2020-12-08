using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Structural.Proxy
{
    public class DatabaseProxy : IDatabase
    {
        public const int NumberOfAvailableConnections = 3;
        private IDatabase _database;
        private SemaphoreSlim _semaphoreSlim = new SemaphoreSlim(NumberOfAvailableConnections);

        public DatabaseProxy(IDatabase database)
        {
            _database = database;
        }

        public async Task<int?> RequestAsync(int parameter)
        {
            if(_database == null)
            {
                Console.WriteLine("New database");
                _database = new Database();
            }

            await _semaphoreSlim.WaitAsync();
            var result = await _database.RequestAsync(parameter);
            _semaphoreSlim.Release();

            if(_semaphoreSlim.CurrentCount == NumberOfAvailableConnections)
            {
                _database = null;
                Console.WriteLine("Database null");
            }

            return result;
        }
    }
}
