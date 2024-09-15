---
uid: enum-systemmessagetype
title: Enum values for SystemMessageType
description: Lists the enum values for SystemMessageType.
so.generated: true
keywords: database enum
so.topic: reference
so.envir: onsite, online
---

# SystemMessageType Enum

Type of message, example: info, warning, error

| Name | Value | Description |
|------|-------|-------------|
|Unspecified|0|System message type is unspecified.|
|Info|1|There is information that the user should be made aware of.|
|Warning|2|There is a problem that the user must be made aware of.|
|Error|3|There is a problem that the system will not be able to get around.|

## Usage

* [Message](../message.md).type - Definition of a message, corresponding to the header of a protocol
