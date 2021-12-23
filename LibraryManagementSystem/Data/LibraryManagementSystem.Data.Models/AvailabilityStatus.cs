namespace LibraryManagementSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using LibraryManagementSystem.Data.Common.Models;

    public class AvailabilityStatus : BaseDeletableModel<int>
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
