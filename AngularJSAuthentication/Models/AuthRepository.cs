using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace AngularJSAuthentication.Models
{
    public class AuthRepository: IDisposable
    {
        private AuthContext _ctx;
        private UserManager<IdentityUser> _userManger;

        public AuthRepository()
        {
            _ctx = new AuthContext();
            _userManger = new UserManager<IdentityUser>(new UserStore<IdentityUser>(_ctx));
        }

        public async Task<IdentityResult> RegisterUser(UserModel userModel)
        {
            IdentityUser user= new IdentityUser
            {
                UserName = userModel.UserName
            };

            var result = await _userManger.CreateAsync(user, userModel.Password);
            return result;
        }

        public async Task<IdentityUser> FindUser(string userName, string password)
        {
            IdentityUser user = await _userManger.FindAsync(userName, password);
            return user;
        }

        public void Dispose()
        {
            _ctx.Dispose();
            _userManger.Dispose();
        }
    }
}