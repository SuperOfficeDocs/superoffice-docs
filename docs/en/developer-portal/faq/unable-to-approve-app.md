---
uid: tenant-consent-problems
title: Unable to approve app
description: How to solve problems related to approving a customer's tenant
author: Margrethe Romnes
date: 09.15.2023
keywords: tenant, consent, approve
topic: howto
envir: cloud
client: online
---

# Unable to approve app

You are unable to complete providing consent (Approve) to the application.

## Account does not have access error

![Account does not have access error -screenshot][img2]

This means that SuperOffice Operations Center doesn't recognize your user as an administrator.

You can resolve this issue by signing in to SuperOffice, navigate to settings and maintenance (admin), then make a change to the user like user level or role and then save. Next, change back and save again.

Your user is now able to successfully approve the application.

## Technical error

![img2 -screenshot][img1]

This means that you're trying to authenticate an app with an unknown [redirect URL][1]. The redirect must be set in the application configuration.

If you are using `devnet-tools.superoffice.com`, the correct redirect is `https://devnet-tools.superoffice.com/openid/callback`.

To resolve this issue:

1. Sign in to the Developer Portal and [verify that the redirect URL is correct and valid][2].
1. If this setting is correct, copy the complete **Request ID** from the error dialog and send it in an email to `appdev AT superoffice.com`.

<!-- Referenced links -->
[1]: ../create-app/config/redirects.md
[2]: ../create-app/config/cors-and-redirection-urls.md

<!-- Referenced images -->
[img1]: media/redirect-consent-error.png
[img2]: media/no-access-error-page.png
