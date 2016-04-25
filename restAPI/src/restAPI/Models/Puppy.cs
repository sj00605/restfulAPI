using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace restAPI.Models
{
    public class Puppy
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public int weight { get; set; }
        public Owner owner { get; set; } 
    }
}
