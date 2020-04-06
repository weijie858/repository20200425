using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webform
{
    public partial class testoa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         //   System.Web.Security.SqlMembershipProvider
            // System.Web.Security.MembershipProvider
            //System.Web.Security.Membership.Providers[]
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            BLL.机构service service = new BLL.机构service();
            service.delete(Guid.NewGuid());
        }
    }
}