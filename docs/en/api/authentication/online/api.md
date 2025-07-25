---
title: OpenID Connect
uid: superoffice_openid_connect
description: OIDC endpoints and metadata document, authorization header types, SuperOffice-specific claims
author: AnthonyYates
keywords: OpenID Connect, metadata document
content_type: reference
deployment: online
platform: web
redirect_from: /en/authentication/online/api
---

# OpenID Connect

The OpenID Connect identity provider has multiple endpoints with which the user and client application interact.

OpenID Connect describes a metadata document that contains most of the information required for an app to perform sign-in. This includes all endpoint URLs in use and the location of the service’s public signing keys.

The metadata is a simple JavaScript Object Notation (JSON) document and can be found at:

`https://{environment}.superoffice.com/login/.well-known/openid-configuration`

The **environment** subdomain is unique for each [application environment][1]:

## Environment-specific sub-domains

Only use these root sub-domains.

> [!CAUTION]
> DO NOT USE numbered sub-domains for authentication/authorization!
> Numbered sub-domains are only for API data access, not obtaining authorization tokens.

| Environment | Sub-domain |
|-------------|------------|
| Development | sod        |
| Stage       | qaonline   |
| Production  | online     |

### Example excerpt

```json
{
"issuer": "https://sod.superoffice.com",
"authorization_endpoint": "https://sod.superoffice.com/login/common/oauth/authorize",
"token_endpoint": "https://sod.superoffice.com/login/common/oauth/tokens",
"jwks_uri": "https://sod.superoffice.com/login/.well-known/jwks",
"scopes_supported": [
  "openid"
],
"response_modes_supported": [
  "form_post",
  "fragment",
  "query"
],
"response_types_supported": [
  "code",
  "id_token",
  "code id_token",
  "token id_token",
  "token"
],
"subject_types_supported": [
  "public"
],
"id_token_signing_alg_values_supported": [
  "RS256"
],
"token_endpoint_auth_methods_supported": [
  "client_secret_post",
  "client_secret_basic"
],
"grant_types_supported": [
  "implicit",
  "authorization_code",
  "refresh_token"
],
}
```

## Endpoints

### Authorize endpoint

This is where the user is asked to authenticate and [grant the partner application consent to access][2] their identity. When consent is given, this endpoint passes back an Authorization Code.

Here, the user interacts indirectly with the identity provider through a user agent, such as a browser.

### Tokens endpoint

This endpoint authenticates the client application. It also exchanges the Authorization Code from the authorization endpoint for an [ID token][3], an access token, and a refresh token.

#### Access tokens

**Access tokens** are used in token-based authentication to allow an application to access an API.

The SuperOffice access token is **proprietary** and not a standard JWT. It cannot be inspected with tools such as [jwt.io][8].

The access token is primarily a means to call a target API. It is:

* used as a **credential** when calling the API
* time-limited and needs to be refreshed periodically (3600 seconds / 1 hour)

You will receive the access token in the authorization response. It is up to the application to securely store the access token.

You need to get a new access token when:

* the application user signs in for the 1st time
* the previous token expires

#### Refresh tokens

**Refresh tokens** are used in token-based authentication to get a new access token and ID token when those expire.

The refresh token is sent in a request:

* when the access (or ID) token has expired
* when you want to update the claims in an ID token

The refresh token is only returned in the **authentication code flow**. To read more about how to use a refresh token, visit the [Authorization Code flow][4] section.

### JWKS endpoint

The JSON Web Key Set (JWKS) is a set of keys that contains the public certificate used to verify any JSON web token (JWT) issued by SuperID.

### UserInfo endpoint

**Not supported**, however some OpenID Connect clients allow post-authentication hooks to populate a users profile.

In that case, assuming the hook provides the access_token, one can use the [`v1/User/currentPrincipal`][9] REST endpoint to obtain current users profile details.

**Examples:**

* [NextJS OAuth 2.0 provider][10]
* [AspNet.Security.OAuth.SuperOffice][11]

### End Session endpoint

The end session endpoint can be used to trigger single sign-out (see [spec][6]).

### Revocation endpoint

This endpoint is used to revoke access tokens (reference tokens only) and refresh token.

<!-- Referenced links -->
[1]: ../../../developer-portal/getting-started/app-envir.md
[2]: ../../../developer-portal/provisioning/get-consent.md
[3]: index.md
[4]: ../online/sign-in-user/auth-code-flow.md#refresh-token
[6]: https://openid.net/specs/openid-connect-session-1_0.html#RPLogout
[8]: https://jwt.io/
[9]: ../../reference/restful/rest/User/v1User_GetCurrentPrincipal.md
[10]: https://github.com/SuperOffice/devnet-nextjs-chakraui/blob/09457d1fb020d827de045bcd131f11732edc29d3/lib/superoffice.js#L16
[11]: https://github.com/aspnet-contrib/AspNet.Security.OAuth.Providers/blob/c2cecd1660aa8f48d0fe4da5c38184874bede0e0/src/AspNet.Security.OAuth.SuperOffice/SuperOfficeAuthenticationHandler.cs#L46
