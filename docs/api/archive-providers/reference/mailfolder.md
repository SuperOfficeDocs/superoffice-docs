---
uid: MailFolder
title: MailFolder
description: 
keywords:
  - "archive"
  - "provider"
  - "archive provider"
  - "MailFolder"
so.generated: true
so.date: 23.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "MailFolder"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.MailFolderProvider">SuperOffice.CRM.ArchiveLists.MailFolderProvider</see> inside NetServer's SODatabase assembly.

Provides list of subscribed and unsubscribed mail folders available for an account

## Supported Entities
| Name | Description |
| ---- | ----- |
|"mailfolder"|[(mailfolder)]|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|id| *None* |id|  |
|subscribed| *None* ||  |
|name| *None* ||  |

## Sample

```http!
GET /api/v1/archive/MailFolder?$select=
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

