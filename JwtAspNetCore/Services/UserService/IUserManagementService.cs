using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JwtAspNetCore.Services
{
    public interface IUserManagementService
    {
        bool IsValidUser(string username, string password);
    }
}
