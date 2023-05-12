---
title: Permissions in SharePoint
uid: sharepoint-permissions
description: About permissions in SharePoint​
author: Bergfrid Dias
so.date: 06.23.2022
keywords: SharePoint, permission security, access control
so.topic: howto
so.version:
so.envir: cloud
so.client: online
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

## <a id="aad-service-acccount" />AAD Service Account for SuperOffice documents​

In Azure Active Directory (Azure AD), there are three types of [service accounts][1]: managed identities, service principals, and user accounts employed as service accounts. When you create service accounts for automated use, they’re granted permissions to access resources in Azure and Azure AD.

To use a **AAD Service Account** for your SharePoint site for SuperOffice documents, a normal user account employed as service account is recommended:
We recommend that you use a "service" account to create sites and libraries in SharePoint to avoid using personal accounts, since these will have unlimited access to all files in the site (Site-owner). If this service account has Global Administrator rights in AAD, then this can be used to authorize our SuperOffice Document Library App. It will need a license to be able to access SharePoint.
Global administrator rights can of course be turned off and on for this account as needed.

<!-- Referenced links -->
[1]: https://learn.microsoft.com/en-us/azure/active-directory/fundamentals/service-accounts-governing-azure

<!-- Referenced images -->
