using Abp.Application.Services;
using Abp.Domain.Repositories;
using Core.Entities.Concrete;
using SmartClass.Derses.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartClass.Derses
{
    public class DersService : AsyncCrudAppService<Ders, DersDto, int, PagedDersResultDto, CreateDersDto, DersDto>, IDersService
    {
        public DersService(IRepository<Ders, int> repository) : base(repository)
        {
        }
    }
}
