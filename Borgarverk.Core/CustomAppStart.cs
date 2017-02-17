using System;
using Borgarverk.Core.ViewModels;
using MvvmCross.Core.ViewModels;

namespace Borgarverk.Core
{
	public class CustomAppStart : MvxNavigatingObject, IMvxAppStart
	{
		/// <summary>
		/// Hint can take command-line startup parameters, and then pass them to the called view models.
		/// </summary>
		/// <param name="hint"></param>
		public void Start(object hint = null)
		{
			// ShowViewModel is a core navigation mechanism in MvvmCross.
			// for now, just start the regular MainMenuViewModel view.
			ShowViewModel<FormEntryViewModel>();
		}
	}
}
