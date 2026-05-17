using Cysharp.Threading.Tasks;
using Spellcast.Presentation.Scenes.Game;
using Spellcast.Presentation.Values;
using VContainer;

namespace Spellcast.Presentation.Scenes.MainMenu
{
	public class MainMenuInSceneRouter : InSceneRouter
	{
		[Inject] private IGameSceneSwitcher gameSceneSwitcher = null!;

		protected override string SceneName => SceneIds.MainMenu;
		
		public UniTask RouteToGame()
		{
			return gameSceneSwitcher.SwitchToGame();
		}
	}
}