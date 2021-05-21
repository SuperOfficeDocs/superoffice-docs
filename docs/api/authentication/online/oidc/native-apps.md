---
title: OpenID Connect native apps
uid: oidc_native_apps
description: OpenID Connect native apps
author: {github-id}
keywords:
so.topic: concept
so.envir: cloud
so.client: online
---

# OpenID Connect native apps

The main benefit of using OAuth2 Native App flow on Windows and mobile devices is having that single sign-on experience. When the browser is opened and the user navigates to SuperOffice, SuperID can access the client's SuperOffice cookie. When SuperID verifies the user is already authenticated, the user will bypass re-entering credentials and will simply be redirected back to the client and have a great single sign-on experience.

With regards to the [OAuth2 native app flow][1], the application must establish a listener, preferably on the [redirection endpoint][2] IP address, and waits for the response in the default browser. While localhost can be used, it is NOT recommended. Here is a [quote from the specification:][3]

> ...the use of localhost is NOT RECOMMENDED. Specifying a redirect URI with the loopback IP literal rather than localhost avoids inadvertently listening on network interfaces other than the loopback interface. It is also less susceptible to client-side firewalls and misconfigured hostname resolution on the user's device.

> [!NOTE]
> All Windows and mobile applications for SuperOffice must adhere to the specification. When registering, you can define any redirection endpoint for the application, but the URL must start with `http://127.0.0.1:{port}/{path}` for IPv4, and `http://[::1]:{port}/{path}` for IPv6.

Before invoking the default browser to start the sign-in procedure, [set the OpenID Connect client options][4].

The Native app flow depends on the use of Proof Key for Code Exchange to generate a random key that replaces the use of the `client_secret`. Please see the [specification][5] for more information. Our examples use the [IdentityModel.OidcClient][6] NuGet package, which takes care of setting the `code_challenge` and `code_verifier`.

From this point on it’s completely up to the application to decide what to do with the information provided. It’s logical to assume that the application will want to access the user's claims to obtain the tenant's SOAP or REST web service endpoints.

## Native app flow parameters

| Option | Value | Description |
|--------|-------|-------------|
| Authority | `https://sod.superoffice.com/login` | SuperOffice SuperID login URL |
| LoadProfile (Call UserInfo Endpoint) | false | because SuperOffice populates all user profile data in the id\_token claims |
| ClientId | YOUR\_APPLICATION\_ID | your unique identifier received when registering the application idea |
| scope | openid | other scopes will be ignored |
| RedirectUri | `http://127.0.0.1:7890/desktop-callback/` (example) | must match the redirect URL where the listener is listening for the authentication response |
| ResponseMode | form\_post | places response in request body. |
| Flow | code | authentication code |
| code\_verifier | dBjftJeZ4CVP-mB92K27uhbUJU1p1r\_wW1gFWFOEjXk | high-entropy cryptographic random STRING using the unreserved characters \[A-Z\] / \[a-z\] / \[0-9\] / "-" / "." / "\_" / "~" from Section 2.3 of RFC3986, with a minimum length of 43 characters and a maximum length of 128 characters. |
| code\_challenge | E9Melhoa2OwvFrEMTJguCHaoeK1t8URWbuGJSstw-cM | A challenge derived from the code verifier that is sent in the authorization request, to be verified against later. [code\_challenge = BASE64URL-ENCODE(SHA256(ASCII(code\_verifier)))][7] |
| code\_challenge\_method | (optional) S256 or plain | A method that was used to derive code challenge. |

SuperOffice CRM Online doesn't implement the optional userInfo endpoint which clients can call to obtain and populate a user's claims.

While SuperOffice only requires the `openid` scope, as required by the OIDC specification, more scopes can be included but will be ignored as of this writing.

<!-- Referenced links -->
[1]: https://tools.ietf.org/html/rfc8252
[2]: ../../../../../superoffice-docs/docs/apps/redirects/index.md
[3]: https://tools.ietf.org/html/rfc8252#page-11
[4]: ../../../tutorials/native-app-flow-tutorial.md
[5]: https://tools.ietf.org/html/rfc7636
[6]: https://github.com/IdentityModel/IdentityModel.OidcClient
[7]: https://tools.ietf.org/html/rfc7636#appendix-A
