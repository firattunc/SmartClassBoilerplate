using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartClass.Tests.Dto
{
    public class TesteBaslaResultDto
    {
        public List<Soru> Sorular { get; set; }
        public int soruNo { get; set; }
        public int soruSayisi { get; set; }
    }
}
