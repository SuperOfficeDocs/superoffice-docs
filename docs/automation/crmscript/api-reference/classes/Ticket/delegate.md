---
uid: crmscript_class_ticket_delegate
title: Ticket.delegate()
description: CRMScript method in the Ticket class that delegates a ticket to a user according to the rules on the category
intellisense: Ticket.delegate
keywords: delegate(), delegate(Integer)
so.topic: reference
---

# delegate()

Delegates the ticket to a user according to the rules on the category of the ticket. You can optionally specify a user ID **not** to delegate to.

> [!NOTE]
> For this function to take effect, you have to call `Ticket.save()`.

## Methods

* Ticket.delegate()
* Ticket.delegate(Integer notUser)

## Parameters

| Parameter | Type | Description |
|---|---|---|
| notUser | Integer | Optional. The ID of a user you do not want to delegate to. |
