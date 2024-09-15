---
uid: enum-shipmentmessagetype
title: Enum values for ShipmentMessageType
description: Lists the enum values for ShipmentMessageType.
so.generated: true
keywords: database enum
so.topic: reference
so.envir: onsite, online
---

# ShipmentMessageType Enum

Identifies if HTML or plain message is included in message.

| Name | Value | Description |
|------|-------|-------------|
|Plain|1|Contains a plain part|
|Html|2|Contains a HTML part|
|SourceView|4|Obsolete|
|Sms|8|Contains a SMS|
|Document|16|Contains a document. The document_message field contains the id of the actual document|

## Usage

* [s_message](../s-message.md).flags - A message used in a shipment. Can be html and/or plain text
