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
    public class AltBasliklar:Entity<int>
    {        
        public string AltBaslikAdi { get; set; }
        public int KonuId { get; set; }
        [ForeignKey("KonuId")]
        public virtual Konu Konu { get; set; }
        public virtual ICollection<GenelIstatistik> GenelIstatistiks { get; set; }
        public AltBasliklar()
        {
            GenelIstatistiks = new HashSet<GenelIstatistik>();
        }
    }
}
