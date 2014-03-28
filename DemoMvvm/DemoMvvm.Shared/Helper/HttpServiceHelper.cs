using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DemoMvvm.Shared.Helper
{
    public class HttpServiceHelper
    {
        public async Task<int> SubmitDummyRequest(string name, string email, int categoryId, string inquiry)
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync("http://httpstat.us/200");
            return (int) response.StatusCode;
        }

    }
}
