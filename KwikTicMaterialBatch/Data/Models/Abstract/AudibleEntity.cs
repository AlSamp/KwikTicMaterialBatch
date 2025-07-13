namespace KwikTicMaterialBatch.Data.Models.Abstract
{
    public abstract class AuditableEntity //: TenantBaseEntity, IAuditableEntity, IMustHaveTenant
    {
        public Guid CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedOn { get; set; }
    }
}
