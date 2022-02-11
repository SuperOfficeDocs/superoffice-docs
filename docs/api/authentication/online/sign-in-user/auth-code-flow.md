---
title: Authorization Code flow
uid: auth_code_flow
description: "Introduction to the Authorization Code flow."
author: {github-id}
keywords: oidc
so.topic: concept
so.envir: cloud
so.client: online
---

# Authorization Code flow

In the Authorization Code flow, a human user accesses a client application that requires the user to authenticate.

There are 2 types of Authorization Code flow. The standard as described below, and [Proof Key for Code Exchange][5] (PKCE) to support native applications such as Windows apps and mobile phone apps. PKCE support was introduced in January 2020.

![Authorization Code flow][img1]

1. After clicking **Sign in**, the partner application redirects the user agent, typically a browser, to the [authorization endpoint][2] of the identity provider.

    `https://sod.superoffice.com/login/common/oauth/authorize`

2. The user agent sends a request to the identity provider authorization URI with the following information:
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

    Authorization Code flow [parameters are listed below][3].

3. The user is then directed to the authentication server **sign-in screen**, where they enter their credentials. An identity provider authenticates the user and asks for consent to access their resources on behalf of the Relying Party.

    ```http!
    GET https://sod.superoffice.com/login/common/oauth/authorize?client_id=c789b7d98f3c496fb5aaa4b1a81ca11b&scope=openid&redirect_uri=http://localhost/DevNet-MvcIntegrationServerApp/callback&state=12345&response_type=code
    Accept: application/json
    ```

4. **SuperID redirects to app:** With consent given, the authentication server (SuperID) sends an authorization response message from its authorization endpoint. This redirects the user agent back to the Relying Party using the redirection URI provided earlier. This URI includes an **Authorization Code** and any state provided by the client earlier.

    ```http
    GET Response

    https://partnerapp/callback?
    state=12345&
    code=o0NWI5leHdUflrjlTVVKqbSOt3n9Od0ZrBUq0nXFWKszyOdOZchk60fTf4pDWTFT
    ```

    Authorization Code response [parameters are listed below][4].

5. **App requests access token from SuperID:** The Relying Party (app) then requests an [ID token][1] from the token endpoint by sending the client ID, the client secret, the Authorization Code, the redirect URI, and the grant type to SuperID (the authentication service).

    ```http
    POST Request (can be tested in a client such as Postman or Fiddler)Content-Type: application/x-www-form-urlencoded
    
    https://sod.superoffice.com/login/common/oauth/tokens?
    client_id=c789b7d98f3c496fb5aaa4b1a81ca11b&
    client_secret=83d0f3bcb9afbc7eb9d0682e9b86db52&
    code=o0NWI5leHdUflrjlTVVKqbSOt3n9Od0ZrBUq0nXFWKszyOdOZchk60fTf4pDWTFT&
    redirect_uri=http://partner-app/callback&
    grant_type=authorization_code&
    ```

    Authorization Code request [parameters are listed below][9].

6. The identity provider (SuperID) authenticates the client using the client ID and secret and validates the redirect URI. When the grant type is set to `authorization_code`, the identity provider will validate the code parameter. Alternatively, the grant type is set to `refresh_token` and the provider will validate the `refresh_token` parameter.

7. If valid, the identity provider responds with the ID token from the token endpoint. The response also includes an [access token][2] and an optional [refresh token][2]. The client validates the ID token, and if successful, the identity is proven and the Authorization Code flow is complete.

    ```http!
    POST https://sod.superoffice.com/login/common/oauth/tokens?client_id=c789b7d98f3c496fb5aaa4b1a81ca11b&client_secret=83d0f3bcb9afbc7eb9d0682e9b86db52&code=o0NWI5leHdUflrjlTVVKqbSOt3n9Od0ZrBUq0nXFWKszyOdOZchk60fTf4pDWTFT&redirect_uri=http://localhost/DevNet-MvcIntegrationServerApp/callback&grant_type=authorization_code
    Content-Type: application/json
    Accept: application/json
    ```

    **Post response:**

    [!include[auth-code-response.md](includes/auth-code-response.md)]
  
    Authorization Code token response [parameters are listed below][10].

This gives you the access token directly, as well as the refresh token (which is used to get more access tokens), and the JWT. You will want to keep the `refresh_token` and `access_token` if the JWT is valid.

## Verify the JWT

To verify the JWT, you need to use a PKCS certificate (there is 1 per environment)

The ID token is encoded as a JSON web token or JWT, which consists of a Header, Payload, and Signature. These elements are delimited by a period. The claims in the token form part of the payload.

![JWT Claims][img2]

