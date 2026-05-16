using UnityEngine;

namespace Spellcast.Presentation.Screens
{
	public abstract class Presenter<TView> : MonoBehaviour where TView : View
	{
		protected TView View = null!;

		private void Awake()
		{
			View = GetComponent<TView>();

			OnAwake();
		}

		protected virtual void OnAwake()
		{
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