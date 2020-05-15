using Lind.DDD.SSO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebapiService.Controllers
{
    public class HomeController : Controller
    {
        #region test
        public readonly static List<UserInfo> UserList = new List<UserInfo>();
        static HomeController()
        {
            UserList.Add(new UserInfo
            {
                Id = 1,
                UserName = "zzl",
                Password = "123",
            });
            UserList.Add(new UserInfo
            {
                Id = 2,
                UserName = "opt",
                Password = "123",
            });
        }
        #endregion
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        /// <summary>
        /// 全站统一登陆
        /// </summary>
        /// <returns></returns>
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(FormCollection form)
        {
            var entity = UserList.FirstOrDefault(i => i.UserName == form["UserName"] && i.Password == form["Password"]);
            if (entity != null)
            {
                //产生令牌
                string tokenValue = Guid.NewGuid().ToString();
                HttpCookie tokenCookie = new HttpCookie("Token");
                tokenCookie.Values.Add("Value", tokenValue);
                tokenCookie.Domain = "http://localhost:8012";
                Response.AppendCookie(tokenCookie);

                //产生主站凭证
                object info = true;
                Lind.DDD.ConfigConstants.ConfigManager.Config.SSO.Provider = "cache";
                SSOManager.Instance.TokenInsert(tokenValue, info, DateTime.Now.AddMinutes(10));

                //跳转回分站
                return GetTokenUrl(form["BackURL"].ToString());
            }
            return Content("抱歉，帐号或密码有误！请在Web.config中配置帐号密码！");

        }

        #region 向客户端分站公开的方法
        /// <summary>
        /// 当前通过sso授权的用户列表
        /// </summary>
        /// <returns></returns>
        public ActionResult CurrentUserList()
        {
         var   list = SSOManager.Instance.GetCacheTable();
            return View(list);
        }

        /// <summary>
        /// 令牌验证
        /// 以URL参数方式返回
        /// </summary>
        /// <param name="backUrl"></param>
        /// <returns></returns>
        public ActionResult GetTokenUrl(string backUrl)
        {
            if (backUrl != null)
            {
                string backURL = Server.UrlDecode(backUrl);

                //获取Cookie
                HttpCookie tokenCookie = Request.Cookies["Token"];
                if (tokenCookie != null)
                {
                    backURL = backURL.Replace("$Token$", tokenCookie.Values["Value"].ToString());
                }

                return Redirect(backURL);
            }
            return null;
        }

        /// <summary>
        /// 根据令牌获取用户凭证,Client调用它
        /// </summary>
        /// <param name="tokenValue"></param>
        /// <returns></returns>
        public object TokenGetCredence(string tokenValue)
        {
            object o = null;

            var sso = SSOManager.Instance.GetCacheTable();// CacheManager.GetCacheTable();
            if (sso != null)
            {
                var entity = sso.FirstOrDefault(i => i.Token == tokenValue);
                if (entity != null)
                {
                    o = entity.Certificate;
                }
            }

            return o;
        }

        /// <summary>
        /// 清除凭证,Client调用它
        /// </summary>
        /// <param name="tokenValue"></param>
        public void ClearToken(string tokenValue)
        {
            var sso = SSOManager.Instance.GetCacheTable();// CacheManager.GetCacheTable();
            if (sso != null)
            {
                var entity = sso.FirstOrDefault(i => i.Token == tokenValue);
                if (entity != null)
                {
                    sso.Remove(entity);
                }
            }
        }
        #endregion
    }
}
