using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace ASM_App_Dev.Models
{
    public class ApplicationUser : IdentityUser
    {
        // test commit
        public string FullName { get; set; }
        public string Address { set; get; }
        List<Order> Orders { get; set; }
  }
}
