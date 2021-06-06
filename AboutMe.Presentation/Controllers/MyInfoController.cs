using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AboutMe.Domain.Entities;
using System.Net.Http;
using Newtonsoft.Json;

namespace AboutMe.Presentation.Controllers
{
    public class MyInfoController : Controller
    {
        public MyInfoController()
        {
        }

        public async Task<IActionResult> MyInfo()
        {
            MyInfo myInfo = new MyInfo();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:9999/api/myinfo"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    myInfo = JsonConvert.DeserializeObject<MyInfo>(apiResponse);
                }
            }
            return View(myInfo);
        }
    }
}
