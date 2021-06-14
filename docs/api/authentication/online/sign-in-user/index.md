---
title: How to authenticate an application user
uid: auth_user_oidc
description: How to authenticate an application user
author: {github-id}
keywords: authentication, OAuth 2.0, OIDC, Authorization Code flow, Implicit flow
so.topic: howto
so.envir: cloud
so.client: online
---

# How to authenticate an application user

Let's look at how you can authenticate an application user with OAuth 2.0. Not sure which flow to use? Check out the [authentication scenarios for various app types][7].

The **client ID** is necessary to link the user to an application definition where the redirect URL is specified.

## Pre-requisites

* You have received a unique [client ID and secret][2].
* You have whitelisted your [redirect URL][3] with SuperOffice.
* You have set up a web page at your redirect URL.
* The application user has a valid username and password.

> [!TIP]
> Remember that the sub-domain is different for [development, stage, and production][4]. Very likely the client ID differs too.

## OAuth Authorization Code flow

In the Authorization Code flow, an end-user accesses a client application that requires the user to authenticate. After clicking **Sign in**, the partner application redirects the user agent, typically a browser, to the authorization endpoint of the Identity Provider.

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

* [Hybrid flow][8]
* [Native App flow on Windows and mobile devices][9]

<!-- Referenced links -->
[1]: implicit-flow.md
[2]: ../../../../../superoffice-docs/docs/apps/terminology.md
[3]: ../../../../../superoffice-docs/docs/apps/redirects/index.md
[4]: ../../../../../superoffice-docs/docs/apps/getting-started/app-envir.md
[5]: ../validate-security-tokens.md
[6]: auth-code-flow.md
[7]: ../which-flow-to-use.md
[8]: hybrid-flow.md
[9]: native-apps.md

<!-- Referenced images -->
[img1]: media/oauth-code-flow.png
[img2]: ../media/id-token.png
