namespace LibraryManagementSystem.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    using LibraryManagementSystem.Data.Models.Assets;

    public class CheckoutHistory : BaseDelatableModel<int>
    {
        [ForeignKey(nameof(Asset))]
        public Guid AssetId { get; set; }

        public virtual Asset Asset { get; set; }

        [ForeignKey(nameof(LibraryCard))]
        public int LibraryCardId { get; set; }

        public virtual LibraryCard LibraryCard { get; set; }

        public virtual DateTime CheckedOut { get; set; }

        public DateTime? CheckedIn { get; set; }
    }
}
