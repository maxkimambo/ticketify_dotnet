using System.Web.Mvc;

namespace Ticket.UI.Web.Controllers
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Serialization;

    using Ticket.UI.Web.helpers;
    using Ticket.UI.Web.Models;

    public class TicketControllerBase : Controller
    {
        private RequestResult requestResult;

        private RequestResponse response;

        public TicketControllerBase()
        {
            this.requestResult = new RequestResult();
            this.response = new RequestResponse();
        }

        /// <summary>
        /// To be used when we need to send alert dialogs to the client
        /// </summary>
        /// <param name="messsage"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public ActionResult SendRequestResult(string messsage, RequestResultType type)
        {
            this.requestResult.Message = messsage;
            this.requestResult.ResultType = type;

            return this.PartialView("_RequestResult", this.requestResult);
        }

        public ActionResult ToJson(object obj)
        {
            var settings = new JsonSerializerSettings
                               {
                                   ContractResolver = new CamelCasePropertyNamesContractResolver()
                               };
            var json = JsonConvert.SerializeObject(obj, Formatting.Indented, settings);
            return this.Content(json, "application/json");
        }

        public JsonResult SendJsonRequestResult(string message, bool success, object data)
        {
            this.response.Message = message;
            this.response.Data = data;
            this.response.Success = success;

            return this.Json(this.response, JsonRequestBehavior.AllowGet);
        }
    }
}