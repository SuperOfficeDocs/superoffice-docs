---
uid: crmscript_class_message_saveinvolved
title: Message.saveInvolved()
description: CRMScript method in class Message that saves the email address of the recipients of a message
intellisense: Message.saveInvolved
sortOrder: 554
keywords: saveInvolved(String), saveInvolved(Vector)
so.topic: reference
---

# saveInvolved()

Saves the email address of the recipients of the message even if they are not customers on the request. These recipients are listed as possible recipients in the **Add message** screen.

You can provide either a single email address or a collection of addresses in a `Vector`.

## Methods

* Message.saveInvolved(String emailAddress)
* Message.saveInvolved(Vector emailAddresses)

## Parameters

| Parameter | Type | Description |
|---|---|---|
| emailAddress | String | A single email address for 1 recipient |
| emailAddresses | Vector | A collection of email addresses for multiple recipients |
