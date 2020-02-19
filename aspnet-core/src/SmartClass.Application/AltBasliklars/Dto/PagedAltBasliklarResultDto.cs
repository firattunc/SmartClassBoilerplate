using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Core.Entities.Concrete;

namespace SmartClass.AltBasliklars.Dto
{
    [AutoMapFrom(typeof(AltBasliklar))]
    public class PagedAltBasliklarResultDto:PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}
