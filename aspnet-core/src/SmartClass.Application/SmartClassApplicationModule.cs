using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SmartClass.Authorization;

namespace SmartClass
{
    [DependsOn(
        typeof(SmartClassCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class SmartClassApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<SmartClassAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(SmartClassApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
