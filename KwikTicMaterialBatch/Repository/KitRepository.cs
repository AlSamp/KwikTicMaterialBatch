using KwikTicMaterialBatch.Data;
using KwikTicMaterialBatch.Data.Models;
using KwikTicMaterialBatch.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace KwikTicMaterialBatch.Repository
{
    public class KitRepository : IKitRepository
    {
        private readonly ApplicationDbContext _db;

        public KitRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<Kit> CreateKitAsync(Kit kit)
        {
            _db.Kits.AddAsync(kit);
            await _db.SaveChangesAsync();
            return kit;
        }

        public async Task<bool> DeleteKitAsync(int id)
        {
            var obj = await _db.Kits.FirstOrDefaultAsync(u => u.KitId== id);

            if (obj is null)
            {
                return false;
            }
            else
            {
                _db.Kits.Remove(obj);
                return await _db.SaveChangesAsync() > 0;

            }
        }

        public async Task<IEnumerable<Kit>> GetAllKitsAsync()
        {
            return await _db.Kits.ToListAsync();
        }

        public async Task<Kit> GetKitByIdAsync(int kitId)
        {
            var obj = await _db.Kits.FirstOrDefaultAsync(u => u.KitId == kitId);

            if (obj is null)
            {
                return new Kit(); // will return null
            }
            else
            {
                return obj;
            }
        }

        public async Task<Kit> UpdateKitAsync(Kit kit)
        {
            var objectFromDb = await _db.Kits.FirstOrDefaultAsync(u => u == kit);

            if (objectFromDb is null)
            {
                return kit;
            }
            else
            {
                // TODO FINISH THIS for each variable in Kit

                objectFromDb = kit;
                _db.Kits.Update(objectFromDb);
                await _db.SaveChangesAsync();

                return objectFromDb;

            }
        }
    }
}
