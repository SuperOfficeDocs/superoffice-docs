---
uid: crmscript_ref_NSCustomerServiceAgent_AddMessageFromMailData
title: NSTicketInfo AddMessageFromMailData(Integer ticketId, String data)
intellisense: NSCustomerServiceAgent.AddMessageFromMailData
keywords: NSCustomerServiceAgent, AddMessageFromMailData
so.topic: reference
---

# NSTicketInfo AddMessageFromMailData(Integer ticketId, String data)

This method will add a message to an existing request in the sam way as importMail would do it from an email. It accepts RFC822 formatted data

**Parameters:**
 - **ticketId** The id of the ticket to add a message
 - **data** RFC822 formatted data to import as a message

**Returns:** NSTicketInfo

```crmscript
NSCustomerServiceAgent agent;
Integer ticketId;
String data;
NSTicketInfo res = agent.AddMessageFromMailData(ticketId, data);
```

