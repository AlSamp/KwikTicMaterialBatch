using KwikTicMaterialBatch.Data;
using KwikTicMaterialBatch.Data.Models;
using KwikTicMaterialBatch.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace KwikTicMaterialBatch.Repository
{
    public class BatchRepository : IBatchRepository
    {
        private readonly ApplicationDbContext _db;

        public BatchRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<Batch> CreateBatchAsync(Batch batch)
        {
            _db.Batches.AddAsync(batch);
            await _db.SaveChangesAsync();
            return batch;
        }

        public async Task<bool> DeleteBatchAsync(int id)
        {
            var obj = await _db.Batches.FirstOrDefaultAsync(u => u.BatchID == id);

            if (obj is null)
            {
                return false;
            }
            else
            {
                _db.Batches.Remove(obj);
                return await _db.SaveChangesAsync() > 0;

            }
        }

        public async Task<IEnumerable<Batch>> GetAllBatchesAsync()
        {
            return await _db.Batches.ToListAsync();
        }

        public async Task<Batch> GetBatchByIdAsync(int batchId)
        {
            var obj = await _db.Batches.FirstOrDefaultAsync(u => u.BatchID == batchId);

            if (obj is null)
            {
                return new Batch(); // will return null
            }
            else
            {
                return obj;
            }
        }

        public async Task<Batch> UpdateBatchAsync(Batch batch)
        {
            var objectFromDb = await _db.Batches.FirstOrDefaultAsync(u => u == batch);

            if (objectFromDb is null)
            {
                return batch;
            }
            else
            {
                // TODO FINISH THIS for each variable in Kit

                objectFromDb = batch;
                _db.Batches.Update(objectFromDb);
                await _db.SaveChangesAsync();

                return objectFromDb;

            }
        }
    }
}
