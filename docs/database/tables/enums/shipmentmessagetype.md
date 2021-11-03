---
uid: enum-shipmentmessagetype
title: Enum values for ShipmentMessageType
description: Lists the enum values for ShipmentMessageType.
so.generated: true
keywords:
  - "database"
so.date: 11.02.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# ShipmentMessageType Enum

Identifies if HTML or plain message is included in message.

| Name | Value | Description |
|------|-------|-------------|
|Plain|0|Contains a plain part|
|Html|1|Contains a HTML part|
|SourceView|2|Obsolete|
|Sms|4|Contains a SMS|
|Document|8|Contains a document. The document_message field contains the id of the actual document|

## Usage

* [s_message](../s-message.md).flags - A message used in a shipment. Can be html and/or plain text
