---
title: Security
uid: dp-security
description: Security related information and tasks in the SuperOffice Developer Portal.
author: Bergfrid Dias
so.date: 05.13.2022
keywords: Developer Portal, app, security
so.topic: howto
so.version:
so.envir: cloud
so.client:
---

# Security

## Get keys

If you have registered the application but lost the keys, you need to [look up your ID][7] and [create a new secret][8].

## Authentication

* [Check what your client ID is][7]
* [Create a new client secret][8]
* [Add a certificate][10]
* [About user contexts][4]

> [!CAUTION]
> SuperOffice doesn't store the **client secret and certificate private key** in the database. When you create a new secret or certificate, copy and store this information. You can't go back and look it up in the Developer Portal later.

Watch the walk-through on YouTube:

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube-nocookie.com/embed/kqEpAw7qQEY?start=0705]

## URLs

* [View or change CORS and redirection URLs][9]
* [About redirects][6]

## User management

* [Manage permissions within the organization][3]
* [Add a user][1]
* [Update a user profile][2]
* [Update your own user profile][5]

<!-- Referenced links -->
[1]: add-user.md
[2]: edit-user.md
[3]: manage-permissions.md
[4]: ../../apps/getting-started/user-contexts.md
[5]: ../howto/update-profile.md
[6]: ../../apps/redirects/index.md
[7]: find-clientid.md
[8]: get-client-secret.md
[9]: cors-and-redirection-urls.md
[10]: new-certificate.md

<!-- Referenced images -->
