using System.Threading.Tasks;
using Abp.Application.Services;
using SmartClass.Authorization.Accounts.Dto;

namespace SmartClass.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
