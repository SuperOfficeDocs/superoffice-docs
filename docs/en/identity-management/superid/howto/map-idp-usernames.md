---
title: Update SuperOffice username to match IdP
uid: map_idp_usernames
description: Update SuperOffice username to match IdP username
author: SuperOffice Product and Engineering
keywords:
content_type: tutorial
deployment: online
platform: web
index: true
---

# Update SuperOffice username to match IdP username

Before using a federated sign-in service, you must update each SuperOffice username to match the IdP username.

> [!TIP]
> The username, also known as the **User-Principal-Name** (UPN), set in your IdP must match the username set in SuperOffice Admin.

## Pre-requisites

* SuperOffice administrator account

* Access to view user accounts of your identity provider

The username you are going to map to is commonly (but not always) the **primary email** registered to the user account at the identity provider: `user@domain`.

## Look up the IdP username

You can find the username in the **admin>users** section.

**For Microsoft:**

Go to [https://admin.microsoft.com/AdminPortal/Home#/users][1]

![UPN Microsoft 365 -screenshot][img1]

**For Google:**

Go to  [https://admin.google.com/ac/users][2]

![UPN Google -screenshot][img2]

## Change username in SuperOffice Admin client

> [!NOTE]
> You **need to map each username** in SuperOffice Admin to the federated ID.

1. Select **Users** from the navigator in the Admin client.

2. For each user:

    1. Select the SuperOffice user to change.
    2. Enter the new username and click **Save**.

<!-- Referenced links -->
[1]: https://admin.microsoft.com/AdminPortal/Home#/users
[2]: https://admin.google.com/ac/users

<!-- Referenced images -->
[img1]: media/upn-o365.png
[img2]: media/upn-google.png
