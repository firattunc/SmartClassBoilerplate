using Abp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartClass.Authorization.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Core.Entities.Concrete
{
    public class Ogrenci: Entity<int>
    {
        public int No { get; set; }
        public int OkulId { get; set; }
        public long UserId { get; set; }
        [ForeignKey("OkulId")]
        public virtual Okul Okul { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        public virtual ICollection<Yorum> Yorums { get; set; }
        public virtual ICollection<TestSonuc> TestSonucs { get; set; }
        public virtual ICollection<Cevap> Cevaps { get; set; }
        public virtual ICollection<GenelIstatistik> GenelIstatistiks { get; set; }
        public virtual ICollection<OgrenciOgretmeni> OgrenciOgretmenis { get; set; }
        public virtual ICollection<OgrenciVelisi> OgrenciVelisis { get; set; }
        public Ogrenci()
        {
            Yorums = new HashSet<Yorum>();
            OgrenciVelisis = new HashSet<OgrenciVelisi>();
            OgrenciOgretmenis = new HashSet<OgrenciOgretmeni>();
            TestSonucs = new HashSet<TestSonuc>();
            Cevaps = new HashSet<Cevap>();
            GenelIstatistiks = new HashSet<GenelIstatistik>();
        }

    }
}
