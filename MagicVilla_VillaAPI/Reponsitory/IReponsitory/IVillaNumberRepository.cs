using MagicVilla_VillaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MagicVilla_VillaAPI.Reponsitory.IReponsitory
{
    public interface IVillaNumberRepository : IRepository<VillaNumber>
    {
        Task<VillaNumber> UpdateAsync(VillaNumber entity);
    }
}
