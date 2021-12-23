namespace LibraryManagementSystem.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    using LibraryManagementSystem.Data.Common.Models;

    public class LibraryCard : BaseDeletableModel<int>
    {
        public LibraryCard()
        {
            this.Checkouts = new HashSet<Checkout>();
        }

        public decimal CurrentFees { get; set; }

        public virtual DateTime Issued { get; set; }

        [ForeignKey(nameof(ApplicationUser))]
        public Guid UserId { get; set; }

        public ApplicationUser User { get; set; }

        public virtual IEnumerable<Checkout> Checkouts { get; set; }
    }
}
