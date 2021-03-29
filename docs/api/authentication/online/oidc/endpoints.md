---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: oidc_endpoints       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Endpoints (OICD) # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: concept              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
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
[1]: https://github.com/SuperOfficeDocs/superoffice-docs/blob/main/docs/apps/getting-started/app-envir.md
[2]: https://github.com/SuperOfficeDocs/superoffice-docs/blob/main/docs/apps/provisioning/get-consent.md
[3]: ../id-token.md
[4]: ../access-token.md
[5]: ../refresh-token.md
[6]: https://openid.net/specs/openid-connect-session-1_0.html#RPLogout