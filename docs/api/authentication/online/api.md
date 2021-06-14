---
title: Authentication API
uid: oidc_auth_api
description: OIDC endpoints and metadata document, authorization header types, SuperOffice-specific claims
author: {github-id}
keywords: OIDC, endpoint, metadata, authentication, soticket, bearer, claims, access token, refresh token
so.topic: reference
so.envir: cloud
so.client: online
---

# API

The OpenID Connect identity provider has multiple endpoints with which the user and client application interact.

## OpenID Connect metadata document

OpenID Connect describes a metadata document that contains most of the information required for an app to perform sign-in. This includes all endpoint URLs in use and the location of the service’s public signing keys.

The metadata is a simple JavaScript Object Notation (JSON) document and can be found at:

`https://{environment}.superoffice.com/login/.well-known/openid-configuration`

The **environment** subdomain is unique for each [application environment][1]:

### Environment-specific sub-domains

| Environment | Sub-domain |
|-------------|------------|
| Development | sod        |
| Stage       | qaonline   |
| Production  | online     |

### Example excerpt

[!include[OIDC metadata document](includes/oidc-metadata.md)]

## Endpoints

### Authorization endpoint

This is where the user is asked to authenticate and [grant the partner application consent to access][2] their identity. When consent is given, this endpoint passes back an Authorization Code.

Here, the user interacts indirectly with the identity provider through a user agent, such as a browser.

### Token endpoint

This endpoint authenticates the client application. It also exchanges the Authorization Code from the authorization endpoint for an [ID token][3], an access token, and a refresh token.

#### Access tokens

**Access tokens** are used in token-based authentication to allow an application to access an API.

The SuperOffice access token is **proprietary** and not a standard JWT. It can't be inspected with tools such as [jwt.io][8].

The access token is primarily a means to call a target API. It is:

* used as a **credential** when calling the API
* time-limited and needs to be refreshed periodically

You will receive the access token in the authorization response. It is up to the application to securely store the access token.

You need to get a new access token when:

* the application user signs in for the 1st time
* the previous token expires

#### Refresh tokens

**Refresh tokens** are used in token-based authentication to get new ID tokens and access tokens when those expire.

A refresh token is essentially a user credential giving infinite authentication. It improves the user experience, especially in native applications.

The refresh token is sent in the request to get a new ID token and/or access token:

* when the access (or ID) token has expired
* when you want to update the claims in an ID token

You should see the refresh token only in the **authentication code flow**, with or without PKCE. Never for single-page applications using the Implicit flow.

You will receive the refresh token in the authorization response when the application user asks for access for the 1st time. It is up to the application to securely store the refresh token. This is usually done in a session. **Refresh tokens must never be stored client-side in the browser!**

> [!CAUTION]
> We might **revoke** a refresh token if we suspect its security has been compromised.

This is a long-lived token that is coupled to a user's consent and that can be re-used:

* for the lifetime of the application, or
* as long as the application authorization record (consent) exists, or
* until it has been revoked - tenants can revoke authorizations

##### Request

A `refresh_token` is used in a POST request as follows:

```http
POST Request (can be tested in a client such as Postman or Fiddler)

https://{env}.superoffice.com/login/common/oauth/tokens?
grant_type=refresh_token&
client_id=4ref5376616343b38d14ddcd804f2654&
client_secret=18f45229e442772a78df5f554e24a456&
refresh_token=nKHwerkjh34Yd6QShsnGKk4cFhTwCv3XtJu9PW2X63MtUMygLdI57BJjwCU0&
redirect_url=http://localhost/callback
```

**Refresh token parameters:**

| Parameter | Required | Description |
|-----------|:--------:|-------------|
| `grant_type` | yes | Must be set to `refresh_token` |
| `client_id` | yes | The client ID (application ID) assigned to your app when you registered it with SuperOffice. |
| `client_secret` | yes | The client secret (application token) assigned to your app when you registered it with SuperOffice. |
| `refresh_token` | yes | The refresh token issued as one of the response items in the Authorization Code flow. |
| `redirect_uri` | no | The redirect URL of your app, where authentication responses are sent and received by your app.<br>It must exactly match one of the redirect URLs registered with SuperOffice. |
| `scope` | no | SuperOffice only supports the scope `openid` and is implicit for each flow. |

