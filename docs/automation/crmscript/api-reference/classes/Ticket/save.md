---
uid: crmscript_ref_Ticket_save
title: Ticket.save()
description: CRMScript method in the Ticket class that saves the object
intellisense: Ticket.save
keywords: save(), save(String), save(Bool,Bool), save(String,Bool,Bool)
so.topic: reference
---

# save()

Saves the ticket and returns the database ID of the stored ticket.

You can optionally specify how to handle read status and escalation.

In addition, you can also write a message to the ticket log in both cases.

## Methods

* Ticket.save()
* Ticket.save(String p_log)
* Ticket.save(Bool setReadStatus, Bool doNotCheckEscalating)
* Ticket.save(String log, Bool setReadStatus, Bool doNotCheckEscalating)

## Parameters

| Parameter | Type | Description |
|---|---|---|
| log | String | Optional. The message that will be saved on the ticket's log |
| setReadStatus | Bool | Optional. Whether to calculate and set the read status on save. True = yes. Used in combination with `doNotCheckEscalating`. |
| doNotCheckEscalating | Bool | Optional. Controls escalation. True = do NOT escalate. Used in combination with `setReadStatus`. |
