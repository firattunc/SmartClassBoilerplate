using Abp.Application.Services;
using Abp.Domain.Repositories;
using Core.Entities.Concrete;
using SmartClass.AltBasliklars.Dto;
using SmartClass.Cevaps.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartClass.AltBasliklars
{
    public class AltBasliklarService : AsyncCrudAppService<AltBasliklar, AltBasliklarDto, int, PagedAltBasliklarResultDto,CreateAltBasliklarDto,AltBasliklarDto>, IAltBasliklarService
    {
        public AltBasliklarService(IRepository<AltBasliklar, int> repository) : base(repository)
        {
        }
    }

}
