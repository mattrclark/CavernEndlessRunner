using System.Linq;
using System.Reflection;
using VContainer;
using VContainer.Unity;

namespace Spellcast.Application
{
    public class ContainerRegistrations : IInstaller
    {
        public void Install(IContainerBuilder builder)
        {
            RegisterProviders(builder);
            RegisterServices(builder);
            RegisterRepos(builder);
            RegisterUseCases(builder);
        }

        private static void RegisterServices(IContainerBuilder builder)
        {
        }

        private static void RegisterProviders(IContainerBuilder builder)
        {
        }

        private static void RegisterRepos(IContainerBuilder builder)
        {
        }
        
        private void RegisterUseCases(IContainerBuilder builder)
        {
	        var useCases = Assembly.GetExecutingAssembly()
	                              .GetTypes()
	                              .Where(t => t.IsClass                                       &&
	                                          t is { IsAbstract: false, Namespace: not null } &&
	                                          t.Namespace.StartsWith("Spellcast.Application.UseCases"))
	                              .ToList();

	        foreach (var useCase in useCases)
		        builder.Register(useCase, Lifetime.Transient);
        }
    }
}
