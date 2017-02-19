using System.Collections.Generic;
using System.Linq;
using MvvmCross.Plugins.Sqlite;

namespace Borgarverk.Core.Services
{
	public class DataService : IDataService
	{
		private readonly ISQLiteConnection _connection;

		public DataService(ISQLiteConnectionFactory factory)
		{
			_connection = factory.Create("one.sql");
			_connection.CreateTable<Kitten>();
		}

		public List<FormEntry> KittensMatching(string nameFilter)
		{
			return _connection.Table<FormEntry>()
							  .OrderBy(x => x.Price)
							  .Where(x => x.Name.Contains(nameFilter))
							  .ToList();
		}

		public void Insert(FormEntry formEntry)
		{
			_connection.Insert(formEntry);
		}

		public void Update(FormEntry formEntry)
		{
			_connection.Update(formEntry);
		}

		public void Delete(FormEntry formEntry)
		{
			_connection.Delete(formEntry);
		}

		public int Count
		{
			get
			{
				return _connection.Table<FormEntry>().Count();
			}
		}
	}
}