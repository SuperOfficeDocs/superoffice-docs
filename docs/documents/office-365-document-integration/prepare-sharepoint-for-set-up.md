---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: prepare_sharepoint_for_set_up       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Preparing IDP login for SharePoint integration # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: howto # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud              # cloud or onsite
so.client: online             # online, web, win, pocket, or mobile
---

# Preparing IDP login for SharePoint integration

This guide will explain how to prepare IDP login for SharePoint integration

## Make sure all users use the correct username

To be able to use O365 for authentication, the users' SuperOffice username needs to be the same for both systems.  
The O365 username (User Principal Name, UPN) is managed by your O365 AAD. Update SuperOffice Admin with this username in the username field.

**NOTE!**
The Office365 username must be identical to login name in CRM Online:

![imagezj6n.png][1]

You see the UPN username in the O365 admin -> users section: [https://admin.microsoft.com/AdminPortal/Home#/users][2]

## Make sure you have enabled SuperID for your site

Your site needs to be on the SuperID platform Easily done in [this form][3]

Read more about [the New Login Experience here][4]

## Make sure you have registered your IDP for your domain

Read how-to here: [How to configure IDP SuperID][5]

If you are using multiple domain names for your users, all domain names must be registered.  

* if it is a custom domain name, inform support to add those to your registered domain name  
* if it is separate main domain names, use the registration link above to register each of them

## Make sure your new O365 authentication works by logging in to CRM Online with O365

### For New users

1. Go to online.superoffice.com
2. Type in the email address, click **Next**.

    * If your browser already has an active O365 session - it will re-use this session to log you automatically in.
    * If your browser has no active O365 session - it will redirect you to your O365 for authentication, before logging you into CRM Online.

### For existing users (used to use password)

Next time a user logs in to online.superoffice.com, after registering the IDP, SuperOffice will recognize the domain name and force the user to switch to IDP authentication.

1. Go to online.superoffice.com
2. Type in the email address, click **Next**.
3. Type in the current SuperOffice password, click **[Next**.
4. SuperOffice will recognize the domain name and force the user to switch to IDP authentication. click **O365** to enable O365 authentication for this user.
    * If your browser already has an active O365 session - it will re-use this session to log you automatically in.
    * If your browser has no active O365 session - it will redirect you to your O365 for authentication, before logging you into CRM Online.

"Forgot password" feature is now handled by O365 - since O365 is activated as the authentication method for this site.

If some existing users do not get asked to switch to IDP authentication, a user may force this by completing a "reset password" in SuperOffice. Next time, after logging, after resetting password, user is asked to switch to IDP autentication.

<!-- Referenced links -->
[1]: https://community.superoffice.com/contentassets/50ae00dc36314ed8a94f49fde7a9a648/imagezj6n.png
[2]: https://admin.microsoft.com/AdminPortal/Home#/users
[3]: https://crm.superoffice.com/scripts/customer.fcgi?action=formFrame&formId=19
[4]: https://community.superoffice.com/en/technical/documentation/prepare/crm-online/superid/
[5]: https://community.superoffice.com/en/technical/documentation/prepare/crm-online/superid/configureIDPforSuperID/