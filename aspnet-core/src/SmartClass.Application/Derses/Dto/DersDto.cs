using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartClass.Derses.Dto
{
    public class DersDto : EntityDto<int>
    {
        public int Name { get; set; }
    }
}
