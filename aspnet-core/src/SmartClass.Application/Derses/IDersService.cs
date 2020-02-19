using Abp.Application.Services;
using SmartClass.Derses.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartClass.Derses
{
    public interface IDersService : IAsyncCrudAppService<DersDto, int, PagedDersResultDto, CreateDersDto,DersDto>
    {
    }
}
