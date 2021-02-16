using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cube.Blazor.Shop.Shared.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        // It is just a tutorial project, with password as a string ;-)
        public string Password { get; set; }
    }
}
