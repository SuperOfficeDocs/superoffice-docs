---
uid: help-en-user-other
title: Manage other users
description: Manage anonymous users and system users (Onsite)
keywords: anonymous user, system user, Other users
author: digitaldiina
date: 10.24.2025
version: 10.4
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
category: identity management
topic: user
deployment: onsite
platform: web
index: true
redirect_from: 
  - /en/admin/user-management/learn/other-users
  - /en/admin/user-management/learn/role/edit-rights-for-anonymous-users
language: en
---

# Manage anonymous users and system users (Onsite)

* **System user**: System users can log in to the system via third-party applications and have all rights.
* **Anonymous**: Anonymous users have rights based on the [role for anonymous users](#rights). It is not usually necessary to have more than one anonymous user set up.

> [!NOTE]
> Anonymous users and system users require the [SuperOffice Expander Services][1] system license and can be managed in the **Other users** tab:
>
> 1. Select <i class="ph ph-user" aria-hidden="true"></i> **Users** in the Navigator.
> 1. Select the **Other users** tab. The list displays existing anonymous users and system users.

## Add anonymous user or system user

1. Click **Add** below the list.

1. Enter an ID in the **User ID** field.

1. Enter, if required, a password for the user in the **Password** field.

1. Enter a description of the user, as appropriate, in the **Description** box.

1. Select **Type**: **System user** or **Anonymous**.

1. Select **Active** to the right of **Login** to activate the user.

1. Click **Save**. The user is added to the list.

## Edit anonymous or system user

1. In the list, double-click the user you want to edit.

1. Make the required changes in the dialog that appears.

1. To end, click **Save**.

## <a id="rights"></a>Edit rights for anonymous users

There is only one role for anonymous users and only the data rights for this role can be edited.

1. [!include[Open Roles](../includes/open-roles.md)]

1. Select the **Anonymous** tab.

1. [Enter the data rights in the **Data rights** tab][2].

The changes are saved automatically.

## Change login rights for other users

If an anonymous user or a system user is no longer to have the option of logging in to the system, you can remove their login rights. The external user will not be removed, but defined as inactive and can always be reactivated if required.

### Deactivate a user

1. In the list, select the active user who you want to remove login rights for, and click **Remove login** below the list.

    This user can then no longer log in to the system.

### Activate a user

1. In the list, double-click the user you want to activate.
1. Select **Active** to the right of **Login** to activate the user.
1. Click **Save**. This user can then log in to the system.

## Delete anonymous or system user

1. Select the user you want to delete.
1. Click the **Delete** button. The user is removed from the list.

<!-- Referenced links -->
[1]: ../../license/expander-services.md
[2]: ../role/set-data-rights-for-role.md
