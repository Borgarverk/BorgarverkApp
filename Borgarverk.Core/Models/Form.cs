using System;
using SQLite;

namespace Borgarverk.Core
{
	public class Form
	{
		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }
		public string idNo { get; set; }
		public CarModel car { get; set; }
		public StationModel station { get; set; }
		public string roadLength { get; set; }
		public string roadWidth { get; set; }
		public string roadArea { get; set; }
		public string tarQty { get; set; }
		public string qtyRate { get; set; }
		public DateTime timeSent { get; set; }

		public Form()
		{
			// á ég að initializa breyturnar?
		}
	}
}
