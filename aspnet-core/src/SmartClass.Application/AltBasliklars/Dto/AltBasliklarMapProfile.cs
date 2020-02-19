using AutoMapper;
using Core.Entities.Concrete;

namespace SmartClass.AltBasliklars.Dto
{
    public class AltBasliklarMapProfile:Profile
    {
        public AltBasliklarMapProfile()
        {
            CreateMap<AltBasliklarDto, Cevap>();
            CreateMap<AltBasliklarDto, Cevap>();
            CreateMap<CreateAltBasliklarDto, Cevap>();
        }
    }
}
