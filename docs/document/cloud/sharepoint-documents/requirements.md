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
  * AAD Authentication of SO Admin (see [IDP authentication][2] for more info)

* Microsoft 365 for business subscription
  * If you don't have a Microsoft 365 subscription, you have to sign up for one at Microsoft

* A SharePoint document library for storing documents
* A SharePoint document library for storing templates

* If you want to enable group access on SharePoint documents based on "Visible for" settings in SuperOffice
  * Need access to 'Global Admin' rights in O365 (to be able to authenticate SuperOffice as a trusted app in your MS 365 solution)
    * Either during setup
    * Or send a link to someone who is

## To use it

* All users must use **Sign in with Microsoft** in SuperOffice Online (AAD).
  * AAD Authentication of users (see [IDP authentication][2] for more info).

> [!NOTE]
> Support Word, Excel, PowerPoint documents, PDF and some image formats.
>
> Support for archiving emails to SharePoint and opening archived emails from SharePoint.
>
> Support for migrating existing documents in SuperOffice archive (SO cloud) to SharePoint. Pilot program from SuperOffice Online 10.1.5.
>
> Support for migrating existing CloudOffice customers (version 1) to 'SharePoint documents 2.0'. Pilot program from SuperOffice Online 10.1.5.
>
> No support for moving a documents to other SharePoint "sites", only within the same site.

<!-- Referenced links -->
[2]: ../legacy/office-365/prepare-sharepoint.md

<!-- Referenced images -->
