using MagicVilla_VillaAPI.Data;
using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Reponsitory.IReponsitory;
using System;
using System.Threading.Tasks;

namespace MagicVilla_VillaAPI.Reponsitory
{
    public class VillaNumberRepository : Repository<VillaNumber>, IVillaNumberRepository
    {
        private readonly ApplicationDbContext _context;
        public VillaNumberRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<VillaNumber> UpdateAsync(VillaNumber entity)
        {
            entity.UpdatedDate = DateTime.Now;
            _context.VillaNumbers.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