The actual verification involves cryptography, and you are best off using a library like .net [System.IdentityModel.Tokens.Jwt][6] or Node [jsonwebtoken][7]. See [jwt.io][8] for a bigger list of libraries.

Here is some Node/JavaScript code that does the verification:

```javascript
request(`https://sod.superoffice.com/login/common/oauth/tokens`, {
    method: 'POST',
    body: {
      code: inputData.code,
      client_id: process.env.CLIENT_ID,
      client_secret: process.env.CLIENT_SECRET,
      grant_type: 'authorization_code',
      redirect_uri: process.env.REDIRECT_URL
    },
    headers: {
      'content-type': 'application/x-www-form-urlencoded',
      'accept': 'application/json'
    }
}).then( response => {
    const result = JSON.parse(response.content);
    const options = { };
    const cert = "-----BEGIN CERTIFICATE-----\n"+
      "MIIDqzCCApMCAQgwDQYJKoZIhvcNAQEFBQAwgZMxCzAJBgNVBAYTAk5PMQ0wCwYD\n"++++...;
    const jwt_token = jwt.verify(result.id_token, cert, options);
})
```

The verify call will throw an error if the `id_token` is not signed by the certificate.

### Call the WebAPI with the access token

You can now make a request to the WebAPI using the access token:

```http
GET /api/v1/contact/2
Authorization: Bearer 8A:Cust12020.AR2s3phb0gXK8DP0NfoYlsrQAQAACIJ/KQ+cbGp-0l9g8PJNlBCEZxS/1hL3Cxt8ITWlQipRbdknTbIFxUuUChHj4U1qUlP6/dJA+aKE1psfT8F4Xw-FlYBjvw6xmM086Vckm0Mmh+fEPuoLspl+EgtQzD0F8Ka4qLFGWICvUg==
Accept: application/json
```

This access token contains your application's identity and the user's identity.

You should get a valid response back.

```json
{
  "TableRight": {
      "Mask": "RI, RestrictedUpdate",
      "Reason": "[SR_ACCESS_ASSOCCONT_DELETE]"
  },
  "FieldProperties": { ... },
  "ContactId": 2,
  "Name": "statezerodatabase",
  "Department": "",
  "OrgNr": "",
  "Number1": "",
  "Number2": "",
  "UpdatedDate": "2016-01-04T13:27:28",
  "CreatedDate": "2002-07-23T15:14:29",
  "Emails": [],
```

## Expired access tokens

If the access token has expired, you will get an HTTP 401 error back (unauthorized).

You will need to use the refresh token to get a new access token. With the new access token, you can re-try the request.

A user's refresh_token is valid for the lifetime of the application, or until it has been revoked. A refresh_token is used in a POST request to generate a new access token as follows:

```http
POST https://sod.superoffice.com/login/common/oauth/tokens?
grant_type=refresh_token&
client_id=4ref5376616343b38d14ddcd804f2654&
client_secret=18f45229e442772a78df5f554e24a456&
refresh_token=nKHwerkjh34Yd6QShsnGKk4cFhTwCv3XtJu9PW2X63MtUMygLdI57BJjwCU0&
redirect_url=http://partnerapp/callback
```

| Parameter | Required | Description |
|---|---|---|
| `grant_type` | yes | Must be set to `refresh_token` |
| `client_id` | yes| The Application ID assigned to your app when you registered it with SuperOffice. |
| `client_secret` | yes | The Application Secret assigned to your app when you registered it with SuperOffice. |
| `refresh_token` | yes | The refresh token issued as one of the response items in the Authorization Code flow. |
| `redirect_uri` | no | The `redirect_uri` of your app, where authentication responses are sent and received by your app. It must exactly match one of the redirect_uris registered with SuperOffice. |
| `scope` | no | SuperOffice only supports the scope *openid* and is implicit for each flow. |

The response contains the token type, access token, expiration in seconds, and identity token.

```json
{
  "token_type": "Bearer",
  "access_token": "8A:Cust12345.AZuHwfgrRZPHqdjhQyay34ggAgAA8z5BnSYUSk4U4sdfr1Bjzycu0S1NC+xvghQ4VoUz9r6xpF2YAOCj0rb3LWnjLqllp3fYk8h2sxwc8d+5nb5bzGvHLHJ1UIRk38Ye4dPpmLSr4B8UaYNc9gs4Wgfgxqtii+o5fcB7lbVaVLFGmjUj1jgtIzVKiAR9eyMiWXL3dWMg+WM2Y0MOTsUrSb10kXkJ4g3M4TvH3rV4HTK3ohToxUleYvFbarx/8jeO7oLJfn3nth8NGtd1lJ",
  "expires_in": 3600,
  "id_token": "eyJ0eFor_Demonstration_PurposeszI1NiIsIng1dCI6IkZyZjdqRC1hc0dpRnFBREdUbVRKZkVxMTZZdyJ9.For_Demonstration_PurposesbSIsImh0dHA6Ly9zY2hlbWVzLnN1cGVyb2ZmaWNlLm5ldC9pZGVudGl0eS9hGl0eS9uZXRzZXJ2ZXJfdXJsIjoiaHR0cHM6Ly9zb2Quc3VwZXJvZmZpY2UuY29tL0N1c3QyNjc1OS9SZW1vdGUvThrOFE3RG1CZ28iLCJpYXQiOiIxNTQ2NjEzMTk4IiwiaXNzIjoiaHR0cHM6Ly9zb2Quc3VwZXJvZmZpY2UuY29tqStzCXqhSjd1u7FjsJhqr1xGLDqLzkOm9_0v0nWFHESjBuPhFPIdt6lmcCuy48HGg5G0eM1_3h6SESsukXe0hNMqp3ZHjm5dCEoxE4HziLWSdRZIUa6tkP6wfHDHU_XUJu7PHo8Wx5aG9IBPZ_r1Xd8mgmt6g"
}
```

## Authorization Code flow parameters

| Parameter | Required | Description |
|-----------|:--------:|-------------|
| `client_id` | yes| The client ID (application ID) assigned to your app when you registered it with SuperOffice. |
| `scope` | yes | Must be `openid`. |
| `redirect_uri` | yes | The [redirection endpoint][1] of your app, where authentication responses are sent and received.<br>It must exactly match one of the redirect URLs registered with SuperOffice. |
| `state` | recommended | A value set by the Relying Party to maintain state between the request and the callback itself. Included in the request and also returned in the token response. |
| `response_type` | yes | Must include `code` for the Authorization Code flow. |
| `response_mode`| no | Can be one of: <br>`fragment` and returns parameters in the URI after hash #<br>`form_post` and returns values in form data |
| `login_hint` | no | Hint to the Authorization Server about the login identifier the user might use to sign in. For SuperOffice, this must be **SuperID username**. When used, it updates the user's name in the login cookie and is displayed in the username field. (added June 2019) |
| `code_challenge` | with PKCE | **Required for PKCE only.** (added January 2020) |
| `code_challenge_method` | no | **Optional for PKCE only.** Defaults to "plain" if not present in the request. Code verifier transformation method is "S256" or "plain". (added January 2020) |

## Authorization Code response

| Parameter | Description |
|-----------|-------------|
| code | The Authorization Code generated by the Authorization Server.<br>Expires after 10 minutes. |
| state | The exact value received from the client. |

## Authorization Code request

| Parameter | Required | Description |
|-----------|:--------:|-------------|
| `client_id` | yes | The ID assigned to your application when you registered it with SuperOffice. |
| `client_secret`| yes | The **application secret** (token) assigned to your application when you registered it with SuperOffice. |
| `code` | yes | The Authorization Code that the application requested.<br>The application can use the Authorization Code to request an access token for the target resource. |
| `redirect_uri` | yes | The redirect endpoint of your application, where authentication responses are sent and received by your app.<br>It must exactly match one of the redirect URIs registered with SuperOffice. |
| `grant_type` | yes | Must be `authorization_code` for the Authorization Code flow. |
| `code_verifier` | with PKCE | **Required for PKCE only.** (added January 2020) |

## Authorization Code token response

| Parameter | Description |
|-----------|-------------|
| `access_token` | The access token issued by the Authorization Server. |
| `token_type` | Provides the client with the information required to successfully utilize the access token to make a protected resource request. |
| `expires_in` | The lifetime in seconds of the access token. |
| `refresh_token` | The refresh token, which can be used to [obtain new access tokens][2].<br>The refresh token is a long-lived JWT token that can be re-used.<br>It is coupled to an end-users consent and is valid as long as the application authorization record (consent) exists. Tenants can revoke authorizations. |
| `id_token` | JSON Web Token or JWT, which consists of a Header, Payload, and Signature. The claims in the token form part of the payload. |

<!-- Referenced links -->
[1]: ../index.md
[2]: ../api.md
[5]: https://tools.ietf.org/html/rfc7636
[6]: https://www.nuget.org/packages/System.IdentityModel.Tokens.Jwt/
[7]: https://github.com/auth0/node-jsonwebtoken
[8]: https://jwt.io/
[3]: #authorization-code-flow-parameters
[4]: #authorization-code-response
[9]: #authorization-code-request
[10]: #authorization-code-token-response

<!-- Referenced images -->
[img1]: media/oauth-code-flow.png
[img2]: ../../media/id-token.png
