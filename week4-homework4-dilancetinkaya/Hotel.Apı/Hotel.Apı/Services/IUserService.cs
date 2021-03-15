using Hotel.Apı.Model;
using Hotel.Apı.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Apı.Services
{
    public interface IUserService
    {
        Task<UserInfo> Authenticate(TokenRequest req);

    }
}
