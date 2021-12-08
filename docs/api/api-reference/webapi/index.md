---
title: SuperOffice WebApi Client Library
description: Describes the SuperOffice WebApi library, a REST client for SuperOffice web services.
author: Anthony Yates
so.date: 11.24.2021
so.topic: reference
keywords: API, WebApi, REST client, SuperOffice.WebApi, OpenID Connect, OAuth, TokenValidationResult
---

# SuperOffice WebApi Client Library

First things first!

> [!NOTE]
> **This is not an OAuth 2.0 client**. When authenticating with [OpenID Connect][5] or [OAuth][4], you still have to use another means to obtain OAuth tokens.

For OAuth/OpenID Connect authentication in web applications, we recommend you take a look at the [AspNet.Security.OAuth.SuperOffice][1] provider. It's an open source library created by DevNet, and tailored for SuperOffice online.

Now lets begin looking how to use the `SuperOffice.WebApi` library.

## What is SuperOffice.WebApi

[!include[ALT](../../includes/webapi-client-intro.md)]

OK. So that's what the `SuperOffice.WebApi` library is, now lets see how to use it.

## Getting started

* Read the introduction to [SuperOffice web services][6]
* Learn about the [WebAPI Agent endpoints][3].
* Learn about the [WebAPI Client][2].
* [Call the web services][7] through the WebAPI Client library.
* Check out the reference in the left menu.

## Package dependencies

These will automatically be included when you add the `SuperOffice.WebApi` package to a project.

.NETStandard 2.0

* Microsoft.Extensions.Logging.Abstractions (>= 5.0.0)
* Microsoft.IdentityModel.JsonWebTokens (>= 5.6.0)
* Microsoft.IdentityModel.Logging (>= 5.6.0)
* Microsoft.IdentityModel.Tokens (>= 5.6.0)
* Newtonsoft.Json (>= 12.0.2)
* System.Security.Permissions (>= 4.7.0)

## Known issues

The current `SuperOffice.WebApi` package dependencies are not the latest Microsoft packages available. Therefore, if your project uses newer versions of the Microsoft packages, there will be conflicts with `TokenValidationResult`.

<!-- Referenced links -->

[1]: https://www.nuget.org/packages/AspNet.Security.OAuth.SuperOffice/
[2]: ../../netserver/web-services/proxies/index.md
[3]: ../../netserver/web-services/endpoints/agents-webapi/index.md
[4]: ../../authentication/online/index.md#oauth
[5]: ../../authentication/online/index.md#oidc
[6]: ../../netserver/web-services/index.md
[7]: ../../netserver/web-services/proxies/webapi-client.md
