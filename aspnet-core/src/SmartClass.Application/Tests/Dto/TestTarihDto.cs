using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Core.Entities.Concrete;
using SmartClass.Authorization.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartClass.Tests.Dto
{
    [AutoMapFrom(typeof(TestSonuc))]
    public class TestTarihDto:EntityDto<int>
    {
        public DateTime Tarih { get; set; }
    }
}
