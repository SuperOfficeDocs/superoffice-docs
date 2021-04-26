---
title: Application hosting
uid: app_hosting
description: Application hosting
author: {github-id}
keywords:
so.topic: concept
so.envir: cloud
so.client: online
---

# Application hosting

You are responsible for hosting your own applications, regardless if you develop standard applications for the SuperOffice App Store or custom applications for a specific customer.

SuperOffice will not bill, [provision][1], or host partner applications. Instead, the App Store redirects to our partners' websites where customers buy directly from the partner.

As a partner, you will have to host your applications in **your own cloud** environment. This could be in an environment managed by a group of partners or for example in their Azure or Amazon cloud.

In practical terms, this means that you must build and host a page that receives [JWT tokens][3] at the redirect URL. This page must be up and running before you attempt to connect to our APIs and authorize your application.

Before you get to authorization, you must sign up to get your unique [client IDs and client secret][4]. You must tell us about your callback/redirect [URLs][5] when you [sign up][6].

<!-- Referenced links -->
[1]: ../provisioning/index.md
[3]: ../../../../data-access/docs/authentication/tokens/validate-security-tokens.md
[4]: ../terminology.md
[5]: ../redirects/index.md
[6]: get-app-keys.md
