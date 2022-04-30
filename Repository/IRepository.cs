using CalendarManagementApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityDemo.Repository
{
    public interface IRepository
    {
        UserModel LoginUser(LoginViewModel model);
        bool RegisterUser(UserModel model);
        bool UpdateUser(UserModel identityModel);
        bool ChangePassword(ChangePasswordModel model);
        bool ResetPassword(ResetPasswordModel model);

    }
}