---
title: Redirects
uid: redirects
description: "Learn what a redirect URL, or callback URL, is and where to set it."
author: Bergfrid Dias, Margrethe Romnes
date: 09.12.2023
keywords: callback, redirect, endpoint
topic: concept
envir: cloud
client: online
---

# Redirection endpoint

A redirect URL, or callback URL, is a context-specific URL that will be called by the browser after successful sign-in or when a user clicks one of the available buttons on your application entry.

> [IETF, RFC 6749][1] section 3.1.2 "Redirection endpoint": After completing its interaction with the Resource Owner, the Authorization Server directs the Resource Owner's user-agent back to the client. The Authorization Server redirects the user-agent to the client's redirection endpoint previously established with the Authorization Server during the client registration process or when making the authorization request.

The application residing at the redirect URL is expected to receive the security token from the request body, [validate the security token][2], and can then reliably access the [claims][3] contained in the security token.

## Where do I set my redirects?

The redirection endpoints are specified when you [register the application][5]. If you need to make changes later, [update the application configuration][4] in the Developer Portal.

> [!TIP]
> You can register (whitelist) additional URLs. If you plan to use multiple endpoints, consider submitting a URL that incorporates a regular expression.

## Login callback URL

* The SuperOffice login page will post the claims and login results to this page
* Can be configured as POST or GET request, depending on what you prefer
  * POST is considered more secure because the parameters are not exposed to proxies or browser caches
  * Example: `https://app.partner.com/app/LoginRedirect.aspx`

## Application install URL

* Where the App Store will link to when the user clicks **Buy**.

## Application configure URL

* Where the App Store will link to when the user clicks **Configure**.

## Application uninstall URL

* Where the App Store will link to when the user clicks **Uninstall**
  * This will not [revoke app authorization][6] for the tenant.

## Custom error callback URL

* Where users are sent if the sign-in is unsuccessful.

## Additional whitelisted URL

* All URLs called by your application must be whitelisted. Otherwise, the call will return an error.

## Post logout redirect URL

* Where users are sent after successful sign-out.

## CORS URL

* All URLs for cross-origin resource sharing must be whitelisted.

## Database mirroring URL

* Where the [SuperOffice Mirroring Task][8] sends data.

## ERP Sync URL

## Quote connector URL

## Custom State Change URL

* Where we send [notifications when a tenant changes status][7]. Mandatory for standard applications.

<!-- Referenced links -->
[1]: https://tools.ietf.org/html/rfc6749#section-3.1.2
[2]: ../../../api/authentication/online/validate-security-tokens.md
[3]: ../../../api/authentication/online/index.md
[4]: cors-and-redirection-urls.md
[5]: ../index.md
[6]: ../../provisioning/revoke.md
[7]: ../../best-practices/tenant-status/index.md#notify
[8]: ../../../mirroring/mirroring-task.md
