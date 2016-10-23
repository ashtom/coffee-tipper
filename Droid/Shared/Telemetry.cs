using System;
using System.Collections.Generic;
using CoffeeTip.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(Telemetry))]

namespace CoffeeTip.Droid
{
	public class Telemetry : ITelemetry
	{
		public Telemetry()
		{
		}

		public void TrackEvent(string name)
		{
			HockeyApp.MetricsManager.TrackEvent(name);
		}

		public void TrackEvent(String name, Dictionary<string, string> properties)
		{
			HockeyApp.MetricsManager.TrackEvent(name, properties, new Dictionary<string, double> { });
		}
	}
}