---
uid: help-en-admin-listprofiles-commonprofiles
title: admin listProfiles commonProfiles
description: admin listProfiles commonProfiles
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Service
so.topic: help
language: en
---

# Common profiles

Common profiles are linked to a role and apply to all users who have that role (see [Roles][2]). You configure common profiles in the **Show profiles** screen. This screen contains two types of profiles:

* **System**: These profiles you can configure by following the procedure below.
* **System screens**: This is a list of screens created using the system designers in SuperOffice Service. You can change these if you have access to **System design** > **Screens** (see [Screens][1]).

## Create common profiles

We explain how to create a common profile by using a specific example. In the example below, we assume that you want to add a field in the **Find requests** screen.

1. Select ![icon][img1] **System settings** > **Profile**. The **Show profiles** screen appears.
2. Choose **System**. This displays a hierarchical list of all the profiles in the system.
3. Click **Search**.
4. Point at **Find requests**, and click ![icon][img2] (**New common profile**) to the right of the name. The **Edit element profile** screen appears.
5. In the **Name** field, enter the name of the profile.
6. Click the **Add criteria** button.
7. In the dialog box that opens, do the following:
    * **Enter the label for the field here**: Enter the field name.
    * **Choose field**: Select which field in the database you want to get data from.
8. Click the **OK**. The new criterion is added below the others.
9. Click **OK**. The new profile is created. You can now, for example, link it to a specific role (see [Create roles][3]).

## Edit common profiles

To edit the information already recorded for a profile:

1. Select ![icon][img1] **System settings** > **Profile**. The **Show profiles** screen appears.
2. Choose **System**. This displays a hierarchical list of all the profiles in the system.
3. Drill down into the hierarchy until you find the profile you want.
4. Click the profile name. The **Edit element profile** screen appears.
5. Make the required changes. For more information about this screen, see the procedure above.
6. Click **OK**. The changes are saved.

## Delete common profiles

To delete a profile from SuperOffice Service, do as follows:

1. Select ![icon][img1] **System settings** > **Profile**. The **Show profiles** screen appears.
2. Choose **System**. This displays a hierarchical list of all the profiles in the system.
3. Drill down into the hierarchy until you find the profile you want.
4. Click the profile name. The **Edit element profile** screen appears.
5. Click the **Restore default (deletes this profile)** button at the bottom of the screen. The profile is deleted.

## What would you like to find out more about?

* [Personal profiles][4]
* [Global profiles][5]

<!-- Referenced links -->
[1]: ../screen/listScreenDefinitions.editScreenDefinition.md
[2]: ../../user-management/role/index.md
[3]: ../../user-management/role/create-role.md
[4]: listProfiles.personalProfile.md
[5]: listProfiles.globalProfiles.md

<!-- Referenced images -->
[img1]: ../../../media/icons/btn-add.png
[img2]: ../../../media/icons/globalmenu-settings-small.png
