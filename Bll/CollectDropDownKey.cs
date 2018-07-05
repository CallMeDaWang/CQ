using System.Net;
using System.IO;
using CQ.Entity;
using System.Text;
using CQ.Utils;

namespace CQ.Bll
{
    public class CollectDropDownKey
    {
        public string Key { get; set; }

        public CollectDropDownKey(string key)
        {
            this.Key = key;
        }
        public string GetDropDownBoxText()
        {
            DropDownBoxResult result = Collect(false);
            return DropDownBoxResultHandle(result);
        }
        private string DropDownBoxResultHandle(DropDownBoxResult result)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < result.Result.Count; i++)
            {
                sb.AppendLine(result.Result[i][0].Replace(this.Key, ""));
            }
            return sb.ToString();
        }
        private DropDownBoxResult Collect(bool extend)
        {
            string baseUrl = "https://suggest.taobao.com/sug";
            Param param = new Param() { code = "utf-8", q = this.Key, _ksTS = "1530585767326_972", callback = "", k = "1", area = "c2c", bucketid = "14" };
            string url = RequestUrlHelper.CreateUrl(baseUrl, param);
            CookieContainer cookie = RequestHelper.GetCookie("http://www.taobao.com", "GET");
            string content = RequestHelper.GetContent(cookie, url);
            DropDownBoxResult result = JsonHelper.DeserializeJsonToObject<DropDownBoxResult>(content);
            return result;
        }
    }
}
