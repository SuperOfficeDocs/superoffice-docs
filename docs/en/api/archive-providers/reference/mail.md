---
uid: Mail
title: Mail
description: Provides populated mail envelope rows as an archive based on a query string
keywords: Mail archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "Mail"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.MailItemSearchProvider">SuperOffice.CRM.ArchiveLists.MailItemSearchProvider</see> inside NetServer's SODatabase assembly.

Provides populated mail envelope rows as an archive based on a query string
This subclass filter envelopes based on a provided string, only envelopes containing
the string in either subject, sender, recipient or date are returned

## Supported Entities
| Name | Description |
| ---- | ----- |
|"companies"|[[SR_INBOX_FROM_CONTACT]]|
|"associates"|[[SR_INBOX_FROM_ASSOCIATE]]|
|"others"|[[SR_INBOX_FROM_OTHER]]|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|id| *None* |SR\_MAIL\_ID: SR\_MAIL\_ID\_TOOLTIP|  |
|status| *None* |SR\_INBOX\_STATUS| x |
|attachment| *None* |SR\_INBOX\_ATTACHMENT: SR\_INBOX\_ATTACHMENT\_TOOLTIP| x |
|from| *None* |SR\_ARCHIVE\_EMAIL\_FROM: SR\_MAIL\_PREVIEW\_FROM\_TOOLTIP| x |
|to| *None* |SR\_ARCHIVE\_EMAIL\_TO: SR\_MAIL\_PREVIEW\_TO\_TOOLTIP| x |
|subject| *None* |SR\_INBOX\_SUBJECT: SR\_INBOX\_SUBJECT\_TOOLTIP| x |
|size| *None* |SR\_MAIL\_SIZE: SR\_MAIL\_SIZE\_TOOLTIP| x |
|archived| *None* |SR\_MAIL\_ARCHIVED: SR\_MAIL\_ARCHIVED\_TOOLTIP|  |
|priority| *None* |SR\_MAIL\_PRIORITY: SR\_MAIL\_PRIORITY\_TOOLTIP| x |
|sent| *None* |SR\_DDLG\_DATO: SR\_INBOX\_SENT\_TOOLTIP| x |
|company| *None* |SR\_SINGULAR\_COMPANY: SR\_SINGULAR\_COMPANY|  |
|person| *None* |SR\_SINGULAR\_CONTACT: SR\_SINGULAR\_CONTACT|  |

## Sample

```http!
GET /api/v1/archive/Mail?$select=to,size
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

