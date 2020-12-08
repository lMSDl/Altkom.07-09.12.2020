using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Structural.Adapter.II
{
    public class DbPersonServiceAdapter : IPeopleService
    {
        private DbPeopleService _service;

        public DbPersonServiceAdapter(DbPeopleService service)
        {
            _service = service;
        }

        public IEnumerable<IPerson> Get()
        {
            //return _service.Get().Select(x => new Person() { Name = $"{x.FirstName} {x.LastName}", Age = DateTime.Today.Year - x.BirthDate.Year});
            return _service.Get().Select(x => new DbPersonToPersonAdapter(x));
        }
    }
}
