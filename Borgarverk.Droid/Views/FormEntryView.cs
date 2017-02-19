using System;
using System.Collections.Generic;
using Android.App;
using Android.OS;
using Android.Widget;
using MvvmCross.Droid.Views;

namespace Borgarverk.Droid
{
	[Activity(Label = "Ný Færlsa", MainLauncher = false, Icon = "@mipmap/icon", Theme = "@style/MyTheme")]
	public class FormEntryView : MvxActivity
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			SetContentView(Resource.Layout.FormEntryView);

			ToggleButton carButton1 = FindViewById<ToggleButton>(Resource.Id.car1Button);
			ToggleButton carButton2 = FindViewById<ToggleButton>(Resource.Id.car2Button);
			ToggleButton carButton3 = FindViewById<ToggleButton>(Resource.Id.car3Button);
			ToggleButton carButton4 = FindViewById<ToggleButton>(Resource.Id.car4Button);
			ToggleButton carButton5 = FindViewById<ToggleButton>(Resource.Id.car5Button);

			ToggleButton stationButton1 = FindViewById<ToggleButton>(Resource.Id.station1Button);
			ToggleButton stationButton2 = FindViewById<ToggleButton>(Resource.Id.station2Button);
			ToggleButton stationButton3 = FindViewById<ToggleButton>(Resource.Id.station3Button);
			ToggleButton stationButton4 = FindViewById<ToggleButton>(Resource.Id.station4Button);
			ToggleButton stationButton5 = FindViewById<ToggleButton>(Resource.Id.station5Button);
			ToggleButton stationButton6 = FindViewById<ToggleButton>(Resource.Id.station6Button);

			carButton1.Click += UnToggleCarButtons;
			carButton2.Click += UnToggleCarButtons;
			carButton3.Click += UnToggleCarButtons;
			carButton4.Click += UnToggleCarButtons;
			carButton5.Click += UnToggleCarButtons;

			stationButton1.Click += UnToggleStationButtons;
			stationButton2.Click += UnToggleStationButtons;
			stationButton3.Click += UnToggleStationButtons;
			stationButton4.Click += UnToggleStationButtons;
			stationButton5.Click += UnToggleStationButtons;
			stationButton6.Click += UnToggleStationButtons;
		}

		public void UnToggleCarButtons(object sender, EventArgs e)
		{
			ToggleButton button = sender as ToggleButton;
			List<ToggleButton> buttonList = new List<ToggleButton>();
			buttonList.Add(FindViewById<ToggleButton>(Resource.Id.car1Button));
			buttonList.Add(FindViewById<ToggleButton>(Resource.Id.car2Button));
			buttonList.Add(FindViewById<ToggleButton>(Resource.Id.car3Button));
			buttonList.Add(FindViewById<ToggleButton>(Resource.Id.car4Button));
			buttonList.Add(FindViewById<ToggleButton>(Resource.Id.car5Button));

			foreach (ToggleButton b in buttonList)
			{
				if (button != b)
				{
					b.Checked = false;
				}
			}
		}

		public void UnToggleStationButtons(object sender, EventArgs e)
		{
			ToggleButton button = sender as ToggleButton;
			List<ToggleButton> buttonList = new List<ToggleButton>();
			buttonList.Add(FindViewById<ToggleButton>(Resource.Id.station1Button));
			buttonList.Add(FindViewById<ToggleButton>(Resource.Id.station2Button));
			buttonList.Add(FindViewById<ToggleButton>(Resource.Id.station3Button));
			buttonList.Add(FindViewById<ToggleButton>(Resource.Id.station4Button));
			buttonList.Add(FindViewById<ToggleButton>(Resource.Id.station5Button));
			buttonList.Add(FindViewById<ToggleButton>(Resource.Id.station6Button));

			foreach (ToggleButton b in buttonList)
			{
				if (button != b)
				{
					b.Checked = false;
				}
			}
		}
	}
}
