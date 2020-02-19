using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SmartClass.Tests.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SmartClass.Tests
{
    public interface ITestService: IApplicationService
    {
        Task<ListResultDto<PuanGrafikDto>> GetAllPuanGrafik(int id);
        Task<ListResultDto<TestIstatistikDto>> GetTestIstatistikById(int id);
        Task<ListResultDto<TestTarihDto>> GetTestTarihlerByKullaniciId(int id);
        Task<string> GetTestPuanByTestId(int id);
        Task<TesteBaslaResultDto> TesteBaslaByKullaniciId(int id);

    }
}
