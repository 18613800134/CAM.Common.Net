using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CAM.Common.Net.Cookie
{
    public class CookieHandler
    {
        public static void set(string key, string value)
        {
            HttpContext.Current.Response.Cookies.Add(new HttpCookie(key, value));
        }

        public static string read(string key)
        {
            string value = "";
            HttpCookie cookie = HttpContext.Current.Request.Cookies[key];
            if (cookie != null)
            {
                value = cookie.Value;
            }
            return value;
        }

        public static void remove(string key)
        {
            HttpCookie cookie = HttpContext.Current.Response.Cookies[key];
            if (cookie != null)
            {
                cookie.Value = null;
                cookie.Expires = DateTime.Now.AddMonths(-1);
            }
        }
    }
}
