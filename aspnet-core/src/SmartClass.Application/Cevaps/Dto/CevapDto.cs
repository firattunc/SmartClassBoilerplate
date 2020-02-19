using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartClass.Cevaps.Dto
{
    public class CevapDto:EntityDto<int>
    {
        public DateTime Tarih { get; set; }
        public string IsTrue { get; set; }
        public int SoruId { get; set; }
        public int OgrenciId { get; set; }
        public int TestSonucId { get; set; }
    }
}
