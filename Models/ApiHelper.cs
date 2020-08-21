using System.Threading.Tasks;
using RestSharp;

namespace DreamClient.Models
{
  class ApiHelper
  {
    public static async Task<string> ApiCall()
    {
      RestClient client = new RestClient("http://localhost:5000/api/Dreams/");
      RestRequest request = new RestRequest($"dreams", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
  }
}