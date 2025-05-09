---
title: Authorization Code flow
uid: auth_code_flow
description: "Introduction to the Authorization Code flow."
author: {github-id}
keywords: oidc
topic: concept
envir: cloud
client: online
---

# Authorization Code flow

Authorization Code flow is the best flow to use for web applications. When it was first introduced Authorization code flow required the client_secret. However, on a windows or mobile application that causes security problems. Proof Key for Code Exchange (PKCE) ([rfc7636][5]) was introduced as extra layer of security on top of Authorization Code flow, and provides a way for native applications to use Authorization Code flow without exposing the client_secret in a vulnerable way.

> [!NOTE]
> PKCE does not replace the use of a client secret for all scenarios, and in fact PKCE is recommended even when a client is securely using the client secret.

## Getting the user's consent

OAuth is about enabling users to grant access to applications, and allowing those application access to their SuperOffice web services.

The Authorization Code flow begins when a client application redirects a user to the [authorize endpoint][2].

```http
# test in a browser to handle the login/redirect
GET Request https://sod.superoffice.com/login/common/oauth/authorize?
client_id=c789b7d98f3c496fb5aaa4b1a81ca11b&
scope=openid&
redirect_uri=https://[registered-application-redirect_uri]/callback&
state=12345&
response_type=code&
```

### Authorization Code flow parameters

| Parameter | Required | Description |
|-----------|:--------:|-------------|
| `client_id` | yes| The client ID (application ID) assigned to your app when you registered it with SuperOffice. |
| `scope` | yes | Must be `openid`. |
| `redirect_uri` | yes | The [redirection endpoint][1] of your app, where authentication responses are sent and received.<br>It must exactly match one of the redirect URIs for your registered application. |
| `state` | recommended | A value set by the Relying Party to maintain state between the request and the callback itself. Included in the request and also returned in the token response. |
| `response_type` | yes | Must include `code` for the Authorization Code flow. |
| `acr_values` | no | Allows passing in additional related information. SuperOffice allows `tenant:contextIdentifer`, i.e. tenant:Cust12345, used to skip the tenant selection dialog |
| `response_mode`| no | Can be one of: <br>`fragment` and returns parameters in the URI after hash #<br>`form_post` and returns values in form data |
| `login_hint` | no | Hint to the Authorization Server about the login identifier the user might use to sign in. For SuperOffice, this must be **SuperID username**. When used, it updates the user's name in the login cookie and is displayed in the username field. (added June 2019) |
| `code_challenge` | with PKCE | **Required for PKCE only.** (added January 2020) |
| `code_challenge_method` | no | **Optional for PKCE only.** Defaults to "plain" if not present in the request. Code verifier transformation method is "S256" or "plain". (added January 2020) |

The user is then directed to the SuperOffice SuperID **sign-in screen**, where they enter their credentials. An identity provider authenticates the user and asks for consent to access their resources on behalf of the Relying Party (app).

## Redirect back to the application

When successfully authenticated and consent given, **SuperID** sends a response that redirects the user agent back to the Relying Party (app) redirect_uri. The response includes an **Authorization Code** and any state provided by the client earlier.

```http
GET https://partnerapp/callback?
    state=12345&
    code=o0NWI5leHdUflrjlTVVKqbSOt3n9Od0ZrBUq0nXFWKszyOdOZchk60fTf4pDWTFT
```

### Authorization Code response

| Parameter | Description |
|-----------|-------------|
| code | The Authorization Code generated by the Authorization Server.<br>Expires after 10 minutes. |
| state | The exact value received from the client. |

## Exchange the authorization code for an access token

This is the final step, where the Relying Party (app) requests an access token.

```http
# can be tested in an HTTP client such as Postman, Fiddler or VS Code)

POST https://sod.superoffice.com/login/common/oauth/tokens?
     client_id=c789b7d98f3c496fb5aaa4b1a81ca11b&
     client_secret=83d0f3bcb9afbc7eb9d0682e9b86db52&
     code=o0NWI5leHdUflrjlTVVKqbSOt3n9Od0ZrBUq0nXFWKszyOdOZchk60fTf4pDWTFT&
     redirect_uri=http://partner-app/callback&
     grant_type=authorization_code&

Content-Type: application/x-www-form-urlencoded
Accept: application/json
```

