using Abp;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Collections.Extensions;
using Abp.Domain.Entities;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using SmartClass.Tests.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartClass.GenelIstatistiks
{
    public class GenelIstatistikService : ApplicationService, IGenelIstatistikService
    {
        private readonly IRepository<GenelIstatistik> _repositoryGenelIstatistik;
        private readonly IRepository<TestSonuc> _repositoryTestSonuc;        
        private readonly IRepository<Cevap> _repositoryCevap;
        private readonly IRepository<Ogrenci> _repositoryOgrenci;
        public GenelIstatistikService(IRepository<GenelIstatistik> repositoryGenelIstatistik,IRepository<TestSonuc> repositoryTestSonuc,
            ,IRepository<Cevap> repositoryCevap, IRepository<Ogrenci> repositoryOgrenci)
        {
            _repositoryCevap = repositoryCevap;                 
            _repositoryOgrenci = repositoryOgrenci;
            _repositoryTestSonuc = repositoryTestSonuc;
            _repositoryGenelIstatistik = repositoryGenelIstatistik;
        }
        public async Task<ListResultDto<TestIstatistikDto>> GetIstatistikByKullaniciId(int id)
        {
            try
            {
                var testSonuc = await _repositoryTestSonuc.GetAllIncluding(x=>x.Ogrenci).FirstOrDefaultAsync(x => x.Ogrenci.UserId == id);
                if (testSonuc == null)
                {
                    throw new EntityNotFoundException { };
                }
                var testIstatistikDtos = new List<TestIstatistikDto>();
                var ogrenciId = _repositoryOgrenci.FirstOrDefaultAsync(x => x.UserId == id).Id;
                var basariYuzdeleri = await _repositoryGenelIstatistik.GetAllIncluding(x=>x.AltBaslik)
                    .Where(x => x.OgrenciId == ogrenciId)                    
                    .OrderBy(x => x.DogruSayisi)
                    .ToListAsync();
                foreach (var item in basariYuzdeleri)
                {
                    //AltBaslik'tan kaç tane sorulmuş
                    var soruCountAltBaslik = await _repositoryCevap.GetAllIncluding(x => x.Soru.SoruAltBasliks)
                        .Where(x => x.Soru.SoruAltBasliks.FirstOrDefault().AltBaslikId == item.AltBaslikId && x.Ogrenci.Id == ogrenciId).CountAsync();                    
                    float yuzde;
                    if (soruCountAltBaslik != 0)
                    {
                        yuzde = ((float)item.DogruSayisi / soruCountAltBaslik);
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
                }
                return new ListResultDto<TestIstatistikDto>(testIstatistikDtos);
            }
            catch (Exception ex)
            {
                throw new AbpException { };
            }
        }

        public async Task<ListResultDto<TestIstatistikDto>> GetIstatistikByOgrenciNo(int no)
        {            
            try
            {
                var ogrenci = _repositoryOgrenci.FirstOrDefaultAsync(x => x.No == no);
                if (ogrenci == null)
                {
                    throw new EntityNotFoundException { };
                }
                var testSonuc = await _repositoryTestSonuc.GetAllIncluding(x=>x.Ogrenci).FirstOrDefaultAsync(x => x.Ogrenci.UserId == ogrenci.Id);
                if (testSonuc == null)
                {
                    throw new EntityNotFoundException { };
                }
                var testIstatistikDtos = new List<TestIstatistikDto>();                
                var basariYuzdeleri = await _repositoryGenelIstatistik.GetAllIncluding(x => x.AltBaslik)
                    .Where(x => x.OgrenciId == ogrenci.Id)
                    .OrderBy(x => x.DogruSayisi)
                    .ToListAsync();
                foreach (var item in basariYuzdeleri)
                {
                    //AltBaslik'tan kaç tane sorulmuş
                    var soruCountAltBaslik = await _repositoryCevap.GetAllIncluding(x => x.Soru.SoruAltBasliks)
                        .Where(x => x.Soru.SoruAltBasliks.FirstOrDefault().AltBaslikId == item.AltBaslikId && x.Ogrenci.Id == ogrenci.Id).CountAsync();
                    float yuzde;
                    if (soruCountAltBaslik != 0)
                    {
                        yuzde = ((float)item.DogruSayisi / soruCountAltBaslik);
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
                }
                return new ListResultDto<TestIstatistikDto>(testIstatistikDtos);
            }
            catch (Exception ex)
            {
                throw new AbpException { };
            }
        }
    }
}
