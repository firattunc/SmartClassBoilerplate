using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartClass.AltBasliklars.Dto
{    
    public class AltBasliklarDto:EntityDto<int>
    {
        public string AltBaslikAdi { get; set; }
        public int KonuId { get; set; }
    }
}
