namespace LibraryManagementSystem.Web.ViewModels.Assets
{
    using System;
    using System.Collections.Generic;

    using LibraryManagementSystem.Data.Models;
    using LibraryManagementSystem.Data.Models.Assets;
    using LibraryManagementSystem.Services.Mapping;

    public class AssetDetailsViewModel : IMapFrom<Asset>
    {
        public Guid AssetId { get; set; }

        public string Title { get; set; }

        public string AuthorOrDirector { get; set; }

        public string Type { get; set; }

        public int Year { get; set; }

        public string ISBN { get; set; }

        public string DeweyCallNumber { get; set; }

        public string Status { get; set; }

        public decimal Cost { get; set; }

        public string CurrentLocation { get; set; }

        public string ImageUrl { get; set; }

        public string PatronName { get; set; }

        public Checkout LatestCheckout { get; set; }

        public ICollection<CheckoutHistory> CheckoutHistory { get; set; }

        public ICollection<Hold> CurrentHolds { get; set; }
    }
}
