dotnet new --install Duende.IdentityServer.Templates


1. dotnet new isempty -n CarvedRockIdentity

2. inside CarvedRockIdentity
    dotnet new isui

3. Similar to OAuth, OpenID Connect uses scopes to represent something you want to protect and that clients want to access. In contrast to OAuth, scopes in OIDC represent identity data like user id, name or email address rather than APIs.

4. Configure OIDC Scopes -- IdentityResources 

5. Add Test Users

6. Register an OIDC client

7. The DefaultChallengeScheme is used when an unauthenticated user must log in. This begins the OpenID Connect protocol, redirecting the user to IdentityServer.