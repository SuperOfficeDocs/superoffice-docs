---
title: What API to use?
uid: what-api-to-use
description: "Our APIs have different authentication and data access techniques. This article aims to clarify which API you should use."
author: Tony Yates
date: 09.13.2018
keywords: apps, API, authentication, proxy
topic: concept
envir: cloud
client: online
---

# What API to use?

When partners build an online application or a one-off integration, the first question I usually get is "what APIs are available?".

I generally respond with we support both SOAP and REST web services. And then their follow-up question is generally "which API should I use?". The answer is, well it depends.

Our REST and SOAP APIs have different authentication and data access techniques, and which one you chose depends on the type of integration you are building. This article highlights some of the differences of each regarding SuperOffice and aims to clarify which API you should use.

## API comparison

Before continuing, let me just state that I am well aware that comparing REST and SOAP can be like [comparing apples to oranges][1], but it is the most common way people **in general** discuss web service APIs.

SOAP is historically known to be a robust enterprise-ready option for performing remote invocations using XML. Its verbosity, however, carries a heavy toll on network traffic and lost its commercial appeal in recent years.

REST is best known for building fast responsive JSON-based online applications. While REST supports XML exchanges, RESTful APIs normally send JavaScript Object Notation (JSON) data, which is more lightweight and therefore faster.

With [REST][2], API consumers simply use URLs to access SuperOffice resources and exchange JSON data.

With [SOAP][3], API consumers commonly use proxies that simplify sending XML back and forth across the wire. People either generate their own proxies or optionally use proxies provided by SuperOffice.

Historically, SuperOffice proxies were included in the SDK, but are now available for download on [NuGet][4].

Both SOAP proxy options, self-generated proxies, and SuperOffice proxies, have a different authentication, authorization, and session-handling experience.

Self-generated proxies must create and manage user sessions themselves, as well as decide how to store and populate required details sent in each SuperOffice web service invocation.

SuperOffice proxies are easier in that they manage the details for you. The power, however, does require API consumers to know more about SuperOffice NetServer internals - specifically 3 plugin classes that help manage session state.

![OnlineAuthentication diagram][img1]

Thankfully [these are shared on github][5], as with example applications that demonstrate how they are used.

## Authentication scenarios

### Pre-requisite

Before authentication, regardless if it is **interactive** (*user*) or **non-interactive** (*server-to-server*) authentication, an application must be granted access to a tenant's web service endpoints.

Granting an application access rights is also referred to as consent or authorization.

An application is granted access to a tenant's web services under the following scenarios:

1. A tenant administrator installs the app via the app store.
2. A developer writing the app mocks the installation of the application.

Both require a user to open a browser and navigate to the following URL:

**OLD form:**

`http://{env}.superoffice.com/login/?app_id=YOUR_APP_ID`

**OAuth 2.0 form:**

`https://{env}.superoffice.com/login/common/oauth/authorize?response_type=id_token token&client_id=YOUR-APP-ID&redirect_uri=YOUR-REDIRECT-URL&scope=openid&state=12345&nonce=7362CAEA-9CA5-4B43-9BA3-34D7C303EBA7`

The difference of use between OLD FORM and OAuth2 URLs is the HTTP Response sent to the Redirect URL.

The OLD URL request receives a JWT or SAML token in the body of the response with claims, including a Ticket credential.

The OAuth2 URL request, which is an Implicit flow request, returns a URL fragment containing a JWT `id_token`, with tenant and user claims, plus an `access_token` credential. See the [SuperOffice OpenID Connect][6] article for more details.

For an app listed in the app store, this URL is usually what lies behind the Install button. For developers creating an app locally on their dev-machine, they must manually invoke this URL in a browser to initiate **mock** an installation.

Both scenarios navigate to the SuperOffice SuperID login page, where either a tenant administrator or developer acting as a tenant administrator provides credentials and gives consent to the application.

When an application is registered, they also provide a redirect URL, which is where SuperID redirects the user once authentication **and consent** is given.

The redirect is a POST request that contains a JSON web token (JWT) in the request body.

While the old form and the new OAuth 2.0 form have a different sequence of events that lead to the response that contains the JWT security token, the JWT contains the claims necessary to interact with the tenant. For provisioning an application's dependencies, such as navigator buttons, web panels, and list items. The claims include URLs for both REST and SOAP web service endpoints, and the almighty SystemUserToken - for non-interactive (server-to-server) communications.

As for web service access, or authorization, when using the old form, then the claims also contain the administrator's Ticket credential. When using the OAuth 2.0 flow, in addition to the JWT token, the `access_token` is included in the response.

