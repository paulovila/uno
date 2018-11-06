﻿using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content.PM;
using Android.Views;

namespace SamplesApp.Droid
{
	[Activity(
			MainLauncher = true,
			ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.ScreenSize,
			WindowSoftInputMode = SoftInput.AdjustPan | SoftInput.StateHidden
		)]
	public class MainActivity : Windows.UI.Xaml.ApplicationActivity
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			this.Window.AddFlags(WindowManagerFlags.Fullscreen | WindowManagerFlags.LayoutNoLimits | WindowManagerFlags.TranslucentNavigation);
		}
	}
}

