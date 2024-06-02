using MagicVilla_VillaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MagicVilla_VillaAPI.Reponsitory.IReponsitory
{
    public interface IVillaRepository : IRepository<Villa>
    {
        Task<Villa> UpdateAsync(Villa entity);
    }
}
