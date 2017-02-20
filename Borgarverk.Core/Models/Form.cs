using System;
using SQLite;

namespace Borgarverk.Core
{
	public class Form
	{
		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }
		public string IdNo { get; set; }
		public CarModel Car { get; set; }
		public StationModel Station { get; set; }
		public string RoadLength { get; set; }
		public string RoadWidth { get; set; }
		public string RoadArea { get; set; }
		public string TarQty { get; set; }
		public string QtyRate { get; set; }
		public DateTime TimeSent { get; set; }

		public Form()
		{
			// á ég að initializa breyturnar?
		}
	}
}
