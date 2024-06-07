using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Models.Dto;
using System.Threading.Tasks;

namespace MagicVilla_VillaAPI.Reponsitory.IReponsitory
{
    public interface IUserRepository
    {
        bool IsUniqueUser(string username);
        Task<LoginResponseDTO> Login(LoginRequestDTO loginRequestDTO);
        Task<LocalUser> Register(RegisterationRequestDTO registerationRequestDTO);
    }
}
