using AutoMapper;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartClass.Cevaps.Dto
{
    public class CevapMapProfile:Profile
    {
        public CevapMapProfile()
        {
            CreateMap<CevapDto, Cevap>();
            CreateMap<CevapDto, Cevap>();                
            CreateMap<CreateCevapDto, Cevap>();
        }
    }
}
