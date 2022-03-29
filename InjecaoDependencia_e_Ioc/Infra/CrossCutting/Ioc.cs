using InjecaoDependencia_e_Ioc.Controllers.Application.Interfaces;
using InjecaoDependencia_e_Ioc.Services;

namespace InjecaoDependencia_e_Ioc.Infra.CrossCutting
{
    public static class Ioc
    {
        public static void RegistrarServicos(IServiceCollection services)
        {

            services.AddScoped<IUserService, UserService>();
        }
    }
}
