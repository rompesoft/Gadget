using Dal;
using Ent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bss
{
    public class UserBss
    {
        #region Objects
        UserDal userObject = new UserDal();
        #endregion
        #region Methods
        public int add(UserEnt user)
        {
            return userObject.add(user);
        }
        public int login(UserEnt user)
        {
            return userObject.login(user);
        }
        #endregion
    }
}