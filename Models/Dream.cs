using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using DreamClient.Models;

namespace DreamClient.Models
{
  public class Dream
    {
      public int DreamId { get; set; }
      public int UserId { get; set; }
      public string UserName { get; set; }
      public string Title { get; set; }
      public string Body { get; set; }

      public static List<Dream> GetDreams()
    {
      var apiCallTask = ApiHelper.ApiCall();
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<Dream> dreamList = JsonConvert.DeserializeObject<List<Dream>>(jsonResponse["results"].ToString());

      return dreamList;
    }
    }
    
}