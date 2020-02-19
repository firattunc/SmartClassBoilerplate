using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SmartClass.Configuration;

namespace SmartClass.Web.Host.Startup
{
    [DependsOn(
       typeof(SmartClassWebCoreModule))]
    public class SmartClassWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public SmartClassWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SmartClassWebHostModule).GetAssembly());
        }
    }
}
