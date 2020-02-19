using Abp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Core.Entities.Concrete
{
    public class Yorum: Entity<int>
    {
        public string Metin { get; set; }
        public DateTime Tarih { get; set; }
        public int OgrenciId { get; set; }
        public int TestSonucId { get; set; }
        [ForeignKey("OgrenciId")]
        public virtual Ogrenci Ogrenci { get; set; }
        [ForeignKey("TestSonucId")]
        public virtual TestSonuc  TestSonuc{ get; set; }

    }
}
