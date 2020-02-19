using Abp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Core.Entities.Concrete
{
    public class OgrenciVelisi : Entity<int>
    {
        public int VeliId { get; set; }
        [ForeignKey("VeliId")]
        public virtual Veli Veli { get; set; }
        public int OgrenciId{ get; set; }        
        [ForeignKey("OgrenciId")]
        public virtual Ogrenci Ogrenci { get; set; }

    }

}
