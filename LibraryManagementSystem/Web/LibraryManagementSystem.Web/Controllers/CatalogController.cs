namespace LibraryManagementSystem.Web.Controllers
{
    using System;
    using System.Linq;

    using LibraryManagementSystem.Data.Models.Assets;
    using LibraryManagementSystem.Services.Data.Contracts;
    using LibraryManagementSystem.Services.Mapping;
    using LibraryManagementSystem.Web.ViewModels.Assets;
    using Microsoft.AspNetCore.Mvc;

    public class CatalogController : Controller
    {
        private readonly ILibraryAssetsService libraryAssets;

        public CatalogController(ILibraryAssetsService libraryAssets)
        {
            this.libraryAssets = libraryAssets;
        }

        public IActionResult Index()
        {
            var assets = this.libraryAssets.GetAll<AssetsInListViewModel>();

            var viewModel = new AssetsListViewModel()
            {
                Assets = assets,
            };

            return this.View(viewModel);
        }

        public IActionResult Detail(Guid id)
        {
            var asset = this.libraryAssets.GetById<AssetDetailsViewModel>(id);

            return this.View(asset);
        }
    }
}
