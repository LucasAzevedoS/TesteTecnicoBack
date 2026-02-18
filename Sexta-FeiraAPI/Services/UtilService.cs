using Newtonsoft.Json;
using Barber.Models;

namespace Barber.Services
{
    public class UtilService
    {
        public string? SeviceConn()
        {
            using (StreamReader r = new StreamReader("appsettings.json"))
            {
                var obj = JsonConvert.DeserializeObject<SeviceConnect>(r.ReadToEnd());

                return obj?.Ambiente == "P" ? obj?.ServiceConn_P : obj?.ServiceConn_H;
            }
        }
    }
}
