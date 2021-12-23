namespace LibraryManagementSystem.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using LibraryManagementSystem.Data.Common.Models;
    using LibraryManagementSystem.Data.Models.Assets;

    public class LibraryBranch : BaseDeletableModel<int>
    {
        public LibraryBranch()
        {
            this.Patrons = new HashSet<ApplicationUser>();
            this.LibraryAssets = new HashSet<Asset>();
        }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Telephone { get; set; }

        public string Description { get; set; }

        public virtual DateTime OpenDate { get; set; }

        public virtual IEnumerable<ApplicationUser> Patrons { get; set; }

        public virtual IEnumerable<Asset> LibraryAssets { get; set; }

        public string ImageUrl { get; set; }
    }
}