##### Response

The response contains the token type, access token, expiration in seconds, and identity token.

[!include[refresh token](includes/refresh-token-response.md)]

### UserInfo endpoint

**Not supported** at the time of writing.

### End Session endpoint

The end session endpoint can be used to trigger single sign-out (see [spec][6]).

### JWKS endpoint

The JSON Web Key Set (JWKS) is a set of keys that contains the public keys used to verify any JSON web token (JWT) issued by SuperID.

## Authorization header types

Your application needs to provide one of the following authorization header types when accessing our APIs. Choose either **SOTicket** or **Bearer**.

### SOTicket authentication

**Content:**

Authorization header with the SuperOffice **SOTICKET** token.

**SO-AppToken** header, which is the client_secret, also known as the application secret.

**Example:**

```http
GET /Cust12345/api/v1/MDOList/category?flat=True HTTP/1.1
Host: sod.superoffice.com
accept: application/json
accept-language: en
Authorization: SOTICKET 7T:MAA3AGYA...MgA2ADcANQA5AA==
SO-AppToken: f2398a3a7wer3759d4b220e9a9c94321
```

### Bearer authentication

**Content:** Authorization header containing Bearer and access token from SuperID

**Example:**

```http
GET /Cust12345/api/v1/MDOList/category?flat=True HTTP/1.1
Host: sod.superoffice.com
accept: application/json
accept-language: en
Authorization: Bearer 8A:Cust12345.AGYA...MgA2ADcANQA5AA==
```

> [!NOTE]
> Available only to SuperOffice CRM Online. Not supported for onsite.

## SuperOffice-specific claims

SuperOffice offers a set of claims in addition to the [OpenID Connect claims][3].

> [!NOTE]
> The claims in the following table are all prefixed with `http://schemes.superoffice.net/identity/`

| Claim name | Federated ID | OpenID Connect | Description |
|---|:-:|:-:|---|
| `associateid` | X | X | The current user's associate ID. |
| `company_name` | X | X | The current user's company name. |
| `ctx` | X | X | The tenant identifier. |
| `email` | X | X | The current user's email address. |
| `firstname` | X | | The current user's first name. |
| `identityprovider` | X | X | The identity provider responsible for authentication. Options:<br>SuperOffice AS (federated ID)<br>`https://sod.superoffice.com` (OpenID Connect) |
| `initials` | X | X | The current user's full name initials. (added June 2019) |
| `is_administrator` | X | X | Determine whether the current user is an administrator. |
| `lastname` | X | | The current user's last name. |
| `netserver_url` | X | X | The URL to a tenant SOAP web service.<br>Often used in conjunction with SuperOffice [.NET NuGet proxies][7].<br>New applications should always use the latest. |
| `remember_me_expires` | X | X | Unused. |
| `serial` | X | X | The tenant database serial number. |
| `so_primary_email_address` | X | X | The current user's primary email address. (added June 2019) |
| `system_token` | X | X | A unique identifier used to exchange for a system ticket.<br>Used for background processing, back-channel communications. |
| `ticket` | X | | A current user's unique identifier, used for authentication. |
| `upn` | X | X | Specifies a user principal name (UPN). |
| `webapi_url` | X | X | The URL to a tenant REST web services. |

<!-- Referenced links -->
[1]: ../../../../superoffice-docs/docs/apps/getting-started/app-envir.md
[2]: ../../../../superoffice-docs/docs/apps/provisioning/get-consent.md
[3]: index.md
[6]: https://openid.net/specs/openid-connect-session-1_0.html#RPLogout
[7]: https://www.nuget.org/packages/SuperOffice.NetServer.Services
[8]: https://jwt.io/
