---
uid: help-en-sharepoint-documents
title: SharePoint document library integration
description: The SuperOffice for Outlook add-in lets you work effortlessly between your Microsoft 365 and SuperOffice CRM solution, by letting you access key information and features from SuperOffice directly in your email.
author: Bergfrid Dias
so.date: 01.15.2024
keywords: document, Sharepoint
so.topic: concept
language: en
---

# SharePoint document library integration

SuperOffice's SharePoint document library integration lets you create, archive, and share documents and emails effortlessly and securely.

This integration allows you to store all documents and emails in SharePoint Online, where they can be accessed by everyone in the company, including even those who do not use SuperOffice CRM. The access to your SuperOffice document site in SharePoint can be controlled through Microsoft Entra domain groups (formerly Azure Active Directory).

![On Preferences in Settings and maintenance you find the Document library where you can set up the SharePoint integration -screenshot][img1]

## Requirements

To set up SharePoint as your document library in SuperOffice, you need:

* SuperOffice Online tenant
  * [Microsoft Entra authentication of SO Admin][1]
* Microsoft 365 for business subscription
  * If you do not have a Microsoft 365 subscription, you have to sign up for one at Microsoft
* A SharePoint document library (for storing documents)
* If you want to enable group access on SharePoint documents based on "Visible for" settings in SuperOffice
  * Need access to 'Global Admin' rights in Microsoft 365 (to be able to authenticate SuperOffice as a trusted app in your Microsoft 365 solution). Either during setup or send a link to someone who is.

> [!NOTE]
> If you do not have a Microsoft 365 subscription and are unable to sign up for one, you can use the default SuperOffice document library, and each user have to install WebTools for Windows or macOS.

## Get started

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/8mIo3Yac2QI]

## Related

* [How to set up the SharePoint folders][2]
* [How to configure SharePoint document library][4]
* [Enjoy effective document collaboration and information sharing with SharePoint and SuperOffice CRM][3] -blog

<!-- Referenced links -->
[1]:https://docs.superoffice.com/en/document/cloud/sharepoint-documents/set-up.html
[2]: set-up-folders.md
[3]: https://community.superoffice.com/no/learning/best-practices-tips/standard-crm/sharepoint-integration/
[4]: ../../../../admin/preferences/learn/document-library/change-to-sharepoint.md

<!-- Referenced images -->
[img1]: ../../../../../media/loc/en/document/admin-preferences-documentlibrary.png
