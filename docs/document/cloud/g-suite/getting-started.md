---
title: Getting started
uid: g_suite_quick_start
description: Google Workspace document integration setup - Self-Service Quick-Guide
author: {github-id}
keywords:
so.topic: getting-started
so.envir: cloud
so.client: online
---

# Getting started (self-service)

This guide explains in short terms how you can get Google Workspace document integration up and running in no-time, in a step-by-step walk-through. It is an alternative to the [full set-up guide][5].

1. **Are users that belong to this tenant successfully using IDP to authenticate?**

    * If yes, go to step 4. Otherwise, continue.

2. **Is IDP for your domain registered?**

    * If yes, go to step 3. Otherwise, [register IDP for your domain][2] (See [how-to][3]).

3. **Are users that belong to this tenant successfully using IDP to authenticate?**

    * If yes, go to step 4.
    * If no, identify why and fix it, so users that belong to this tenant successfully using IDP to authenticate. Ask support for help if needed.

      * Is the correct username used in SuperOffice admin? The field "username" in SuperOffice needs to be the users Google Primary Email (ID).

      * Has the SuperOffice user not been transformed properly from "password" to IDP? Try to use "forgot password", and complete the process of changing passwords, and log in. This should trigger a change to IDP.

      * Is the correct IDP registered? If a custom domain or subdomain is used - register these domain names manually by contacting support.

4. **Do you want to integrate Google Workspace with a "Google Service Account"?** (recommended)

    * If yes, go to step 5. Otherwise, go to step 6.

5. **Create a Google Workspace with a "Google Service Account"**

    1. Log in to Google Workspace admin panel.
    2. Create a normal Google user, ie. "SuperOffice archive user".

6. **Connect Google Workspace and SuperOffice:**

    1. Go to [this URL][4].
    2. Supply a Google Workspace account to be set as "Google integration username". (Use the "Google Service Account" from steps 5 and 6).
    3. Make changes to the settings if you want to.
    4. Click the connect button.

**Setup of document integration done!**

Now, you need to [configure templates][6] in SuperOffice Admin to start using the integration.

<!-- Referenced links -->
[2]: https://id.superoffice.com/identityprovider/register
[3]: ../../../identity-management/superid/howto/register-idp.md
[4]: https://cloudintegration.superoffice.com/app
[5]: set-up.md
[6]: ../configure.md
