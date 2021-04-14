using Dating_API.Entities;

namespace Dating_API.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}