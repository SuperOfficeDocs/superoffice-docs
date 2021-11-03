---
uid: table-Webhook
title: Webhook table
description: Webhook URL to call when events occur in the client or in NetServer. Also tracks call+error statistics.
so.generated: true
keywords:
  - "database"
  - "Webhook"
so.date: 11.02.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# Webhook Table (493)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|webhook\_id|Primary key|PK| |
|name|Name to identify this webhook. Does not have to be unique.|String(400)| |
|events|Comma separated list of event names that this hook responds to: &apos;contact.created,person.changed,project.deleted&apos;|String(4000)| |
|target\_url|Destination to POST event info to. URL for webhooks. Id for CRM scripts|String(4000)| |
|type|Name of plugin that handles this webhook. &apos;webhook&apos; for webhooks, which are handled by the system plugin.|String(100)| |
|application\_token|Application that registered this hook. If set, then other apps won&apos;t be able to modify this record|String(200)|&#x25CF;|
|headers|Hook specific additional HTTP headers that should be added to HTTP request, stored as JSON blob|Clob|&#x25CF;|
|properties|Hook specific additional data that should be added to payload, stored as JSON blob|Clob|&#x25CF;|
|secret|Shared secret key used for generating SHA256 HMAC signature, so that receiver can verify that call came from this server|String(400)|&#x25CF;|
|state|Webhook status - should we post events to the URL? 1=Active, 2=Stopped or 3=TooManyErrors|Enum [WebhookState](enums/webhookstate.md)| |
|total\_calls|Number of times webhook has been invoked since registered. For statistical purposes.|Int| |
|total\_errors|Number of times webhook has returned error since registered. For statistical purposes.|Int| |
|consecutive\_errors|Number of consecutive errors. Reset to 0 when an non-error is received. If too many errors, state is changed to TooManyErrors(3) to deactivate webhook.|Int| |
|last\_error|Most recent error message received from target. HTTP Headers + body. To help with debugging webhooks.|String(4000)|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![Webhook table relationship diagram](./media/Webhook.png)

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|webhook\_id |PK |Clustered, Unique |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

