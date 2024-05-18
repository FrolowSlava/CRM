using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Common.Enums;
using Entities;

namespace UI.Areas.Admin.Models
{
	public class WorkerModel
	{
		[Required(ErrorMessage = "Укажите значение")]
		[Display(Name = "WorkerId")]
		public int WorkerId { get; set; }

		[Display(Name = "WorkerName")]
		public string WorkerName { get; set; }

		[Display(Name = "RolesId")]
		public int? RolesId { get; set; }

		[Display(Name = "IsBusy")]
		public bool? IsBusy { get; set; }

		public static WorkerModel FromEntity(Worker obj)
		{
			return obj == null ? null : new WorkerModel
			{
				WorkerId = obj.WorkerId,
				WorkerName = obj.WorkerName,
				RolesId = obj.RolesId,
				IsBusy = obj.IsBusy,
			};
		}

		public static Worker ToEntity(WorkerModel obj)
		{
			return obj == null ? null : new Worker(obj.WorkerId, obj.WorkerName, obj.RolesId, obj.IsBusy);
		}

		public static List<WorkerModel> FromEntitiesList(IEnumerable<Worker> list)
		{
			return list?.Select(FromEntity).ToList();
		}

		public static List<Worker> ToEntitiesList(IEnumerable<WorkerModel> list)
		{
			return list?.Select(ToEntity).ToList();
		}
	}
}
