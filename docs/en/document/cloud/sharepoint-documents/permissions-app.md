---
title: Permissions of SuperOffice integration app
uid: permissions-app
description: Permissions of SuperOffice integration app
author: Frode Berntsen
so.date: 08.05.2023
keywords: permission, integration, app
so.topic: reference, SharePoint, document integration
so.envir: cloud
so.client: online
---

# Permissions for SuperOffice integration application "SuperOffice Document Library (app)"

SuperOffice integration application "SuperOffice Document Library" requires several permissions to be able to integrate SuperOffice CRM Online with SharePoint site.

To [add the SuperOffice Document Library app in SharePoint][1], a Global Administrator user must sign in once to give the app permission to access the selected site. This is done by using a one-time user-token with scope `Site.FullControl.All`. Once the app is approved with the given scopes for delegated permission, it can read and write files, delete and set permissions on documents, and create documents on behalf of a non-existing SharePoint user (system user). 


## Types of permission

There are two different types of permission: **Application** and (User) **Delegated**.

The reason for choosing a scope with delegated permission is the limitations in the API and can't use application permission here because documents will be created and updated as the application, not as the signed in user.

**Sites.Selected** is only available as Application permission, and can't be applied to Delegated permissions.

This is what we use the scopes in 'SuperOffice Document Library' (app) for:

### User delegated permission (on behalf of the Global Administrator user)

Used once for adding the app. Those permissions will not be persistent / saved (and you may remove these 2 scopes after setup if you want to).

| Permission / Scope | Permission display name | Permission description | Permission type | Explanation (why we need it) |
|---|---|---|-------|-------|
| `User.Read` | Sign in and read user profile | Allows users to sign-in to the app, and allows the app to read the profile of signed-in users. It also allows the app to read basic company information of signed-in users. | `Delegated`. Delegated type means that this application may act on behalf of a user as the user him or herself for this particular permission. | To sign in global administrator user. Used once for adding the SuperOffice Document Library app. This permissions will not be persisted, and it won't be saved in the ZFP database.​|
| `Sites.FullControl.All` | Have full control of all site collections | Allows the application to have full control of all site collections on behalf of the signed-in user. | `Delegated`. Delegated type means that this application may act on behalf of a user as the user him or herself for this particular permission. | To add the SuperOffice Document library app in SharePoint. ​In order to give the permission `Site.Selected` for the app, we must use a user-token with scope `Site.FullControl.All`. Once the app is approved with given scopes for delegated permission, we get a token of user with `Site.FullControl.All`. Then we set the permission to the selected site (see explanation below), enabling application permission. This is a one-time token, and it won't be saved in the ZFP database.​|

### Application permission (on behalf of SuperOffice Document Library)

Used every time to read permissions, read, write, create, delete files in the selected site where the SuperOffice Document library is. Permissions will be persistent, and scope cannot be removed.

| Permission / Scope | Permission display name | Permission description | Permission type | Explanation (why we need it) |
|---|---|---|-------|-------|
| `Sites.Selected` | Access selected site collections | Allow the application to access a subset of site collections without a signed in user.  The specific site collections and the permissions granted will be configured in SharePoint Online. | `Application`. Application type means that this application itself may act for this particular permission. | To read permissions on documents, to read and write files, to delete and set permissions on documents, to create documents on behalf of non existing SharePoint user (system user) - in the selected site where the SuperOffice Document library is.​ |

Enabling Application permission with Sites.Selected has following steps:

| Step | Permission level required |
|---|---|
| Authenticate Global administrator, request additional scopes for permission handling | Global Administrator |
| Approve the app with site selected scope | SharePoint Administrator and Site Owner |
| Make the post call to assign the role for the app (read, write) | Global Administrator |

<!-- Referenced links -->
[1]: ../sharepoint-documents/configure-superoffice.md#step-3---groups-and-access
