using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using DemoSimpleBlazorUserAndRoleManager.Models;
namespace DemoSimpleBlazorUserAndRoleManager.Controller;

public class ServiceHelper3
{
    public static async Task<OutLab> GetOutLab(string lab_order_number)
    {
        var client = new HttpClient();
        var httpResponseMessage = await client.GetAsync("http://172.16.200.202:4000/api/v1/lab_order_image/?lab_order_number=" + lab_order_number);
        if (httpResponseMessage.IsSuccessStatusCode)
        {
            var contentStream = await httpResponseMessage.Content.ReadAsStringAsync();
            if (contentStream != null && contentStream != "null")
            {
                var json = await httpResponseMessage.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<OutLab>(json);
            }
        }
        return null;
    }
}