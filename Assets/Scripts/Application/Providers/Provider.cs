using System;

namespace Spellcast.Application.Providers
{
	public interface IProvider<out T>
	{
		T Get();

		event Action<T>? ValueUpdated;
	}

	public interface IStore<T> : IProvider<T>
	{
		void Set(T newValue);
	}

	public class Provider<T> : IStore<T>
	{
		private T? value;

		public event Action<T>? ValueUpdated;

		public T Get() => value ?? throw new Exception("Value in provider is null."); // TODO: Add separate exception

		public void Set(T newValue)
		{
			value = newValue;

			ValueUpdated?.Invoke(value);
		}
	}
}