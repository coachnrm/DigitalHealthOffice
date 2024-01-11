using Newtonsoft.Json.Linq;
using DemoSimpleBlazorUserAndRoleManager.Models;
namespace DemoSimpleBlazorUserAndRoleManager.Controller;

public class ServiceHelper2
{
    //private static Uri DataBaseAddress { get; set; } = new Uri("http://183.89.226.246:189");
    private static Uri DataBaseAddress { get; set; } = new Uri("http://172.16.200.202:5020");

    public async static Task<List<Wannnut>> GetWanNut(string _hn) //  วันนัด
        {
            var param = new Dictionary<string, string>();

            param.Add("_hn", _hn);

            var content = new FormUrlEncodedContent(param);
            var client = new HttpClient();
            client.BaseAddress = DataBaseAddress;
            var response = await client.PostAsync("api/ShotPerson/GetShotPersonDetail", content);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var json = await response.Content.ReadAsStringAsync();
                return JArray.Parse(json).ToObject<List<Wannnut>>();
            }
            else return new List<Wannnut>();
        }

}