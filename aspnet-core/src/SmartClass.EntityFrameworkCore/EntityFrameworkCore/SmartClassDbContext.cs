using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using SmartClass.Authorization.Roles;
using SmartClass.Authorization.Users;
using SmartClass.MultiTenancy;
using Core.Entities.Concrete;
using static Core.Entities.Concrete.AltBasliklar;

namespace SmartClass.EntityFrameworkCore
{
    public class SmartClassDbContext : AbpZeroDbContext<Tenant, Role, User, SmartClassDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Konu> Konus { get; set; }
        public DbSet<AltBasliklar> AltBasliklars { get; set; }
        public DbSet<Cevap> Cevaps { get; set; }
        public DbSet<Ders> Ders { get; set; }
        public DbSet<GenelIstatistik> GenelIstatistiks { get; set; }
        public DbSet<Il> Ils { get; set; }
        public DbSet<Ilce> Ilces { get; set; }
        public DbSet<Ogrenci> Ogrencis { get; set; }
        public DbSet<Ogretmen> Ogretmens { get; set; }
        public DbSet<Okul> Okuls { get; set; }
        public DbSet<Soru> Sorus { get; set; }
        public DbSet<SoruAltBaslik> SoruAltBasliks { get; set; }
        public DbSet<TestSonuc> TestSonucs { get; set; }
        public DbSet<Yorum> Yorums { get; set; }
        public DbSet<OgrenciOgretmeni> OgrenciOgretmenis { get; set; }
        public DbSet<OgrenciVelisi> OgrenciVelisis { get; set; }
        public DbSet<Veli> Velis { get; set; }
        public SmartClassDbContext(DbContextOptions<SmartClassDbContext> options)
            : base(options)
        {
        }
    }
}
