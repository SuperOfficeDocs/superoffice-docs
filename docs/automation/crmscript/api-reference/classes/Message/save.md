---
uid: crmscript_class_message_save
title: Message.save()
description: CRMScript method of class Method that saves a message and returns the database ID
intellisense: Message.save
sortOrder: 547
keywords: save(), save(String), save(String,Bool)
so.topic: reference
---

# Integer Message.save()

Saves the message and returns the database ID. You can optionally add logging.

## Methods

* Message.save()
* Message.save(String log)
* Message.save(String log, Bool noNewInfo)

## Parameters

| Parameter | Type | Description |
|---|---|---|
| log | String | Optional. Log entry to add to the ticket log that this message belongs to. |
| noNewInfo | Bool | Optional. Used in combination with `log`. Set it to false if your changes should turn the `readStatus` on ticket yellow (if the readStatus is green). |
