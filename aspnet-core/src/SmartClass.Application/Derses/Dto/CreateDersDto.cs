using Abp.AutoMapper;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartClass.Derses.Dto
{
    [AutoMapTo(typeof(Ders))]
    public class CreateDersDto
    {
        public string Name { get; set; }
    }
}
