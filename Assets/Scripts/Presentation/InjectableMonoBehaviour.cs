using Spellcast.Core;
using UnityEngine;

namespace Spellcast.Presentation
{
	public abstract class InjectableMonoBehaviour : MonoBehaviour
	{
		private void Awake()
		{
			InjectDependencies();

			OnDependenciesInjected();

			OnAwake();
		}

		protected virtual void OnDependenciesInjected()
		{
		}

		protected virtual void OnAwake()
		{
		}
		
		private void InjectDependencies()
		{
			SL.Inject(this);
		}
	}
}