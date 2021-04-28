---
title: User contexts
uid: user_contexts
description: User contexts
author: {github-id}
keywords:
so.topic: concept
so.envir: cloud
so.client: online
---

# User contexts

Applications can have 2 different types of interaction with tenant installations: interactive user sessions; non-interactive background services.

SuperOffice CRM Online supports both types of interactions. The first as an **application user** context and the second as a **system user** context.

## Application user (interactive)

This is the typical case when a **person** is signed in to SuperOffice CRM Online.

**Requirements:**

* Application is interactive/reactive
* Application has UI in SuperOffice
* Users have their own sign-in credentials
* Users have their own options

Applications are **not allowed to directly ask users for their credentials**, and therefore must use SuperOffice [federated authentication][1] to sign SuperOffice CRM Online users into their applications.

## System user (non-interactive)

All applications that run as background tasks, without user interaction, must receive a [system user token][2] and use the [system-user flow][3] for interacting with our web services. None of the [OpenID Connect flows][4] are supported.

The system user has unlimited access to the [tenant][6] and is not restricted by functional rights or data rights.

**Requirements:**

* The application runs in the background
* The application must bypass the sentry
* No UI elements in SuperOffice
* Runs as a service

See also [application models terminology][6] and the [system user MVC example][7].

<!-- Referenced links -->
[1]: ../../../../data-access/docs/authentication/online/federated-auth.md
[2]: ../../../../data-access/docs/authentication/online/system-user/system-user-token.md
[3]: ../../../../data-access/docs/authentication/online/system-user/system-user-flow.md
[4]: ../../../../data-access/docs/authentication/online/oidc/index.md
[6]: ../terminology.md
[7]: ../../../../data-access/docs/tutorials/minimal-csharp-app/overview.md
