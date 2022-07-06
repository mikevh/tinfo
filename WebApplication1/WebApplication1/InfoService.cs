using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1
{
    public interface IInfoService
    {
        Task<TmobileInfo> GetInfo();
    }

    public class InfoService : IInfoService
    {
        public async Task<TmobileInfo> GetInfo()
        {
            var http = new HttpClient
            {
                BaseAddress = new Uri("http://192.168.12.1/"),
            };

            var response = await http.GetAsync("/TMI/v1/gateway?get=all");
            var content = await response.Content.ReadAsStringAsync();

            var rv = JsonConvert.DeserializeObject<TmobileInfo>(content);

            return rv;
        }
    }
}
