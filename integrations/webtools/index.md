---
uid: webtools
title: SuperOffice WebTools
description: Introduction to SuperOffice WebTools
keywords: WebTools
author: digitaldiina
date: 03.24.2026
content_type: concept
category: integration
topic: WebTools
audience: person
audience_tooltip: SuperOffice CRM
language: en
redirect_from:
  - /en/document/webtools/index
  - /en/document/webtools/learn/index
  - /da/document/webtools/learn/index
  - /de/document/webtools/learn/index
  - /nl/document/webtools/learn/index
  - /no/document/webtools/learn/index
  - /sv/document/webtools/learn/index
index: true
---

# SuperOffice WebTools

WebTools connects SuperOffice with your documents.

Searching for documents can be a real time thief, and it is even worse if you are looking for information from someone else. Storing it all in SuperOffice solves this problem – just install WebTools to ease the uploading.

You will automatically be asked to upgrade or install SuperOffice WebTools when you log in to SuperOffice CRM through your browser for the first time on your computer.

## What is SuperOffice WebTools?

SuperOffice WebTools is a set of small programs installed on your computer which makes it easy to open, edit, and share important documents with other SuperOffice users. When you have everything in SuperOffice, you will always have access to it in the office, on the go, and at home.

> [!NOTE]
> WebTools for Mac is not the same as WebTools for Windows. Read more about the differences below.

## Windows

If you are using Windows, WebTools integrates your Microsoft 365 document applications with SuperOffice CRM.

* On SuperOffice 11.11 and newer, WebTools provides document integration only.
* On SuperOffice 11.10 and older, WebTools also includes [Mail Link][3], which connects Outlook to SuperOffice CRM.
* The **legacy SuperOffice Windows application** does not require a WebTools installation.

Web Extensions connect your Windows document management system with SuperOffice CRM. You will be able to open and edit Microsoft 365 documents directly in SuperOffice CRM. Double-click the SuperOffice owl in your toolbar to open Web Extensions.

**What does this add-in do?**

* Locks and downloads documents from SuperOffice CRM. Uploads and saves documents to SuperOffice CRM.
* Displays diary notifications (alarms).
* Enables you to automatically log in to SuperOffice CRM from the Toolbar application. This will open a new browser tab.
* Enables the use of [SoProtocol][9]. Opens a context-specific SuperOffice CRM website when an SoProtocol (`superoffice://…`) link is clicked.

[Connect your Microsoft documents with SuperOffice CRM.][2]

## macOS

Installing WebTools for Mac enables an integration between Microsoft 365 documents and SuperOffice CRM (not email). If you use a Mac and want to integrate your email, please configure your SuperOffice Inbox.

Double-click the SuperOffice owl in your toolbar to open WebTools on a Mac.

> [!NOTE]
> SuperOffice provides integration only for Microsoft 365 document applications, and **not for Apple applications** Pages, Numbers, and Keynote. You need the Office package to have documents integrated.

**What does this add-in do?**

* Locks and downloads documents from SuperOffice CRM. Uploads and saves documents to SuperOffice CRM.
* Displays diary notifications (alarms).
* Enables you to automatically log in to SuperOffice CRM  from the Toolbar application. This will open a new browser tab.
* [Copies SuperOffice appointment to Calendar on Mac][12].
* [Copies SuperOffice contacts to Contacts on Mac][12].

## Technical information for administrators

SuperOffice WebTools bridges document editing in SuperOffice CRM with the associated applications on the user's desktop. The integration has 3 features:

* Download, edit and upload documents
* Alarm notifications
* Quick-login to SuperOffice by menu or double-clicking on the icon in the notification area

How it works is detailed in the [technical overview][1].

### Distribution

* SuperOffice Web will automatically detect new versions of WebTools and will offer the user to update. WebTools can also be downloaded manually from the Download menu inside SuperOffice.

* SuperOffice Windows users will receive new versions upon upgrading the Windows client or by manually downloading and installing from the [Download Service][15].

## Related content

* [Connect email, documents and diary][8]
* [Create a document in SuperOffice CRM][5]
* [Documents – safer collaboration, easier uploading][19]

<!-- Referenced links -->
[1]: technical-overview.md
[2]: install.md
[3]: ../mail-link/install.md
[5]: ../../docs/en/document/learn/create.md
[8]: ../../docs/en/learn/getting-started/connect-email-doc/index.md
[9]: ../../docs/en/customization/soprotocol/index.md
[12]: https://cs.superoffice.com/scripts/customer.fcgi?_sf=0&custSessionKey=&customerLang=en&noCookies=true&action=viewKbEntry&id=112136
[15]: https://downloadservice.superoffice.com/
[19]: https://community.superoffice.com/en/product-releases/nyheter/produkt/document-locking/
