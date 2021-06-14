---
title: Redirects
uid: redirects
description: Redirection endpoints
author: {github-id}
keywords: callback
---

# Redirection endpoint

A redirect URL, or callback URL, is a context-specific URL that will be called by the browser after successful sign-in or when a user clicks one of the available buttons on your application entry.

> [IETF, RFC 6749][1] section 3.1.2 "Redirection endpoint": After completing its interaction with the resource owner, the authorization server directs the resource owner's user-agent back to the client. The authorization server redirects the user-agent to the client's redirection endpoint previously established with the authorization server during the client registration process or when making the authorization request.

The application residing at the redirect URL is expected to receive the security token from the request body, [validate the security token][2], and can then reliably access the [claims][3] contained in the security token.

## Where do I set my redirects?

The redirection endpoints are specified when you register the application idea. If you need to make changes later, email `appdev@superoffice.com`.

You can register (whitelist) additional URLs. If you plan to use multiple endpoints, consider submitting a URL that incorporates a regular expression.

To override the default redirect URL, specify the `redirect_url` query string parameter with one of your whitelisted URLs.

<!-- Referenced links -->
[1]: https://tools.ietf.org/html/rfc6749#section-3.1.2
[2]: ../../../../data-access/docs/authentication/online/validate-security-tokens.md
[3]: ../../../../data-access/docs/authentication/online/index.md
