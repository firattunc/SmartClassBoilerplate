using Abp.Domain.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Core.Entities.Concrete
{
    public class Okul: Entity<int>
    {
        public string OkulAdi { get; set; }
        public string ImgUrl { get; set; }
        public int IlceId { get; set; }
        [ForeignKey("IlceId")]
        public virtual Ilce Ilce { get; set; }
        public virtual ICollection<Ogrenci> Ogrencis { get; set; }
        public virtual ICollection<Ogretmen> Ogretmens { get; set; }
        public Okul()
        {
            Ogrencis = new HashSet<Ogrenci>();
            Ogretmens = new HashSet<Ogretmen>();
        }
    }
}
