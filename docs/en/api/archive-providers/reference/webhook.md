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
|webhookId|int|Webhook ID: Webhook ID| x |
|name|string|Name: Webhook name| x |
|events|string|Events: Events that trigger this webhook| x |
|targetUrl|string|Target URL: URL to call when event occurs| x |
|type|string|Type: Webhook type (webhook, crmscript, etc.)| x |
|eventCount|int|Event Count: Number of events this webhook subscribes to|  |
|updatedByFullName|associate|Updated by - Full name: The user who last updated the data| x |
|registeredBy|associate|Registered by: The user who registered the data| x |
|registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|webhookUsage/totalCalls|int|Total Calls: Number of times webhook has been invoked| x |
|webhookUsage/totalErrors|int|Total Errors: Number of times webhook has returned an error| x |
|webhookUsage/consecutiveErrors|int|Consecutive Errors: Number of consecutive errors| x |
|webhookUsage/lastError|string|Last Error: Most recent error message from target| x |
|webhookUsage/lastEvent|datetime|Last Event: Date and time of the last webhook invocation| x |
|webhookUsage/status|int|Status: Webhook status based on state and error count|  |

## Sample

```http!
GET /api/v1/archive/Webhook?$select=targetUrl,updatedByFullName
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

