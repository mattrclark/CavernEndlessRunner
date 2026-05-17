using Cysharp.Threading.Tasks;
using Spellcast.Presentation.Values;
using UnityEngine.SceneManagement;

namespace Spellcast.Presentation.Scenes.Game
{
	public interface IGameSceneSwitcher
	{
		UniTask SwitchToGame();
	}
	
	public class GameSceneSwitcher : IGameSceneSwitcher
	{
		public UniTask SwitchToGame()
		{
			// TODO: This will need to be loaded via addressables
			// This is ok for now though...
			return SceneManager.LoadSceneAsync(SceneIds.Game).ToUniTask();
		}
	}
}