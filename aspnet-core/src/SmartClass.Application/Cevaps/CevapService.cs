using Abp.Application.Services;
using Abp.Domain.Repositories;
using Core.Entities.Concrete;
using SmartClass.Cevaps.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartClass.Cevaps
{
    public class CevapService : AsyncCrudAppService<Cevap, CevapDto, int, PagedCevapResultDto, CreateCevapDto, CevapDto>, ICevapService
    {
        public CevapService(IRepository<Cevap, int> repository) : base(repository)
        {
        }
    }
}
