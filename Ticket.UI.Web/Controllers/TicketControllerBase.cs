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
            requestResult = new RequestResult();
            response = new RequestResponse();
        }

        /// <summary>
        /// To be used when we need to send alert dialogs to the client
        /// </summary>
        /// <param name="messsage"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public ActionResult SendRequestResult(string messsage, RequestResultType type)
        {
            requestResult.Message = messsage;
            requestResult.ResultType = type;

            return this.PartialView("_RequestResult", requestResult);
        }

        public ActionResult ToJson(object obj)
        {
            var settings = new JsonSerializerSettings
                               {
                                   ContractResolver = new CamelCasePropertyNamesContractResolver()
                               };
            var json = JsonConvert.SerializeObject(obj, Formatting.Indented, settings);
            return Content(json, "application/json");
        }

        public JsonResult SendJsonRequestResult(string message, bool success, object data)
        {
            response.Message = message;
            response.Data = data;
            response.Success = success;

            return Json(response, JsonRequestBehavior.AllowGet);
        }
    }
}