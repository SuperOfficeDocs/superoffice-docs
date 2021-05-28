---
uid: crmscript_class_message_send
title: Message.send()
description: CRMScript method in class Message that sends an email version of the message to the main contacts on the parent ticket
intellisense: Message.send
sortOrder: 542
keywords: send(Vector,Vector,Vector), send(Vector,Vector,Vector,Integer), send(Vector,Vector,Vector,String), send(Vector,Vector,Vector,String,String)
so.topic: reference
---

# Bool send()

Sends an email version of the message to the main contacts on the parent ticket.

You can optionally do one of the following:

* Merge with reply template in the settings of the submitted category ID.

* Using the given subject, and a given heading for the body part - the body heading may be empty for no heading, or null for default heading (same as not using this parameter).

Returns true if everything is OK, otherwise false.

## Methods

* Message.send(Vector to, Vector cc, Vector bcc)
* Message.send(Vector to, Vector cc, Vector bcc, Integer categoryId)
* Message.send(Vector to, Vector cc, Vector bcc, String subject)
* Message.send(Vector to, Vector cc, Vector bcc, String subject, String bodyHeading)

## Parameters

| Parameter | Type | Description |
|---|---|---|
| to | Vector | The to-recipients in the email |
| cc | Vector | The cc-recipients in the email |
| bcc | Vector | The bcc-recipients in the email |
| categoryId | Integer | Optional. The ID of the category to check for reply template merge. Alternative to `subject`. |
| subject | String | Optional | The subject in the email. Alternative to `categoryId`. |
| bodyHeading | String | Optional. The body heading in the email. Used in combination with `subject`. |
