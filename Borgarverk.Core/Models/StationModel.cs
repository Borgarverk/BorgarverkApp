using System;
using SQLite;

namespace Borgarverk.Core
{
	public class StationModel
	{
		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }
		public string Name { get; set; }

		public StationModel(string name)
		{
			Name = name;
		}
	}
}
