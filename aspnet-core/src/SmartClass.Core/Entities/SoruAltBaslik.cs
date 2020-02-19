using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Core.Entities.Concrete
{
    public class SoruAltBaslik: Entity<int>
    {     
        public int AltBaslikId { get; set; }
        public int SoruId { get; set; }
        public virtual AltBasliklar AltBaslik { get; set; }
        [ForeignKey("SoruId")]
        public virtual Soru Soru { get; set; }
    }
}

