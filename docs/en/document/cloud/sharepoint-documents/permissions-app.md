---
title: Permissions of SuperOffice integration app
uid: permissions-app
description: Permissions of SuperOffice integration app
author: Frode Berntsen
so.date: 05.08.2023
keywords: permission, integration, app, SharePoint, document
so.topic: reference
so.envir: cloud
so.client: online
---

# Permissions for SuperOffice Document Library integration (app)

The SuperOffice integration application **SuperOffice Document Library** requires several permissions to be able to integrate SuperOffice CRM Online with SharePoint site.

To [add the SuperOffice Document Library app in SharePoint][1], a Global Administrator user must sign in once to give the app permission to access the selected site. This is done by using a one-time user-token with scope `Site.FullControl.All`. Once the app is approved with the given scopes for delegated permission, it can read and write files, delete and set permissions on documents, and create documents on behalf of a non-existing SharePoint user (system user).

## Types of permission

There are two different types of permission:

* (User) **Delegated** means that the application may act on behalf of a user as the user themselves for this particular permission.

* **Application** means that the application itself may act for this particular permission.

The reason for choosing a scope with delegated permission is the limitations in the API and can't use application permission here because documents will be created and updated as the application, not as the signed in user.

**Sites.Selected** is available only as Application permission, and can't be applied to Delegated permissions.

## What we use the scopes for

### User delegated permission (representing Global Administrator)

The delegated permissions are used once for adding the app.

> [!NOTE]
> `User.Read` and `Sites.FullControl.All` will not be persisted and not saved in the ZFP database. You may remove these 2 scopes after setup if desired.

| Scope | Permission display name | Description | Why we need it |
|---|---|---|---|
| `User.Read` | Sign in and read user profile | Allows users to sign in to the app. Allows the app to read the profile of signed-in users and to read basic company information of signed-in users. | To sign in global administrator user. ​|
| `Sites.FullControl.All` | Have full control of all site collections | Allows the application to have full control of all site collections on behalf of the signed-in user. | To add the app in SharePoint. ​To give the permission `Site.Selected` for the app, we must use a user-token with scope `Site.FullControl.All`. Once the app is approved with given scopes for delegated permission, we get a token of user with `Site.FullControl.All`. Then we set the permission to the selected site (see explanation below), enabling application permission. ​|

### Application permission (representing SuperOffice Document Library)

The application permission is used every time to read permissions and to read, write, create, and delete files in the selected site where the SuperOffice Document library is.

> [!NOTE]
> Permissions will be persisted, and `Sites.Selected` can't be removed.

| Scope | Permission display name | Description | Why we need it |
|---|---|---|---|
| `Sites.Selected` | Access selected site collections | Allow the application to access a subset of site collections without a signed in user. The specific site collections and the permissions granted will be configured in SharePoint Online. | To read permissions on documents. To read and write files. To delete and set permissions on documents. To create documents on behalf of non-existing SharePoint user (system user) in the selected site where the SuperOffice Document library is.​ |

#### Steps to enable Application permission with Sites.Selected

| Step | Permission level required |
|---|---|
| Authenticate Global administrator, request additional scopes for permission handling | Global Administrator |
| Approve the app with site selected scope | SharePoint Administrator and Site Owner |
| Make the POST call to assign the role for the app (read, write) | Global Administrator |

<!-- Referenced links -->
[1]: configure-superoffice.md#step-4
