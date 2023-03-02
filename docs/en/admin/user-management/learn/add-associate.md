---
uid: help-en-user-add
title: Add user
description: In this how-to guide, you will learn how to add a new user in SuperOffice CRM.
author: SuperOffice RnD
so.date: 02.21.2023
keywords: user, associate
so.topic: howto
language: en
---

# Add users

After your SuperOffice CRM solution is configured and customized, it is time to give your users access to their CRM solution.

Administrators are responsible for providing new users with a user plan, a username, a password and the user group the user belongs to. You can add users to SuperOffice CRM in Settings and maintenance.

> [!NOTE]
> If you provided information on users when you ordered SuperOffice CRM, you do not have to add users. Users will have received login information from SuperOffice by email. Check if users are in the system in the menu Users in Settings and Maintenance.
>
> This procedure describes how to add one user at a time. To add multiple users, see [Import users][1].

Follow the guided steps or watch the video below to see how you can add a new user in SuperOffice CRM (video length - 1:46):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://youtu.be/oLlfTrCAqCU]

## Add a new SuperOffice CRM user

1. Open the **Users** screen.
2. Select the **Associates** tab.
3. Click the **Add** button below the list.
4. Enter the name and email address of the new user in the top-part of the card.
5. If more than one owner company is available in your SuperOffice installation, you can select this below the **Email** field.
6. Enter the relevant information in the **Details** and **Licences** tabs.
7. Click **Save**. The name of the new user will now be displayed in the list.

> [!TIP]
> If active users need a different user plan, you can [assign user plans][4] in Settings and maintenance. How to change user plan for active users.

## The Details tab

In the **Details** tab, you have the following options:

* **User ID**: In the **User ID** field, edit the suggested ID for the user (if you do not want to use the automatically generated ID). You cannot specify a user ID that already exists in the database. There are no restrictions on the characters that can be used in the user ID.

    > [!NOTE]
    > The user ID should not contain too many characters, because it is displayed in the ID columns in SuperOffice CRM, and space in these columns may be limited.

* **Nick name**: The nick name is the name visible to other users of SuperOffice, and is used for SuperOffice Service users only. You can edit the suggested nick name for the user (if you do not want to use the automatically generated name).

* **Authentication**: If multiple authentication methods are available, you can select an authentication method here.

* **User name**: Enter the SuperOffice user name. This should be the same name as in your identity provider's system (if you use Office 365 or Gmail for authentication). When you use SuperOffice for authentication, simply fill in your email address. Make sure the email address is valid, because it is used for account confirmation.

* **Role**: Specify the [role][3] the user should have in the **Role** list box. The role determines the user's data access and functional rights. You cannot change your own role.

* **User plan**: Select the relevant user plan for the user. This determines which SuperOffice features the user can access.

* **Former employee**: If a user should no longer have access to SuperOffice, select this option to remove the user plan and login rights of the user.

* **Primary group**: Select one of the predefined options for group membership in the **Primary group** list box. These options are defined in the **Lists** screen. The user is granted access to data owned by other users in the same primary group. Access rights (for example, write and delete access) for these data are defined in the [role][3] the user belongs to. See [Visibility][2] for more information on sharing data with your primary group.

* **Other groups**: Click in the **Other groups** field and select which other groups the user should belong to. If the list contains many groups, start typing a group name in the search field to filter the list.

* **Service categories**: These categories are used to give users access to specific request categories.

* **Service categories from user groups**: Shows the categories the user gets from being in a user group.

### Example

[!include[Example](includes/example-grouping.md)]

## The Licences tab

In the **Licences** tab, you can select licenses in addition to those defined by the selected user plan.

**Confidential activities**: activates the **Visible for** list for follow-ups, documents and sales, to make records visible only to the user, the user's primary group or everyone. See [Visibility][2].

## Can log in

In the lower part of the user card, you can activate or deactivate the login rights of the selected user by clicking the **Can log in** button. By default this option is activated when you select a user plan for the user.

<!-- Referenced links -->
[1]: import-users.md
[2]: visibility.md
[3]: role/index.md
[4]: change-user-plan.md

<!-- Referenced images -->
