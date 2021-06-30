---
uid: crmscript_ref_NSTicketAgent_SendTicketMessage
title: Void SendTicketMessage(Integer ticketMessageEntityId, String[] to, String[] cc, String[] bcc, String subject, Integer replyTemplateId, String gdprSource)
intellisense: NSTicketAgent.SendTicketMessage
keywords: NSTicketAgent, SendTicketMessage
so.topic: reference
---

Send a message to recipients, e.g. by email or sms

**Parameters:**
 - **ticketMessageEntityId** The id of the ticket message to send
 - **to** The To-recipients. Each recipient must be in correct format
 - **cc** The Cc-recipients. Each recipient must be in correct format
 - **bcc** The Bcc-recipients. Each recipient must be in correct format
 - **subject** The subject
 - **replyTemplateId** Optional ID of reply template to merge message with. <= 0 to skip.
 - **gdprSource** Optional GdprSource string which will be stored for newly created Persons. Blank value will give Gdpr source: API.

**Returns:** This method has no return value

```crmscript
NSTicketAgent agent;
Integer ticketMessageEntityId;
String[] to;
String[] cc;
String[] bcc;
String subject;
Integer replyTemplateId;
String gdprSource;
Void res = agent.SendTicketMessage(ticketMessageEntityId, to, cc, bcc, subject, replyTemplateId, gdprSource);
```

