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
		}

	}
}
