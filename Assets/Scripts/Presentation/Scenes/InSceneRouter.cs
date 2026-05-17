namespace Spellcast.Presentation.Scenes
{
	public abstract class InSceneRouter : InjectableMonoBehaviour
	{
		protected abstract string SceneName { get; }
		
		protected override void OnAwake()
		{
			Initialize();
		}

		protected virtual void Initialize()
		{
		}
	}
}