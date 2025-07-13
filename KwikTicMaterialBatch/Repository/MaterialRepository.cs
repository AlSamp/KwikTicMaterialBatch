using KwikTicMaterialBatch.Data;
using KwikTicMaterialBatch.Data.Models;
using KwikTicMaterialBatch.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace KwikTicMaterialBatch.Repository
{

    public class MaterialRepository : IMaterialRepository
    {
        private readonly ApplicationDbContext _db;

        public MaterialRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<Material> CreateMaterial(Material material)
        {
            _db.Materials.AddAsync(material);
            await _db.SaveChangesAsync();
            return material;
        }

        public async Task<bool> DeleteMaterial(int id)
        {
            var obj = await _db.Materials.FirstOrDefaultAsync(u => u.KitId == id);

            if(obj is null)
            {
                return false;
            }
            else
            {
                _db.Remove(obj);
                return await _db.SaveChangesAsync() > 0;
                
            }
        }

        public async Task<IEnumerable<Material>> GetAllMaterials()
        {
           return await _db.Materials.ToListAsync();
        }

        public async Task<Material> GetMaterialById(int materialId)
        {
            var obj = await _db.Materials.FirstOrDefaultAsync(u => u.MaterialID == materialId);

            if(obj is null)
            {
                return new Material(); // will return null
            }
            else
            {
                return obj;
            }
        }

        public async Task<Material> UpdateMaterial(Material material)
        {
            var objectFromDb = await _db.Materials.FirstOrDefaultAsync(u => u == material);

            if(objectFromDb is null)
            {
                return material;
            }
            else
            {
                // TODO FINISH THIS
                //objectFromDb.MaterialSerialNumber = material.MaterialSerialNumber;

                _db.Materials.Update(objectFromDb);
                await _db.SaveChangesAsync();

                return objectFromDb;
                
            }
        }
    }
}
