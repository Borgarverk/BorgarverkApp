using System;
using MvvmCross.Plugins.Sqlite;
using SQLite;

namespace Borgarverk.Core
{
	public class FormEntry
	{
		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }
		public string Car { get; set; }
		public string Station { get; set; }
		public string RoadLength { get; set; }
		public string RoadArea { get; set; }
		public string TarQty { get; set; }
		public string QtyRate { get; set; }
		
		public override string ToString()
		{
			return string.Format("{0} - {1}, {2}", Id, Car, Station);
		}
	}
}
