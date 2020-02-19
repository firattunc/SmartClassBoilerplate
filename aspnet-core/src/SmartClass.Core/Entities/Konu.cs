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
    public class Konu: Entity<int>
    {
        public string KonuAdi { get; set; }
        public int DersId { get; set; }
        public virtual ICollection<AltBasliklar> AltBasliklar { get; set; }
        [ForeignKey("DersId")]
        public virtual Ders Ders { get; set; }
        public Konu()
        {
            AltBasliklar = new HashSet<AltBasliklar>();
        }
      
    }
}
