using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
namespace DownloadVideo.Common {
    public class HttpWebResponseUtility {
        private static readonly string DefaultUserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; SV1; .NET CLR 1.1.4322; .NET CLR 2.0.50727)";
       
        /// <summary>
        /// 创建Get方式的HTTP请求
        /// </summary>
        /// <param name="url">请求的地址</param>
        /// <param name="cookies">随同HTTP请求发送的Cookie</param>
        /// <param name="userAgent">请求的客户端浏览器信息</param>
        /// <param name="timeout">请求的超时时间</param>
        /// <returns></returns>
        private static HttpWebRequest CreateRequest(string url, CookieCollection cookies, string userAgent, int? timeout) {
            if (string.IsNullOrEmpty(url)) {
                throw new ArgumentNullException("url不得为空");
            }
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            request.Method = "GET";
            request.UserAgent = DefaultUserAgent;
            if (!string.IsNullOrEmpty(userAgent)) {
                request.UserAgent = userAgent;
            }
            if (timeout.HasValue) {
                request.Timeout = timeout.Value;
            }
            if (cookies != null) {
                request.CookieContainer = new CookieContainer();
                request.CookieContainer.Add(cookies);
            }
            //request.Headers.Set(HttpRequestHeader.AcceptLanguage, "zh-CN,zh;q=0.8,en;q=0.6");
            //request.Headers.Set(HttpRequestHeader.ContentEncoding, "gzip,deflate,sdch");
            //request.Headers.Set(HttpRequestHeader.AcceptCharset, "gb2312");
            request.ContentType = "text/html; charset='gb2312'";
            return request;
        }

        /// <summary>
        /// 异步创建Get方式的HTTP请求 并取得响应
        /// </summary>
        /// <param name="url">请求的地址</param>
        /// <param name="cookies">随同HTTP请求发送的Cookie</param>
        /// <param name="userAgent">请求的客户端浏览器信息</param>
        /// <param name="timeout">请求的超时时间</param>
        /// <returns></returns>
        public static async Task<WebResponse> CreateGetHttpResponseAsync(string url, CookieCollection cookies, string userAgent, int? timeout) {
            var request = CreateRequest(url, cookies, userAgent, timeout);
            var ws = await request.GetResponseAsync();
            return ws;
        }

        /// <summary>
        /// 创建Get方式的HTTP请求 并取得响应
        /// </summary>
        /// <param name="url">请求的地址</param>
        /// <param name="cookies">随同HTTP请求发送的Cookie</param>
        /// <param name="userAgent">请求的客户端浏览器信息</param>
        /// <param name="timeout">请求的超时时间</param>
        /// <returns></returns>
        public static WebResponse CreateGetHttpResponse(string url, CookieCollection cookies, string userAgent, int? timeout) {
            var request = CreateRequest(url, cookies, userAgent, timeout);
            var ws = request.GetResponse();
            return ws;
        }
    }
}
