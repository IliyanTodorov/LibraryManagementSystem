namespace LibraryManagementSystem.Data.Models.Assets
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    using LibraryManagementSystem.Data.Common.Models;
    using LibraryManagementSystem.Data.Models.Assets.Tags;

    public class Asset : BaseDeletableModel<Guid>
    {
        public Asset()
        {
            this.AssetTags = new HashSet<AssetTag>();
        }

        [ForeignKey(nameof(AvailabilityStatus))]
        public int AvailabilityStatusId { get; set; }

        public AvailabilityStatus AvailabilityStatus { get; set; }

        public decimal Cost { get; set; }

        public string ImageUrl { get; set; }

        [ForeignKey(nameof(LibraryBranch))]
        public int LibraryBranchId { get; set; }

        public LibraryBranch LibraryBranch { get; set; }

        public ICollection<AssetTag> AssetTags { get; set; }
    }
}
