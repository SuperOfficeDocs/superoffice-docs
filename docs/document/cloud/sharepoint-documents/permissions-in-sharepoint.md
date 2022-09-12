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

# About permissions in SharePoint​

​
> [!NOTE]
> You need to set up permissions before you can configure **Groups and access** for your SharePoint documents in SuperOffice Online.

## Level

In SharePoint, you can give permission on **site level** or on **document library level​**:

* Document libraries automatically inherits the permission from the site level​.
* Document within the library will inherit the permission from the library itself​.

## SharePoint user groups​

In SharePoint you can create and maintain SharePoint user groups, which gives direct access​.

You can't use SharePoint user groups to set permission on document level with SuperOffice SharePoint Documents. The integration needs to use domain (AAD) groups. We will explain this later.​

## SharePoint site owner group​

When you create a site in SharePoint, you automatically get an **owner-group**. Members of this owner group will have access to all documents within that site.​

This access can't be removed (neither programmatically nor manually).​

For that reason, you need to use a **ServiceAccount** to create your SharePoint site for SuperOffice documents​.

<!-- Referenced links -->

<!-- Referenced images -->
