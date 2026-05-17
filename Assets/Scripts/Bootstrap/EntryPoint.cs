using Spellcast.Core;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Spellcast.Bootstrap
{
	[DefaultExecutionOrder(-100)]
	public class EntryPoint : LifetimeScope
	{
		protected override void Configure(IContainerBuilder builder)
		{
			builder.RegisterBuildCallback(SL.Initialize);
			
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