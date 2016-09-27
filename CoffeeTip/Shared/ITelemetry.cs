using System;
using System.Collections.Generic;

namespace CoffeeTip
{
	public interface ITelemetry
	{
		void TrackEvent(String name);
		void TrackEvent(String name, Dictionary<string, string> properties);
	}
}