## Authorization Code request

| Parameter | Required | Description |
|-----------|:--------:|-------------|
| `client_id` | yes | The ID assigned to your application when you registered it with SuperOffice. |
| `client_secret`| yes | The **application secret** (token) assigned to your application when you registered it with SuperOffice. |
| `code` | yes | The Authorization Code that the application requested.<br>The application can use the Authorization Code to request an access token for the target resource. |
| `redirect_uri` | yes | The redirect endpoint of your application, where authentication responses are sent and received by your app.<br>It must exactly match one of the redirect URIs registered with SuperOffice. |
| `grant_type` | yes | Must be `authorization_code` for the Authorization Code flow. |
| `code_verifier` | with PKCE | **Required for PKCE only.** (added January 2020) |

The identity provider (central-superid) will verify all the parameters, ensuring the client ID and secret match and the code hasn't expired. When that's complete, it will generate an access token and send it in the response.

### Post response

[!include[auth-code-response.md](includes/auth-code-response.md)]

| Parameter | Description |
|-----------|-------------|
| `access_token` | The access token issued by the Authorization Server. |
| `token_type` | Provides the client with the information required to successfully utilize the access token to make a protected resource request. |
| `expires_in` | The lifetime in seconds of the access token. 3600 / 1 hour is expected |
| `refresh_token` | The refresh token, which can be used to [obtain new access tokens][2].<br>The refresh token is a long-lived JWT token that can be re-used.<br>It is coupled to an end-users consent and is valid as long as the application authorization record (consent) exists. Tenants can revoke authorizations. |
| `id_token` | JSON Web Token or JWT, which consists of a Header, Payload, and Signature. The claims in the token form part of the payload. |

The application now has an access token and can start making API requests to the SuperOffice tenant web services.

Certified OpenID Connect libraries automatically verify the id_token. If your application doesn't use a certified library, read [how to validate the id_token JWT][3].

With a verified id_token the application can safely store the `refresh_token` for fetching a new access token when the current expires.

The Authorization Code flow is complete!

## Refresh token

When an access token has expired, refresh tokens are used to get a new access tokens without forcing the user to go through the Authorization Core flow again.

> [!NOTE]
> No other flow, only the Authorization Code flow, returns a refresh token.

The refresh token is only used:

* when the access (or ID) token has expired
* when there is a need to update the claims in an ID token

> [!WARNING]
> Refresh tokens must never be stored client-side in the browser!

This is a long-lived token that is a contract between an application and tenant user. It can be re-used:

* for the lifetime of the application, or
* as long as the application authorization record (consent) exists, or
* until it has been revoked - tenants can revoke authorizations

> [!CAUTION]
> Refresh tokens may be **revoked** if we suspect its security has been compromised, or a customer or application vendor requests it be revoked.

### Send a refresh_token request

A `refresh_token` is used in a POST request sent to the tokens endpoint.

```http
POST Request (can be tested in a client such as Postman or Fiddler)

https://{env}.superoffice.com/login/common/oauth/tokens?
grant_type=refresh_token&
client_id=4ref5376616343b38d14ddcd804f2654&
client_secret=18f45229e442772a78df5f554e24a456&
refresh_token=nKHwerkjh3asd6QShsnGKk4casdwCv3XtJu9PW2XasdtUMygLdI57BJjwCU0&
redirect_url=http://localhost/callback

Accept: application/json
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

### Receive a refresh_token response

The response contains the token type, access token, expiration in seconds, and id token.

[!include[refresh token](../includes/refresh-token-response.md)]

<!-- Referenced links -->
[1]: ../index.md
[2]: ../api.md
[3]: ../validate-security-tokens.md
[5]: https://tools.ietf.org/html/rfc7636

<!-- Referenced images -->
