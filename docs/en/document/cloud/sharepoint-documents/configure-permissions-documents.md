---
title: Permissions in SharePoint
uid: config-sharepoint-permissions-documents
description: How to set up the SharePoint using site permissions and Microsoft Entra domain groups
author: Bergfrid Dias
date: 01.15.2024
keywords: SharePoint, permission, security, access control, Microsoft Entra, domain group, ME-ID, AAD
topic: howto
version:
envir: cloud
client: online
---

# How to set up SharePoint permissions for documents

> [!NOTE]
> This feature is relevant only if **Confidential activities** is enabled for users in Settings and maintenance, and the **Visible for** field is set on the document property:
>
> * **Confidential activities** in [Settings and maintenance - Users][1] activates the *Visible for* for the user.
>
> * The **Visible for** field in the [document dialog][2] display a list that allows you to choose whether the document will be visible to all users, private (visible only to the user defined as owner), or visible to all users in one of the user groups that the owner belongs to.

## Step 1 – Navigate to the site where the SuperOffice document library reside

To give users permissions to create, delete and edit SuperOffice documents in SharePoint, you need to give them access / permissions to the site where the document library reside.

This will give them access to the document library too.

![SharePoint main site -screenshot][img1]

## Step 2 – Navigate to Advanced permissions settings

1. In your SuperOffice document Site - click on the cog-wheel and then **Site permissions**.

2. Click on **Advanced permissions settings**.

    ![Advanced permissions settings -screenshot][img2]

## Step 3 – Grant permissions

1. Click on **Grant Permissions**.
2. In **Invite people**, type in and add Microsoft Entra domain groups. Members of these groups will automatically get access.
    > [!WARNING]
    >
    > The Group type must be Microsoft 365 and not Security.
3. Tick off **Send an email invitation**. (There will be a lot of emails that the users will wonder about.)
4. Make sure the permission level is **Edit**.
5. When your done adding groups, press **Share**.

    ![Grant permissions -screenshot][img3]

## Step 4 – Review the SharePoint site groups

Members of the SharePoint site group Owners (Permission Levels Full Control), will have access to all content on that site. Including all folders and documents.

Make sure there are no user accounts in this group. Only service accounts.

![Review SharePoint site groups -screenshot][img4]

<!-- Referenced links -->
[1]: ../../../admin/user-management/learn/add-associate.md
[2]: https://id.superoffice.com/identityprovider/register

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/document/so-sharepoint-home.png
[img2]: ../../../../media/loc/en/document/advanced-permissions.png
[img3]: ../../../../media/loc/en/document/share.png
[img4]: ../../../../media/loc/en/document/review.png
