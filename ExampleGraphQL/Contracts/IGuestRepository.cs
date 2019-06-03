using ExampleGraphQL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleGraphQL.Contracts
{
    public interface IGuestRepository
    {
        IEnumerable<Guest> GetGuests();
    }
}
