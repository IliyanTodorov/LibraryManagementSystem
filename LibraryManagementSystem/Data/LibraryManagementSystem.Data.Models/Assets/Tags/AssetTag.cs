namespace LibraryManagementSystem.Data.Models.Assets.Tags
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class AssetTag
    {
        public int TagId { get; set; }

        public Tag Tag { get; set; }

        public Guid AssetId { get; set; }

        public Asset Asset { get; set; }
    }
}
