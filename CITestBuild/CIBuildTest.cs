using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CITestBuild
{
    public class CIBuildTest
    {
        public CIBuildTest()
        {

        }

        public List<UserInfo> GetUserList()
        {
            return new List<UserInfo> { new UserInfo { UserID = 1, Name = "Pratap", Email = "pratap@yopmail.com" },
                new UserInfo { UserID = 2, Name = "santosh", Email = "santosh@yopmail.com" }, new UserInfo { UserID = 3, Name = "prabhash", Email = "pravash@yopmail.com" },new UserInfo { UserID = 4, Name = "swornim", Email = "swornim@yopmail.com" } };
        }

    }
}
