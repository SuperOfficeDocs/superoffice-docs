---
title: Requirements
uid: sharepoint-requirements
description: Requirements for SharePoint Documents
author: Bergfrid Dias
so.date: 11.01.2023
keywords: SharePoint, document, AAD IDP
so.topic: reference
so.envir: cloud
so.client: online
---

# Requirements

## To set it up

* SuperOffice Online tenant
  * AAD Authentication of SuperOffice Admin. For more info, see [IDP authentication][2].
  * You will not be able to continue to set up the integration [until ALL users with user plan use IDP](#to-use-it).

* Microsoft 365 for business subscription
  * If you don't have a Microsoft 365 subscription, you have to sign up for one at Microsoft.
  * You will be warned when you set up the integration if one or more users use different domain names. Note: [ALL users with user plan must be in the same Azure AD subscription](#to-use-it).

* A SharePoint site with document library for storing documents and document library for storing templates.

* Permissions to your SharePoint document libraries using domain (AAD) groups.
  * The Group type must be Microsoft 365 and not Security.
  * This is mandatory if you plan to use *Visible for* in SuperOffice Online and recommended either way.

* If you want to enable group access on SharePoint documents based on *Visible for* settings in SuperOffice.
  * *Global Admin* rights in Microsoft 365 (to be able to authenticate SuperOffice document library as a trusted app in your Microsoft 365 solution)
    * Either during setup
    * Or, send a link to someone who is

## To use it

[!include[AAD](includes/req-usage.md)]

* No support for moving documents to other SharePoint sites, only within the same site.

* [!include[data rights](includes/req-data-rights.md)]

<!-- Referenced links -->
[2]: ../../../identity-management/federated-id-and-identity-providers.md

<!-- Referenced images -->
