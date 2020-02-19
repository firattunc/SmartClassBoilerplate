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
    public class TestSonuc: Entity<int>
    {
        public DateTime Tarih { get; set; }
        public DateTime BitisTarih { get; set; }
        public int DogruSayisi { get; set; }
        public int OgrenciId { get; set; }
        [ForeignKey("OgrenciId")]
        public virtual Ogrenci Ogrenci { get; set; }
        [JsonIgnore]
        public virtual ICollection<Cevap> Cevaps { get; set; }
        [JsonIgnore]
        public virtual ICollection<Yorum> Yorums { get; set; }

        public TestSonuc()
        {
            Cevaps = new HashSet<Cevap>();
            Yorums = new HashSet<Yorum>();
        }
       
    }
}
