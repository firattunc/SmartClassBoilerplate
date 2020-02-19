using Abp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Core.Entities.Concrete
{
    public class GenelIstatistik: Entity<int>
    {        
        public int DogruSayisi { get; set; }
        public int OgrenciId { get; set; }
        public int AltBaslikId { get; set; }
        [ForeignKey("OgrenciId")]
        public virtual Ogrenci Ogrenci { get; set; }
        [ForeignKey("AltBaslikId")]
        public virtual AltBasliklar AltBaslik { get; set; }
       
    }
}
