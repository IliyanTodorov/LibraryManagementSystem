namespace LibraryManagementSystem.Data.Models.Assets.Tags
{
    using System.Collections.Generic;

    using LibraryManagementSystem.Data.Common.Models;

    public class Tag : BaseDeletableModel<int>
    {
        public Tag()
        {
            this.AssetTags = new HashSet<AssetTag>();
        }

        public string Name { get; set; }

        public ICollection<AssetTag> AssetTags { get; set; }
    }
}
