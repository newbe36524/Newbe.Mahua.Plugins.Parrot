using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Newbe.Mahua.HttpApiClient.Api;
using Newbe.Mahua.HttpApiClient.Model;

namespace Newbe.Mahua.Plugins.Parrot.Controllers
{
    public class ReceiveMahuaOutputController : Controller
    {
        /// <summary>
        /// 接受并处理收到好友消息事件
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        [HttpPost("api/ReceiveMahuaOutput")]
        public ActionResult Reveive(
            [FromBody] IReadOnlyDictionary<string, string> body)
        {
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

            return Ok();
        }
    }
}