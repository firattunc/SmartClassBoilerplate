using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartClass.Derses.Dto
{
    [AutoMapFrom(typeof(Ders))]
    public class PagedDersResultDto:PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}
