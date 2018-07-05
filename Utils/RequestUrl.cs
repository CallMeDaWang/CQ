using CQ.Entity;
using System.Reflection;
using System.Text;

namespace CQ.Utils
{
    public class RequestUrl
    {
        public static string CreateUrl(string baseUrl, Param param)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(baseUrl).Append("?");
            PropertyInfo[] properties = param.GetType().GetProperties();
            foreach (PropertyInfo property in properties)
            {
                string name = property.Name;
                string value = (string)property.GetMethod.Invoke(param, null);
                if (value != null)
                {
                    sb.Append(name + "=" + value+"&");
                }
            }
            string url = sb.ToString();
            url = url.Substring(0, url.Length - 1);
            return url.Replace("__", "-");
        }
    }
}
