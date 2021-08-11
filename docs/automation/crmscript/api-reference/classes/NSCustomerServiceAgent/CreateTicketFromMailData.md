---
uid: crmscript_ref_NSCustomerServiceAgent_CreateTicketFromMailData
title: NSTicketInfo CreateTicketFromMailData(Integer mailboxId, String data)
intellisense: NSCustomerServiceAgent.CreateTicketFromMailData
keywords: NSCustomerServiceAgent, CreateTicketFromMailData
so.topic: reference
---

# NSTicketInfo CreateTicketFromMailData(Integer mailboxId, String data)

This method create a new ticket in the same way as importMail would import an email. It accepts RFC822 formatted data

**Parameters:**
 - **mailboxId** The id of the Service mailbox
 - **data** RFC822 formatted data to import as a ticket

**Returns:** NSTicketInfo

```crmscript
NSCustomerServiceAgent agent;
Integer mailboxId;
String data;
NSTicketInfo res = agent.CreateTicketFromMailData(mailboxId, data);
```

