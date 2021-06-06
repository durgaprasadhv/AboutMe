using AboutMe.Domain.Abstract.Repositories;
using AboutMe.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AboutMe.API.Controllers
{
    public class MyInfoController : Controller
    {
        private readonly IMyInfoService _myInfoService;
        public MyInfoController(IMyInfoService myInfoService)
        {
            _myInfoService = myInfoService;
        }

        [Route("api/[controller]")]
        [HttpGet]
        public async Task<IActionResult> GetMyInfo()
        {
            return Ok(await _myInfoService.GetMyInfoAsync());
        }
    }
}
