using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication.Controllers
{
    public class WebAppController : ApiController
    {
        // GET api/values
        public IEnumerable<string> GetFruits()
        {
            return new string[] { 
                "Apple", 
                "Banana",
                "Canteloupe",
                "Durian",
                "Elderberry",
                "Fig",
                "Guava",
                "Honeydew Melon",
                "Icaco",
                "Jujube",
                "Kaffir Lime",
                "Loquat",
                "Medlar",
                "Nectarine",
                "Orangelo",
                "Papaya",
                "Quandong",
                "Rambutan",
                "Star Fruit",
                "Tamarind",
                "Umbu",
                "Voavanga",
                "Wolfberry",
                "Xylocarp",
                "Yuzu",
                "Zalzalak"
            };
        }
    }
}
