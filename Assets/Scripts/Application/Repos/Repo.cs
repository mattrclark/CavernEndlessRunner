using System;
using System.Linq;
using Spellcast.Domain.Entities;

namespace Spellcast.Application.Repos
{
	public interface IRepo<out T>
	{
		T[] GetAll();
		T?  GetById(int id);
	}

	public abstract class Repo<T> : IRepo<T> where T : Entity
	{
		protected T[] Data;

		public Repo(T[]? data)
		{
			Data = data ?? Array.Empty<T>();
		}

		public T[] GetAll()
		{
			return Data;
		}

		public T? GetById(int id)
		{
			return Data.FirstOrDefault(x => x.Id == id); //TODO: Resolve null exception
		}

		public void Set(T[] data)
		{
			Data = data;
		}
	}
}