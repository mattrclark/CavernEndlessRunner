using VContainer;
using VContainer.Unity;

namespace Spellcast.Bootstrap
{
	public class EntryPoint : LifetimeScope
	{
		protected override void Configure(IContainerBuilder builder)
		{
			var installers = new IInstaller[]
			                 {
				                 new Application.ContainerRegistrations(),
				                 new Infrastructure.ContainerRegistrations(),
				                 new Presentation.ContainerRegistrations()
			                 };

			foreach (var installer in installers)
				installer.Install(builder);
		}
	}
}