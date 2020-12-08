using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Structural.Adapter.II
{
    public class DbPersonToPersonAdapter : IPerson
    {
        private DbPerson _dbPerson;

        public DbPersonToPersonAdapter(DbPerson dbPerson)
        {
            _dbPerson = dbPerson;
        }

        public string Name => $"{_dbPerson.FirstName} {_dbPerson.LastName}";

        public int Age => DateTime.Today.Year - _dbPerson.BirthDate.Year;

    }
}
