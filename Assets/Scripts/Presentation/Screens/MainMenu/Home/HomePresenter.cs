using Cysharp.Threading.Tasks;
using Spellcast.Presentation.Scenes.MainMenu;
using Spellcast.Presentation.Screens.MainMenu.Options;
using UnityEngine;
using VContainer;

namespace Spellcast.Presentation.Screens.MainMenu.Home
{
	[RequireComponent(typeof(HomeView))]
	public class HomePresenter : Presenter<HomeView>
	{
		[Inject] private OptionsRouter         optionsRouter = null!;
		[Inject] private MainMenuInSceneRouter inSceneRouter = null!;

		protected override void OnAwake()
		{
			View.OnStartButtonPressed.AddListener(() => inSceneRouter.RouteToGame().Forget());
		}
	}
}