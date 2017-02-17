using Android.App;
using Android.OS;
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
