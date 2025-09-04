---
uid: webtools
title: SuperOffice WebTools
description: Introduction to SuperOffice WebTools
keywords: WebTools
author: Hans Oluf Waaler, Miriam Eirin Hiorth Johnson, Bergfrid Dias
date: 10.13.2016
content_type: concept
category: integration
topic: WebTools
audience: person
audience_tooltip: SuperOffice CRM
language: en
redirect_from: 
  - /en/document/webtools/index
  - /en/document/webtools/learn/index
index: true
---

# SuperOffice WebTools

WebTools connects SuperOffice with your documents and email.

Searching for email or documents can be a real time thief, and it is even worse if you are looking for information from someone else. Storing it all in SuperOffice solves this problem – just install WebTools to ease the uploading.

You will automatically be asked to upgrade or install SuperOffice WebTools when you log in to SuperOffice CRM through your browser for the first time on your computer.

## What is SuperOffice WebTools?

SuperOffice WebTools is a set of small programs installed on your computer which makes it easy to open, edit, and share important documents and emails with other SuperOffice users. When you have everything in SuperOffice, you will always have access to it in the office, on the go, and at home.

> [!NOTE]
> WebTools for Mac is not the same as WebTools for Windows. Read more about the differences below.

## Windows

If you are using Windows, you need WebTools to integrate your Outlook and Microsoft 365 document applications with SuperOffice CRM. WebTools consists of an email plugin (add-in) and a document plugin. Each of these applications allows you to perform different tasks and are visible in different places on your computer.

> [!NOTE]
> The **legacy SuperOffice Windows application** does not require a WebTools installation. Mail Link is installed as default with this application. SuperOffice Office (Word, Excel, PowerPoint) Ribbons is also installed, and it is part neither of WebTools nor Mail Link.

### Mail Link

Mail Link connects your Outlook to SuperOffice CRM so you can attach documents from your CRM, and archive communication into your CRM through the SuperOffice CRM ribbon. You can also send emails from the CRM interface by right-clicking on a contact or clicking an email address on a Contact screen. This will automatically open an email in Outlook.

**What does this add-in do?**

* Archives emails and attachments to SuperOffice from Outlook. You can archive email as appointments or requests. Emails that you archive to SuperOffice are automatically saved to the sender’s company card. If needed, you can also link an email to a project and sale.
* Looks up or creates a new contact in SuperOffice CRM from Outlook.
* Attaches documents from SuperOffice CRM when creating a new email in Outlook.
* Allows you to [create email templates][6] that can be used from SuperOffice CRM.
* Lets you open the Outlook application from SuperOffice CRM.
* Lets you add all contacts from a selection as recipients of an email.

### Web Extensions

Web Extensions connect your Windows document management system with SuperOffice CRM. You will be able to open and edit Microsoft 365 documents directly in SuperOffice CRM. Double-click the SuperOffice owl in your toolbar to open Web Extensions.

**What does this add-in do?**

* Locks and downloads documents from SuperOffice CRM. Uploads and saves documents to SuperOffice CRM.
* Displays diary notifications (alarms).
* Enables you to automatically log in to SuperOffice CRM  from the Toolbar application. This will open a new browser tab.
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

SuperOffice WebTools bridges document editing in SuperOffice CRM with the associated applications on the user's desktop. The integration has 4 features:

* Download, edit and upload documents
* Alarm notifications
* Quick-login to SuperOffice by menu or double-clicking on the icon in the notification area
* Bridge between user-initiated actions in SuperOffice CRM Web and SuperOffice Mail Link

How it works is detailed in the [technical overview][1].

### Distribution

* SuperOffice Web will automatically detect new versions of WebTools and will offer the user to update. WebTools can also be downloaded manually from the Download menu inside SuperOffice.

* SuperOffice Windows users will receive new versions upon upgrading the Windows client or by manually downloading and installing from the [Download Service][15].

## Related content

* [How to use SuperOffice Inbox][3]
* [Connect email, documents and diary][8]
* [Save an email in SuperOffice CRM][4]
* [Create a document in SuperOffice CRM][5]
* [Documents – safer collaboration, easier uploading][19]

<!-- Referenced links -->
[1]: technical-overview.md
[2]: install.md
[3]: ../../docs/en/email/inbox/learn/index.md
[4]: ../../docs/en/email/learn/index.md
[5]: ../../docs/en/document/learn/create.md
[6]: ../../docs/en/admin/lists/learn/create-email-template.md
[8]: ../../docs/en/learn/getting-started/connect-email-doc/index.md
[9]: ../../docs/en/ui/soprotocol/index.md
[12]: https://cs.superoffice.com/scripts/customer.fcgi?_sf=0&custSessionKey=&customerLang=en&noCookies=true&action=viewKbEntry&id=112136
[15]: https://www3.superoffice.com/DownloadService/
[19]: https://community.superoffice.com/en/product-releases/nyheter/produkt/document-locking/
