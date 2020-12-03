---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: g_suite_quick_Start       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Quick-start for G Suite Document Integration # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: howto                 # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud              # cloud or onsite
so.client: online             # online, web, win, pocket, or mobile
---

# G SUITE document integration setup - Self-Service Quick-Guide

This article explains in short terms how you can get G Suite document integration up and running in no-time, in a step-by-step walk-through. It is an alternative to the [full set-up guide](set-up.md)

1. **Are users that belong to this tenant successfully using IDP to authenticate?**

    * If yes, go to step 5. Otherwise, continue.

2. **Is your tenant on SuperID?**

    * If yes, go to step 3. Otherwise, [request SuperID for your tenant][1]

3. **Is IDP for your domain registered?**

    * If yes, go to step 4. Otherwise, [register IDP for your domain][2] (See [how-to][3])

4. **Are users that belong to this tenant successfully using IDP to authenticate?**

    * If yes, go to step 5.
    * If no, identify why and fix it, so users that belong to this tenant successfully using IDP to authenticate. Ask support for help if needed.

      * Is the correct username used in SuperOffice admin? Need to be O365 UPN

      * Has the SuperOffice user not been transformed properly from "password" to IDP? Try to use "forgot password", and complete the process of changing passwords, and log in. This should trigger a change to IDP.
      * Is the correct IDP registered? If a custom domain or subdomain is used - register these domain names manually by contacting support.

5. **Do you want to integrate G Suite with a "Google Service Account"?** (recommended)

* If yes, go to step 6. Otherwise, go to step 7.

6. **Create a G Suite with a "Google Service Account"**

    1. Log in to G Suite admin panel
    2. Create a normal Google user, ie. "SuperOffice archive user".

7. **Connect G Suite and SuperOffice:**

    1. Go to [this URL][4]
    2. Supply a G Suite account to be set as "Google integration username". (Use the "Google Service Account" from steps 5 and 6)
    3. Make changes to the settings if you want to
    4. Click the connect button.

**Setup of document integration done!**

Now, you need to [configure templates](configure-cloud-document-handling.md) in SuperOffice Admin to start using the integration.

<!-- Referenced links -->
[1]: https://crm.superoffice.com/scripts/customer.fcgi?action=formFrame&formId=19
[2]: https://id.superoffice.com/identityprovider/register
[3]: https://community.superoffice.com/en/technical/documentation/prepare/crm-online/superid/configureIDPforSuperID/
[4]: https://cloudintegration.superoffice.com/app