using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using X.Common;

namespace X.Invoke
{
    public class Webapi
    {
        /// <summary>
        /// 查询接口
        /// </summary>
        /// <param name="url"></param>
        /// <param name="config"></param>
        /// <returns></returns>
        public static string Get(string url, string entityForm = null, WebapiConfig config=null, Dictionary<string, string> httpRequestHeaderMap = null) {
            config = config == null ? new WebapiConfig() {
                ParamsType = ParamType.OTHER
            } : config;
            config.Method = HttpMethod.GET;
           return RemoteInvoke.Call(url, entityForm, config, httpRequestHeaderMap);
        }

        /// <summary>
        /// 新增接口
        /// </summary>
        /// <param name="url"></param>
        /// <param name="entityForm"></param>
        /// <param name="config"></param>
        /// <returns></returns>
        public static string POST(string url,string entityForm,WebapiConfig config = null, Dictionary<string, string> httpRequestHeaderMap = null) {
            config = config == null ? new WebapiConfig()
            {
                ParamsType = ParamType.FORM
            } : config;
            config.Method = HttpMethod.POST;
            return RemoteInvoke.Call(url, entityForm, config, httpRequestHeaderMap);
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="url"></param>
        /// <param name="entityForm"></param>
        /// <param name="config"></param>
        /// <returns></returns>
        public static string PUT(string url, string entityForm, WebapiConfig config = null, Dictionary<string, string> httpRequestHeaderMap = null)
        {
            config = config == null ? new WebapiConfig()
            {
                ParamsType = ParamType.FORM
            } : config;
            config.Method = HttpMethod.PUT;
            return RemoteInvoke.Call(url, entityForm, config, httpRequestHeaderMap);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="url"></param>
        /// <param name="entityForm"></param>
        /// <param name="config"></param>
        /// <returns></returns>
        public static string DELETE(string url,string entityForm = null, WebapiConfig config = null, Dictionary<string, string> httpRequestHeaderMap = null)
        {
            config = config == null ? new WebapiConfig()
            {
                ParamsType = ParamType.FORM
            } : config;
            config.Method = HttpMethod.DELETE;
            return RemoteInvoke.Call(url, entityForm, config, httpRequestHeaderMap);
        }

    }
}
