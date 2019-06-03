using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExampleGraphQL.Contracts;
using ExampleGraphQL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExampleGraphQL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestController : ControllerBase
    {
        private readonly IGuestRepository guestRepository;

        public GuestController(IGuestRepository guestRepository)
        {
            this.guestRepository = guestRepository;
        }

        public IEnumerable<Guest> GetGuests()
            => guestRepository.GetGuests();
    }
}