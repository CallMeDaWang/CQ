using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CQ.Utils
{
    public class RequestHelper
    {
        public static CookieContainer GetCookie(string url, string method)
        {

            CookieContainer cookie = new CookieContainer();
            HttpWebRequest httpRequset = (HttpWebRequest)HttpWebRequest.Create(url);//创建http 请求
            httpRequset.CookieContainer = cookie;//设置cookie
            httpRequset.Method = method;//POST 提交
            httpRequset.KeepAlive = true;
            httpRequset.UserAgent = "Mozilla/5.0 (Windows NT 6.3; WOW64; Trident/7.0; rv:11.0) like Gecko";
            httpRequset.Accept = "*/*";
            //httpRequset.ContentType = "text/html; charset=utf-8";//以上信息在监听请求的时候都有的直接复制过来
            //byte[] bytes = System.Text.Encoding.UTF8.GetBytes(data);
            //httpRequset.ContentLength = bytes.Length;
            //  Stream stream = httpRequset.GetRequestStream();
            // stream.Write(bytes, 0, bytes.Length);
            //      stream.Close();//以上是POST数据的写入

            HttpWebResponse httpResponse = (HttpWebResponse)httpRequset.GetResponse();//获得 服务端响应
            return cookie;//拿到cookie
        }
        public static string GetContent(CookieContainer cookie, string url)
        {
            string content;
            HttpWebRequest httpRequest = (HttpWebRequest)HttpWebRequest.Create(url);
            httpRequest.CookieContainer = cookie;
            //httpRequest.Referer = url;
            httpRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.3; WOW64; Trident/7.0; rv:11.0) like Gecko";
            httpRequest.Accept = "text/html, application/xhtml+xml, */*";
            httpRequest.ContentType = "application/x-www-form-urlencoded";
            httpRequest.Method = "GET";

            HttpWebResponse httpResponse = (HttpWebResponse)httpRequest.GetResponse();

            using (Stream responsestream = httpResponse.GetResponseStream())
            {

                using (StreamReader sr = new StreamReader(responsestream, System.Text.Encoding.UTF8))
                {
                    content = sr.ReadToEnd();
                }
            }

            return content;
        }
    }
}
