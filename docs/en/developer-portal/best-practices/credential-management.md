---
uid: app-best-practice-credential-management
title: Credential management
description: Best practices for Credential management
author: Eivind Fasting
keywords: apps, best practices, 3rd-party, credential management
date: 08.05.2023
topic: howto
envir: cloud
client: online
---

# Credential management

SuperOffice supports two types of authentication: front-channel and back-channel. Both exist outside any tenant API space and availability is independent of the tenant.

## Front-channel

Authentication is a user-interactive experience facilitated by OAuth 2.0 or **OpenID Connect** (OIDC), and is documented in our [interactive authentication][1] section. In short, the result of an OIDC flow includes an access token, an ID token, and a refresh token. An access token is good for 20 minutes, and a new one is easily obtained using the refresh token. As a **best practice**, several frameworks including ASP.NET, continue to use access tokens until an HTTP 403 error occurs, at which time it uses the refresh token to obtain a new access token and then tries the request again. We have [one example][2] (ASP.NET Core 3.1) that demonstrates another routine using [middleware][3] that checks the expiration of the token before each request and updates it if necessary. We do not claim this to be *the way* to do it but share this as one option among several possible solutions.

## Back-channel

Authentication is a non-interactive, server-to-server, experience facilitated by the [System User flow][4]. This flow returns a JWT token that contains several claims **including a ticket**. The ticket claim is *the* credential, **not** the JWT itself, and is valid for up to 6 hours. Our recommended **best practice** for back-channel communications is to actively manage the system user ticket credential. The ticket credential is good for 6 hours, and has a sliding-expiration behavior that resets the 6 hour window each time it is used. We recommend applications cache the Ticket credential and keep track of the timeout period from when it was issued and last used. Only obtain a new ticket when the current one has expired or is about to expire.

Do not invoke the system user flow before each and every call to a tenant's API, unless there is more than 6 hours between each invocation.

You must for security reasons [Validate every security token][5] sent from SuperOffice CRM Online.

<!-- Referenced links -->
[1]: ../../api/authentication/online/sign-in-user/index.md
[2]: https://github.com/SuperOffice/devnet-oidc-razor-pages-webapi
[3]: https://github.com/SuperOffice/devnet-oidc-razor-pages-webapi/blob/master/source/SuperOffice.DevNet.RazorPages/Middleware/RefreshTokenMiddleware.cs
[4]: ../../api/authentication/online/auth-application/index.md
[5]: ../../api/authentication/online/validate-security-tokens.md
