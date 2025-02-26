---
uid: dp-add-user
title: Add a user
description: How to add a user in the SuperOffice Developer Portal.
keywords: Developer Portal, user, access
author: Bergfrid Dias
date: 02.26.2025
version: 2.0
version_devportal: 2.0
topic: howto
envir: cloud
client: online
---
<!-- markdownlint-disable-file MD051 -->

# Add a user

[!include[Definition of user](../includes/def-dp-user.md)]

You can view the users already added on your partner page.

![Users page -screenshot][img1]

This task requires **User management** permission.

## [Partner Admin](#tab/partner-admin)

### Who can I add?

You can add any known user by name or email address that shares one or more tenants with you **in production**. You can't add users that don't share a tenant with you. If you want to add a user that doesn't share a tenant with you, you must first add the user to your tenant by creating a new user in the target SuperOffice instance [Settings and maintenance][3].

* If it matches an existing [SuperID][2] user account, select and add the user to the partner. If you know this user is a SuperOffice CRM Online user, make sure you use the correct UPN - `firstname@company.com` versus `firstname.lastname@company.com`
* If the search results are empty, ensure the **active user** belongs to at least one of your shared tenants **in production**. If not, you can't add them to your partner.

### How to

1. In the Developer Portal, go to your partner page.
2. Select **Users** from the left menu.
3. Click **Add User** button.

    ![Add use -screenshot][img6]

4. Enter a valid name or email address, then select the user from the list.

    ![Find user by email in the SuperOffice Developer Portal -screenshot][img7]

5. Selected the user from the list, then click **Add**.

6. The user is added to the Partner Users collection.

7. You can now [assign permissions][1].

## [DevPortal Admins](#tab/devportal-admin)

### Who can I add?

You can assign a known user or create a new one. In both cases, you look up an email address.

* If it matches an existing [SuperID][2] user account **in production**, all you have to do is to assign it to the partner. If you know this user is a SuperOffice CRM Online user, make sure you use the correct UPN - `firstname@company.com` versus `firstname.lastname@company.com`
* If the address is unknown, you can fill in a form to create a new user. This person becomes both a SuperID user and a portal user.

### How to

1. In the Developer Portal, go to your partner page.
2. Select **Users** from the left menu.
3. Click **Create User**.
4. Enter a valid email address and click **Find user by email**.

    ![Find user by email in the SuperOffice Developer Portal -screenshot][img2]

5. Either assign a known user or create a new one.

    For known SuperID users, click **Assign to Partner**.

    ![Assign User to Partner dialog -screenshot][img5]

    If the user is unknown:

    1. Click **Create User**.

        ![Create user button in the SuperOffice Developer Portal -screenshot][img3]

    2. Fill in the form.

        ![Create user form in the SuperOffice Developer Portal -screenshot][img4]

    3. Click **Create**.

6. You can now [assign permissions][1].

***

<!-- markdownlint-disable DOCSMD007 -->
> [!TIP]
> [!include[Link to user settings](includes/see-user-settings.md)]
<!-- markdownlint-restore -->

<!-- Referenced links -->
[1]: manage-permissions.md
[2]: ../../identity-management/superid/overview.md
[3]: ../../admin/user-management/learn/add-associate.md

<!-- Referenced images -->
[img1]: media/users.png
[img2]: media/search-user.png
[img3]: media/create-user.png
[img4]: media/create-user-form.png
[img5]: media/assign-user-to-partner.png
[img6]: media/add-user-button.png
[img7]: media/type-user-email.png
