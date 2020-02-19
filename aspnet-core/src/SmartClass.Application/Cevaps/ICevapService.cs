using Abp.Application.Services;
using SmartClass.Cevaps.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartClass.Cevaps
{
    public interface ICevapService:IAsyncCrudAppService<CevapDto,int,PagedCevapResultDto,CreateCevapDto,CevapDto>
    {

    }
}
