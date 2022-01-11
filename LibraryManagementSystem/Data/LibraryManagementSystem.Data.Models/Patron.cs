namespace LibraryManagementSystem.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using LibraryManagementSystem.Data.Common.Models;

    public class Patron : BaseDeletableModel<Guid>
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public string Email { get; set; }

        public string Telephone { get; set; }

        [Required]
        public virtual LibraryCard LibraryCard { get; set; }

        public virtual LibraryBranch HomeLibraryBranch { get; set; }
    }
}
