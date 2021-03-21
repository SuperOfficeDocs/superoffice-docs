---
uid: enum-shipmentmessagetype
title: Enum values for ShipmentMessageType
description: Lists the enum values for ShipmentMessageType.
so.generated: true
keywords:
  - "database"
so.date: 21.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# ShipmentMessageType Enum

Identifies if HTML or plain message is included in message.

* Plain = 0
* Html = 1
* SourceView = 2
* Sms = 4
* Document = 8

## Usage

* [s_message](../s-message.md).flags - A message used in a shipment. Can be html and/or plain text
