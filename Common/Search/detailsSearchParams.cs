using System;
using System.Collections.Generic;
using Common.Enums;

namespace Common.Search
{
	public class detailsSearchParams : BaseSearchParams
	{
		public detailsSearchParams(int startIndex = 0, int? objectsCount = null) : base(startIndex, objectsCount)
		{
		}
	}
}
