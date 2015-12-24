
namespace Ticket.UI.Web.Models
{
    public enum RequestResultType
    {
        Success,
        Failed,
        Warning,
        Info
    }

    public class RequestResult
    {
        public RequestResultType ResultType { get; set; }
        public string Message { get; set; }
    }
}