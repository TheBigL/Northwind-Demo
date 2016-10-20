using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind_Data.Security
{
    public class ApplicationUser : IdentityUser
    {
        public int? EmployeeId { get; set; }
        public string CustomerId { get; set; }
    }
}
