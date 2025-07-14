using KwikTicMaterialBatch.Data.Models;

namespace KwikTicMaterialBatch.Repository.IRepository
{
    public interface IBatchRepository
    {
        public Task<Batch> CreateBatchAsync(Batch batch); // Create a new Batch
        public Task<Batch> UpdateBatchAsync(Batch batch); // Update a specific Batch
        public Task<bool> DeleteBatchAsync(int id); // Delete a specific Batch by its ID
        public Task<Batch> GetBatchByIdAsync(int batchId); // Get a specific Batch by its ID
        public Task<IEnumerable<Batch>> GetAllBatchesAsync(); // Get All Batches
    }
}
