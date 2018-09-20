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
        public static string Get(string url, string entityForm = null, WebapiConfig config=null) {
            config = config == null ? new WebapiConfig() {
                Method = HttpMethod.GET,
                ParamsType = ParamType.OTHER
            } : config;

           return RemoteInvoke.Call(url, entityForm, config);
        }

        /// <summary>
        /// 新增接口
        /// </summary>
        /// <param name="url"></param>
        /// <param name="entityForm"></param>
        /// <param name="config"></param>
        /// <returns></returns>
        public static string POST(string url,string entityForm,WebapiConfig config = null) {
            config = config == null ? new WebapiConfig()
            {
                Method = HttpMethod.POST,
                ParamsType = ParamType.FORM
            } : config;
            return RemoteInvoke.Call(url, entityForm, config);
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="url"></param>
        /// <param name="entityForm"></param>
        /// <param name="config"></param>
        /// <returns></returns>
        public static string PUT(string url, string entityForm, WebapiConfig config = null)
        {
            config = config == null ? new WebapiConfig()
            {
                Method = HttpMethod.PUT,
                ParamsType = ParamType.FORM
            } : config;
            return RemoteInvoke.Call(url, entityForm, config);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="url"></param>
        /// <param name="entityForm"></param>
        /// <param name="config"></param>
        /// <returns></returns>
        public static string DELETE(string url,string entityForm = null, WebapiConfig config = null)
        {
            config = config == null ? new WebapiConfig()
            {
                Method = HttpMethod.DELETE,
                ParamsType = ParamType.FORM
            } : config;
            return RemoteInvoke.Call(url, entityForm, config);
        }

    }
}
