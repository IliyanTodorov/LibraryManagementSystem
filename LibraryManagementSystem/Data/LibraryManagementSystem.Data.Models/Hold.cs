namespace LibraryManagementSystem.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    using LibraryManagementSystem.Data.Common.Models;
    using LibraryManagementSystem.Data.Models.Assets;

    public class Hold : BaseDeletableModel<int>
    {
        public virtual DateTime HoldPlaced { get; set; }

        public virtual DateTime? UpdatedOn { get; set; }

        [ForeignKey(nameof(Asset))]
        public Guid AssetId { get; set; }

        public virtual Asset Asset { get; set; }

        [ForeignKey(nameof(LibraryCard))]
        public int LibraryCardId { get; set; }

        public virtual LibraryCard LibraryCard { get; set; }
    }
}
