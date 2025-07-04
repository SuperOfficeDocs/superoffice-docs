---
title: Terms and conditions
uid: superid_terms_and_conditions
description: SuperID terms and conditions
author:
keywords: SuperID
date:
content_type: reference
deployment: online
platform: web
index: true
---

# SuperID terms and conditions

## Passwords and authentication when migrating from Onsite to CRM Online

Users' passwords of this tenant will be moved to [SuperID.][1]

**SuperID will handle authentication**, including managing passwords (set/reset) for non-federated users.

All authentication features are moved from the local onsite tenant to SuperID.

[Password administration][2] will be self-service.

**SuperOffice administrators will lose their ability to set and reset a user's password from the SuperOffice Admin client.**

> [!NOTE]
> The **set new password** feature of SuperID requires users to validate their authentication through 2-step email verification.

All tenants in CRM Online are **not eligible to use** the [password policy preferences][3] in SuperOffice Admin, as this is not used when using either SuperID or your IdP service for authentication.

## User creation

> [!NOTE]
> The **create a new user** feature from Admin requires users to validate their authentication through 2-step email verification.

You must, therefore, have access to this new user's email to verify the user before you can use it and sign in.

<!-- Referenced links -->
[1]: overview.md
[2]: ../user/reset-password.md
[3]: ../user/enforce-password-policy.md
