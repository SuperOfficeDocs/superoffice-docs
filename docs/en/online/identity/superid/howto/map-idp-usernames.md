---
uid: map_idp_usernames
title: Update SuperOffice username to match IdP
description: Update SuperOffice username to match IdP username
keywords: IdP username
author: SuperOffice Product and Engineering
date: 02.05.2026
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

* **For Microsoft:** Go to [https://admin.microsoft.com/AdminPortal/Home#/users][1]

* **For Google:** Go to  [https://admin.google.com/ac/users][2]

## Change username in SuperOffice Settings and maintenance

> [!NOTE]
> You **need to map each username** in SuperOffice Settings and maintenance to the federated ID.

1. Go to Settings and maintenance.

1. Select **Users** from the navigator.

1. For each user:

    1. Select the SuperOffice user to change.
    2. Enter the new username and click **Save**.

<!-- Referenced links -->
[1]: https://admin.microsoft.com/AdminPortal/Home#/users
[2]: https://admin.google.com/ac/users
