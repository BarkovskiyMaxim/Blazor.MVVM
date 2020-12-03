using Blazor.MVVM.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Blazor.MVVM {
    public static class Registration {
        public static void AddMVVM(this IServiceCollection serviceContainer) {
            serviceContainer.AddSingleton<ITemplateStorage, TemplateStorage>();
        }
    }
}
