using System;
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

			Button carButton1 = FindViewById<Button>(Resource.Id.car1Button);
			Button carButton2 = FindViewById<Button>(Resource.Id.car2Button);
			Button carButton3 = FindViewById<Button>(Resource.Id.car3Button);
			Button carButton4 = FindViewById<Button>(Resource.Id.car4Button);
			Button carButton5 = FindViewById<Button>(Resource.Id.car5Button);

			carButton1.Click += (object sender, EventArgs e) =>
			{
				carButton1.Selected = true;
				carButton2.Selected = false;
				carButton3.Selected = false;
				carButton4.Selected = false;
				carButton5.Selected = false;
			};
			carButton2.Click += (object sender, EventArgs e) =>
			{
				carButton1.Selected = false;
				carButton2.Selected = true;
				carButton3.Selected = false;
				carButton4.Selected = false;
				carButton5.Selected = false;
			};
			carButton3.Click += (object sender, EventArgs e) =>
			{
				carButton1.Selected = false;
				carButton2.Selected = false;
				carButton3.Selected = true;
				carButton4.Selected = false;
				carButton5.Selected = false;
			};
			carButton4.Click += (object sender, EventArgs e) =>
			{
				carButton1.Selected = false;
				carButton2.Selected = false;
				carButton3.Selected = false;
				carButton4.Selected = true;
				carButton5.Selected = false;
			};
			carButton5.Click += (object sender, EventArgs e) =>
			{
				carButton1.Selected = false;
				carButton2.Selected = false;
				carButton3.Selected = false;
				carButton4.Selected = false;
				carButton5.Selected = true;
			};
		}
	}
}
