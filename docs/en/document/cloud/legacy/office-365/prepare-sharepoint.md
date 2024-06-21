---
title: Preparing IDP login for SharePoint
uid: prepare_sharepoint_for_set_up
description: Preparing IDP login for SharePoint integration
author: {github-id}
keywords: SharePoint, Microsoft Entra
date: 01.15.2024
topic: howto
envir: cloud
client: online
---

# Preparing IDP login for SharePoint integration

This guide will explain how to prepare IDP login for SharePoint integration.

## Make sure all users use the correct username

To be able to use Microsoft 365 for authentication, the users' SuperOffice username needs to be the same for both systems.
The Microsoft 365 username (User Principal Name, UPN) is managed in Microsoft Entra admin center. Update SuperOffice Admin with this username in the username field.

> [!NOTE]
> The Microsoft 365 username must be identical to login name in CRM Online:

![Microsoft 365 username must be identical to login name in CRM Online -screenshot][img1]

You see the UPN username in the Microsoft 365 admin -> users section: [https://admin.microsoft.com/AdminPortal/Home#/users][2]

## Make sure you have registered your IDP for your domain

[How to configure IDP SuperID][5]

If you are using multiple domain names for your users, all domain names must be registered:

* If it is a custom domain name, inform support to add those to your registered domain name.
* If it is separate main domain names, use the registration link above to register each of them.

## Make sure your new Microsoft 365 authentication works

Verify by logging in to CRM Online with Microsoft 365.

### For new users

1. Go to `online.superoffice.com`.
2. Type in the email address, click **Next**.

    * If your browser already has an active Microsoft 365 session - it will re-use this session to log you automatically in.
    * If your browser has no active Microsoft 365 session - it will redirect you to your Microsoft 365 for authentication, before logging you into CRM Online.

### For existing users (used to use password)

Next time a user logs in to `online.superoffice.com`, after registering the IDP, SuperOffice will recognize the domain name and force the user to switch to IDP authentication.

1. Go to `online.superoffice.com`.
2. Type in the email address, click **Next**.
3. Type in the current SuperOffice password, click **Next**.
4. SuperOffice will recognize the domain name and force the user to switch to IDP authentication. Click **O365** to enable Microsoft 365 authentication for this user.
    * If your browser already has an active Microsoft 365 session - it will re-use this session to log you automatically in.
    * If your browser has no active Microsoft 365 session - it will redirect you to your Microsoft 365 for authentication, before logging you into CRM Online.

The "Forgot password" feature is now handled by Microsoft 365 - since Microsoft 365 is activated as the authentication method for this site.

If some existing users do not get asked to switch to IDP authentication, a user may force this by completing a "reset password" in SuperOffice. Next time, after logging, after resetting the password, the user is asked to switch to IDP authentication.

<!-- Referenced links -->
[2]: https://admin.microsoft.com/AdminPortal/Home#/users
[5]: ../../../../identity-management/superid/howto/register-idp.md

<!-- Referenced images -->
[img1]: media/imagezj6n.png
