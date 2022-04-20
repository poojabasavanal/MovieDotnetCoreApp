using System;
using System.Collections.Generic;
using System.Text;
using MovieCoreApp.Entity.Models;

namespace MovieCoreApp.DAL.Repositories
{
    public interface IUserInfoRepository
    {
        void Register(UserInfo userInfo);
        UserInfo Login(UserInfo user);
    }
}
