---
uid: Mail
title: Mail
description: Provides populated mail envelope rows as an archive based on a query string
keywords:
  - "archive"
  - "provider"
  - "archive provider"
  - "Mail"
so.generated: true
so.date: 23.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "Mail"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.MailItemSearchProvider">SuperOffice.CRM.ArchiveLists.MailItemSearchProvider</see> inside NetServer's SODatabase assembly.

Provides populated mail envelope rows as an archive based on a query string
This subclass filter envelopes based on a provided string, only envelopes containing
the string in either subject, sender, recipient or date are returned

## Supported Entities
| Name | Description |
| ---- | ----- |
|"companies"|Companies|
|"associates"|Associates|
|"others"|Others|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|id| *None* |ID: ID of the e-mail|  |
|status| *None* |Status| x |
|attachment| *None* |Attachment: Indicates whether the e-mail has one or more attachments| x |
|from| *None* |From: The sender of the e-mail| x |
|to| *None* |To: The recipient of the e-mail| x |
|subject| *None* |Subject: The subject of the e-mail| x |
|size| *None* |Size: The size of the e-mail| x |
|archived| *None* |Archived: Indicates whether the e-mail has been archived in SuperOffice CRM|  |
|priority| *None* |Priority: The e-mail's priority| x |
|sent| *None* |Date : The time this e-mail was sent at| x |
|company| *None* |Company: Company|  |
|person| *None* |Contact: Contact|  |

## Sample

```http!
GET /api/v1/archive/Mail?$select=attachment,to,size
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

