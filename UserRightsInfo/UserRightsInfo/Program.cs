using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRightsInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            TPIManager.CTpiGlobals conn = TPI.CommonFunc.DBClass.BuildConnect();
            IRightMngr mngr = conn.RightMngr;
        }

        /// <summary>
        /// 取得库中用户有权限的刊名
        /// </summary>
        /// <param name="rootId"></param>
        /// <param name="userKey"></param>
        /// <returns></returns>
        public static string GetBuyList(string rootId, string userKey)
        {
            string cacheKey = "CCGBBook_UserBuyBook_" + userKey;
            //if (HttpContext.Current.Cache[cacheKey] == null)
            {
                string reValue = string.Empty;
                string pName;
                string sReRights = TPI.CommonFunc.DBClass.BuildConnect().TPILoginObj.GetUserRights(rootId.ToLower(), out pName);
                if (!string.IsNullOrEmpty(sReRights))
                {
                    sReRights = sReRights.TrimEnd(';').ToUpper();

                    if (string.IsNullOrEmpty(sReRights))
                        return reValue;

                    if (sReRights == rootId.ToUpper())
                    {
                        reValue = "*";
                    }
                    else if (sReRights.IndexOf(rootId) >= 0)
                    {
                        string[] item = sReRights.Split(';');
                        StringBuilder bookList = new StringBuilder();
                        foreach (string name in item)
                        {
                            bookList.AppendFormat("{0}+", name.Substring(5));
                        }
                        reValue = bookList.ToString().TrimEnd('+');
                    }
                    //HttpContext.Current.Cache.Add(cacheKey, reValue, null, DateTime.Now.AddHours(6), TimeSpan.Zero, System.Web.Caching.CacheItemPriority.Default, null);
                }
            }
            //if (HttpContext.Current.Cache[cacheKey] != null)
            //    return (string)HttpContext.Current.Cache[cacheKey];
            //else
                return string.Empty;
        }
    }
}
