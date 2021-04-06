---
uid: crmscript_ref_NSTicketMessageEntity_GetMailSorter
title: String GetMailSorter()
intellisense: NSTicketMessageEntity.GetMailSorter
keywords: NSTicketMessageEntity, GetMailSorter
so.topic: reference
---

The name of the mail sorter used when the email was imported. Note: We must use name instead of id since the id&apos;s change every time one changes the mail sorter. :-0

**Returns:** String


```crmscript
NSTicketMessageEntity thing;
String mailSorter  = thing.GetMailSorter();
```


