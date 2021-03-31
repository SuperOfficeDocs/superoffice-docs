---
uid: crmscript_ref_NSCustomerServiceAgent_AddMessageFromMailData
title: TicketInfo AddMessageFromMailData(Integer ticketId, String data)
intellisense: NSCustomerServiceAgent.AddMessageFromMailData
keywords: NSCustomerServiceAgent, AddMessageFromMailData
so.topic: reference
---

This method will add a message to an existing request in the sam way as importMail would do it from an email. It accepts RFC822 formatted data

**Parameters:**
 - **ticketId** The id of the ticket to add a message
 - **data** RFC822 formatted data to import as a message

**Returns:** An object containing some meta data for the ticket

```crmscript
NSCustomerServiceAgent agent;
Integer ticketId;
String data;
TicketInfo res = agent.AddMessageFromMailData(ticketId, data);
```

