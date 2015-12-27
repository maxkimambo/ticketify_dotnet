
namespace Ticket.UI.Web.helpers
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Serialization;
    using System.IO;

    public static class JsonHelper
    {
        public static string ToJson(this object obj)
        {

            using (var stringWriter = new StringWriter())
            using (var jsonWriter = new JsonTextWriter(stringWriter))
            {

                var serializer = new JsonSerializer();
                serializer.ContractResolver = new CamelCasePropertyNamesContractResolver();

                // to disable quotes around object names
                jsonWriter.QuoteName = false;

                serializer.Serialize(jsonWriter, obj);
                return stringWriter.ToString();
            }


        }
    }
}