namespace LibraryManagementSystem.Web.ViewModels.Assets
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using LibraryManagementSystem.Data.Models.Assets;
    using LibraryManagementSystem.Services.Mapping;

    public class AssetsInListViewModel : IMapFrom<Asset>
    {
        public Guid Id { get; set; }

        public string ImageUrl { get; set; }

        public string Title { get; set; }

        public string Type { get; set; }

        public string AuthorOrDirector { get; set; }

        public string DeweyCallNumber { get; set; }

        public string NumberOfCopies { get; set; }
    }
}
