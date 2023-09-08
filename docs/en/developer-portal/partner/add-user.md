---
title: Add a user
uid: dp-add-user
description: How to add a user in the SuperOffice Developer Portal.
author: Bergfrid Dias
so.date: 06.01.2022
keywords: Developer Portal, user, access
so.topic: howto
so.version:
so.envir: cloud
so.client: online
---

# Add a user

[!include[Definition of user](../includes/def-dp-user.md)]

You can view the users already added on your partner page.

![Users page -screenshot][img1]

## Who can I add?

You can assign a known user or create a new one. In both cases, you look up an email address.

* If it matches an existing [SuperID][2] user account **in production**, all you have to do is to assign it to the partner. If you know this user is a SuperOffice CRM Online user, make sure you use the correct UPN - `firstname@company.com` versus `firstname.lastname@company.com`
* If the address is unknown, you can fill in a form to create a new user. This person becomes both a SuperID user and a portal user.

## How to

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

<!-- markdownlint-disable DOCSMD007 -->
> [!TIP]
> [!include[Link to user settings](includes/see-user-settings.md)]
<!-- markdownlint-restore -->

<!-- Referenced links -->
[1]: manage-permissions.md
[2]: ../../identity-management/superid/overview.md

<!-- Referenced images -->
[img1]: media/users.png
[img2]: media/search-user.png
[img3]: media/create-user.png
[img4]: media/create-user-form.png
[img5]: media/assign-user-to-partner.png
