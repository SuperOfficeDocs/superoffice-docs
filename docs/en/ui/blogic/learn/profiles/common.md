---
uid: help-en-service-profile-common
title: Common profiles
description: Common profiles
author: SuperOffice RnD
date: 04.24.2023
keywords: profile, service
content_type: howto
language: en
---

# Common profiles

[!include[Legacy](../includes/legacy-profiles.md)]

Common profiles are linked to a [role][2] and apply to all users who have that role. You configure common profiles in the **Show profiles** screen.

## Profile types

* **System**: These profiles you can configure by following the procedure below.
* **System screens**: A list of screens created using the [system designers][1] in SuperOffice Service. You can change these if you have access to **System design** > **Screens**.

## <a id="create"></a>Create common profiles

As an example, the following steps show how to add a field in the **Find requests** screen.

1. Select **System settings** > **Profile**. The **Show profiles** screen appears.
2. Choose **System**. This displays a hierarchical list of all the profiles in the system.
3. Click **Search**.
4. Point at **Find requests**, and click <i class="ph ph-list" aria-label="Main menu"></i> (**New common profile**) to the right of the name. The **Edit element profile** screen appears.
5. In the **Name** field, enter the name of the profile.
6. Click the **Add criteria** button.
7. In the dialog, do the following:
    * **Enter the label for the field here**: Enter the field name.
    * **Choose field**: Select which field in the database you want to get data from.
8. Click the **OK**. The new criterion is added below the others.
9. Click **OK**. The new profile is created. You can now, for example, [link it to a specific role][3].

## Edit information in a common profile

1. Select **System settings** > **Profile**. The **Show profiles** screen appears.
2. Choose **System**. This displays a hierarchical list of all the profiles in the system.
3. Drill down into the hierarchy until you find the profile you want.
4. Click the profile name. The **Edit element profile** screen appears.
5. Make the required changes.
6. Click **OK**. The changes are saved.

## Delete a common profile

1. Select **System settings** > **Profile**. The **Show profiles** screen appears.
2. Choose **System**. This displays a hierarchical list of all the profiles in the system.
3. Drill down into the hierarchy until you find the profile you want.
4. Click the profile name. The **Edit element profile** screen appears.
5. Click the **Restore default (deletes this profile)** button at the bottom of the screen. The profile is deleted.

## What would you like to find out more about?

* [Personal profiles][4]
* [Global profiles][5]

<!-- Referenced links -->
[1]: ../screen-properties.md
[2]: ../../../../admin/user-management/role/index.md
[3]: ../../../../admin/user-management/role/create-role.md
[4]: personal.md
[5]: global.md
