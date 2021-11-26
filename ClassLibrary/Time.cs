using System;

namespace ClassLibrary
{
	public static class Time
	{
		public static string GetCurrentTime()
		{
			return DateTime.Now.ToShortDateString();
		}
	}
}
