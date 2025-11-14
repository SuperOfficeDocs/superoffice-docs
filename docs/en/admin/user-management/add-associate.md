---
uid: help-en-user-add
title: Add user
description: In this how-to guide, you will learn how to add a new user in SuperOffice CRM and what to do if a newly created user cannot log in.
keywords: user, associate
author: digitaldiina
date: 10.24.2025
version: 10.4
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
category: identity management
topic: user
index: true
redirect_from: /en/admin/user-management/learn/add-associate
language: en
---

# Add users

After your SuperOffice CRM solution is configured and customized, it is time to give your users access to their CRM solution.

Administrators are responsible for providing new users with a user plan, a username, a password and the user group the user belongs to. You can add users to SuperOffice CRM in Settings and maintenance.

> [!NOTE]
> If you provided information on users when you ordered SuperOffice CRM, you do not have to add users. Users will have received login information from SuperOffice by email. Check if users are in the system in the menu Users in Settings and maintenance.
>
> This procedure describes how to add one user at a time. To add multiple users onsite, see [Import users][1].

## Steps

1. Open the Users screen.
1. Select the **Associates** tab.
1. Click the **Add** button below the list.
1. Enter the name and email address of the new user in the top-part of the card.
1. If more than one owner company is available in your SuperOffice installation, you can select this below the **Email** field.
1. Enter the relevant information in the **Details** and **Licences** tabs.

    ![Create user details -screenshot][img7]

1. Click **Save**. The name of the new user will now be displayed in the list.

    * If active users need a different user plan, you can [assign user plans][4] in Settings and maintenance.

    * In the lower part of the user card, you can activate or deactivate the login rights of the selected user by clicking the **Can log in** button. By default this option is activated when you select a user plan for the user.

## <a id="fields"></a>Key fields explained

<!-- markdownlint-disable-file MD051 -->
### [Details tab](#tab/details)

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

#### Example

Joe Johnson works in the sales department of a large company. The primary group is set to "Sales" so that Joe has access rights to data created by users in the sales department. The access rights to the primary group are defined in the role Joe belongs to. This role determines if Joe can edit or delete data created by other users in the sales department (see [Define data rights for a role][8]).

Joe also needs limited rights to documents from the marketing department and development department. These two departments are added under **Other groups**. In the role Joe belongs to it is specified that Joe has read access only to these data.

### [Licences tab](#tab/license)

In the **Licences** tab, you can select licenses in addition to those defined by the selected user plan.

**Confidential activities**: activates the **Visible for** list for follow-ups, documents and sales, to make records visible only to the user, the user's primary group or everyone.

***

## Video: Add a new SuperOffice CRM user

Watch this demo to see how you can add a new user in SuperOffice CRM.
(This video shows a previous version of SuperOffice, so the design may look different. The steps are the same.)

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/oLlfTrCAqCU]

(video length - 1:46)

## Troubleshooting

### A newly created user cannot log in to SuperOffice ONLINE

There are two common situations when a new user cannot log in:

* The username is not an email address or the email address is not valid
* The new user's account is not activated

1. [!include[Click Users](includes/goto-users.md)]

1. In the list of users, select the user who cannot log in (2).

    ![Select user -screenshot][img1]

1. Make sure that the user has a valid email address filled in because this email address will receive an activation email.

    ![Verify email address of user -screenshot][img2]

1. Make sure that the user has received the activation email, and that the activation link has been pressed within 48 hours.

    ![Activation email -screenshot][img3]

    To resend the welcome email, go to **Settings and maintenance** > **Users**, select your user, click on the **Task** button and choose **Send welcome email**.

1. Make sure that the user has followed the [instructions on how to log in to SuperOffice CRM][7].

## A newly created user cannot log in to SuperOffice ONSITE

Onsite, if a new user cannot log in, the most common cause is that a SuperOffice licence was no properly assigned during the creation process.

### SuperOffice 9

1. Confirm that the user has a licence assigned and **Can log in** is enabled.

1. If that looks OK, try to remove the licence, **Save** the user. Then re-assign a licence and toggle login again.

![Assign licence to user -screenshot][img4]

> [!NOTE]
> If a new user still cannot log in, you can try to [update the SuperOffice CRM license][9] (FAQ).

## Related content

* [Add anonymous or system user (onsite)][5]
* [Edit user / associate][6]

<!-- Referenced links -->
[1]: onsite/import-users.md
[2]: index.md#visible
[3]: role/index.md
[4]: ../license/change-user-plan.md
[5]: onsite/other-users.md
[6]: update-user.md
[7]: ../../learn/getting-started/login.md
[8]: role/set-data-rights-for-role.md
[9]: https://cs.superoffice.com/scripts/customer.fcgi?_sf=0&custSessionKey=&customerLang=en&noCookies=true&action=viewKbEntry&id=113003

<!-- Referenced images -->
[img1]: ../../../media/loc/en/admin/select-user-login.png
[img2]: ../../../media/loc/en/admin/filled-in-email.png
[img3]: ../../../media/loc/en/admin/activation-email.png
[img4]: ../../../media/loc/en/admin/give-licence-9.png
[img7]: ../../../media/loc/en/admin/selected-user-plan.png
