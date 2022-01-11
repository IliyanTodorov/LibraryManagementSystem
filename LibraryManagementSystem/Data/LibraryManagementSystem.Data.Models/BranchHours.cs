namespace LibraryManagementSystem.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using LibraryManagementSystem.Data.Common.Models;

    public class BranchHours : BaseDeletableModel<int>
    {
        [Range(0, 6)]
        public int DayOfWeek { get; set; }

        [Range(0, 23)]
        public int OpenTime { get; set; }

        [Range(0, 23)]
        public int CloseTime { get; set; }

        public virtual LibraryBranch Branch { get; set; }
    }
}