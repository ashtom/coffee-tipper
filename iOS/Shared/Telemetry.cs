using System;
using CoffeeTip.iOS;

[assembly: Xamarin.Forms.Dependency(typeof(Telemetry))]

namespace CoffeeTip.iOS
{
	public class Telemetry : ITelemetry
	{
		public Telemetry()
		{
		}

		public void TrackEvent(String name)
		{
			HockeyApp.MetricsManager.TrackEvent(name);
		}
	}
}
