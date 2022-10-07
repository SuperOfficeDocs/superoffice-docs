---
title: Permissions in SharePoint
uid: config-sharepoint-permissions-templates
description: How to set up the SharePoint permissions for templates
author: Martin Pavlas
so.date: 29.09.2022
keywords: SharePoint, permission security, access control
so.topic: howto
so.version:
so.envir: cloud
so.client: online
---

# How to set up SharePoint permissions for templates

We recommend that you create a separate SharePoint document library on your SuperOffice Document site for your templates.

## Permissions to the SharePoint document library for SuperOffice templates

People who will edit the templates should have Permission level edit​. For instance, create a domain (AAD) group named template-editors​.

All other users of SuperOffice Online must have Permission level Read. This is necessary because they must read it when creating document​.

All domain groups with access to the document library must be added to the template library​.

If all users can edit templates you don’t need to do anything, since you have already granted edit permissions on the site level.

## Step 1 – Select the SuperOffice template library​

1. ​Navigate to the site where the template library resides​.

2. Open **Site contents**, left menu in a SharePoint site​.

    ![Site contents -screenshot][img1]

3. Choose your SuperOffice template library​.

    ![Template library​ -screenshot][img2]

## Step 2 – Stop inheriting permissions​

In order to control access to you SuperOffice document library, you must stop inheriting permissions. Stop inheriting also makes it possible to grant permissions.

1. ​In your SuperOffice document library - click on the cog-wheel and then **Library settings**​.

    ![Library settings​ -screenshot][img3]

2. Click on **Permissions for this document library**.

    ![Permissions for this document library​ -screenshot][img4]

3. Choose **Stop Inheriting Permissions**.

    ![Stop Inheriting Permissions​ -screenshot][img5]

## Step 3a – Change permissions​

If the AAD (domain) groups already exist.

1. Select the groups​.

2. Click on **Edit User Permissions**​.

    ![Edit User Permissions​ -screenshot][img6]

3. In the next dialog, choose **Read** and press **OK**​.

    ![Read​ -screenshot][img7]

If the groups do not exist or you need to add a group that can edit, see 3b.

## Step 3b – Grant permissions​

1. Click on **Grant Permissions**​.

    ![Grant Permissions -screenshot][img8]

2. In **Invite people**​.

    * Type in and add domain (AAD) group(s)​. Members of these groups will automatically get access.

    * Tick off **Share everything in this folder, even items with unique permissions**​.

    * Tick off **Send an email invitation**. There will be a lot of emails that the users will wonder about​.

        For normal users, not editors: Select a permission level **Read**.​

        ![Invite people -screenshot][img9]

        For editors, members of your Template Editors: Select a permission level **Edit**.

        ![Invite people -screenshot][img10]

    * When your done adding groups, press **Share**.

## Step 4 – Review the SharePoint site groups​

​We recommend that you remove user permissions for the standard SharePoint groups Members and Visitors, and that you limit the number of members in the Group owner. Make sure there are no user accounts in this group, only service accounts.

![Invite people -screenshot][img11]

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: media/01-templ-site.png
[img2]: media/02-templ-library.png
[img3]: media/03-templ-library-settings.png
[img4]: media/04-templ-library-permissions.png
[img5]: media/05-templ-inheriting.png
[img6]: media/06-templ-groups.png
[img7]: media/07-templ-read.png
[img8]: media/08-templ-grant-permissions.png
[img9]: media/09-templ-invite-people.png
[img10]: media/10-templ-edit.png
[img11]: media/11-templ-remove.png
