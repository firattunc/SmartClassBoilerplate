using Abp;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Entities;
using Abp.Domain.Repositories;
using Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using SmartClass.Tests.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartClass.Tests
{
    public class TestService : ApplicationService, ITestService
    {
        private readonly IRepository<GenelIstatistik> _repositoryGenelIstatistik;
        private readonly IRepository<TestSonuc> _repositoryTestSonuc;
        private readonly IRepository<Cevap> _repositoryCevap;
        private readonly IRepository<Ogrenci> _repositoryOgrenci;
        private readonly IRepository<Soru> _repositorySoru;
        public TestService(IRepository<GenelIstatistik> repositoryGenelIstatistik, IRepository<TestSonuc> repositoryTestSonuc
            , IRepository<Cevap> repositoryCevap, IRepository<Ogrenci> repositoryOgrenci, IRepository<Soru> repositorySoru)
        {
            _repositorySoru = repositorySoru;
            _repositoryCevap = repositoryCevap;
            _repositoryOgrenci = repositoryOgrenci;
            _repositoryTestSonuc = repositoryTestSonuc;
            _repositoryGenelIstatistik = repositoryGenelIstatistik;
        }
        public async Task<ListResultDto<PuanGrafikDto>> GetAllPuanGrafik(int id)
        {
            try
            {
                List<PuanGrafikDto> puanGrafikDtos = new List<PuanGrafikDto>();
                var tests = _repositoryTestSonuc.GetAllIncluding(x=>x.Cevaps).Include(x => x.Ogrenci).Where(x => x.Ogrenci.UserId == id);
                if (await tests.CountAsync()==0)
                {
                    throw new EntityNotFoundException { };
                }
                foreach (var test in tests)
                {
                    var soruAdet = 100 / (double)test.Cevaps.Count;
                    puanGrafikDtos.Add(new PuanGrafikDto { Puan = test.DogruSayisi * soruAdet, Tarih = test.BitisTarih.ToString() });
                }
                return new ListResultDto<PuanGrafikDto>(puanGrafikDtos);
            }
            catch (Exception)
            {
                throw new AbpException { };
            }
        }

        public async Task<ListResultDto<TestIstatistikDto>> GetTestIstatistikById(int id)
        {
            try
            {
                var testIstatistikDtos = new List<TestIstatistikDto>();
                var testSonuc = await _repositoryTestSonuc.FirstOrDefaultAsync(x => x.Id == id);
                var ogrenciId = (await _repositoryOgrenci.FirstOrDefaultAsync(x => x.Id == testSonuc.OgrenciId)).Id;
                var basariYuzdeleri = await _repositoryGenelIstatistik.GetAllIncluding(x=>x.AltBaslik)
                    .Where(x => x.OgrenciId == ogrenciId)
                    .OrderBy(x => x.DogruSayisi)
                    .ToListAsync();
                int dogruSayisi = 0;
                foreach (var item in basariYuzdeleri)
                {
                    //AltBaslikla ilgili çözülmüş sorular
                    var soruAltBaslik =await _repositoryCevap.GetAllIncluding(x=>x.Soru.SoruAltBasliks)
                            .Where(x => x.Soru.SoruAltBasliks.FirstOrDefault().AltBaslikId == item.AltBaslikId && x.Ogrenci.Id == ogrenciId
                            && x.TestSonucId == testSonuc.Id).ToListAsync();
                    //AltBaslik'tan kaç tane sorulmuş
                    int soruCountAltBaslik = soruAltBaslik.Count;

                    foreach (var cevap in soruAltBaslik)
                    {
                        if (Convert.ToInt32(cevap.IsTrue) == 1)
                        {
                            dogruSayisi++;
                        }
                    }
                    float yuzde;
                    if (soruCountAltBaslik != 0)
                    {
                        yuzde = ((float)dogruSayisi / soruCountAltBaslik);
                    }
                    else
                    {
                        yuzde = 0;
                    }
                    testIstatistikDtos.Add(new TestIstatistikDto
                    {
                        BasariYuzdesi = yuzde,
                        AltBaslikAdi = item.AltBaslik.AltBaslikAdi
                    });
                    dogruSayisi = 0;
                }
                return new ListResultDto<TestIstatistikDto>(testIstatistikDtos);
            }
            catch (Exception ex)
            {

                throw new AbpException { };
            }
        }

        public async Task<string> GetTestPuanByTestId(int id)
        {
            var test = await _repositoryTestSonuc.GetAllIncluding(x=>x.Cevaps).FirstOrDefaultAsync(x => x.Id == id);
            var soruAdet = test.Cevaps.Count;
            double oran = 100 / (double)soruAdet;
            var puan = (test.DogruSayisi * oran);
            string result = puan.ToString("0.00");
            return result;
        }

        public Task<ListResultDto<TestTarihDto>> GetTestTarihlerByKullaniciId(int id)
        {
            var listResultDto = new ListResultDto<TestTarihDto>();            
        }

        public Task<TesteBaslaResultDto> TesteBaslaByKullaniciId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
