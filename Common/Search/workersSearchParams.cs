using System;
using System.Collections.Generic;
using Common.Enums;

namespace Common.Search
{
	public class workersSearchParams : BaseSearchParams
	{
		public workersSearchParams(int startIndex = 0, int? objectsCount = null) : base(startIndex, objectsCount)
		{
		}
	}
}
