using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace restAPI.Models
{
    public interface IOwnerRepository
    {
        Owner Add(Owner owner);
        IEnumerable<Owner> GetAll();
        Owner Find(string FirstName);
        Owner Remove(string FirstName);
        Boolean Update(Owner owner);
    }
}
