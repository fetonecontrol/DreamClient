using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace DreamClient.Models
{
  public class Dream
    {
      public int DreamId { get; set; }
      public DateTime Date { get; set; }
      public string UserName { get; set; }
      public string Title { get; set; }
      public string Body { get; set; }


      public static List<Dream> GetDreams()
      {
        var apiCallTask = ApiHelper.ApiCall();
        var result = apiCallTask.Result;

        JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
        List<Dream> dreamList = JsonConvert.DeserializeObject<List<Dream>>(jsonResponse.ToString());

        return dreamList;
      }
      public static void Post(Dream dream)
      {
        string jsonPlace = JsonConvert.SerializeObject(dream);
        var apiCallTask = ApiHelper.Post(jsonPlace);
      }

    }
    
}