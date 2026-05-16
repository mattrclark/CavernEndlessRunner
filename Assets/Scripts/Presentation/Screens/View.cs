using UnityEngine;

namespace Spellcast.Presentation.Screens
{
	public class View : MonoBehaviour
	{
		public void Open()  => gameObject.SetActive(true);
		public void Close() => gameObject.SetActive(false);
	}
}