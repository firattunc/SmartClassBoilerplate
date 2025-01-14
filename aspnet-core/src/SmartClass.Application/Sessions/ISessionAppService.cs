﻿using System.Threading.Tasks;
using Abp.Application.Services;
using SmartClass.Sessions.Dto;

namespace SmartClass.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
