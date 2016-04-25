using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace restAPI.Models
{
    public interface IPuppyRepository
    {
        Puppy Add(Puppy puppy);
        IEnumerable<Puppy> GetAll();
        Puppy Find(int Id);
        Puppy Remove(int Id);
        void Update(Puppy puppy);
    }
}
