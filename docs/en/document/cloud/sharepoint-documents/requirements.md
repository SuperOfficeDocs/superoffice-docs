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
  * Soon you will not be able to continue to set up the integration until ALL users with user plan use IDP (see "Requirements - To use it" below)

* Microsoft 365 for business subscription
  * If you don't have a Microsoft 365 subscription, you have to sign up for one at Microsoft.
  * Soon you will not be able to continue to set up the integration until ALL users with user plan must be in the same Azure AD subscription (see "Requirements - To use it" below)

* A SharePoint site with document library for storing documents and document library for storing templates.

* Permissions to your SharePoint document libraries using domain (AAD) groups. This is mandatory if you plan to use "Visible for" in SuperOffice Online and recommended either way.

* If you want to enable group access on SharePoint documents based on "Visible for" settings in SuperOffice.
  * 'Global Admin' rights in Microsoft 365 (to be able to authenticate SuperOffice document library as a trusted app in your Microsoft 365 solution)
    * Either during setup
    * Or send a link to someone who is

## To use it

* ALL users with user plan must use **Sign in with Microsoft** in SuperOffice Online (AAD).
  * AAD Authentication of users (see [IDP authentication][2] for more info).
* ALL users with user plan must be in the same Azure AD subscription as the one used during set up

> [!NOTE]
> No support for moving documents to other SharePoint sites, only within the same site.

<!-- Referenced links -->
[2]: ../legacy/office-365/prepare-sharepoint.md

<!-- Referenced images -->
