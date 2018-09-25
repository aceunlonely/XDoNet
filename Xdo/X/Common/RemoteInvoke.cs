using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;

namespace X.Common
{
    internal class RemoteInvoke
    {
        public static string Call(string url,string param, WebapiConfig config = null,Dictionary<string,string> httpRequestHeaderMap = null)
        {
            if (config == null) config = new WebapiConfig();
            
            using (WebClientWithTimeout web = new WebClientWithTimeout())
            {
                //超时过期
                web.Timeout = (int)(1000 * config.timeoutSecond);
                web.Proxy = null;
                web.Encoding = config.Encode;
                if (httpRequestHeaderMap != null)
                {
                    foreach (KeyValuePair<string, string> kv in httpRequestHeaderMap) {
                        web.Headers.Add(kv.Key, kv.Value);
                    }
                }
                if (string.IsNullOrEmpty(param) == false  )
                {
                    if (config.ParamsType == ParamType.FORM)
                    {
                        web.Headers.Add(HttpRequestHeader.ContentType, "application/x-www-form-urlencoded");
                        byte[] postData = Encoding.UTF8.GetBytes(param);
                        byte[] responseData = web.UploadData(url, config.Method.ToString(), postData);//得到返回字符流
                        string srcString = Encoding.UTF8.GetString(responseData);
                        return srcString;
                    }
                    else if (config.ParamsType == ParamType.JSON)
                    {
                        web.Headers.Add(HttpRequestHeader.ContentType, "application/json");
                        
                        return web.UploadString(url, config.Method.ToString(), param);
                    }
                    return web.UploadString(url, config.Method.ToString(), param);
                }
                if(config.Method == HttpMethod.GET)
                    return web.DownloadString(url);
                return web.UploadString(url, config.Method.ToString(), "");

            }
        }
    }

    public class WebapiConfig
    {
        public Encoding Encode = Encoding.UTF8;
        public double timeoutSecond = Config.XWebclientTimeoutSeconds;
        public HttpMethod Method = HttpMethod.POST;
        public ParamType ParamsType = ParamType.FORM;
    }

    public enum HttpMethod {
         GET = 1,POST =2, PUT = 3, DELETE =4
    }

    public enum ParamType {
        FORM =1,
        COOKIE = 2,
        OTHER =3,
        JSON =4
    }
}
