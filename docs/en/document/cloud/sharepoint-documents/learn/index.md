---
uid: help-en-sharepoint-documents
title: SharePoint document library integration
description: The SuperOffice for Outlook add-in lets you work effortlessly between your Microsoft 365 and SuperOffice CRM solution, by letting you access key information and features from SuperOffice directly in your email.
author: Bergfrid Dias
so.date: 02.14.2023
keywords: document, Sharepoint
so.topic: concept
language: en
---

# SharePoint document library integration

SuperOffice's SharePoint document library integration lets you create, archive, and share documents and emails effortlessly and securely.

This integration allows you to store all documents and emails in SharePoint Online, where they can be accessed by everyone in the company, including even those who do not use SuperOffice CRM. The access to your SuperOffice document site in SharePoint can be controlled through domain groups (AAD = Azure active directory authentication).

![On Preferences in Settings and maintenance you find the Document library where you can set up the SharePoint integration -screenshot][img1]

## Requirements

To set up SharePoint as your document library in SuperOffice, you need:

* SuperOffice Online tenant
  * [AAD Authentication of SO Admin][1]
* Microsoft 365 for business subscription
  * If you do not have a Microsoft 365 subscription, you have to sign up for one at Microsoft
* A SharePoint document library (for storing documents)
* If you want to enable group access on SharePoint documents based on "Visible for" settings in SuperOffice
  * Need access to 'Global Admin' rights in Microsoft 365 (to be able to authenticate SuperOffice as a trusted app in your Microsoft 365 solution). Either during setup or send a link to someone who is.

> [!NOTE]
> If you do not have a Microsoft 365 subscription and are unable to sign up for one, you can use the default SuperOffice document library, and each user have to install WebTools for Windows OS or Mac OS.

## Get started

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://youtu.be/8mIo3Yac2QI]

## Related

* [How to set up the SharePoint folders][2]
* How to configure SharePoint document library
* Manage your document templates
* [Enjoy effective document collaboration and information sharing with SharePoint and SuperOffice CRM][3] -blog

<!-- Referenced links -->
[1]: ../set-up.md
[2]: set-up-folders.md
[3]: https://community.superoffice.com/no/learning/best-practices-tips/standard-crm/sharepoint-integration/

<!-- Referenced images -->
[img1]: media/admin-preferences-documentlibrary.png
