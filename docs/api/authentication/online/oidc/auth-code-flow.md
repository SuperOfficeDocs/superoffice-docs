---
title: Authorization code flow
uid: auth_code_flow
description: Authorization code flow
author: {github-id}
keywords: oidc
so.topic: concept
so.envir: cloud
so.client: online
---

# Authorization code flow

In the authorization code flow, a human user accesses a client application that requires the user to authenticate.

There are two types of Authorization Code Flow. The standard as described below, and [Proof Key for Code Exchange][5] (PKCE) to support native applications such as Windows apps and mobile phone apps. PKCE support was introduced in January 2020.

![Authorization Code Flow][img1]

1. After clicking **Sign in**, the partner application redirects the user agent, typically a browser, to the [authorization endpoint][6] of the identity provider.

    `https://sod.superoffice.com/login/common/oauth/authorize`

2. The user agent sends  a request to the identity provider authorization URI with the following information:
    * a **response type**
    * the **scope**
    * the **client ID**
    * the **state**
    * the **redirect URI**

    ```http
    GET Request (test in a browser to handle the login/redirect)

    https://sod.superoffice.com/login/common/oauth/authorize?
    client_id=c789b7d98f3c496fb5aaa4b1a81ca11b&
    scope=openid&
    redirect_uri=https://partnerapp/callback&
    state=12345&
    response_type=code&
    ```

    Authorization code flow parameters are listed below.

3. The user is then directed to the authentication server **sign-in screen**, where they enter their credentials. An identity provider authenticates the user and asks for consent to access their resources on behalf of the relying party.

4. With consent given, the authentication server sends an authorization response message from its authorization endpoint. This redirects the user-agent back to the relying party using the redirection URI provided earlier. This URI includes an **authorization code** and any state provided by the client earlier.

    ```http
    GET Response

    https://partnerapp/callback?
    state=12345&
    code=o0NWI5leHdUflrjlTVVKqbSOt3n9Od0ZrBUq0nXFWKszyOdOZchk60fTf4pDWTFT
    ```

    Authorization code response parameters are listed below.

5. The relying party then makes a request for an [ID token][1] to the token endpoint by sending the client ID, the client secret, the authorization code, the redirect URI, and the grant type.

    ```http
    POST Request (can be tested in a client such as Postman or Fiddler)Content-Type: application/x-www-form-urlencoded
    
    https://sod.superoffice.com/login/common/oauth/tokens?
    client_id=c789b7d98f3c496fb5aaa4b1a81ca11b&
    client_secret=83d0f3bcb9afbc7eb9d0682e9b86db52&
    code=o0NWI5leHdUflrjlTVVKqbSOt3n9Od0ZrBUq0nXFWKszyOdOZchk60fTf4pDWTFT&
    redirect_uri=http://partner-app/callback&
    grant_type=authorization_code&
    ```

    Authorization code request parameters are listed below.

6. The identity provider authenticates the client using the client ID and secret and validates the redirect URI. When the grant type is set to `authorization_code`, the identity provider will validate the code parameter. Alternatively, the grant type is set to `refresh_token` and the provider will validate the `refresh_token` parameter.

7. If valid, the identity provider responds back with the [ID token][1] from the token endpoint. The response also includes an [access token][3] and an optional [refresh token][4]. The client validates the ID token, and if successful, the identity is proven and the authorization code flow is complete.

    [!include[auth-code-response.md](./includes/auth-code-response.md)]
  
    Authorization code token response parameters are listed below.

## Authorization code flow parameters

| Parameter | Required | Description |
|-----------|:--------:|-------------|
| `client_id` | yes| The client ID (application ID) assigned to your app when you registered it with SuperOffice. |
| `scope` | yes | Must be `openid`. |
| `redirect_uri` | yes | The [redirection endpoint][1] of your app, where authentication responses are sent and received.<br>It must exactly match one of the redirect URLs registered with SuperOffice. |
| `state` | recommended | A value set by the relying party to maintain state between the request and the callback itself. Included in the request and also returned in the token response. |
| `response_type` | yes | Must include `code` for the authorization code flow. |
| `response_mode`| no | Can be one of: <br>`fragment` and returns parameters in the URI after hash #<br>`form_post` and returns values in form data |
| `login_hint` | no | Hint to the authorization server about the login identifier the user might use to sign in. For SuperOffice, this must be **SuperID username**. When used, it updates the user's name in the login cookie and is displayed in the username field. (added June 2019) |
| `code_challenge` | with PKCE | **Required for PKCE only.** (added January 2020) |
| `code_challenge_method` | no | **Optional for PKCE only.** Defaults to "plain" if not present in the request. Code verifier transformation method is "S256" or "plain". (added January 2020) |

## Authorization code response

| Parameter | Description |
|-----------|-------------|
| code | The authorization code generated by the authorization server.<br>Expires after 10 minutes. |
| state | The exact value received from the client. |

## Authorization code request

| Parameter | Required | Description |
|-----------|:--------:|-------------|
| `client_id` | yes | The ID assigned to your application when you registered it with SuperOffice. |
| `client_secret`| yes\ | The **application secret** (token) assigned to your application when you registered it with SuperOffice. |
| `code` | yes | The authorization code that the application requested.<br>The application can use the authorization code to request an access token for the target resource. |
| `redirect_uri` | yes | The redirect endpoint of your application, where authentication responses are sent and received by your app.<br>It must exactly match one of the redirect URIs registered with SuperOffice. |
| `grant_type` | yes | Must be `authorization_code` for the authorization code flow. |
| `code_verifier` | with PKCE | **Required for PKCE only.** (added January 2020) |

## Authorization code token response

| Parameter | Description |
|-----------|-------------|
| `access_token` | The access token issued by the authorization server. |
| `token_type` | Provides the client with the information required to successfully utilize the access token to make a protected resource request. |
| `expires_in` | The lifetime in seconds of the access token. |
| `refresh_token` | The refresh token, which can be used to [obtain new access tokens][4].<br>The refresh token is a long-lived JWT token that can be re-used.<br>It is coupled to an end-users consent and is valid as long as the application authorization record (consent) exists. Tenants can revoke authorizations. |
| `id_token` | JSON Web Token or JWT, which consists of a Header, Payload, and Signature. The claims in the token form part of the payload. |

<!-- Referenced links -->
[1]: ../../tokens/id-token.md
[3]: ../../tokens/access-token.md
[4]: ../../tokens/refresh-token.md
[5]: https://tools.ietf.org/html/rfc7636
[6]: endpoints.md

<!-- Referenced images -->
[img1]: media/authorizationcodeflow-800.png