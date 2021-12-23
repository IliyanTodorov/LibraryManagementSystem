namespace LibraryManagementSystem.Data.Models.Assets
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using LibraryManagementSystem.Data.Common.Models;

    public class Book : BaseDeletableModel<int>
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public string ISBN { get; set; }

        public int PublicationYear { get; set; }

        public string Edition { get; set; }

        public string Publisher { get; set; }

        public string DeweyIndex { get; set; }

        public string Language { get; set; }

        public string Summary { get; set; }

        [ForeignKey(nameof(Asset))]
        public Guid AssetId { get; set; }

        public Asset Asset { get; set; }
    }
}
