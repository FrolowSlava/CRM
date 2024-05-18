using System;
using System.Collections.Generic;
using System.Linq;
using Common.Enums;

namespace Entities
{
	public class Worker
	{
		public int WorkerId { get; set; }
		public string WorkerName { get; set; }
		public int? RolesId { get; set; }
		public bool? IsBusy { get; set; }

		public Worker(int workerId, string workerName, int? rolesId, bool? isBusy)
		{
			WorkerId = workerId;
			WorkerName = workerName;
			RolesId = rolesId;
			IsBusy = isBusy;
		}
	}
}
