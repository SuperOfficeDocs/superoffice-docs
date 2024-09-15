---
uid: enum-ticketmessagecategory
title: Enum values for TicketMessageCategory
description: Lists the enum values for TicketMessageCategory.
so.generated: true
keywords: database enum
so.topic: reference
so.envir: onsite, online
---

# TicketMessageCategory Enum

Defines what kind of message this is.

| Name | Value | Description |
|------|-------|-------------|
|Message|0|A normal message|
|Bounce|1|Email bounce|
|OutboxFailed|2|This message is the error message returned by the sending system (for example a mail server)|

## Usage

* [ej_message](../ej-message.md).message_category - This table contains the messages listed under tickets.
