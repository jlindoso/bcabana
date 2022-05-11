using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
namespace business.Model.Classes
{
    public class Usuario: IdentityUser<int>
    {
        
    }


    public class UserLogin: IdentityUserLogin<int>{}
    public class UserRole: IdentityUserRole<int>{}
    public class UserClaim: IdentityUserClaim<int>{}

    public class Role: IdentityRole<int>{}
}