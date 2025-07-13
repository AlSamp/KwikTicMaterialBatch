using KwikTicMaterialBatch.Data.Models.Abstract;

namespace KwikTicMaterialBatch.Data.Models
{
    /// <summary>
    /// Material is a uniquely identifiable quantity of parts.
    /// </summary>
    public class Material : AuditableEntity
    {

        public int MaterialID { get; set; }

        /// <summary>
        /// Unique Serial Number that will be used as a Barcode or QR code on the material
        /// </summary>
        public string MaterialSerialNumber { get; set; }

        /// <summary>
        /// Part number of the Material
        /// </summary>
        public string MaterialName { get; set; }

        /// <summary>
        /// Description of the part number
        /// </summary>
        public string MaterialDescription { get; set; }

        /// <summary>
        /// How many items in the original Material
        /// </summary>
        public Nullable<int> Quantity { get; set; }

        /// <summary>
        /// Has this Material been used up / Empty?
        /// </summary>
        public bool AllUsed { get; set; } = false;


        /// <summary>
        /// Which KitId is the Material currently in?
        /// </summary>
        public Nullable<int> KitId { get; set; }

        /// <summary>
        /// Which Kit is the Material currently in?
        /// </summary>
        public virtual Kit Kit { get; set; }


        /// <summary>
        /// List of BatcheIds where the Material has been used
        /// </summary>
        //public ICollection<int> BatchId { get; set;}

        /// <summary>
        /// List of Batches where the Material has been used
        /// </summary>
        public virtual ICollection<Batch> Batches { get; set; } = new List<Batch>();


    }
}
