---
uid: crmscript-trigger-outbox-tutorial
title: Trigger for outbox
description: How to use a trigger for the outbox
author: hjelms
so.date: 10.20.2023
keywords: CRMScript
so.topic: tutorial
---

<!-- markdownlint-disable-file MD044 -->
# Creating a trigger for the outbox

This event is called when an email or SMS outbox item is created. All emails or SMSes sent from SuperOffice Service will pass through the outbox. The event is named [Outbound email or SMS created][1]. The `EventData` instance will contain several input values relevant to the context.

First, the input value `eventType` will identify the event that caused the outbox item to be created. The list of known events are:

* emailFilter/emailFilterSms: When an email/SMS is sent as a result of an email filter.
* notifyUser/notifyUserSms: When a user is notified by email/SMS for example of a new request.
* autoReply: When an auto-reply is sent back to the customer when a case is created.
* addMessage/addMessageSms: When a message is added to a request, or a new request is created, with email/SMS recipients.
* paswordEmail: When an email is sent to a customer with the username/password.
* sendTicketMessages/sendTicketMessagesSms: When a request is being forwarded by email/SMS.
* personSendEmail: When the `PersonAgent.SendEmail()` method is called. Out of the box the same as "passwordEmail", but from the CRM client.
* chatTranscriptEmail: When a chat session transcript is being sent.
* newCustomerEmail: When a new customer email is being sent.
* customerKey: When an email with a session-key for the Customer Center is sent (for example, for updating Mailings subscriptions).
* crmScript: When an email is sent from CRMScript using the Email-class (Note: can be overridden using setValue("eventName", "...")).
* notSupported: Used as a fallback value for deprecated or obsolete functionality.

The input values will be different, depending on whether this is an email or SMS event. For emails, the `EventData.InputValues` will contain values such as *outbox.to*, *outbox.subject*. For SMSs, it will contain, for example, *body*, *recipient*, and *sender*. Also, depending of the type, various operations are supported, controlled by settings values in the `EventData.OutputValues`.

## Trigger executed for Email

The following **input values** are available:

* outbox.ticketId: The ID of the ticket.
* outbox.messageId: The ID of the message.
* outbox.from/envelopeFrom: The two from addresses for the email.
* outbox.subject: The subject of the email.
* outbox.to/cc/bcc: The recipients of the email.
* outbox.textPlain/textHtml: The contents of the email.
* outbox.part.length/outbox.part.n.contentType/outbox.part.n.data: The array of parts in the message.
* outbox.attachment.length/outbox.attachment.n.contentType/outbox.attachment.n.name: The array of attachments in the message.

The following **output values** are supported:

* outbox.subject: Change the subject.
* outbox.to/cc/bcc: Change the recipients.
* outbox.textPlain/textHtml: Change the contents of the email.
* outbox.header.length/outbox.header.n.name/outbox.header.n.value: Support for adding/replacing any number of RFC822 headers. .length is the number of headers to set, and "n" is the count starting at zero.

## Trigger executed for SMS

The following **input values** are available:

* outbox.ticketId: The ID of the ticket.
* outbox.messageId: The ID of the message.
* outbox.body: The contents of the SMS.
* outbox.recipient: The recipient(s) of the SMS.
* outbox.sender: The sender of the SMS.

The following **output values** are supported:

* outbox.body: Change the contents of the SMS.
* outbox.recipient: Change the recipient(s) of the SMS.
* outbox.sender: Change the sender of the SMS.

For both email and SMS, setting `EventData.BlockExecution` to *true* will block the Outbox item (prevent it from being created). The idea of this trigger is that minor changes to emails and SMSs can be performed by settings output values.

## Example

This example will block outbound emails sent as replies to a request, and instead ask the customer to log in to the Customer Centre to view the message.

```crmscript
#setLanguageLevel 4;
if (ed.getInputValue("outbox.eventName") == "addMessage") {
  // Block the original message
  ed.setBlockExecution(true); 

  // Send an alternative message
  Email e;
  e.setValue("to", ed.getInputValue("outbox.to"));
  e.setValue("cc", ed.getInputValue("outbox.cc"));
  e.setValue("bcc", ed.getInputValue("outbox.bcc"));
  e.setValue("subject", ed.getInputValue("outbox.subject"));
  e.setValue("body", "A new message has been added to your ticket: " + ed.getInputValue("outbox.ticketId") + ". Please log in to the Customer Centre to view it.");
  e.send();  
}
```

This example will add a new header to any outbound email.

```crmscript
#setLanguageLevel 4;
ed.setOutputValue("outbox.header.length", "1");
ed.setOutputValue("outbox.header.0.name", "X-our-header");
ed.setOutputValue("outbox.header.0.value", "Email processed by CRMScript");
```

<!-- Referenced links -->
[1]: <xref:CRMSCript.Event.Trigger.OutboxItemCreated>
