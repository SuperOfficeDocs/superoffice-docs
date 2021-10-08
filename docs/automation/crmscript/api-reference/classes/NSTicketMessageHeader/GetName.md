---
uid: crmscript_ref_NSTicketMessageHeader_GetName
title: String GetName()
intellisense: NSTicketMessageHeader.GetName
keywords: NSTicketMessageHeader, GetName
so.topic: reference
---

# String GetName()

The name of the header. This can for example be To, Cc or other custom headers that is set up in Service

**Returns:** String

```crmscript
NSTicketAgent agent;
NSTicketMessage message = agent.GetTicketMessageEntity(12);
NSTicketMessageHeader[] headers = message.GetMessageHeaders();
for(Integer i = 0; i < headers.length(); i++)
{
    printLine(headers[i].GetName());
}
```
