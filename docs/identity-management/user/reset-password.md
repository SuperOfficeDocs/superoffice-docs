---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: reset_password       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Reset password      # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: howto                      # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Reset password

Resetting a password is done differently depending on the sign-in service used.

## Reset password for SuperID - basic

1. Click **Forgot password** on the CRM Online sign-in page.

2. Follow the instructions in the email to set a new password.

SuperOffice administrators can't reset SuperID passwords on users' behalf. The admin can only initiate a reset, which will have the same effect as if the user clicked **Forgot password** themselves.

## Reset password for SuperID - federated (IDP)

Use the identity provider's reset password feature to reset your password. Look for a link that says **Forgot password** or **Reset password** in the IDP sign-in dialog.

SuperOffice administrators can't reset federated passwords on users' behalf. They must contact the identity provider's admin to resolve the issue.

Read more about [SuperID accounts and passwords][1].

<!-- Referenced links -->
[1]: ../superid/user-accounts-and-passwords.md
