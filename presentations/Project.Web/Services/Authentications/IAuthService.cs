using Project.Shared.Authentications;
using Project.Shared.Common;
using Project.Web.Models;

namespace Project.Web.Services.Authentications
{
    public interface IAuthService
    {
        Task<Response<AuthenticationResponse>> Login(AuthenticationRequest request);
    }
}