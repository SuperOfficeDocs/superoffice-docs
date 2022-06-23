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

* A SharePoint document library (for storing documents)

* If you want to enable group access on SharePoint documents based on "Visible for" settings in SuperOffice
  * Need access to 'Global Admin' rights in O365 (to be able to authenticate SuperOffice as a trusted app in your MS 365 solution)
    * Either during setup
    * Or send a link to someone who is

## To use it

* All users must use **Sign in with Microsoft** in SuperOffice Online (AAD)
  * AAD Authentication of users (see [IDP authentication][2] for more info)

> [!NOTE]
> Support Word, Excel, PowerPoint documents, PDF and some image-formats.
>
> Support for arching emails to SharePoint and opening archived emails from SharePoint.
>
> No support for migrating existing documents in SuperOffice archive (SO cloud) to SharePoint. If this is a requirement, you must wait for a later version.  
>
> No support for migrating existing CloudOffice customers (version 1) to 'SharePoint documents 2.0'. Must wait for later version.
>
> No support for moving a documents to other SharePoint "sites", only within the same site.

<!-- Referenced links -->
[2]: ../legacy/office-365/prepare-sharepoint.md

<!-- Referenced images -->
[img1]: media/
