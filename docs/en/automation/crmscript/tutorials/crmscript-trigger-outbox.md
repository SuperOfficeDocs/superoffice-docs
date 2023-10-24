---
uid: crmscript-trigger-outbox-tutorial
title: Trigger for outbox
description: How to use a trigger for the outbox
author: hjelms
so.date: 20.10.2023
keywords: CRMScript
so.topic: tutorial
---

# Creating a trigger for the outbox

This event is called when an outbox item is created (either an email or an SMS). The EventData instance will contain several input values that are relevant to the context.
First of all, the input value "eventType" will identify which event it was that caused the outbox item to be created. The list of known events are:
* emailFilter/emailFilterSms: When an email/sms is sent as a result of an email filter.
* notifyUser/notifyUserSms: When a user is notified by email/sms e.g. of a new request.
* autoReply: When an auto-reply is sent back to the customer when a case is created.
* addMessage/addMessageSms: When a message is added to a request, or a new request is created, with email/sms recipients.
* paswordEmail: When an email is sent to a customer with the username/password.
* sendTicketMessages/sendTicketMessagesSms: When a request is being forwared by email/sms.
* personSendEmail: When the PersonAgent.SendEmail() method is called. Out of the box the same as "passwordEmail", but from the CRM-client.
* chatTranscriptEmail: When a chat session transcript is being sent.
* newCustomerEmail: When a new customer email is being sent.
* customerKey: When an email with a session-key for the Customer Center is sent (e.g. for updating Mailings subscriptions).
* crmScript: When an email is sent from CRMScript using the Email-class (Note: can be overridden using setValue("eventName", "...")).
* notSupported: Used as a fallback value for deprecated or obsolete functionality.

Depending on whether this is an Email or SMS event, the input values will be different. For Emails, the EventData.InputValues will contain values such as "outbox.to", "outbox.subject", etc. For SMSs, it will contain e.g. "body", "recipient" and "sender". Also, depending of the type, various operations are supported, controlled by settings values in the EventData.OutputValues. 

## Trigger executed for Email

The following input values are available:
* outbox.ticketId: The id of the ticket.
* outbox.messageId: The id of the message.
* outbox.from/envelopeFrom: The two from addresses for the email.
* outbox.subject: The subject of the email.
* outbox.to/cc/bcc: The recipients of the email.
* outbox.textPlain/textHtml: The contents of the email. 
* outbox.part.length/outbox.part.n.contentType/outbox.part.n.data: The array of parts in the message.
* outbox.attachment.length/outbox.attachment.n.contentType/outbox.attachment.n.name: The array of attachments in the message.

The following output values are supported:
* outbox.subject: Change the subject.
* outbox.to/cc/bcc: Change the recipients.
* outbox.textPlain/textHtml: Change the contents of the email.
* outbox.header.length/outbox.header.n.name/outbox.header.n.value: Support for adding/replacing any number of RFC822 headers. .length is the number of headers to set, and "n" is the count starting at zero.

## Trigger executed for SMS

The following input values are available:
* outbox.ticketId: The id of the ticket.
* outbox.messageId: The id of the message.
* outbox.body: The contents of the sms.
* outbox.recipient: The recipient(s) of the sms.
* outbox.sender: The sender of the sms. 

The following output values are supported:
* outbox.body: Change the contents of the sms.
* outbox.recipient: Change the recipient(s) of the sms.
* outbox.sender: Change the sender of the sms. 

For both Email and SMS, setting EventData.BlockExecution to true will block the Outbox item (prevent it from being created). The idea of this trigger is that minor changes to Emails and SMSs can be performed by settings output values. 
