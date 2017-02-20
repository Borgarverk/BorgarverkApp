using System;
using System.Collections.Generic;
using Android.App;
using Android.OS;
using Android.Support.V4.Content;
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
			/* Gæti þurft að nota seinna
			string[] arr = Resources.GetStringArray(Resource.Array.cars);*/

			Spinner carSpinner = FindViewById<Spinner>(Resource.Id.carSpinner);
			Spinner stationSpinner = FindViewById<Spinner>(Resource.Id.stationSpinner);

			ArrayAdapter carAdapter = ArrayAdapter.CreateFromResource(
				this,
				Resource.Array.cars,
				Android.Resource.Layout.SimpleSpinnerItem);

			carAdapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);

			carSpinner.Adapter = carAdapter;

			ArrayAdapter stationAdapter = ArrayAdapter.CreateFromResource(
				this,
				Resource.Array.stations,
				Android.Resource.Layout.SimpleSpinnerItem);

			stationAdapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);

			stationSpinner.Adapter = stationAdapter;
		}

	}
}
