using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartClass.Cevaps.Dto
{
    [AutoMapFrom(typeof(Cevap))]
    public class PagedCevapResultDto: PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}
