using Duende.IdentityServer;
using Duende.IdentityServer.Models;
using IdentityModel;

namespace CarvedRockIdentity;

public static class Config
{
    public static IEnumerable<IdentityResource> IdentityResources =>
        new IdentityResource[]
        {
            new IdentityResources.Profile(),
            new IdentityResources.OpenId(),
            new IdentityResources.Email()

        };

    public static IEnumerable<ApiScope> ApiScopes =>
        new ApiScope[]
            { new ApiScope("api","api") };

    public static IEnumerable<ApiResource> ApiResources =>
        new ApiResource[]
        {
            new ApiResource("api","API resource",new string[] { JwtClaimTypes.Email , JwtClaimTypes.Name })
            {
                Scopes ={"api"},
                
            }
        };

    public static IEnumerable<Client> Clients =>
        new Client[]
            { 
                 // interactive ASP.NET Core Web App
        new Client
        {
            ClientId = "CarvedRock.WebApp",
            ClientSecrets = { new Secret("carvedrock".Sha256()) },
            AlwaysIncludeUserClaimsInIdToken = true,
            AllowedGrantTypes = GrantTypes.Code,
            
            // where to redirect to after login
            RedirectUris = { "https://localhost:7273/signin-oidc" },
            AllowOfflineAccess = true,
            // where to redirect to after logout
            PostLogoutRedirectUris = { "https://localhost:7273/signout-callback-oidc" },

            AllowedScopes = new List<string>
            {
                IdentityServerConstants.StandardScopes.OpenId,
                IdentityServerConstants.StandardScopes.Profile,
                IdentityServerConstants.StandardScopes.Email,
                IdentityServerConstants.StandardScopes.OfflineAccess,
                "api"
            }
        }
            };
}