using System;
using System.Collections.Generic;
using MvvmCross.Core.ViewModels;

namespace Borgarverk.Core.ViewModels
{
	public class FormEntryViewModel : MvxViewModel
	{
		private FormEntryModel model;

		public FormEntryViewModel()
		{
			model = new FormEntryModel();
		}

		private string idNo = "";
		public string IdNo
		{
			get 
			{ 
				return idNo;
			}
			set
			{
				SetProperty(ref idNo, value);
				RaisePropertyChanged(() => IdNo);

			}
		}

		private CarModel car = new CarModel("");
		public CarModel Car
		{
			get 
			{ 
				return car; 
			}
			set 
			{ 
				car = value;
				System.Diagnostics.Debug.WriteLine("Item Selected " + Car.CarNo);
				RaisePropertyChanged(() => Car); 
			}
		}

		private StationModel station = new StationModel("");
		public StationModel Station
		{
			get 
			{ return station; 
			}
			set 
			{ 
				station = value;
				System.Diagnostics.Debug.WriteLine("Item Selected " + station.Name);
				RaisePropertyChanged(() => Station); 
			}
		}

		private string roadLength;
		public string RoadLength
		{
			get
			{
				return roadLength;
			}
			set
			{
				SetProperty(ref roadLength, value);
				RaisePropertyChanged(() => RoadLength);

			}
		}

		private string roadWidth;
		public string RoadWidth
		{
			get
			{
				return roadWidth;
			}
			set
			{
				SetProperty(ref roadWidth, value);
				RaisePropertyChanged(() => RoadWidth);

			}
		}

		private string roadArea;
		public string RoadArea
		{
			get
			{
				return roadArea;
			}
			set
			{
				SetProperty(ref roadArea, value);
				RaisePropertyChanged(() => RoadArea);

			}
		}

		private string tarQty;
		public string TarQty
		{
			get
			{
				return tarQty;
			}
			set
			{
				SetProperty(ref tarQty, value);
				RaisePropertyChanged(() => TarQty);

			}
		}

		private string qtyRate;
		public string QtyRate
		{
			get
			{
				return qtyRate;
			}
			set
			{
				SetProperty(ref qtyRate, value);
				RaisePropertyChanged(() => QtyRate);

			}
		}

		private DateTime timeSent;
		public DateTime TimeSent
		{
			get
			{
				return timeSent;
			}
			set
			{
				SetProperty(ref timeSent, value);
				RaisePropertyChanged(() => TimeSent);
			}
		}

		private List<CarModel> carItems = new List<CarModel>()
			{
				new CarModel("ML-455"),
				new CarModel("MU-510"),
				new CarModel("BZ-963"),
				new CarModel("US-553"),
				new CarModel("AZ-R92")
			};

		public List<CarModel> CarItems
		{
			get 
			{
				return carItems;
			}
			set 
			{
				carItems = value; 
				RaisePropertyChanged(() => CarItems); 
			}
		}

		private List<StationModel> stationItems = new List<StationModel>()
			{
				new StationModel("Akureyri"),
				new StationModel("Ísafjörður"),
				new StationModel("Reykjavík"),
				new StationModel("Hlaðbær Colas"),
				new StationModel("Reyðarfjörður")
			};

		public List<StationModel> StationItems
		{
			get
			{
				return stationItems;
			}
			set
			{
				stationItems = value;
				RaisePropertyChanged(() => StationItems);
			}
		}

		/*public class Thing
		{
			public Thing(string caption)
			{
				Caption = caption;
			}

			public string Caption { get; private set; }

			public override string ToString()
			{
				return Caption;
			}

			public override bool Equals(object obj)
			{
				var rhs = obj as Thing;
				if (rhs == null)
					return false;
				return rhs.Caption == Caption;
			}

			public override int GetHashCode()
			{
				if (Caption == null)
					return 0;
				return Caption.GetHashCode();
			}
		}
		private List<Thing> _items = new List<Thing>()
			{
				new Thing("One"),
				new Thing("Two"),
				new Thing("Three"),
				new Thing("Four"),
			};
		public List<Thing> Items
		{
			get { return _items; }
			set { _items = value; RaisePropertyChanged(() => Items); }
		}

		private Thing _selectedItem = new Thing("Three");
		public Thing SelectedItem
		{
			get { return _selectedItem; }
			set { _selectedItem = value; RaisePropertyChanged(() => SelectedItem); }
		}*/


		private MvxCommand confirmFormCommand;
		public IMvxCommand ConfirmFormCommand
		{
			get 
			{
				confirmFormCommand = confirmFormCommand ?? new MvxCommand(ConstructForm);
				return confirmFormCommand; 
			}
		}

		void ConstructForm()
		{
			System.Diagnostics.Debug.WriteLine("CLICKED!");
			model.idNo = IdNo;
			model.car = Car;
			model.station = Station;
			model.roadLength = RoadLength;
			model.roadWidth = RoadWidth;
			model.roadArea = RoadArea;
			model.tarQty = TarQty;
			model.qtyRate = QtyRate;
		}

	}
}