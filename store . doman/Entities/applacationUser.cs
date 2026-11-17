using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store.doman.Entities
{
    internal class applacationUser :IdentityUser
    {
        public string FullName { get; set; } = null;


    }
}
