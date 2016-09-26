using System;

namespace CoffeeTip
{
	public interface ITelemetry
	{
		void TrackEvent(String name);
	}
}
