using UnityEngine;

namespace Spellcast.Presentation.Screens
{
	public abstract class Presenter<TView> : InjectableMonoBehaviour where TView : View
	{
		protected TView View = null!;

		protected override void OnDependenciesInjected()
		{
			View = GetComponent<TView>();
		}

#if UNITY_EDITOR
		protected virtual void Reset()
		{
			if (GetComponent<TView>() != null)
				return;

			gameObject.AddComponent<TView>();

			Debug.Log($"Automatically added required component {typeof(TView).Name}");
		}
#endif
	}
}