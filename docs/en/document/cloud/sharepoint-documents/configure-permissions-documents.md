---
title: Permissions in SharePoint
uid: config-sharepoint-permissions-documents
description: How to set up the SharePoint using site permissions and Domain (AAD) groups
author: Bergfrid Dias
so.date: 06.21.2022
keywords: SharePoint, permission security, access control
so.topic: howto
so.version:
so.envir: cloud
so.client: online
---

# How to set up SharePoint permissions for documents

> [!NOTE]
> This feature is only relevant if 'Confidential activities' is enabled for users in 'Settings and maintenance', and 'Visible for' field is set on the the document property:

<details>
<summary>Show details for Confidential activities and Visible for</summary>

'Confidential activities' in the [Settings and maintenance - Users][1]: activates the 'Visible for' for the user.

'Visible for' field in the [document dialog][2]: display a list that allows you to choose whether the document will be visible to all users, private (i.e. visible only to the user defined as owner), or visible to all users in one of the user groups that the owner belongs to. 
    
</details>

## Step 1 – Navigate to the site where the SuperOffice document library reside​

To give users permissions to create, delete and edit SuperOffice documents in SharePoint, you need to give them access / permissions to the site where the document library reside​.

This will give them access to the document library too.

![SharePoint main site -screenshot][img1]

## Step 2 – Navigate to Advanced permissions settings​

1. In your SuperOffice document Site - click on the cog-wheel and then **Site permissions**.

2. Click on **Advanced permissions settings**.

    ![Advanced permissions settings -screenshot][img2]

## Step 3 – Grant permissions​

1. Click on **Grant Permissions**.

2. In **Invite people**, type in and add domain (AAD) groups​. Members of these groups will automatically get access.

3. Tick off **Send an email invitation**. (There will be a lot of emails that the users will wonder about​.)

4. Make sure the permission level is **Edit**.​

5. When your done adding groups, press **Share**.​

    ![Grant permissions -screenshot][img3]

## Step 4 – Review the SharePoint site groups​

​Members of the SharePoint site group Owners (Permission Levels Full Control), will have access to all content on that site. Including all folders and documents.​

Make sure there are no user accounts in this group. Only service accounts.​

​![Review SharePoint site groups​ -screenshot][img4]

<!-- Referenced links -->
[1]: https://help.superoffice.com/Documentation/Help/EN/CRM/10.1/WebHelpAdmin/chap07/Adding_users_web.htm
[2]: https://id.superoffice.com/identityprovider/register

<!-- Referenced images -->
[img1]: media/so-sharepoint-home.png
[img2]: media/advanced-permissions.png
[img3]: media/share.png
[img4]: media/review.png
