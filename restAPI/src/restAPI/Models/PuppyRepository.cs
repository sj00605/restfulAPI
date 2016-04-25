using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace restAPI.Models
{
    public class PuppyRepository : IPuppyRepository
    {

        static ConcurrentDictionary<int, Puppy> _puppy = new ConcurrentDictionary<int, Puppy>();
        private int _nextId = 1;

        public PuppyRepository()
        {
            Add(new Puppy { Name = "Trooper", Breed = "Dachshund", owner = new Owner { FirstName = "Samantha", LastName = "Jacobs", Phone = "478-714-7276" }, weight = 20 });

        }

        public IEnumerable<Puppy> GetAll()
        {
            return _puppy.Values;
        }

        public Puppy Add(Puppy puppy)
        {
            if( puppy == null)
            {
                throw new ArgumentNullException("puppy");
                return null;
            }

            puppy.Id = _nextId++;

            //puppy.Id = Guid.NewGuid().ToString();
            _puppy[puppy.Id] = puppy;

            return puppy;
        }

        public Puppy Find(int Id)
        {
            Puppy puppy;
            _puppy.TryGetValue(Id, out puppy);

            return puppy;
        }

        public Puppy Remove(int Id)
        {
            Puppy puppy;
            _puppy.TryGetValue(Id, out puppy);
            _puppy.TryRemove(Id, out puppy);

            return puppy;
        }

        public void Update(Puppy puppy)
        {
            _puppy[puppy.Id] = puppy;
        }

    }
}
