using Duende.IdentityServer;
using Duende.IdentityServer.Models;

namespace CarvedRockIdentity;

public static class Config
{
    public static IEnumerable<IdentityResource> IdentityResources =>
        new IdentityResource[]
        {
            new IdentityResources.Profile(),
            new IdentityResources.OpenId()
        };

    public static IEnumerable<ApiScope> ApiScopes =>
        new ApiScope[]
            { };

    public static IEnumerable<Client> Clients =>
        new Client[]
            { 
                 // interactive ASP.NET Core Web App
        new Client
        {
            ClientId = "CarvedRock.WebApp",
            ClientSecrets = { new Secret("carvedrock".Sha256()) },

            AllowedGrantTypes = GrantTypes.Code,
            
            // where to redirect to after login
            RedirectUris = { "https://localhost:7273/signin-oidc" },

            // where to redirect to after logout
            PostLogoutRedirectUris = { "https://localhost:7273/signout-callback-oidc" },

            AllowedScopes = new List<string>
            {
                IdentityServerConstants.StandardScopes.OpenId,
                IdentityServerConstants.StandardScopes.Profile
            }
        }
            };
}