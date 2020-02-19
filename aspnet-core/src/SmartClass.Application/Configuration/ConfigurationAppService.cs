using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using SmartClass.Configuration.Dto;

namespace SmartClass.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : SmartClassAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
