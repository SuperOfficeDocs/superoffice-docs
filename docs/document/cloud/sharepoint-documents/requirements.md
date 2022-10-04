---
title: Requirements
uid: sharepoint-requirements
description: Requirements for SharePoint Documents
author: Bergfrid Dias
so.date: 06.20.2022
keywords: SharePoint, document
so.topic: reference
so.envir: cloud
so.client: online
---

# Requirements

## To set it up

* SuperOffice Online tenant
  * AAD Authentication of SuperOffice Admin (see [IDP authentication][2] for more info).

* Microsoft 365 for business subscription
  * If you don't have a Microsoft 365 subscription, you have to sign up for one at Microsoft.

* A SharePoint site with document library for storing documents and document library for storing templates.

* Permissions to your SharePoint document libraries using domain (AAD) groups. This is mandatory if you plan to use "Visible for" in SuperOffice Online and recommended either way.

* If you want to enable group access on SharePoint documents based on "Visible for" settings in SuperOffice.
  * 'Global Admin' rights in Microsoft 365 (to be able to authenticate SuperOffice document library as a trusted app in your Microsoft 365 solution)
    * Either during setup
    * Or send a link to someone who is

## To use it

* All users must use **Sign in with Microsoft** in SuperOffice Online (AAD).
  * AAD Authentication of users (see [IDP authentication][2] for more info).

> [!NOTE]
> No support for moving documents to other SharePoint sites, only within the same site.

<!-- Referenced links -->
[2]: ../legacy/office-365/prepare-sharepoint.md

<!-- Referenced images -->
