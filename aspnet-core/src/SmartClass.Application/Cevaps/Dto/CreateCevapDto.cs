using Abp.AutoMapper;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartClass.Cevaps.Dto
{
    [AutoMapTo(typeof(Cevap))]
    public class CreateCevapDto
    {
        public string Cevap { get; set; }
        public int SoruId { get; set; }
        public int OgrenciId { get; set; }
    }
}
