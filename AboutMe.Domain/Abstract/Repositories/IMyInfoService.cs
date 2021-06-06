using AboutMe.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AboutMe.Domain.Abstract.Repositories
{
    public interface IMyInfoService
    {
        Task<MyInfo> GetMyInfoAsync();
    }
}
