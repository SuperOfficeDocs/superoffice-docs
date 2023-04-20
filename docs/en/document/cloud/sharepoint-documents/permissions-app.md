---
title: Permissions of SuperOffice integration app
uid: permissions-app
description: Permissions of SuperOffice integration app
author: Martin Pavlas
so.date: 09.12.2022
keywords: permission, integration, app
so.topic: reference
so.envir: cloud
so.client: online
---

# Permissions for SuperOffice integration application

SuperOffice integration application requires several permissions to be able to integrate SuperOffice CRM Online with SharePoint site.

## Types of permission

There are two different types of permission: **Application** and (User) **Delegated**.

The reason for choosing a scope with delegated permission is the limitations in the API and can't use application permission here because documents will be created and updated as the application, not as the signed in user.

**Sites.Selected** is only available as Application permission, and can't be applied to Delegated permissions.

This is what we use the scopes for:

### User delegated permission

Used once for adding the app. Those permissions will not be persistent / saved.

| App | User | Scope | Usage |
|---|---|---|-------|
| SuperOffice | CRM Admin | User.Read |  Sign in and read user profile​. To sign in a global administrator user. ​ |
| SuperOffice Documents | CRM Admin | Sites.FullControl.All | When giving permission for SuperOffice documents app the permission level Site.Selected we need to use a user token with Site.FullControl scope. For this once the app is approved with given scopes for delegated permission we will get a token of user with Site.FullControl and will set the permission to the selected site. But this will be an one time token. The token won't be saved in the ZFP database. ​ |

### Application permission

| App | User | Scope | Usage |
|---|---|---|---|
| SuperOffice Documents | AD application | Sites.Selected | Access selected site collections. ​To read permissions on documents.​ |
| SuperOffice Documents | AD application | Files.ReadWrite.All | Read and write files in all site collections. ​Delete and set permissions on documents. Create documents on behalf of non existing SharePoint user (system user).​ |

Enabling Application permission with Sites.Selected has following steps:

| Step | Permission level required |
|---|---|
| Authenticate Global administrator, request additional scopes for permission handling | Global Administrator |
| Approve the app with site selected scope | SharePoint Administrator |
| Make the post call to assign the role for the app (read, write) | Global Administrator |
