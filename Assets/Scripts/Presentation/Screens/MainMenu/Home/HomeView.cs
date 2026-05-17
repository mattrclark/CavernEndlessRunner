using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Spellcast.Presentation.Screens.MainMenu.Home
{
	public class HomeView : View
	{
		[SerializeField] private Button startGameButton = null!;
		
		public UnityEvent OnStartButtonPressed =>  startGameButton.onClick;
	}
}