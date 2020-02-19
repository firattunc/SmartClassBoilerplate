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
    public class Ogretmen: Entity<int>
    {
        public int OkulId { get; set; }
        public long UserId { get; set; }
        [ForeignKey("OkulId")]
        public virtual Okul Okul { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        public virtual ICollection<OgrenciOgretmeni> OgrenciOgretmenis { get; set; }
        public Ogretmen()
        {
            OgrenciOgretmenis = new HashSet<OgrenciOgretmeni>();
        }
    }

}
