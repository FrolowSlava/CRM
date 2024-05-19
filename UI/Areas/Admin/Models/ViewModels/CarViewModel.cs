namespace UI.Areas.Admin.Models.ViewModels
{
	public class CarViewModel
	{
		public SearchResultViewModel<CarModel> carModel { get; set; }
		public SearchResultViewModel<ClientModel> clientModel { get; set; }

	}
}
