namespace KwikTicMaterialBatch.Data.Models
{
    /// <summary>
    /// A container that holds a list of Material
    /// </summary>
    public class Kit //: AuditableEntity
    {
        public int KitId { get; set; }

        /// <summary>
        /// Name of this Kit
        /// Unique - Probably used as a Barcode or QR Code on the Box or Container
        /// </summary>
        public string KitName { get; set; }

        /// <summary>
        /// List of Material currently in this Kit
        /// </summary>
        public virtual ICollection<Material> Materials { get; set; }
    }

}
