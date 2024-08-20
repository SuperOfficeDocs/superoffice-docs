---
title: Permissions in SharePoint
uid: config-sharepoint-permissions-templates
description: How to set up the SharePoint permissions for templates
author: Martin Pavlas
date: 01.15.2024
keywords: SharePoint, permission, security, access control, Microsoft Entra, domain group, ME-ID, AAD
topic: howto
version:
envir: cloud
client: online
---

# How to set up SharePoint permissions for templates

We recommend that you create a separate SharePoint document library on your SuperOffice Document site for your templates.

## Permissions to the SharePoint document library for SuperOffice templates

People who will edit the templates should have Permission level edit​. For instance, create a Microsoft Entra (formerly AAD) domain group named template-editors​.

All other users of SuperOffice Online must have Permission level Read. This is necessary because they must read it when creating document​.

All domain groups with access to the document library must be added to the template library​.

If all users can edit templates you don’t need to do anything, since you have already granted edit permissions on the site level.

## <a id="step-1"></a>Step 1 – Select the SuperOffice template library​

1. ​Navigate to the site where the template library resides​.

2. Open **Site contents**, left menu in a SharePoint site​.

    ![Site contents -screenshot][img1]

3. Choose your SuperOffice template library​.

    ![Template library​ -screenshot][img2]

## <a id="step-2"></a>Step 2 – Stop inheriting permissions​

In order to control access to you SuperOffice document library, you must stop inheriting permissions. Stop inheriting also makes it possible to grant permissions.

1. ​In your SuperOffice document library - click on the cog-wheel and then **Library settings**​.

    ![Library settings​ -screenshot][img3]

2. Click on **Permissions for this document library**.

    ![Permissions for this document library​ -screenshot][img4]

3. Choose **Stop Inheriting Permissions**.

    ![Stop Inheriting Permissions​ -screenshot][img5]

## <a id="step-3a"></a>Step 3a – Change permissions​

Follow these steps if the Microsoft Entra domain groups already exist. If the groups do not exist or you need to add a group that can edit, go to step 3b.

1. Select the groups​.

2. Click on **Edit User Permissions**​.

    ![Edit User Permissions​ -screenshot][img6]

3. In the next dialog, choose **Read** and press **OK**​.

    ![Read​ -screenshot][img7]

## <a id="step-3b"></a>Step 3b – Grant permissions​

1. Click on **Grant Permissions**​.

    ![Grant Permissions -screenshot][img8]

2. In **Invite people**​.

    * Type in and add Microsoft Entra domain groups​. Members of these groups will automatically get access.

    * Tick off **Share everything in this folder, even items with unique permissions**​.

    * Tick off **Send an email invitation**. There will be a lot of emails that the users will wonder about​.

        For normal users, not editors: Select a permission level **Read**.​

        ![Invite people -screenshot][img9]

        For editors, members of your Template Editors: Select a permission level **Edit**.

        ![Invite people -screenshot][img10]

    * When your done adding groups, press **Share**.

## <a id="step-4"></a>Step 4 – Review the SharePoint site groups​

​We recommend that you remove user permissions for the standard SharePoint groups Members and Visitors, and that you limit the number of members in the Group owner. Make sure there are no user accounts in this group, only service accounts.

![Invite people -screenshot][img11]

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/document/01-templ-site.png
[img2]: ../../../../media/loc/en/document/02-templ-library.png
[img3]: ../../../../media/loc/en/document/03-templ-library-settings.png
[img4]: ../../../../media/loc/en/document/04-templ-library-permissions.png
[img5]: ../../../../media/loc/en/document/05-templ-inheriting.png
[img6]: ../../../../media/loc/en/document/06-templ-groups.png
[img7]: ../../../../media/loc/en/document/07-templ-read.png
[img8]: ../../../../media/loc/en/document/08-templ-grant-permissions.png
[img9]: ../../../../media/loc/en/document/09-templ-invite-people.png
[img10]: ../../../../media/loc/en/document/10-templ-edit.png
[img11]: ../../../../media/loc/en/document/11-templ-remove.png
