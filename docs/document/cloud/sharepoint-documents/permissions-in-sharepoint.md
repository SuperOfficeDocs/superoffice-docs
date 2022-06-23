---
title: Permissions in SharePoint
uid: sharepoint-permissions
description:
author: Bergfrid Dias
so.date: 06.23.2022
keywords: SharePoint, permission security, access control
so.topic:
so.version:
so.envir:
so.client:
---

# About permission in SharePoint​
​
> [!NOTE]
> You need to set up permissions before you can configure **Groups and access** for your SharePoint documents in SuperOffice Online.

## Level

In SharePoint, you can give permission on **site level** or on **document library level​**:

* Document libraries automatically inherits the permission from the site level​.
* Document within the library will inherit the permission from the library itself​.

## SharePoint user groups​

In SharePoint you can create and maintain SharePoint user groups, which gives direct access​

You can't use SharePoint user groups to set permission on document level with SuperOffice SharePoint Documents. The integration needs to use domain (AAD) groups. We will explain this later.​

## SharePoint site owner group​

When you create a site in SharePoint, you automatically get an **owner-group**. Members of this owner group will have access to all documents within that site.​

This access can't be removed (neither programmatically nor manually).​

For that reason, you need to use a **ServiceAccount** to create your SharePoint site for SuperOffice documents​.

## Types of permission

There are two different types of permission: **Application** and (User) **Delegated**.

The reason for choosing a scope with delegated permission is the limitations in the API and can't use application permission here because documents will be created and updated as the application, not as the signed in user.

**Sites.Selected** is only available as Application permission, and can't be applied to Delegated permissions.  

This is what we use the scopes for:

### User delegated permission

| App | User | Scope | Usage |
|---|---|---|-------|
| SuperOffice | Normal | Sites.ReadWrite.All | Create, Update and delete documents<br />Set permission on documents<br />can't use application permission here because documents will be created and updated as the application, not as the logged in user |
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
| Make the post call to assign the role for the app(read, write) | Global Administrator |

<!-- Referenced links -->

<!-- Referenced images -->
