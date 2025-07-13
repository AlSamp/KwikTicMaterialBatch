using KwikTicMaterialBatch.Data.Models;

namespace KwikTicMaterialBatch.Repository.IRepository
{
    public interface IBatchRepository
    {
        public Batch CreateBatch(Batch batch); // Create a new Batch
        public Batch UpdateBatch(Batch batch); // Update a specific Batch
        public bool DeleteBatch(int id); // Delete a specific Batch by its ID
        public Batch GetBatchById(int batchId); // Get a specific Batch by its ID
        public IEnumerable<Batch> GetAllBatches(); // Get All Batches
    }
}
