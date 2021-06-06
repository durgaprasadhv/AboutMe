using System;
using System.Collections.Generic;
using System.Text;

namespace AboutMe.Domain.Entities
{
    public class MyInfoModel
    {
        public MyInfoModel()
        {
            Skills = new List<string>();
        }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ProfileImage { get; set; }
        public List<string> Skills { get; set; }
    }
}
