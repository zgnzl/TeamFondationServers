using CNKI_Mngr;
using System;
using System.Web;

namespace CnkiAuthMngr
{
    public class UserRights
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        private static IAuthMngr CreateInstance(string _UserLoginPlatform)
        {
            if (string.IsNullOrEmpty(_UserLoginPlatform))
                throw new ArgumentNullException("平台参数不能为空",new Exception());
                    IAuthMngr mngr = TAuthMngr.Create(_UserLoginPlatform);
            if (mngr == null)
                throw new NullReferenceException("TAuthMngr.Create(string _UserLoginPlatform)");
            return mngr;
        }

        public static UserRightInfo GetUserInfo(out string errorMsg, string _UserLoginPlatform,string uid, string productID )
        {
            IAuthMngr mngr = CreateInstance(_UserLoginPlatform);
            int ret = mngr.UserLogin(uid, GetUserIP());
            errorMsg = ((CNKI_Mngr.TAuthMngr)mngr).ErrorMessage;
            return GetProductInfo(ret, mngr, productID);  
        }

        public static UserRightInfo GetUserInfo( out string errorMsg,string _UserLoginPlatform,string username,string password,LogonType logontype, string productID)
        {
            IAuthMngr mngr = CreateInstance(_UserLoginPlatform);
            int ret = mngr.UserLogin(username,password, GetUserIP(), logontype);
            errorMsg = ((TAuthMngr)mngr).ErrorMessage;
            return GetProductInfo(ret, mngr, productID);
        }

        private static UserRightInfo GetProductInfo(int ret, IAuthMngr mngr,string productID)
        {
            if (ret == 1)
            {
                return mngr.GetUserInfo().RightInfo[productID];
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 获取用户IP
        /// </summary>
        /// <returns></returns>
        public static string GetUserIP()
        {
            string ip = string.Empty;
            if (!string.IsNullOrEmpty(HttpContext.Current.Request.ServerVariables["HTTP_VIA"]))
                ip = Convert.ToString(HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"]);
            if (string.IsNullOrEmpty(ip))
                ip = Convert.ToString(HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"]);
            if (ip.Equals("::1"))
                ip = "127.0.0.1";

            return ip;
        }
    }
}
