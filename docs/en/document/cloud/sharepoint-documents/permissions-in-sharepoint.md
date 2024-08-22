---
title: Permissions in SharePoint
uid: sharepoint-permissions
description: About permissions in SharePoint​
author: Bergfrid Dias
date: 01.15.2024
keywords: SharePoint, permission, security, access control, domain group, Microsoft Entra, ME-ID, AAD, Azure
topic: howto
version:
envir: cloud
client: online
---

# About permissions in SharePoint​

​We recommend that you use Microsoft Entra (formerly AAD) domain groups to control access to you SuperOffice document site in SharePoint​. All your user administration will be in the Microsoft Entra admin center, you will maintain group members there​.

> [!WARNING]
>
> The Group type must be Microsoft 365 and not Security.

If you plan to **use Visible for** (or already using this in CRM):​

Microsoft Entra groups is the only way to set permissions in SharePoint according to your SuperOffice user groups​. We recommend (if not already) that you create corresponding groups in Microsoft Entra ID to your SuperOffice user groups​.

If you plan **NOT to use Visible for**:​

We recommend that you use Microsoft Entra domain groups and not the SharePoint groups.​ Then you will have one place to handle users and permissions, and by adding users to this group in Microsoft Entra ID when creating them – you will not have to add them again in SharePoint.

> [!NOTE]
> You need to set up permissions before you can configure **Groups and access** for your SharePoint documents in SuperOffice Online.

## Level

In SharePoint, you can give permission on **site level** or on **document library level​**:

* Document libraries automatically inherits the permission from the site level​.
* Document within the library will inherit the permission from the library itself​.

## SharePoint user groups​

In SharePoint you can create and maintain SharePoint user groups, which gives direct access​.

You can't use SharePoint user groups to set permission on document level with SuperOffice SharePoint Documents. The integration needs to use Microsoft Entra domain groups. We will explain this later.​

## SharePoint site owner group​

When you create a site in SharePoint, you automatically get an **owner-group**. Members of this owner group will have access to all documents within that site.​

This access can't be removed (neither programmatically nor manually).​

For that reason, you need to use a **ServiceAccount** to create your SharePoint site for SuperOffice documents​.

<!-- markdownlint-disable-next-line MD013 -->
## <a id="aad-service-account"></a>Microsoft Entra service account for SuperOffice documents​

In Microsoft Entra ID, there are three types of [service accounts][1]: managed identities, service principals, and user accounts employed as service accounts. When you create service accounts for automated use, they’re granted permissions to access resources in Azure and Microsoft Entra ID.

To use a **Microsoft Entra service account** for your SharePoint site for SuperOffice documents, a normal user account employed as service account is recommended:
We recommend that you use a "service" account to create sites and libraries in SharePoint to avoid using personal accounts, since these will have unlimited access to all files in the site (Site-owner). If this service account has Global Administrator rights in Microsoft Entra ID, then this can be used to authorize our SuperOffice Document Library App. It will need a license to be able to access SharePoint.
Global administrator rights can of course be turned off and on for this account as needed.

<!-- Referenced links -->
[1]: https://learn.microsoft.com/en-us/entra/architecture/govern-service-accounts

<!-- Referenced images -->
