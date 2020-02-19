using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SmartClass.Tests.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SmartClass.GenelIstatistiks
{
    public interface IGenelIstatistikService:IApplicationService
    {
        Task<ListResultDto<TestIstatistikDto>> GetIstatistikByOgrenciNo(int no);
        Task<ListResultDto<TestIstatistikDto>> GetIstatistikByKullaniciId(int id);
    }
}
