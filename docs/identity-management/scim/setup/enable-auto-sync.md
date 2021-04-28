---
title: enable_auto_scim_sync
description: Enable automatic sync to SuperOffice
author: {github-id}
keywords:
so.topic: howto
# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud             # cloud or onsite
so.client: online             # online, web, win, pocket, or mobile
---

# Enable automatic sync to SuperOffice

Automatic sync is a powerful tool for when you have set up your mapping.

## Pre-requisites

* SuperOffice administrator account with access to user admin.
* You have [created the Azure enterprise application][1].

## Procedure

1. [Sign in to the SuperOffice Identity Manager][2].

2. [Create SCIM rules][3] to cover all users you want to appear in SuperOffice.

3. [Preview the result][4] \- either for 1 user or for all users.

4. [Rearrange or activate/deactivate][5] rules if necessary.

5. Slide **User sync active** to *on*.

    ![user sync active slider][img1]

<!-- Referenced links -->
[1]: create-azure-enterprise-app.md
[2]: ../sign-in-to-scim.md
[3]: ../provisioning/add-scim-rule.md
[4]: ../provisioning/preview-sync.md
[5]: ../provisioning/activate-deactivate-rules.md

<!-- Referenced images -->
[img1]: media/user-sync-active.png
