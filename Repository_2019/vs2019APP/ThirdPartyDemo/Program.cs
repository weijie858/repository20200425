using System;
using System.Net.Http;
using IdentityModel.Client;

namespace ThirdPartyDemo
{
    class Program
    {
        //第三方ClientCredential模式调用
        static void Main(string[] args)
        {
            var diso = DiscoveryClient.GetAsync("http://localhost:5000").Result;
            if (diso.IsError)
            {
                Console.WriteLine(diso.Error);
            }
            var tokenClient = new TokenClient(diso.TokenEndpoint, "client", "secret");
        var tockenResponse=    tokenClient.RequestClientCredentialsAsync("api").Result;
            if (tockenResponse.IsError)
            {
                Console.WriteLine(tockenResponse.Error);
            }
            else
            {
                Console.WriteLine(tockenResponse.Json);
            }
            var httpClient = new HttpClient();
            httpClient.SetBearerToken(tockenResponse.AccessToken);
            var response = httpClient.GetAsync("http://localhost:5001/api/values").Result;
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine(response.Content.ReadAsStringAsync().Result);
            }
     
            Console.ReadLine();
        }
    }
}
