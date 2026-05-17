using System.Linq;
using System.Reflection;
using Spellcast.Presentation.Scenes.Game;
using VContainer;
using VContainer.Unity;

namespace Spellcast.Presentation
{
	public class ContainerRegistrations : IInstaller
	{
		public void Install(IContainerBuilder builder)
		{
			RegisterSceneSwitchers(builder);
			RegisterRouters(builder);
			RegisterInteractors(builder);
		}

		private static void RegisterSceneSwitchers(IContainerBuilder builder)
		{
			builder.Register<GameSceneSwitcher>(Lifetime.Transient)
			       .As<IGameSceneSwitcher>();
		}

		private static void RegisterRouters(IContainerBuilder builder)
		{
			var routers = Assembly.GetExecutingAssembly()
			                      .GetTypes()
			                      .Where(t => t.IsClass     &&
			                                  !t.IsAbstract &&
			                                  t.Name.EndsWith("Router"))
			                      .ToList();

			foreach (var router in routers)
				builder.Register(router, Lifetime.Singleton)
					.AsSelf();
		}

		private static void RegisterInteractors(IContainerBuilder builder)
		{
			var interactors = Assembly.GetExecutingAssembly()
			                          .GetTypes()
			                          .Where(t => t.IsClass     &&
			                                      !t.IsAbstract &&
			                                      t.Name.EndsWith("Interactor"))
			                          .ToList();

			foreach (var interactor in interactors)
				builder.Register(interactor, Lifetime.Transient)
				       .AsSelf();
		}
	}
}