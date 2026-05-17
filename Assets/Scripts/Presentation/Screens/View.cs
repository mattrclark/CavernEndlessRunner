namespace Spellcast.Presentation.Screens
{
	public class View : InjectableMonoBehaviour
	{
		public void Open()  => gameObject.SetActive(true);
		public void Close() => gameObject.SetActive(false);
	}
}