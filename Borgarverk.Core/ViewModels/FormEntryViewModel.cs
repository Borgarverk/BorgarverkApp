using MvvmCross.Core.ViewModels;

namespace Borgarverk.Core.ViewModels
{
	public class FormEntryViewModel : MvxViewModel
	{
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

		private string car;
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

		private string station;
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

		private string roadLength = "";
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

		private string roadWidth = "";
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

		private string roadArea = "";
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

		private string tarQty = "";
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

		private string qtyRate = "";
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

		MvxCommand confirmForm;

		public IMvxCommand ConfirmForm
		{
			get { return new MvxCommand(ConstructForm); }
		}

		void ConstructForm()
		{
			System.Diagnostics.Debug.WriteLine("CLICKED!");
		}
	}
}