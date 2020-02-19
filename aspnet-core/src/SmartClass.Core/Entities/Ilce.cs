using Abp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Core.Entities.Concrete
{
    public class Ilce: Entity<int>
    {
        public string IlceAd { get; set; }
        public int IlId { get; set; }
        [ForeignKey("IlId")]
        public virtual Il Il { get; set; }
       
    }
}
