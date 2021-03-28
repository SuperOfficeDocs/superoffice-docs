---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: user_contexts       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: User contexts # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: concept              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
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

All applications that run as background tasks, without user interaction, must receive a [system user token][2] and use the [system-user flow][3] for interacting with our web services. None of the [OpenID Connect flow][4]s are supported.

The system user has unlimited access to the [tenant][5] and is not restricted by functional rights or data rights.

**Requirements:**

* The application runs in the background
* The application must bypass the sentry
* No UI elements in SuperOffice
* Runs as a service

See also [application models][6] and the [system user MVC example][7].

<!-- Referenced links -->
[1]: https://github.com/SuperOfficeDocs/data-access/blob/main/docs/authentication/online/federated-auth.md
[2]: https://github.com/SuperOfficeDocs/data-access/blob/main/docs/authentication/online/system-user/system-user-token.md
[3]: https://github.com/SuperOfficeDocs/data-access/blob/main/docs/authentication/online/system-user/system-user-flow.md
[4]: https://github.com/SuperOfficeDocs/data-access/blob/main/docs/authentication/online/oidc/index.md
[5]: ../tenant-status/index.md
[6]: models.md
[7]: https://github.com/SuperOfficeDocs/data-access/blob/main/docs/tutorials/minimal-csharp-app/overview.md
