---
title: Permissions of SuperOffice integration app
uid: permissions_app
description:
author: {github-id} # Your GitHub alias.
so.date: 12.09.2022
keywords: permission, integration, app
so.topic: reference
so.envir: cloud
so.client: online
---

# Permissions of SuperOffice integration application

SuperOffice integration application requires several permissions to be able to integrate SuperOffice CRM Online with SharePoint site.

## Types of permission

There are two different types of permission: **Application** and (User) **Delegated**.

The reason for choosing a scope with delegated permission is the limitations in the API and can't use application permission here because documents will be created and updated as the application, not as the signed in user.

**Sites.Selected** is only available as Application permission, and can't be applied to Delegated permissions.

This is what we use the scopes for:

### User delegated permission

| App | User | Scope | Usage |
|---|---|---|-------|
| SuperOffice | Normal | Sites.ReadWrite.All | Create, Update and delete documents<br />Set permission on documents<br />Can't use application permission here because documents will be created and updated as the application, not as the logged in user |
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
| Approve the app with site selected scope | SharePoint Administrator |
| Make the post call to assign the role for the app (read, write) | Global Administrator |
