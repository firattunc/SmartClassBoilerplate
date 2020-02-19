using AutoMapper;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartClass.Derses.Dto
{
    public class DersMapProfile:Profile
    {
        public DersMapProfile()
        {
            CreateMap<DersDto, Ders>();
            CreateMap<DersDto, Ders>();
            CreateMap<CreateDersDto, Ders>();
        }
    }
}
