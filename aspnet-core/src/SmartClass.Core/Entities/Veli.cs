using Abp.Domain.Entities;
using SmartClass.Authorization.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Core.Entities.Concrete
{
    public class Veli: Entity<int>
    {
        public long UserId { get; set; }   
        [ForeignKey("UserId")]
        public virtual User User { get; set; }       
    }
}
