using KwikTicMaterialBatch.Data.Models.Abstract;

namespace KwikTicMaterialBatch.Data.Models
{

    /// <summary>
    /// Record of a Production Order
    /// </summary>
    public class Batch //: AuditableEntity
    {
        public int BatchID { get; set; }
        /// <summary>
        /// Unique Name of the Batch / Production Order
        /// </summary>
        public string BatchName { get; set; }

        public virtual ICollection<Material> Materials { get; set; }
    }
}
