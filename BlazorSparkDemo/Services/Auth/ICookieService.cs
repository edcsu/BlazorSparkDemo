using Microsoft.AspNetCore.Authentication.Cookies;

namespace BlazorSparkDemo.Lib.Auth
{
    public interface ICookieService
    {
        Task ValidateAsync(CookieValidatePrincipalContext context);
    }
}