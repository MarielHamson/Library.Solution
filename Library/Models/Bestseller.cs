using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Library.Models
{
  public class Bestseller
  {
    public string Books { get; set; }


    public static List<Bestseller> GetBestsellers(string apiKey)
    {
      var apiCallTask = ApiHelper.ApiCall(apiKey);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<Bestseller> bestsellerList = JsonConvert.DeserializeObject<List<Bestseller>>(jsonResponse["results"].ToString());

      return bestsellerList;
    }
  }
}





























































































































