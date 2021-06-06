using AboutMe.Domain.Abstract.Repositories;
using AboutMe.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AboutMe.Infrastructure.Repositories
{
    public class MyInfoService : IMyInfoService
    {
        public async Task<MyInfo> GetMyInfoAsync()
        {
            return await GetMyInfo();
        }

        //Mocked async method
        private Task<MyInfo> GetMyInfo()
        {
            List<string> skills = new List<string>
            {
                "C#", "ASP.NET", "ASP.NET MVC", "ASP.NET CORE", "Web API", "Windows Forms", "Xamarin Forms", "Angular", "SQL Server", "MongoDB", "ADO.NET",
                "Entity Framework", "LINQ", "HTML", "CSS", "Microsoft Azure"
            };

            MyInfo myInfo = new MyInfo();
            myInfo.MyInfoObject = new MyInfoModel
            {
                Title = "Hi, I'm Durgaprasad Vasupalli a Full Stack Developer!",
                Description = "With comprehensive experience in diverse facets of analysis, design, development, and execution of software applications.  " +
                "A true team player offering 8 years of experience in the software industry, skilled at technical leadership, communication and experienced in " +
                "full project life cycle from design to implementation to integration.",
                ProfileImage = "assets/profile-img.jpeg",
                Skills = skills
            };

            return Task.FromResult<MyInfo>(myInfo);
        }
    }
}
