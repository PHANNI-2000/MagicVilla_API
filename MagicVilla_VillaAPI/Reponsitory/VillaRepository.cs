using MagicVilla_VillaAPI.Data;
using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Reponsitory.IReponsitory;
using System;
using System.Threading.Tasks;

namespace MagicVilla_VillaAPI.Reponsitory
{
    public class VillaRepository : Repository<Villa>, IVillaRepository
    {
        private readonly ApplicationDbContext _context;
        public VillaRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Villa> UpdateAsync(Villa entity)
        {
            entity.UpdatedDate = DateTime.Now;
            _context.Villas.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
