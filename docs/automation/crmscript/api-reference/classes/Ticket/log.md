---
uid: crmscript_class_ticket_log
title: Ticket.log()
description: CRMScript method in the Ticket class that writes a message to the ticket log
intellisense: Ticket.log
keywords: log(String), log(String,String)
so.topic: reference
---

# log()

Writes the given message to the ticket log. Used for logging changes and events on a ticket

You can optionally specify who updated the log.

## Methods

* Ticket.log(String message)
* Ticket.log(String who, String message)

## Parameters

| Parameter | Type | Description |
|---|---|---|
| who | String | Optional | The name of the user that made the change to log |
| message | String | The message to log |
