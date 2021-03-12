---
title: mailarchivehelper
description: MailArchiveHelper
author: Tony Yates
so.date: 06.24.2016
keywords:
so.topic: concept
so.client: web
so.envir: onsite
---

# MailArchiveHelper

The `MailArchiveHelper` supports both web and Windows versions of SuperOffice. It is included with the Outlook mail link.

![diagram][img1]

The SuperOffice application uses these components to send mail via a local mail client. The mail clients use these components via plugins to archive the mail into the appropriate SuperOffice application.

## Windows or web application?

When the Windows client is installed it marks the registry - the *SuperOffice.Application* and *SuperOfficeDB.Database* COM objects are registered. The `MailLinkHelper` looks for the presence of these keys as a hint that it should use the local installation.

The registry value **SuperOfficeTarget** in the appropriate key is used to figure out which client to talk to. This value is set during the MSI installation using an MSI custom action. This custom action checks the registry for the `HKCR\SuperOffice.Application` key. If this key is present, we default to "win".

* win: use COM to talk to the local SOCRM client.
* web: use web services to talk to the SuperOffice web client

The URL for the website is stored in the registry value `WebUrl`

The preference dialog also allows the user to choose which client to use: win or web.

## Create a custom plugin

There is a mail client that you want to write a plugin for.

* Use the API of the mail-client to write your plugin
* Use the SuperOffice helper to deal with archiving emails into SuperOffice

Your plugin is the green box on the diagram. SuperOffice supplies the red boxes: the mail archive helper hides the difference between the web and win APIs from you.

Example showing how to archive an email:

```csharp
MailArchiveHelper mah = new MailArchiveHelper();
mah.Initialize("MyMailLink", ".somail", "MyMailLinkHelpFile.chm");

IArchiveInfo archiveInfo = new ArchiveInfo("John Doe", "john.doe@company.com", true, true);
IDocumentInfo documentInfo = new DocumentInfo();

documentInfo.Title = "Proposition of meeting regarding big sale";
documentInfo.Filename = "c:\\temp\\myemail.somail";
documentInfo.Date = DateTime.Now;
documentInfo.Direction = DocDirection.kIncoming;

mah.ArchiveDocument(archiveInfo, documentInfo);
```

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: media/diagram.jpg
