namespace DEMO.DAL.Models.Shared
{
    public class BaseEntity
    {
        public int Id { get; set; }

        public int CreatedBy { get; set; } // User Id

        public DateTime CreatedOn { get; set; }  // inserting Data

        public int LastModifiedBy { get; set; }  //User Id

        public DateTime LastModifiedOn { get; set; }  // Update Data

        public bool IsDeleted { get; set; } //Apply Soft Deleted
    }
}
