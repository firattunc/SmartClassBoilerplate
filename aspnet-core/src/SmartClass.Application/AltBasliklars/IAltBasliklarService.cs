using Abp.Application.Services;
using SmartClass.AltBasliklars.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartClass.AltBasliklars
{
    public interface IAltBasliklarService: IAsyncCrudAppService<AltBasliklarDto, int, PagedAltBasliklarResultDto, CreateAltBasliklarDto,AltBasliklarDto>
    {
    }
}
