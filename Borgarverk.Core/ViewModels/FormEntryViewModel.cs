using MvvmCross.Core.ViewModels;

namespace Borgarverk.Core.ViewModels
{
	public class FormEntryViewModel : MvxViewModel
	{
		private Form model;

		public FormEntryViewModel()
		{
			model = new Form();
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

		private string car = "";
		public string Car
		{
			get
			{
				return car;
			}
			set
			{
				SetProperty(ref car, value);
				RaisePropertyChanged(() => Car);

			}
		}

		private string station = "";
		public string Station
		{
			get
			{
				return station;
			}
			set
			{
				SetProperty(ref station, value);
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

		public IMvxCommand ConfirmForm
		{
			get { return new MvxCommand(ConstructForm); }
		}

		public IMvxCommand GetCar
		{
			get { return new MvxCommand<string>(AddCar); }
		}

		public IMvxCommand GetStation
		{
			get { return new MvxCommand<string>(AddStation); }
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

		void AddCar(string num)
		{
			System.Diagnostics.Debug.WriteLine("CLICKED CAR BUTTON!");
			System.Diagnostics.Debug.WriteLine(num);
			model.car = num;
		}

		void AddStation(string num)
		{
			System.Diagnostics.Debug.WriteLine("CLICKED STATION BUTTON!");
			System.Diagnostics.Debug.WriteLine(num);
			model.station = num;
		}
	}
}