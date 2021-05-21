---
title: Endpoints (OICD)
uid: oidc_endpoints
description: Endpoints (OICD)
author: {github-id}
keywords:
so.topic: concept
so.client: online
---

# Endpoints (OICD)

The OpenID Connect identity provider has a number of endpoints with which the user and client application interact.

## OpenID Connect metadata document

OpenID Connect describes a metadata document that contains most of the information required for an app to perform sign-in. This includes all endpoint URLs in use and the location of the service’s public signing keys. The OpenID Connect metadata document can be found at:

`https://{environment}.superoffice.com/login/.well-known/openid-configuration`

The **environment** subdomain is unique for each [application environment][1]; development (sod), stage (qaonline), and production (online).

## Common endpoints

### Authorization endpoint

This is where the user is asked to authenticate and [grant the partner application consent to access][2] their identity. When consent is given, this endpoint passes back an authorization code.

Here, the user interacts indirectly with the identity provider through a user agent, such as a browser.

### Token endpoint

This endpoint authenticates the client application. It also exchanges the authorization code from the authorization endpoint for an [ID token][3], an [access token][4], and a [refresh token][5].

### UserInfo endpoint

**Not supported** at the time of writing.

### End Session endpoint

The end session endpoint can be used to trigger single sign-out (see [spec][6].

### Jwks endpoint

The JSON Web Key Set (JWKS) is a set of keys which contains the public keys used to verify any JSON Web Token (JWT) issued by the SuperID.

<!-- Referenced links -->
[1]: ../../../../../superoffice-docs/docs/apps/getting-started/app-envir.md
[2]: ../../../../../superoffice-docs/docs/apps/provisioning/get-consent.md
[3]: ../../tokens/id-token.md
[4]: ../../tokens/access-token.md
[5]: ../../tokens/refresh-token.md
[6]: https://openid.net/specs/openid-connect-session-1_0.html#RPLogout