using System.Threading.Tasks;
using SmartClass.Configuration.Dto;

namespace SmartClass.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
