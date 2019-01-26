using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using Newbe.Mahua.HttpApiClient.Api;
using Newbe.Mahua.HttpApiClient.Model;
using Newtonsoft.Json;

namespace Newbe.Mahua.Plugins.Parrot
{
    public class ReceiveMahuaHandler : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            using (var sr = new StreamReader(context.Request.InputStream))
            {
                var json = sr.ReadToEnd();
                var body = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
                if (body != null &&
                    body.TryGetValue("TypeCode", out var typeCode) &&
                    typeCode == "ProcessPrivateMessage" &&
                    body.TryGetValue("Platform", out var platform) &&
                    int.TryParse(platform, out var intPlatform) &&
                    intPlatform == 0 &&
                    body.TryGetValue("FromQQ", out var qq) &&
                    body.TryGetValue("Msg", out var msg)
                )
                {
                    var cqpApi = new CqpApi("http://127.0.0.1:36524");
                    cqpApi.Apiv1CqpCQSendPrivateMsg(new CqpCQSendPrivateMsgHttpInput
                        {
                            Msg = msg,
                            Qqid = Convert.ToInt64(qq)
                        }
                    );
                }
            }
        }

        public bool IsReusable { get; } = false;
    }
}