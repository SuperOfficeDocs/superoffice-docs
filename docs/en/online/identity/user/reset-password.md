---
title: Reset password
uid: reset_password
description: Reset password
author: SuperOffice Product and Engineering
keywords:
content_type: howto
index: true
---

# Reset password

Resetting a password is done differently depending on the sign-in service used.

## Reset password for SuperID - basic

1. Click **Forgot password** on the CRM Online sign-in page.

2. Follow the instructions in the email to set a new password.

> [!NOTE]
> SuperOffice administrators can't reset SuperID passwords on users' behalf. The admin can only initiate a reset, which will have the same effect as if the user clicked **Forgot password** themselves.

## Reset password for SuperID - federated (IDP)

Use the identity provider's reset password feature to reset your password. Look for a link that says **Forgot password** or **Reset password** in the IDP sign-in dialog.

> [!NOTE]
> SuperOffice administrators can't reset federated passwords on users' behalf. They must contact the identity provider's admin to resolve the issue.

Read more about [SuperID accounts and passwords][1].

<!-- Referenced links -->
[1]: ../superid/user-accounts-and-passwords.md
