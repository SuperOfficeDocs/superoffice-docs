---
uid: s_message
title: s_message table
description: A message used in a shipment. Can be html and/or plain text
so.generated: true
keywords:
  - "database"
  - "s_message"
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# SMessage Table (335)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|Primary key|PK| |
|plain\_message|Plain message text of this message|Clob|&#x25CF;|
|html\_message|HTML formatted text of this message|Clob|&#x25CF;|
|sms\_message|SMS version of this message|Clob|&#x25CF;|
|description|Describes this message|String(255)|&#x25CF;|
|subject|The mail subject field of the message|String(255)|&#x25CF;|
|header\_field|Extra header fields added to mail. Must be formatted correctly|Clob|&#x25CF;|
|flags|Identifies if HTML or plain message is included in message.|Enum [ShipmentMessageType](enums\EnumShipmentMessageType.md)| |
|folder\_id|The folder which this message belongs to. -1 indicates that the message is on the root|Int| |
|inline\_images|Should images be included inline?|Bool|&#x25CF;|
|register\_views|Register message views?|Bool|&#x25CF;|
|access\_key|Key used for access verification|String(255)|&#x25CF;|
|registered|Registered when|UtcDateTime|&#x25CF;|
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)|&#x25CF;|
|updated|Last updated when|UtcDateTime|&#x25CF;|
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)|&#x25CF;|
|updatedCount|Number of updates made to this record|UShort|&#x25CF;|
|document\_message|The SM document used as template for this mailing|FK [document](document.md)|&#x25CF;|
|long\_description|A field for a long description of this template|String(4000)|&#x25CF;|
|design|Will contain the design part of a message. The format will vary based on the type of designer used to create the message|Clob|&#x25CF;|
|designtype|Enum containing the type of the design|Enum [DesignType](enums\EnumDesignType.md)| |


![s_message table relationship diagram](media\s_message.png)

[!include[details](./includes/s-message.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

