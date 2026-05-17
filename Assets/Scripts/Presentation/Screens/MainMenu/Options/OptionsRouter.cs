using UnityEngine;

namespace Spellcast.Presentation.Screens.MainMenu.Options
{
	public class OptionsRouter : Router
	{
		[SerializeField] private OptionsView optionsView = null!;
		
		public void RouteToOptions() => SwitchTo(optionsView);
	}
}