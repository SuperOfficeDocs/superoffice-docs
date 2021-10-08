---
uid: crmscript_ref_NSTicketMessageHeader_GetValue
title: String GetValue()
intellisense: NSTicketMessageHeader.GetValue
keywords: NSTicketMessageHeader, GetValue
so.topic: reference
---

# String GetValue()

The value of the header.

**Returns:** String

```crmscript
NSTicketAgent agent;
NSTicketMessage message = agent.GetTicketMessageEntity(12);
NSTicketMessageHeader[] headers = message.GetMessageHeaders();
for(Integer i = 0; i < headers.length(); i++)
{
    printLine(headers[i].GetValue());
}

```
