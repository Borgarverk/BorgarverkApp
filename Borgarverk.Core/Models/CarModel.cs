using System;
using SQLite;

namespace Borgarverk.Core
{
	public class CarModel
	{
		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }
		public string CarNo { get; set; }

		public CarModel(string no)
		{
			CarNo = no;
		}
	}
}
