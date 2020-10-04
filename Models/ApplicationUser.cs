using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace NetCore01_2._1.Models
{
    public class ApplicationUser: IdentityUser
    {
        public string City { get; set; }
    }
}
