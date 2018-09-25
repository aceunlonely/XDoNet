using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using X.Common;

namespace WebapiClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test();
            Test();
            Console.Read();
        }

        static void Test() {
            //http://localhost/WebapiServer/api/values
            //查询
            Console.WriteLine("GET : "+ X.Invoke.Webapi.Get("http://localhost/WebapiServer/api/values/3"));
            //新增
            Console.WriteLine("POST : " + X.Invoke.Webapi.POST("http://localhost/WebapiServer/api/values","name=LiSA&age=3"));
            //修改
            Console.WriteLine("PUT : " + X.Invoke.Webapi.PUT("http://localhost/WebapiServer/api/values/3", "name=LiSA&age=3"));
            //删除
            Console.WriteLine("DELETE : " + X.Invoke.Webapi.DELETE("http://localhost/WebapiServer/api/values/3"));

        }
        static void Test2()
        {
            //http://localhost/WebapiServer/api/tests
            //查询
            Console.WriteLine("GET : " + X.Invoke.Webapi.Get("http://localhost/WebapiServer/api/test/1"));
            //新增
            Console.WriteLine("POST : " + X.Invoke.Webapi.POST("http://localhost/WebapiServer/api/test", "{ \"name\" : \"LiSA\", \"age\": 3}",new WebapiConfig() { Method= HttpMethod.POST, ParamsType= ParamType.JSON}));
            //修改
            Console.WriteLine("PUT : " + X.Invoke.Webapi.PUT("http://localhost/WebapiServer/api/test/3", "{ \"name\" : \"LiSA\", \"age\": 3}" , new WebapiConfig() { Method = HttpMethod.PUT , ParamsType = ParamType.JSON}));
            //删除
            Console.WriteLine("DELETE : " + X.Invoke.Webapi.DELETE("http://localhost/WebapiServer/api/test/4"));


        }
    }
}
