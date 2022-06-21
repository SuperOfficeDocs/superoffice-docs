---
title: Permissions in SharePoint
uid: sharepoint-permissions
description:
author: Bergfrid Dias
so.date: 06.21.2022
keywords: SharePoint, permission security, access control
so.topic:
so.version:
so.envir:
so.client:
---

# Permissions in SharePoint
​
> [!NOTE]
> You need to set up permissions before you can configure “Groups and access” for your SharePoint documents in SuperOffice Online. ​

## About permission in SharePoint​

* In SharePoint you can give permission on site level or on document library level​
  * Document libraries automatically inherits the permission from the site level. ​
  * Document within the library will inherit the permission from the library itself​
* SharePoint user groups​
  * In SharePoint you can create and maintain SharePoint user groups, which gives direct access​
  * You cannot use SharePoint user groups to set permission on document level with SuperOffice SharePoint Documents. The integration needs to use domain (AAD) groups. We will explain this later. ​
* SharePoint site owner group​
  * When you create a site in SharePoint, you automatically get an “owner-group”. Members of this owner group will have access to all documents within that site. ​
  * This access cannot be removed (neither programmatically nor manually). ​
  * For that reason, you need to use a “ServiceAccount” to create your SharePoint site for SuperOffice Documents​

## Types of permission

There are two different types of permission: Application and (User) Delegated.  
The reason for choosing a scope with delegated permission is the limitations in the API and cannot use application permission here because documents will be created and updated as the application, not as the logged in user”.  
Sites.Selected is only available as Application permission, and cannot be applied to Delegated permissions.  

This is what we use the scopes for:

### User delegated permission

| App | User | Scope | Usage |
|---|---|---|-------|
| SuperOffice | Normal | Sites.ReadWrite.All | Create, Update and delete documents<br />Set permission on documents<br />Cannot use application permission here because documents will be created and updated as the application, not as the logged in user |
| SuperOffice | CRM Admin | Sites.ReadWrite.All | List sites and libraries<br />List AD groups attached to selected library<br/>Create meta data columns in SharePoint document library |
| SuperOffice Documents | CRM Admin | Sites.FullControl | When giving permission for SuperOffice documents app the permission level Site.Selected we need to use a user token with Site.FullControl scope. For this once the app is approved with given scopes for delegated permission we will get a token of user with Site.FullCOntrol and will set the permission to the selected site. But this will be an one time token this token will not be saved in the ZFP database |

### Application permission

| App | User | Scope | Usage | Permission type |
|---|---|---|---|---|
| SuperOffice Documents | AD application | Sites.Selected | Deleted inherited permissions | Application Permission |

Enabling Application permission with Sites.Selected has following steps:

| Step | Permission level required |
|---|---|
| Authenticate Global administrator, request additional scopes for permission handling | Global Administrator |
| Approve the app with site selected scope | Sharepoint Administrator |
| Make the post call to assign the role for the app(eg: read, write) | Global Administrator |

## Use AAD groups to control access to SuperOffice documents​

* We recommend that you use domain (AAD) groups to control access to you SuperOffice document site in SharePoint​
* All your user administration will be in Azure Portal, you will maintain group members there​
* If you plan to use Visible for (or already using this in CRM): ​
* AAD groups is the only way to set permissions in SharePoint according to your SuperOffice user groups​
  * We recommend (if not already) that you create corresponding groups in AAD to your SuperOffice user groups​
* If you plan NOT to use Visible for, ​
  * We recommend that you use domain (AAD) group and not the SharePoint groups.​
  * Then you will have one place to handle users and permissions, and by adding users to this group in AAD when creating them – you will not have to add them again in SharePoint.

## How to set up the SharePoint using site permissions and Domain (AAD) groups

### Step 1 – Navigate to the site where the SuperOffice document library reside​

In order to give users permissions to create, delete and edit SuperOffice documents in SharePoint, you need to give them access / permissions to the site where the document library reside​

This will give them access to the document library too.

  ![-screenshot][img1]

### Step 2 – Navigate to Advanced permissions settings​

In your SuperOffice document Site - click on the cog-wheel and then “Site permissions”​

Click on “Advanced permissions settings”​

  ![-screenshot][img2]

### Step 3 – Grant permissions​

Click on “Grant Permissions”​

In “Invite people”​

Type in and add domain (AAD) group(s)​

Members of these groups will automatically get access. ​

Tick off “Send an email invitation” (There will be a lot of emails that the users will wonder about​

Make sure the permission level is “Edit”. ​

When your done adding groups, press “Share”​

  ![-screenshot][img3]

### Step 4 – Review the SharePoint site groups​

​Members of the SharePoint site group Owners (Permission Levels Full Control), will have access to all content on that site. Including all folders and documents. ​

Make sure it is no user accounts in this group. Only service accounts. ​

​  ![-screenshot][img4]

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: media/so-sharepoiont-home.png
[img2]: media/advanced-permissions.png
[img3]: media/share.png
[img4]: media/review.png
