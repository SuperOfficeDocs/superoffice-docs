---
uid: TicketNewMessageNotification
title: TicketNewMessageNotification
description: 
keywords:
  - "archive"
  - "provider"
  - "archive provider"
  - "TicketNewMessageNotification"
so.generated: true
so.date: 03.31.2023
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "TicketNewMessageNotification"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.TicketNewMessageNotificationSubProvider">SuperOffice.CRM.ArchiveLists.TicketNewMessageNotificationSubProvider</see> inside NetServer's SODatabase assembly.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"ticketNewMessage"|Request|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|id| *None* |!!id| x |
|associateId|associate|Associate: SR\_SINGULAR\_ASSOCIATE\_TOOLTIP| x |
|originatorFullName| *None* |!!originatorFullName|  |
|notifyDateTime|datetime|!!notifyDateTime| x |
|title| *None* |!!title|  |
|updateType| *None* |!!updateType|  |
|ticketId| *None* |!!ticketId| x |
|category| *None* |!!category| x |
|customUrl| *None* |!!customUrl| x |

## Sample

```http!
GET /api/v1/archive/TicketNewMessageNotification?$select=associateId,associateId,notifyDateTime
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

