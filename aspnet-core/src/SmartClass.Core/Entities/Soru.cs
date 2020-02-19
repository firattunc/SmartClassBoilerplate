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
    public class Soru: Entity<int>
    {
        public string ImgUrl { get; set; }
        public string Cevap { get; set; }
        public int DersId { get; set; }        
        public int KonuId { get; set; }
        [ForeignKey("DersId")]
        public virtual Ders Ders { get; set; }
        [ForeignKey("KonuId")]
        public virtual Konu Konu { get; set; }
        public virtual ICollection<SoruAltBaslik> SoruAltBasliks { get; set; }
        public virtual ICollection<Cevap> Cevaps { get; set; }
        public Soru()
        {
            SoruAltBasliks = new HashSet<SoruAltBaslik>();
            Cevaps = new HashSet<Cevap>();
        }


    }

}
