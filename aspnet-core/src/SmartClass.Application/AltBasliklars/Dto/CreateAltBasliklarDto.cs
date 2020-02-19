using Abp.AutoMapper;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartClass.AltBasliklars.Dto
{
    [AutoMapTo(typeof(AltBasliklar))]
    public class CreateAltBasliklarDto
    {
        public string AltBaslikAdi { get; set; }
        public int KonuId { get; set; }
    }
}
