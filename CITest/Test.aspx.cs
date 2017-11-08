using CITestBuild;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CITest
{
    public partial class Test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<UserInfo> lstUsers = new List<UserInfo>();
            CIBuildTest objTest = new CIBuildTest();
            lstUsers = objTest.GetUserList();
            grdUsers.AutoGenerateColumns = true;
            grdUsers.DataSource = lstUsers;
            grdUsers.DataBind();
        }
    }
}