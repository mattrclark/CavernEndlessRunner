using VContainer;

namespace Spellcast.Core
{
	// ReSharper disable once InconsistentNaming
	public static class SL
	{
		private static IObjectResolver resolver;

		public static void Initialize(IObjectResolver resolver)
		{
			SL.resolver = resolver;
		}
		
		public static void Inject(object type)
		{
			resolver.Inject(type);
		}
	}
}