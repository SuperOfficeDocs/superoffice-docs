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

​We recommend that you use domain (AAD) groups to control access to you SuperOffice document site in SharePoint​. All your user administration will be in Azure Portal, you will maintain group members there​.

> [!WARNING]
>
> The Group type must be Microsoft 365 and not Security.

If you plan to **use Visible for** (or already using this in CRM):​

AAD groups is the only way to set permissions in SharePoint according to your SuperOffice user groups​. We recommend (if not already) that you create corresponding groups in AAD to your SuperOffice user groups​.

If you plan **NOT to use Visible for**:​

We recommend that you use domain (AAD) group and not the SharePoint groups.​ Then you will have one place to handle users and permissions, and by adding users to this group in AAD when creating them – you will not have to add them again in SharePoint.

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
