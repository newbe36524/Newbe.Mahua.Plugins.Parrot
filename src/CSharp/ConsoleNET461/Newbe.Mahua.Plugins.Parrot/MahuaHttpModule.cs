using Nancy;
using Nancy.ModelBinding;
using Newbe.Mahua.HttpApiClient.Api;
using Newbe.Mahua.HttpApiClient.Model;
using System;

namespace Newbe.Mahua.Plugins.Parrot
{
    public class MahuaHttpModule : NancyModule
    {
        public MahuaHttpModule() : base("/api")
        {
            Post["/ReceiveMahuaOutput"] = parameters =>
            {
                var body = this.Bind<BodyModel>();
                if (body != null &&
                    body.TypeCode == "ProcessPrivateMessage" &&
                    body.Platform == 0
                )
                {
                    var cqpApi = new CqpApi("http://127.0.0.1:36524");
                    cqpApi.Apiv1CqpCQSendPrivateMsg(new CqpCQSendPrivateMsgHttpInput
                        {
                            Msg = body.Msg,
                            Qqid = body.FromQQ
                        }
                    );
                    return "ok";
                }

                return "nothing";
            };
        }
    }

    public class BodyModel
    {
        public string TypeCode { get; set; }
        public int SubType { get; set; }
        public long FromQQ { get; set; }
        public string Msg { get; set; }
        public int MsgId { get; set; }
        public int Font { get; set; }
        public int Platform { get; set; }
        public DateTime CreateTime { get; set; }
    }
}