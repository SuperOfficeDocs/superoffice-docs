---
title: Authentication with WebTools, MailLink, and Pocket
uid: authentication_with_webtools_maillink_and_pocket
description: Authentication with WebTools, MailLink, and Pocket
author: SuperOffice Product and Engineering
keywords: OAuth 2.0
content_type: concept
index: true
---

# Authentication with WebTools, MailLink, and Pocket

Let's look at how SuperID changes authentication for WebTools, MailLink, and Pocket.

## Before SuperID

* We use proprietary tickets representing the user for authentication. A ticket is valid for a 10-hour sliding window.

* WebTools, MailLink, and the mobile client use classic usernames and passwords. The password is stored encrypted on the device.

* A user must re-authenticate when changing the password.

* Double-clicking the WebTools owl icon will sign the user directly in to the tenant.

> [!NOTE]
> An invalid cached password will sometimes result in locking the user account.

## With SuperID

* We use industry-standard [OAuth 2.0 access tokens and refresh tokens][1] representing a user signed in to an application.

* The access token is valid for 1 hour. The refresh token is valid for several years.

* Access tokens can't be shared between applications.

* The tokens are unique per user and application and are stored on the device.

* WebTools, MailLink, and the mobile client all use industry-standard OAuth 2.0 for Native Apps ([RFC 8252][2]).

* Double-clicking the WebTools owl icon will send the user to the tenant. If the user is not signed in, the user will be redirected back to the sign-in dialog, must click **Next**, and then possibly authenticate to sign in.

<!-- Referenced links -->
[1]: ../../../api/authentication/online/index.md
[2]: https://tools.ietf.org/html/rfc5282
