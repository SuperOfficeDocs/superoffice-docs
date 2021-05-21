---
title: Refresh tokens
uid: refresh_token
description: Refresh tokens
author: {github-id}
keywords: authentication
so.topic: concept
so.envir: cloud
so.client: online
---

# Refresh tokens

Refresh tokens are used in token-based authentication to get new ID tokens and access tokens when those expire.

A refresh token is essentially a user credential giving infinite authentication. It improves the user experience, especially in native applications.

## How is the refresh token used?

The refresh token is sent in the request to get a new ID token and/or access token:

* when the access (or ID) token has expired
* when you want to update the claims in an ID token

You should only see the refresh token in the authentication code flow, with or without PKCE. Never for single-page applications using the implicit flow.

### Request

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
| `refresh_token` | yes | The refresh token issued as one of the response items in the authorization code flow. |
| `redirect_uri` | no | The redirect URL of your app, where authentication responses are sent and received by your app.<br>It must exactly match one of the redirect URLs registered with SuperOffice. |
| `scope` | no | SuperOffice only supports the scope `openid` and is implicit for each flow. |

### Response

The response contains the token type, access token, expiration in seconds, and identity token.

[!include[refresh token](./includes/refresh-token-response.md)]

## Where does the refresh token come from?

You will receive the refresh token in the authorization response when the application user asks for access for the 1st time.

It is up to the application to securely store the refresh token. This is usually done in a session. **Refresh tokens must never be stored client-side in the browser!**

> [!CAUTION]
> We might **revoke** a refresh token if we suspect its security has been compromised.

## When does the refresh token expire?

This is a long-lived token that is coupled to a user's consent and that can be re-used.

* for the lifetime of the application, or
* as long as the application authorization record (consent) exists, or
* until it has been revoked - tenants can revoke authorizations