Older online applications that use the old form were not required to include the `redirect_url`. It was optional. Applications that needed to override the default `redirect_url` could supply a `redirect_url` as long as it was registered in the application's `redirect_url` whitelist. If an application supplies a `redirect_url` that does not exist in the white list, SuperID will simply redirect the user's online tenant.

`http://sod.superoffice.com/login/?app_id=YOUR_APP_ID&redirect_url=YOUR_WHITELISTED_REDIRECT_URL`

There is **no way to circumvent in the installation and consent process**… An application must receive consent to access a tenant's resources! Any attempt to authenticate via the APIs without prior consent will fail.

### Interactive and Non-Interactive Authentication

First and foremost, regardless of an application uses the SOAP or REST APIs, no application is allowed to present users with their own sign-in screen. All interactive authentications must be performed via the [SuperOffice Online sign-in page][7]. All normal users must be sent to the same URL as when their administrator installs the application.

Therefore the results of an interactive authentication for a normal user are very much the same as their administrator or developer when the application was installed.

Once authenticated, the interactive user is redirected to the applications `redirect_url` and the application can provision anything necessary for that user, and/or redirect the user back to SuperOffice.

It’s not uncommon for users to interactively sign in to an app when it is exposed in SuperOffice through a web panel. In that case, and when using OAuth 2.0, include the `<uctx>` template variable in the web panel URL to get the customer's context identifier and include that in the endpoint.

`https://sod.superoffice.com/login/{contextIdentifier}/oauth/authorize?...`

**Example:**

`https://sod.superoffice.com/login/Cust12345/oauth/authorize?response_type=id_token token&client_id=YOUR-APP-ID&redirect_uri=YOUR-REDIRECT-URL&scope=openid&state=12345&nonce=7362CAEA-9CA5-4B43-9BA3-34D7C303EBA7`

This will ensure the web panel application provides the user with a seamless SSO experience.

**Normal users** are everyday users employed by the company that licenses SuperOffice, and use it to help accomplish their daily goals. **System users** are special accounts that have unlimited access to SuperOffice data, and are used to perform routine tasks that are not owned by normal users. System accounts used through web services **do not** support impersonation contexts, so they cannot do work on behalf of a normal user.

[OpenID Connect][6], which is [popular identity layer][8] built on top of OAuth 2.0, is commonly used by RESTful API consumers and is supported in SuperOffice Online.

Most people who chose to use OpenID Connect, use one of the available OpenID Connect [frameworks provided][9] depending on their technology stack.

While nearly impossible to cover homegrown solutions, SuperOffice has successfully tested OpenID Connect friendly frameworks; including [Microsoft ASPNET authentication services][10], as well as Identity Server’s [oidc-client][11]. In fact, the SuperOffice Online [Angular example][12] uses the `oidc-client-js` npm package.

SuperOffice supports interactive [OpenID Connect workflows][6], such as Authorization Code, Implicit, and Hybrid Flow, but there is no support for non-interactive OAuth2 workflows; such as Client Credentials.

SuperOffice does, however, issue refresh tokens, and in that way does support a non-interactive flow once the user has interactively signed in. Since it does require the user to first interactively authenticate to receive a refresh token, we refer to this as **Semi-Interactive**. From that point on, each users’ refresh token can be securely stored and used toward the **tokens** endpoint to obtain an access token, which is then used as a credential to perform API calls on behalf of a particular user.

[Read more about user context][13]

<!-- Referenced links -->
[13]: user-contexts.md
[2]: ../../api/reference/restful/rest/index.md
[3]: ../../api/reference/soap/index.md
[6]: ../../api/authentication/online/index.md

[1]: https://stackoverflow.com/questions/19884295/soap-vs-rest-differences
[4]: https://www.nuget.org/packages/SuperOffice.NetServer.Services/

[5]: https://github.com/SuperOffice/SuperOffice.DevNet.Online/tree/master/Source/SuperOffice.DevNet.Online.Login/SoPlugins
[11]: https://github.com/IdentityModel/oidc-client-js
[12]: https://github.com/SuperOffice/DevNet-Angular-OpenID-REST

[7]: https://online.superoffice.com/login/
[8]: http://openid.net/connect/
[9]: http://openid.net/developers/certified/
[10]: https://docs.microsoft.com/en-us/aspnet/core/security/authentication/social/?view=aspnetcore-2.1

<!-- Referenced images -->
[img1]: media/onlineauthentication.png
