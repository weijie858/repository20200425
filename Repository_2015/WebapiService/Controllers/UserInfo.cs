using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebapiService.Controllers
{
    public class UserInfo
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string AppName { get; set; }
        public string UniqueID { get; set; }
    }
}