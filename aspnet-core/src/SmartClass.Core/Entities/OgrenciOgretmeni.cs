using Abp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Core.Entities.Concrete
{
    public class OgrenciOgretmeni: Entity<int>
    {
        public int OgrenciId { get; set; }
        public int OgretmenId { get; set; }
        [ForeignKey("OgrenciId")]
        public virtual Ogrenci Ogrenci { get; set; }
        [ForeignKey("OgretmenId")]
        public virtual Ogretmen Ogretmen { get; set; }
    }
}
