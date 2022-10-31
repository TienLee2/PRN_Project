using System.Linq;
using System.Security.Claims;

namespace PRN_Project.Extensions
{
    public static class ItentityExtensions
    {


        public static string GetSpecificClaim(this ClaimsPrincipal claimsPrincipal, string claimType)
        {
            var claim = claimsPrincipal.Claims.FirstOrDefault(x=>x.Type ==claimType);
            return (claim != null) ? claim.Value : string.Empty;
        }
    }
}
