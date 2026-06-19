---
uid: Webhook
title: Webhook
description: Archive provider for listing webhooks.
keywords: Webhook archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "Webhook"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.WebhookProvider">SuperOffice.CRM.ArchiveLists.WebhookProvider</see> inside NetServer's SODatabase assembly.

Archive provider for listing webhooks.
Lists all webhooks in the Webhook table.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"webhook"|webhook|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|webhookId|int|SR\_ADMIN\_WEBHOOK\_ID: SR\_ADMIN\_WEBHOOK\_ID| x |
|name|string|SR\_ADMIN\_WEBHOOK\_NAME: SR\_ADMIN\_WEBHOOK\_NAME\_TOOLTIP| x |
|events|string|SR\_ADMIN\_WEBHOOK\_EVENTS: SR\_ADMIN\_WEBHOOK\_EVENTS\_TOOLTIP| x |
|targetUrl|string|SR\_ADMIN\_WEBHOOK\_TARGET\_URL: SR\_ADMIN\_WEBHOOK\_TARGET\_URL\_TOOLTIP| x |
|type|string|SR\_ADMIN\_WEBHOOK\_TYPE: SR\_ADMIN\_WEBHOOK\_TYPE\_TOOLTIP| x |
|eventCount|int|SR\_ADMIN\_WEBHOOK\_EVENT\_COUNT: SR\_ADMIN\_WEBHOOK\_EVENT\_COUNT\_TOOLTIP|  |
|registeredByFullName|associate|SR\_REGISTEREDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|registeredDate|date|SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
|updatedByFullName|associate|SR\_UPDATEDASSOC - SR\_ARCHIVE\_ASSOC\_FULLNAME: SR\_UPDATEDASSOC\_TOOLTIP| x |
|webhookUsage/totalCalls|int|SR\_ADMIN\_WEBHOOK\_TOTAL\_CALLS: SR\_ADMIN\_WEBHOOK\_TOTAL\_CALLS\_TOOLTIP| x |
|webhookUsage/totalErrors|int|SR\_ADMIN\_WEBHOOK\_TOTAL\_ERRORS: SR\_ADMIN\_WEBHOOK\_TOTAL\_ERRORS\_TOOLTIP| x |
|webhookUsage/consecutiveErrors|int|SR\_ADMIN\_WEBHOOK\_CONSECUTIVE\_ERRORS: SR\_ADMIN\_WEBHOOK\_CONSECUTIVE\_ERRORS\_TOOLTIP| x |
|webhookUsage/lastError|string|SR\_ADMIN\_WEBHOOK\_LAST\_ERROR: SR\_ADMIN\_WEBHOOK\_LAST\_ERROR\_TOOLTIP| x |
|webhookUsage/lastEvent|datetime|SR\_ADMIN\_WEBHOOK\_LAST\_EVENT: SR\_ADMIN\_WEBHOOK\_LAST\_EVENT\_TOOLTIP| x |
|webhookUsage/status|int|SR\_ADMIN\_WEBHOOK\_STATUS: SR\_ADMIN\_WEBHOOK\_STATUS\_TOOLTIP|  |

## Sample

```http!
GET /api/v1/archive/Webhook?$select=type,targetUrl,registeredByFullName
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

