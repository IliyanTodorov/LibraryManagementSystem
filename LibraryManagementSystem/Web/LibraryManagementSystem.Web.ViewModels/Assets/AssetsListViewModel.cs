namespace LibraryManagementSystem.Web.ViewModels.Assets
{
    using System.Collections.Generic;

    public class AssetsListViewModel
    {
        public IEnumerable<AssetsInListViewModel> Assets { get; set; }
    }
}
