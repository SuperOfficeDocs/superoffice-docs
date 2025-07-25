---
title: How to authenticate an application user
uid: auth_user_oidc
description: How to authenticate an application user
author: SuperOffice Product and Engineering
keywords: authentication, OAuth 2.0, OIDC, Authorization Code flow, Implicit flow
content_type: howto
category: api
deployment: online
platform: web
redirect_from: /en/authentication/online/sign-in-user/index
---

# How to authenticate an application user (front-channel)

Front-channel authentication is a user-interactive experience facilitated by OAuth 2.0 or **OpenID Connect** (OIDC). In short, the result of an OIDC flow includes an access token, an ID token, and a refresh token. An access token is good for 20 minutes, and a new one is easily obtained using the refresh token. As a **best practice**, several frameworks including ASP.NET, continue to use access tokens until an HTTP 403 error occurs, at which time it uses the refresh token to obtain a new access token and then tries the request again. We have [one example][11] (ASP.NET Core 3.1) that demonstrates another routine using [middleware][12] that checks the expiration of the token before each request and updates it if necessary. We do not claim this to be *the way* to do it but share this as one option among several possible solutions.

Not sure which flow to use? Check out the [authentication scenarios for various app types][7].

The **client ID** is necessary to link the user to an application definition where the redirect URL is specified.

## Pre-requisites

* You have received a unique [client ID and secret][2].
* You have whitelisted your [redirect URL][3] with SuperOffice.
* You have set up a web page at your redirect URL.
* The application user has a valid username and password.

> [!TIP]
> Remember that the sub-domain is different for [development, stage, and production][4]. Very likely the client ID differs too.

## OAuth Authorization Code flow

In the [Authorization Code flow][6], an end-user grants access to a client application that requires consent prior to access tenant resources (web services). The application redirects the user agent, typically a browser, to the authorization endpoint of the Identity Provider.

![oauth-code-flow][img1]

To start the flow, the user agent sends a request to the Identity Provider authorization URI. You can find both code examples and parameter descriptions in our [detailed walk-through of the flow][6].

## Implicit flow

Below is a high-level overview of the flow. For details, check out the [Implicit flow scenarios][1].

1. Forward the user to the SuperOffice CRM Online **sign-in page** to authenticate.

    ```http
    https://{env}.superoffice.com/login/common/oauth/authorize?response_type=id_token token
    &client_id=YOUR-APP-ID&redirect_uri=YOUR-REDIRECT-URL&scope=openid&state=12345
    &nonce=7362CAEA-9CA5-4B43-9BA3-34D7C303EBA7
    ```

2. Receive the **authentication token** when the sign-in page redirects the user back to your application.

3. [Validate the authentication token][5].

> [!WARNING]
> No application is allowed to ask users for their credentials, ever!

## Other options

* [Native App flow on Windows and mobile devices][9]
* [Hybrid flow][8]

<!-- Referenced links -->
[1]: implicit-flow.md
[2]: ../../../../developer-portal/getting-started/index.md#terminology
[3]: ../../../../developer-portal/create-app/config/redirects.md
[4]: ../../../../developer-portal/getting-started/app-envir.md
[5]: ../validate-security-tokens.md
[6]: auth-code-flow.md
[7]: ../which-flow-to-use.md
[8]: hybrid-flow.md
[9]: native-apps.md

[11]: https://github.com/SuperOffice/devnet-oidc-razor-pages-webapi
[12]: https://github.com/SuperOffice/devnet-oidc-razor-pages-webapi/blob/master/source/SuperOffice.DevNet.RazorPages/Middleware/RefreshTokenMiddleware.cs

<!-- Referenced images -->
[img1]: media/oauth-code-flow.png
